﻿using System.Collections.Generic;
using AzerothWarsCSharp.MacroTools.Buffs;
using AzerothWarsCSharp.MacroTools.Extensions;
using AzerothWarsCSharp.MacroTools.SpellSystem;
using AzerothWarsCSharp.MacroTools.Wrappers;
using WCSharp.Buffs;
using WCSharp.Shared.Data;
using static War3Api.Common;

namespace AzerothWarsCSharp.MacroTools.Spells
{
  /// <summary>
  /// Heals nearby friendly units and removes specific abilities from the caster for a limited duration.
  /// </summary>
  public sealed class Ascendance : Spell
  {
    public float DurationBase { get; init; }
    public float DurationLevel { get; init; }
    public float HealBase { get; init; }
    public float HealLevel { get; init; }
    public float Radius { get; init; }
    
    public IEnumerable<int>? AbilitiesToRemove { get; init; }
    
    public Ascendance(int id) : base(id)
    {
    }

    public override void OnCast(unit caster, unit target, Point targetPoint)
    {
      foreach (var unit in new GroupWrapper()
                 .EnumUnitsInRange(caster.GetPosition(), Radius)
                 .EmptyToList()
               )
      {
        if (IsPlayerAlly(GetOwningPlayer(caster), GetOwningPlayer(unit)))
        {
          unit.Heal(HealBase + HealLevel * GetAbilityLevel(caster));
        }
      }
      var ascendancyBuff = new AscendancyBuff(caster, caster)
      {
        Duration = DurationBase + DurationLevel * GetAbilityLevel(caster),
        AbilitiesToRemove = AbilitiesToRemove
      };
      BuffSystem.Add(ascendancyBuff);
    }
  }
}