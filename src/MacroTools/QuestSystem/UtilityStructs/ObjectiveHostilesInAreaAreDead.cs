﻿using System.Collections.Generic;
using System.Linq;
using MacroTools.Extensions;
using WCSharp.Shared.Data;
using static War3Api.Common;

namespace MacroTools.QuestSystem.UtilityStructs
{
  /// <summary>
  /// Objective that is completed when all Neutral Hostile units in an are are dead.
  /// </summary>
  public sealed class ObjectiveKillAllInArea : Objective
  {
    private readonly string _areaName;
    private readonly int _maxKillCount;
    private int _currentKillCount;
    
    private int CurrentKillCount
    {
      get => _currentKillCount;
      set
      {
        _currentKillCount = value;
        Description = $"All creeps {_areaName} are dead ({_currentKillCount}/{_maxKillCount})";
        if (_currentKillCount == _maxKillCount) 
          Progress = QuestProgress.Complete;
      }
    }
    
    /// <summary>
    /// Initializes a new instance of the <see cref="ObjectiveKillAllInArea"/> class.
    /// </summary>
    public ObjectiveKillAllInArea(IEnumerable<Rectangle> rectangles, string areaName)
    {
      _areaName = areaName;
      foreach (var rectangle in rectangles)
      {
        var unitsInAreas = CreateGroup().EnumUnitsInRect(rectangle).EmptyToList()
          .Where(x => x.OwningPlayer() == Player(PLAYER_NEUTRAL_AGGRESSIVE) && !x.IsType(UNIT_TYPE_ANCIENT) &&
                      !x.IsType(UNIT_TYPE_SAPPER));
        foreach (var unit in unitsInAreas)
        {
          _maxKillCount++;
          CreateTrigger()
            .RegisterUnitEvent(unit, EVENT_UNIT_DEATH)
            .AddAction(() =>
            {
              CurrentKillCount++;
              DestroyTrigger(GetTriggeringTrigger());
            });
        }
      }
      CurrentKillCount = 0;
    }
  }
}