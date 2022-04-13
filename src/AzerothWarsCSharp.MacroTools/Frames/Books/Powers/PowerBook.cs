﻿using System;
using System.Linq;
using AzerothWarsCSharp.MacroTools.FactionSystem;
using WCSharp.Shared.Data;
using static War3Api.Common;

namespace AzerothWarsCSharp.MacroTools.Frames.Books.Powers
{
  public sealed class PowerBook : Book<PowerPage>
  {
    private const float BottomButtonYOffset = 0.015f;
    private const float BottomButtonXOffset = 0.02f;
    private const float BookWidth = 0.25f;
    private const float BookHeight = 0.39f;

    private static bool _initialized;
    private static PowerBook _instance;

    private Faction _trackedFaction;

    private PowerBook(float width, float height, float bottomButtonXOffset, float bottomButtonYOffset) : base(width,
      height, bottomButtonXOffset, bottomButtonYOffset)
    {
      var firstPage = AddPage();
      firstPage.Visible = true;
      BookTitle = "Powers";
      LauncherPosition = new Point(0.15f, 0.56f);
      Position = new Point(0.4f, 0.36f);
      TrackedFaction = Person.ByHandle(GetLocalPlayer()).Faction;
    }

    /// <summary>
    ///   The <see cref="PowerBook" /> displays the <see cref="Power" />s of this <see cref="Faction" />.
    /// </summary>
    public Faction TrackedFaction
    {
      get => _trackedFaction;
      set
      {
        if (_trackedFaction != null) _trackedFaction.PowerAdded -= OnFactionAddPower;

        if (_trackedFaction == value) return;
        _trackedFaction = value;
        _trackedFaction.PowerAdded += OnFactionAddPower;
        AddAllPowers(value);
      }
    }

    private void OnFactionAddPower(object? sender, FactionPowerEventArgs factionPowerEventArgs)
    {
      AddPower(factionPowerEventArgs.Power);
    }

    private void OnFactionRemovePower()
    {
    }

    private void AddAllPowers(Faction faction)
    {
      foreach (var power in faction.GetAllPowers())
        AddPower(power);
    }

    private void AddPower(Power power)
    {
      var lastPage = Pages.Last();
      if (lastPage.CardCount >= lastPage.CardLimit)
      {
        AddPage();
        lastPage = Pages.Last();
      }

      lastPage.AddPower(power);
    }

    private static void LoadToc(string tocFilePath)
    {
      if (!BlzLoadTOCFile(tocFilePath)) throw new Exception($"Failed to load TOC {tocFilePath}");
    }

    public static void Initialize()
    {
      if (!_initialized)
      {
        LoadToc(@"war3mapImported\ArtifactSystem.toc");
        LoadToc(@"ui\framedef\framedef.toc");
        _instance = new PowerBook(BookWidth, BookHeight, BottomButtonXOffset, BottomButtonYOffset);
        _initialized = true;
      }
    }
  }
}