﻿using AzerothWarsCSharp.MacroTools.Buffs;
using AzerothWarsCSharp.MacroTools.SpellSystem;
using WCSharp.Buffs;
using static War3Api.Common;

namespace AzerothWarsCSharp.MacroTools.Spells
{
  /// <summary>
  /// Causes the specified unit type to always have a squad of tentacles surrounding them.
  /// </summary>
  public sealed class HideousAppendages : UnitEffect
  {
    public int TentacleUnitTypeId { get; init; } = FourCC("hfoo");
    
    public int TentacleCount { get; init; } = 6;
    
    /// <summary>
    /// How far away from the buff holder to position the tentacles.
    /// </summary>
    public float RadiusOffset { get; init; } = 250;
    
    public HideousAppendages(int id) : base(id)
    {
    }

    public override void OnCreated()
    {
      var hideousAppendagesBuff = new HideousAppendagesBuff(GetTriggerUnit(), GetTriggerUnit())
      {
        TentacleUnitTypeId = TentacleUnitTypeId,
        TentacleCount = TentacleCount,
        Duration = float.MaxValue,
        RadiusOffset = RadiusOffset
      };
      BuffSystem.Add(hideousAppendagesBuff);
    }
  }
}