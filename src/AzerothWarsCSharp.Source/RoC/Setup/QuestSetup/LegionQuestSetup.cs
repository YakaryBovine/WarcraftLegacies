using AzerothWarsCSharp.Source.Main.Libraries.QuestSystem;
using AzerothWarsCSharp.Source.RoC.Quests.Legion;

namespace AzerothWarsCSharp.Source.RoC.Setup.QuestSetup
{
  public class LegionQuestSetup{

    public static void Setup( ){
      //Early duel
      QuestData newQuest = FACTION_LEGION.AddQuest(QuestArgusControl.create());
      FACTION_LEGION.StartingQuest = newQuest;
      FACTION_LEGION.AddQuest(QuestEmbassy.create());
      FACTION_LEGION.AddQuest(QuestLegionCaptureSunwell.create());
      FACTION_LEGION.AddQuest(QuestLegionKillLordaeron.create());
      //Misc
      FACTION_LEGION.AddQuest(QuestSummonLegion.create());
      FACTION_LEGION.AddQuest(QuestConsumeTree.create());
      FACTION_LEGION.AddQuest(QuestDreadlordInsurgent.create());
    }

  }
}
