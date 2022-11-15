﻿using MacroTools.PassiveAbilities;
using MacroTools.PassiveAbilitySystem;
using MacroTools.SpellSystem;
using WarcraftLegacies.Source.Mechanics.Goblins;
using WarcraftLegacies.Source.Setup.FactionSetup;
using static War3Api.Common;

namespace WarcraftLegacies.Source.Setup.Spells
{
  /// <summary>
  /// Responsible for setting up all <see cref="GoblinSetup.Goblin"/> related <see cref="Spell"/>s and <see cref="PassiveAbility"/>s.
  /// </summary>
  public static class GoblinSpellSetup
  {
    /// <summary>
    /// Sets up all <see cref="GoblinSetup.Goblin"/> related <see cref="Spell"/>s and <see cref="PassiveAbility"/>s.
    /// </summary>
    public static void Setup()
    {
      var zeppelinTradeTargets = new[]
      {
        Regions.Trade1.Center,
        Regions.Trade2.Center,
        Regions.Trade3.Center,
        Regions.Trade4.Center
      };
      PassiveAbilityManager.Register(new Trader(Constants.UNIT_NZEP_TRADING_ZEPPELIN_WARSONG, 0, 60, zeppelinTradeTargets));

      var traderTradeTargets = new[]
      {
        Regions.Trader1.Center,
        Regions.Trader2.Center,
        Regions.Trader3.Center
      };
      PassiveAbilityManager.Register(new Trader(Constants.UNIT_O04S_TRADER_GOBLIN, 40, 0, traderTradeTargets));

      SpellSystem.Register(new NuclearLaunch(Constants.ABILITY_A0RH_INTERCONTINENTAL_BOMBARDMENT_GOBLIN_ARTILLERY, 25));

      PassiveAbilityManager.Register(new NuclearLaunchWarning(Constants.UNIT_H011_INTERCONTINENTAL_ARTILLERY_GOBLIN,
        Constants.UNIT_H06L_DUMMY_NUKE_WARNING, @"war3mapImported/NuclearLaunchDetected.mp3", 25));

      var artillerySpeedMult =
        new AnimationSpeedMultiplier(Constants.UNIT_H011_INTERCONTINENTAL_ARTILLERY_GOBLIN, 0.4f);
      PassiveAbilityManager.Register(artillerySpeedMult);

      PassiveAbilityManager.Register(new OilUser(Constants.UNIT_H011_INTERCONTINENTAL_ARTILLERY_GOBLIN));
      PassiveAbilityManager.Register(new OilUser(FourCC("Ntin")));
      PassiveAbilityManager.Register(new OilUser(Constants.UNIT_N062_SHREDDER_GOBLIN));
      PassiveAbilityManager.Register(new OilUser(Constants.UNIT_H08Z_ASSAULT_TANK_GOBLIN));
      PassiveAbilityManager.Register(new OilUser(Constants.UNIT_H091_WAR_ZEPPELIN_GOBLIN));
      PassiveAbilityManager.Register(new OilProducer(Constants.UNIT_O04R_OIL_PLATFORM_GOBLIN, 11.5f));
      PassiveAbilityManager.Register(new OilUser(Constants.UNIT_H04Z_KEZAN_OIL_SUPPLY_GOBLIN));
      PassiveAbilityManager.Register(new OilUser(Constants.UNIT_NTIN_CHIEF_ENGINEER_GOBLIN));
      PassiveAbilityManager.Register(new OilRigConstructor(Constants.UNIT_N0AQ_OIL_RIG_WARSONG, new[]
      {
        Regions.OilRig1.Center, 
        Regions.OilRig2.Center,
        Regions.OilRig3.Center,
        Regions.OilRig4.Center,
        Regions.OilRig5.Center,
        Regions.OilRig6.Center
      }));
      
    }
  }
}