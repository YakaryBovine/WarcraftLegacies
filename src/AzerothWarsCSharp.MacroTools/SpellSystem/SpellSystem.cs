﻿using System;
using System.Collections.Generic;
using WCSharp.Events;
using static War3Api.Common;

namespace AzerothWarsCSharp.MacroTools.SpellSystem
{
  /// <summary>
  /// Provides a way to extend the functionality of existing Warcraft 3 spells and passive abilities
  /// by adding extra code on top of their normal effects.
  /// </summary>
  public static class SpellSystem
  {
    private static readonly Dictionary<int, Spell> SpellsByAbilityId = new();

    static SpellSystem()
    {
      PlayerUnitEvents.AddCustomEventFilter(EVENT_PLAYER_UNIT_TRAIN_FINISH, "UnitTypeFinishesBeingTrained",
        () => GetUnitTypeId(GetTrainedUnit()));
    }

    /// <summary>
    /// Returns the registered <see cref="Spell"/> with the provided ability ID.
    /// </summary>
    /// <exception cref="Exception">Thrown if there is no ability with the provided ID.</exception>
    public static Spell GetSpellByAbilityId(int abilityId)
    {
      if (!SpellsByAbilityId.ContainsKey(abilityId))
        throw new Exception($"There is no Spell with abilityId {abilityId}.");
      return SpellsByAbilityId[abilityId];
    }
    
        /// <summary>
    /// Registeres the provided passive ability to the <see cref="SpellSystem"/>, causing its functionality
    /// to be invoked when specific Warcraft 3 events occur.
    /// </summary>
    public static void Register(TakeDamageEffect takeDamageEffect)
    {
      PlayerUnitEvents.Register(PlayerUnitEvent.UnitTypeDamages, takeDamageEffect.OnTakesDamage,
        takeDamageEffect.DamagedUnitTypeId);
    }

    /// <summary>
    /// Registeres the provided passive ability to the <see cref="SpellSystem"/>, causing its functionality
    /// to be invoked when specific Warcraft 3 events occur.
    /// </summary>
    public static void Register(UnitEffect unitEffect)
    {
      PlayerUnitEvents.Register(PlayerUnitEvent.UnitTypeDamages, unitEffect.OnDealsDamage, unitEffect.UnitTypeId);
      PlayerUnitEvents.Register(PlayerUnitEvent.UnitTypeIsCreated, unitEffect.OnCreated, unitEffect.UnitTypeId);
      PlayerUnitEvents.Register(PlayerUnitEvent.UnitTypeFinishesBeingTrained, unitEffect.OnTrained, unitEffect.UnitTypeId);
      PlayerUnitEvents.Register(PlayerUnitEvent.UnitTypeFinishesTraining, unitEffect.OnTrainedUnit, unitEffect.UnitTypeId);
      PlayerUnitEvents.Register(PlayerUnitEvent.UnitTypeFinishesBeingConstructed, unitEffect.OnConstruction,
        unitEffect.UnitTypeId);
      PlayerUnitEvents.Register(PlayerUnitEvent.UnitTypeFinishesUpgrade, unitEffect.OnUpgrade, unitEffect.UnitTypeId);
      PlayerUnitEvents.Register(PlayerUnitEvent.HeroTypeFinishesRevive, unitEffect.OnCreated, unitEffect.UnitTypeId);
    }

    /// <summary>
    ///   Registers the provided <see cref="Spell"/> to the <see cref="SpellSystem"/>, causing its functionality
    /// to be invoked when a Warcraft 3 spell matching its IDs is used.
    /// </summary>
    public static void Register(Spell spell)
    {
      PlayerUnitEvents.Register(PlayerUnitEvent.SpellEffect, OnCast, spell.Id);
      PlayerUnitEvents.Register(PlayerUnitEvent.SpellEndCast, OnStop, spell.Id);
      PlayerUnitEvents.Register(PlayerUnitEvent.SpellLearnedByHeroType, OnLearn, spell.Id);
      SpellsByAbilityId.Add(spell.Id, spell);
    }

    private static void OnStop()
    {
      SpellsByAbilityId[GetSpellAbilityId()]
        .OnStop(GetTriggerUnit());
    }

    private static void OnCast()
    {
      SpellsByAbilityId[GetSpellAbilityId()]
        .OnCast(GetTriggerUnit(), GetSpellTargetUnit(), GetSpellTargetX(), GetSpellTargetY());
    }

    private static void OnLearn()
    {
      SpellsByAbilityId[GetLearnedSkill()].OnLearn(GetTriggerUnit());
    }
  }
}