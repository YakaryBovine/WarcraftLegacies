﻿using System;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using AzerothWarsCSharp.ObjectFactory.Units;
using CSharpLua;
using Microsoft.CodeAnalysis;
using War3Api.Object;
using War3Net.Build;
using War3Net.Build.Extensions;
using War3Net.Build.Info;
using War3Net.Build.Object;
using War3Net.IO.Mpq;
using WCSharp.ConstantGenerator;
using CoreSystemProvider = CSharpLua.CoreSystem.CoreSystemProvider;

namespace AzerothWarsCSharp.Launcher
{
  internal static class Program
  {
    // Input
    private const string SOURCE_CODE_PROJECT_FOLDER_PATH = @"..\..\..\..\AzerothWarsCSharp.Source";
    private const string TEST_SOURCE_CODE_PROJECT_FOLDER_PATH = @"..\..\..\..\AzerothWarsCSharp.TestSource";
    private const string ASSETS_FOLDER_PATH = @"..\..\..\..\Assets\";

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
      Console.WriteLine("4. Compile and run test map");
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
          Build(BASE_MAP_PATH, SOURCE_CODE_PROJECT_FOLDER_PATH, false);
          break;
        case ConsoleKey.D3:
          Build(BASE_MAP_PATH, SOURCE_CODE_PROJECT_FOLDER_PATH, true);
          break;
        case ConsoleKey.D4:
          Build(TEST_MAP_PATH, TEST_SOURCE_CODE_PROJECT_FOLDER_PATH, true);
          break;
        default:
          Console.WriteLine($"{Environment.NewLine}Invalid input. Please choose again.");
          MakeDecision();
          break;
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
      var map = Map.Open(baseMapPath);

      FixDoodadData(map);
      SetTestPlayerSlot(map, 0);
      var builder = new MapBuilder(map);
      builder.AddFiles(baseMapPath, "*", SearchOption.AllDirectories);
      builder.AddFiles(ASSETS_FOLDER_PATH, "*", SearchOption.AllDirectories);

      ObjectEditor.SupplmentMapWithObjectData(map);
      
      // Set debug options if necessary, configure compiler
      const string csc = DEBUG ? "-debug -define:DEBUG" : null;
      var csproj = Directory.EnumerateFiles(projectFolderPath, "*.csproj", SearchOption.TopDirectoryOnly).Single();
      var compiler = new Compiler(csproj, OUTPUT_FOLDER_PATH, string.Empty, null,
        "War3Api.Common.*;War3Api.Blizzard.*;WCSharp.*;AzerothWarsCSharp.MacroTools.*", "", csc, false, null,
        string.Empty)
      {
        IsExportMetadata = true,
        IsModule = false,
        IsInlineSimpleProperty = false,
        IsPreventDebugObject = true,
        IsCommentsDisabled = !DEBUG
      };

      // Collect required paths and compile
      var coreSystemFiles = CoreSystemProvider.GetCoreSystemFiles();
      var blizzardJ = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
        "Warcraft III/JassHelper/Blizzard.j");
      var commonJ = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
        "Warcraft III/JassHelper/common.j");
      var compileResult = map.CompileScript(compiler, coreSystemFiles, blizzardJ, commonJ);

      // If compilation failed, output an error
      if (!compileResult.Success)
        throw new Exception(compileResult.Diagnostics.First(x => x.Severity == DiagnosticSeverity.Error).GetMessage());

      // Update war3map.lua so you can inspect the generated Lua code easily
      File.WriteAllText(Path.Combine(OUTPUT_FOLDER_PATH, OUTPUT_SCRIPT_NAME), map.Script);

      // Build w3x file
      var archiveCreateOptions = new MpqArchiveCreateOptions
      {
        BlockSize = 3,
        AttributesCreateMode = MpqFileCreateMode.Overwrite,
        ListFileCreateMode = MpqFileCreateMode.Overwrite
      };

      builder.Build(Path.Combine(OUTPUT_FOLDER_PATH, OUTPUT_MAP_NAME), archiveCreateOptions);

      // Launch if that option was selected
      if (launch) LaunchGame();
    }

    /// <summary>
    ///   Makes all players prior to the given player slot computers,
    ///   so that the given player slot is what the tester will play as when the map is launched.
    /// </summary>
    private static void SetTestPlayerSlot(Map map, int playerSlot)
    {
      foreach (var player in map.Info.Players)
        if (player.Id < playerSlot)
          player.Controller = PlayerController.Computer;
    }

    private static void FixDoodadData(Map map)
    {
      if (map.Doodads != null)
      {
        var i = 0;
        foreach (var doodad in map.Doodads.Doodads)
        {
          doodad.CreationNumber = i;
          i++;
        }
      }
        
    }
    
    private static void LaunchGame()
    {
      var wc3Exe = ConfigurationManager.AppSettings["wc3exe"];
      if (File.Exists(wc3Exe))
      {
        var commandLineArgs = new StringBuilder();
        var isReforged = Version.Parse(FileVersionInfo.GetVersionInfo(wc3Exe).FileVersion) >= new Version(1, 32);
        commandLineArgs.Append(isReforged ? " -launch" : $" -graphicsapi {GRAPHICS_API}");

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
  }
}