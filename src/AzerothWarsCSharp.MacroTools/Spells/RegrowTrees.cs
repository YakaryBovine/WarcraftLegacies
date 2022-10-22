﻿using AzerothWarsCSharp.MacroTools.Libraries;
using AzerothWarsCSharp.MacroTools.SpellSystem;
using WCSharp.Shared.Data;

namespace AzerothWarsCSharp.MacroTools.Spells
{
  public sealed class RegrowTrees : Spell
  {
    public RegrowTrees(int id) : base(id)
    {
    }

    public float Radius { get; init; }

    public override void OnCast(unit caster, unit target, Point targetPoint)
    {
      GeneralHelpers.EnumDestructablesInCircle(Radius, new Point(GetUnitX(caster), GetUnitY(caster)),
        () => { DestructableRestoreLife(GetEnumDestructable(), GetDestructableMaxLife(GetEnumDestructable()), true); });
    }
  }
}