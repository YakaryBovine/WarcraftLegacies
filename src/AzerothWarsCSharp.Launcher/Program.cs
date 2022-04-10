﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using AzerothWarsCSharp.IntegrityChecker;
using AzerothWarsCSharp.ObjectFactory.Units;
using CSharpLua;
using Microsoft.CodeAnalysis;
using War3Api.Object;
using War3Net.Build;
using War3Net.Build.Extensions;
using War3Net.Build.Object;
using War3Net.IO.Mpq;
using WCSharp.ConstantGenerator;

namespace AzerothWarsCSharp.Launcher
{
  internal static class Program
  {
    // Input
    private const string SOURCE_CODE_PROJECT_FOLDER_PATH = @"..\..\..\..\AzerothWarsCSharp.Source";
    private const string TEST_SOURCE_CODE_PROJECT_FOLDER_PATH = @"..\..\..\..\AzerothWarsCSharp.TestSource";
    private const string ASSETS_FOLDER_PATH = @"..\..\..\..\Assets\";

    /// <summary>
    ///   Folder containing loose JASS files that will be added to the final result.
    /// </summary>
    private const string JASS_FOLDER_PATH = @"..\..\..\..\..\jass\";
    private const string BASE_MAP_PATH = @"..\..\..\..\..\maps\source.w3x";
    private const string TEST_MAP_PATH = @"..\..\..\..\..\maps\testsource.w3x";

    /// <summary>
    ///   File containing Warcraft 3 objects that will be added to the final result.
    /// </summary>
    private const string BASE_OBJECT_PATH = @"..\..\..\..\..\source.w3o";

    // Output
    private const string OUTPUT_FOLDER_PATH = @"..\..\..\..\..\artifacts";
    private const string OUTPUT_SCRIPT_NAME = @"war3map.lua";
    private const string OUTPUT_MAP_NAME = @"target.w3x";

    // Warcraft III
    private const string GRAPHICS_API = "Direct3D9";
#if DEBUG
    private const bool DEBUG = true;
#else
		private const bool DEBUG = false;
#endif

    /// <summary>
    ///   Entry point for the program.
    /// </summary>
    private static void Main()
    {
      Console.WriteLine("The following actions are available:");
      Console.WriteLine("1. Generate constants");
      Console.WriteLine("2. Compile map");
      Console.WriteLine("3. Compile and run map");
      Console.WriteLine("4. Find unused models");
      Console.WriteLine("5. Compile and run test map");
      MakeDecision();
    }

    /// <summary>
    ///   Prompts the user for some build options.
    /// </summary>
    private static void MakeDecision()
    {
      Console.Write("Please type the number of your desired action: ");
      switch (Console.ReadKey().Key)
      {
        case ConsoleKey.D1:
          ConstantGenerator.Run(BASE_MAP_PATH, SOURCE_CODE_PROJECT_FOLDER_PATH, new ConstantGeneratorOptions
          {
            IncludeCode = true
          });
          break;
        case ConsoleKey.D2:
          Build(BASE_MAP_PATH, TEST_SOURCE_CODE_PROJECT_FOLDER_PATH, false);
          break;
        case ConsoleKey.D3:
          Build(BASE_MAP_PATH,TEST_SOURCE_CODE_PROJECT_FOLDER_PATH, true);
          break;
        case ConsoleKey.D4:
          DisplayUnusedModels();
          break;
        case ConsoleKey.D5:
          Build(TEST_MAP_PATH, TEST_SOURCE_CODE_PROJECT_FOLDER_PATH, true);
          break;
        default:
          Console.WriteLine($"{Environment.NewLine}Invalid input. Please choose again.");
          MakeDecision();
          break;
      }
    }

    private static void DisplayUnusedModels()
    {
      //List directories which may have models in them
      var modelFolderPaths = new List<string>()
      {
        Path.Combine(BASE_MAP_PATH, "war3mapImported"),
        BASE_MAP_PATH
      };
      
      //Get all models in relevant directories
      var modelFilePaths = new List<string>();
      foreach (var path in modelFolderPaths)
      {
        modelFilePaths.AddRange(Directory.EnumerateFiles(path, "*.mdx"));
      }

      //Get object data
      using var fileStream = File.OpenRead(BASE_OBJECT_PATH);
      using var binaryReader = new BinaryReader(fileStream);
      var objectData = binaryReader.ReadObjectData(false);
      
      //Get and display unused models
      var unusedModels = MapIntegrityChecker.FindUnusedModels(objectData, modelFilePaths, BASE_MAP_PATH);
      foreach (var unusedModel in unusedModels)
      {
        Console.WriteLine(unusedModel.RelativePathMdx);
      }
    }
    
    /// <summary>
    ///   Builds the Warcraft 3 map.
    /// </summary>
    private static void Build(string baseMapPath, string projectFolderPath, bool launch)
    {
      // Ensure these folders exist
			Directory.CreateDirectory(ASSETS_FOLDER_PATH);
			Directory.CreateDirectory(OUTPUT_FOLDER_PATH);

			// Load existing map data
			var map = Map.Open(BASE_MAP_PATH);
			var builder = new MapBuilder(map);
			builder.AddFiles(baseMapPath, "*", SearchOption.AllDirectories);
			builder.AddFiles(ASSETS_FOLDER_PATH, "*", SearchOption.AllDirectories);

			// Set debug options if necessary, configure compiler
			const string csc = DEBUG ? "-debug -define:DEBUG" : null;
			var csproj = Directory.EnumerateFiles(projectFolderPath, "*.csproj", SearchOption.TopDirectoryOnly).Single();
			var compiler = new Compiler(csproj, OUTPUT_FOLDER_PATH, string.Empty, null, "War3Api.*;WCSharp.*;AzerothWarsCSharp.MacroTools.*", "", csc, false, null, string.Empty)
			{
				IsExportMetadata = true,
				IsModule = false,
				IsInlineSimpleProperty = false,
				IsPreventDebugObject = true,
				IsCommentsDisabled = !DEBUG
			};

			// Collect required paths and compile
			var coreSystemFiles = CSharpLua.CoreSystem.CoreSystemProvider.GetCoreSystemFiles();
			var blizzardJ = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Warcraft III/JassHelper/Blizzard.j");
			var commonJ = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Warcraft III/JassHelper/common.j");
			var compileResult = map.CompileScript(compiler, coreSystemFiles, blizzardJ, commonJ);

			// If compilation failed, output an error
			if (!compileResult.Success)
			{
				throw new Exception(compileResult.Diagnostics.First(x => x.Severity == DiagnosticSeverity.Error).GetMessage());
			}

			// Update war3map.lua so you can inspect the generated Lua code easily
			File.WriteAllText(Path.Combine(OUTPUT_FOLDER_PATH, OUTPUT_SCRIPT_NAME), map.Script);

			// Build w3x file
			var archiveCreateOptions = new MpqArchiveCreateOptions
			{
				ListFileCreateMode = MpqFileCreateMode.Overwrite,
				AttributesCreateMode = MpqFileCreateMode.Prune,
				BlockSize = 3,
			};

			builder.Build(Path.Combine(OUTPUT_FOLDER_PATH, OUTPUT_MAP_NAME), archiveCreateOptions);

			// Launch if that option was selected
			if (launch)
			{
				var wc3exe = ConfigurationManager.AppSettings["wc3exe"];
				if (File.Exists(wc3exe))
				{
					var commandLineArgs = new StringBuilder();
					var isReforged = Version.Parse(FileVersionInfo.GetVersionInfo(wc3exe).FileVersion) >= new Version(1, 32);
					if (isReforged)
					{
						commandLineArgs.Append(" -launch");
					}
					else
					{
						commandLineArgs.Append($" -graphicsapi {GRAPHICS_API}");
					}

					commandLineArgs.Append(" -nowfpause");

					var mapPath = Path.Combine(OUTPUT_FOLDER_PATH, OUTPUT_MAP_NAME);
					var absoluteMapPath = new FileInfo(mapPath).FullName;
					commandLineArgs.Append($" -loadfile \"{absoluteMapPath}\"");

					Process.Start(wc3exe, commandLineArgs.ToString());
				}
				else
				{
					throw new Exception("Please set wc3exe in Launcher/app.config to the path of your Warcraft III executable.");
				}
			}
    }

    /// <summary>
    /// Launches Warcraft 3.
    /// </summary>
    private static void LaunchGame()
    {
      var wc3Exe = ConfigurationManager.AppSettings["wc3exe"];
      if (File.Exists(wc3Exe))
      {
        var commandLineArgs = new StringBuilder();
        var isReforged = Version.Parse(FileVersionInfo.GetVersionInfo(wc3Exe).FileVersion) >= new Version(1, 32);
        if (isReforged) commandLineArgs.Append(" -launch");
        commandLineArgs.Append($" -graphicsapi {GRAPHICS_API}");
        commandLineArgs.Append(" -nowfpause");

        var mapPath = Path.Combine(OUTPUT_FOLDER_PATH, OUTPUT_MAP_NAME);
        var absoluteMapPath = new FileInfo(mapPath).FullName;
        commandLineArgs.Append($" -loadfile \"{absoluteMapPath}\"");

        Process.Start(wc3Exe, commandLineArgs.ToString());
      }
      else
      {
        throw new Exception("Please set wc3exe in Launcher/app.config to the path of your Warcraft III executable.");
      }
    }

    /// <summary>
    ///   Takes some ObjectData, process it a bit, then adds it to the given ObjectDatabase.
    /// </summary>
    private static ObjectDatabase ProcessAdditionalObjectData(ObjectDatabase destinationObjectDatabase,
      ObjectData objectData)
    {
      var tempObjectDatabase = new ObjectDatabase();
      tempObjectDatabase.AddObjects(objectData);
      foreach (var unit in tempObjectDatabase.GetUnits())
      {
        var unitFactory = new UnitFactory(unit);
        unitFactory.Generate(unit.NewId, destinationObjectDatabase);
      }

      return destinationObjectDatabase;
    }

    /// <summary>
    /// Take a file containing some object data, process it a bit, then add it to the ObjectDatabase.
    /// </summary>
    private static ObjectDatabase ProcessAdditionalObjectData(ObjectDatabase objectDatabase, string objectDataPath)
    {
      using var fileStream = File.OpenRead(objectDataPath);
      using var binaryReader = new BinaryReader(fileStream);
      var objectData = binaryReader.ReadObjectData(false);
      ProcessAdditionalObjectData(objectDatabase, objectData);
      return objectDatabase;
    }

    private static ObjectDatabase GenerateObjectDatabase()
    {
      ObjectDatabase objectDatabase = new();
      //Human.GenerateObjectData(objectDatabase);
      ProcessAdditionalObjectData(objectDatabase, BASE_OBJECT_PATH);
      return objectDatabase;
    }

    private static void WriteObjectData(Map map, ObjectDatabase objectDatabase)
    {
      var objectData = objectDatabase.GetAllData();
      map.UnitObjectData = objectData.UnitData;
      map.ItemObjectData = objectData.ItemData;
      map.DestructableObjectData = objectData.DestructableData;
      map.DoodadObjectData = objectData.DoodadData;
      map.AbilityObjectData = objectData.AbilityData;
      map.BuffObjectData = objectData.BuffData;
      map.UpgradeObjectData = objectData.UpgradeData;
    }
  }
}