﻿using AzerothWarsCSharp.Launcher.ObjectFactory.Abilities;
using AzerothWarsCSharp.Launcher.ObjectFactory.Units;
using System.Drawing;
using War3Api.Object;

namespace AzerothWarsCSharp.Launcher.ObjectFactory
{
  public static class Kultiras
  {
    public static void Setup()
    {
      //Sea Elemental
      var seaElemental = new UnitFactory(UnitType.Seaelemental)
      {
        TextName = "Sea Elemental",
        ArtIconGameInterface = "SeaElemental",
        AbilitiesNormal = System.Array.Empty<Ability>(),
        DamageBase = 10,
        DamageNumberOfDice = 2,
        DamageSidesPerDie = 6,
        HitPoints = 600,
        Flavour = "Avatar of the sea's primordial force.",
      }.Generate("ksea");

      //Summon Sea Elemental
      var summonSeaElemental = new SummonWaterElementalFactory()
      {
        Levels = 1,
        SummonedUnit = new Unit[] { seaElemental },
        SummonCount = new int[] { 1 },
        Icon = seaElemental.ArtIconGameInterface,
        Duration = new int[] { 40 },
      }.Generate("asea");

      //Tidesage
      new UnitFactory(UnitType.Priest)
      {
        TextName = "Tidepriest",
        Flavour = "Spellcaster empowered with mystical control over the tides.",
        AbilitiesNormal = new Ability[] { summonSeaElemental },
        DamageBase = 4,
        DamageNumberOfDice = 2,
        DamageSidesPerDie = 7,
        HitPoints = 600,
      }.Generate("ktid");

      //Blacksmith
      var blacksmith = new BuildingFactory(UnitType.Blacksmith)
      {
        ButtonPosition = new Point(2, 0),
        ScalingValue = 0.85F,
        HitPoints = 200,
        UnitsTrained = System.Array.Empty<Unit>(),
        ResearchesAvailable = System.Array.Empty<Upgrade>(),
        Flavour = "Where the weapons and armor of Kul'tiras are forged.",
        AbilitiesNormal = System.Array.Empty<Ability>()
      }.Generate("kbla");

      //Scout Tower
      var scoutTowerFactory = new BuildingFactory(UnitType.Scouttower)
      {
        TextName = "Scout Tower",
        HitPoints = 300,
        ArtModelFile = @"buildings\human\HumanTower\HumanTower"
      };
      var scoutTower = scoutTowerFactory.Generate("ksco");

      //Guard Tower
      var guardTowerFactory = new BuildingFactory(UnitType.Scouttower)
      {
        TextName = "Guard Tower",
        HitPoints = 500,
        Parent = scoutTowerFactory,
        RequiredAnimationNames = new string[] { "upgrade", "first" }
      };
      var guardTower = guardTowerFactory.Generate("kgua");

      //Cannon Tower
      var cannonTowerFactory = new BuildingFactory(UnitType.Scouttower)
      {
        TextName = "Cannon Tower",
        HitPoints = 600,
        Parent = scoutTowerFactory,
        RequiredAnimationNames = new string[] { "upgrade", "second" }
      };
      var cannonTower = cannonTowerFactory.Generate("kcan");

      //Evasion
      var evasionFactory = new EvasionFactory()
      {
        ChanceToEvade = { 0.1F, 0.2F, 0.3F, 0.4F },
        Levels = 4,
        Icon = "Evasion",
        TextName = "Evasion",
        ButtonPosition = new Point(2,2)
      };
      var evasion = evasionFactory.Generate("aaaa");

      //Immolation
      var immolationFactory = new ImmolationFactory()
      {
        DamagePerSecond = { 10F, 20F, 30F, 40F },
        ManaCost = { 5, 5, 5, 5 },
        Levels = 4,
        Icon = "ImmolationOn",
        TextName = "Immolation",
        ButtonPosition = new Point(1, 2)
      };
      var immolation = immolationFactory.Generate("imm1");

      //Immolation
      var manaburnfactory = new ManaBurnFactory()
      {
        MaxManaDrained = { 50, 100, 200, 250 },
        CastRange = { 300 },
        Levels = 4,
        Icon = @"ManaBurn",
        TextName = "Mana Burn",
        ButtonPosition = new Point(0, 2)
      };
      var manaburn = manaburnfactory.Generate("mbur");

      //Metamorphosis
      var metamorphosisFactory = new MetamorphosisFactory()
      {
        Levels = 3,
        Icon = @"Metamorphosis",
        TextName = "Metamorphosis",
        ButtonPosition = new Point(3, 2),
        BonusHitPoints = { 200, 100, 6000 },
        AlternateForm = { scoutTower, cannonTower, guardTower },
        NormalForm = { blacksmith, blacksmith, blacksmith },
        MorphFlags = { MorphFlags.Uninterruptable },
        Duration = { 60, 60, 120 },
        TransformTime = { 1, 1, 1}
      };
      var metamorphosis = metamorphosisFactory.Generate("meta");

      //Blademaster
      new HeroFactory(UnitType.Demonhunter)
      {
        AbilitiesHero = new Ability[] { evasion, immolation, manaburn, metamorphosis },
        Strength = 100,
        Agility = 10,
        Intelligence = 5,
        ProperName = "YakaryBovine",
        TextName = "Blademaster",
      }.Generate("Yakb");

      //Deckhand
      new WorkerFactory(UnitType.Peasant)
      {
        TextName = "Deckhand",
        DamageBase = 4,
        DamageNumberOfDice = 1,
        DamageSidesPerDie = 2,
        HitPoints = 230,
        AbilitiesNormal = new Ability[] { evasion },
        StructuresBuilt = new Unit[] { blacksmith, scoutTower, guardTower, cannonTower },
        Flavour = "The backbone of Kul'tiran seafaring society.",
      }.Generate("kdec");
    }
  }
}