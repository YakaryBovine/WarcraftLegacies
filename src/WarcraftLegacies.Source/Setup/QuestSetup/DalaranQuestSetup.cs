﻿using MacroTools;
using MacroTools.QuestSystem.UtilityStructs;
using WarcraftLegacies.Source.Quests.Dalaran;
using WarcraftLegacies.Source.Setup.FactionSetup;
using static War3Api.Common;

namespace WarcraftLegacies.Source.Setup.QuestSetup
{
  public static class DalaranQuestSetup
  {
    public static void Setup()
    {
      var dalaran = DalaranSetup.Dalaran;

      QuestNewGuardian newGuardian = new();
      QuestTheNexus theNexus = new();
      QuestCrystalGolem crystalGolem = new();
      QuestFallenGuardian fallenGuardian = new();
      QuestSouthshore questSouthshore =
        new(Regions.SouthshoreUnlock, PreplacedUnitSystem.GetUnit(FourCC("nmrm"), Regions.SouthshoreUnlock.Center));

      newGuardian.AddObjective(new ObjectiveDontCompleteQuest(theNexus));
      crystalGolem.AddObjective(new ObjectiveDontCompleteQuest(theNexus));
      fallenGuardian.AddObjective(new ObjectiveDontCompleteQuest(theNexus));
      theNexus.AddObjective(new ObjectiveDontCompleteQuest(newGuardian));

      dalaran.AddQuest(questSouthshore);
      dalaran.StartingQuest = questSouthshore;
      dalaran.AddQuest(new QuestShadowfang(Regions.ShadowfangUnlock,
        PreplacedUnitSystem.GetUnit(Constants.UNIT_NWLD_DIRE_WOLF_CREEP, Regions.ShadowfangUnlock.Center)));
      dalaran.AddQuest(new QuestDalaran(new[] {Regions.Dalaran, Regions.DalaranDungeon}));
      dalaran.AddQuest(new QuestJainaSoulGem());
      dalaran.AddQuest(new QuestBlueDragons());
      dalaran.AddQuest(new QuestKarazhan());

      dalaran.AddQuest(crystalGolem);
      dalaran.AddQuest(fallenGuardian);
      dalaran.AddQuest(newGuardian);
      dalaran.AddQuest(theNexus);
    }
  }
}