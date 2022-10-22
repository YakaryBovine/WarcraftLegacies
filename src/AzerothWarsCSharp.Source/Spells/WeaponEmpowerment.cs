﻿using AzerothWarsCSharp.MacroTools.SpellSystem;

namespace AzerothWarsCSharp.Source.Spells
{
  /// <summary>
  /// When Mograine learns additional levels of Weapon Empowerment he gains additional abilities.
  /// </summary>
  public sealed class WeaponEmpowerment : Spell
  {
    public WeaponEmpowerment(int id) : base(id)
    {
    }

    public override void OnLearn(unit learner)
    {
      var owner = GetOwningPlayer(learner);
      switch (GetAbilityLevel(learner))
      {
        case 1:
          SetPlayerAbilityAvailable(owner, Constants.ABILITY_A0KC_INCINERATE_PURPLE_ALEXANDROS, true);
          SetPlayerAbilityAvailable(owner, Constants.ABILITY_A0MQ_PULVERIZE_PURPLE_ALEXANDROS, true);
          break;
        case 2:
          SetUnitAbilityLevel(learner, Constants.ABILITY_A0KC_INCINERATE_PURPLE_ALEXANDROS, 2);
          SetUnitAbilityLevel(learner, Constants.ABILITY_A0MQ_PULVERIZE_PURPLE_ALEXANDROS, 2);
          break;
        case 3:
          SetUnitAbilityLevel(learner, Constants.ABILITY_A0KC_INCINERATE_PURPLE_ALEXANDROS, 3);
          SetUnitAbilityLevel(learner, Constants.ABILITY_A0MQ_PULVERIZE_PURPLE_ALEXANDROS, 3);
          break;
        case 4:
          SetPlayerAbilityAvailable(owner, Constants.ABILITY_A0NP_COMMUNION_ALEXANDROS_SPELLBOOK, true);
          SetPlayerAbilityAvailable(owner, Constants.ABILITY_A01I_CRUSADE_AURA_PURPLE_ALEXANDROS_SPELLBOOK, true);
          break;
      }
    }
  }
}