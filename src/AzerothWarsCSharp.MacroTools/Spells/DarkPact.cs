﻿using AzerothWarsCSharp.MacroTools.SpellSystem;
using static War3Api.Common;

namespace AzerothWarsCSharp.MacroTools.Spells
{
  /// <summary>
  /// Kills a target unit and gives its hitpoints to the caster.
  /// </summary>
  public sealed class DarkPact : Spell
  {
    public DarkPact(int id) : base(id)
    {
    }
    
    public override void OnCast(unit caster, unit target, float targetX, float targetY)
    {
      SetUnitState(caster, UNIT_STATE_LIFE, GetUnitState(caster, UNIT_STATE_LIFE) + GetUnitState(target, UNIT_STATE_LIFE));
      KillUnit(target);
    }
  }
}