using AzerothWarsCSharp.Source.RoC.Quests.BlackEmpire;
using AzerothWarsCSharp.Source.RoC.Setup.FactionSetup;

namespace AzerothWarsCSharp.Source.RoC.Setup.QuestSetup
{
  public static class BlackEmpireQuestSetup
  {
    public static void Setup()
    {
      var blackempire = BlackEmpireSetup.FACTION_BLACKEMPIRE;
      blackempire.StartingQuest = blackempire.AddQuest(new QuestFirstObelisk(Regions.NyalothaUnlock1.Rect));
      blackempire.AddQuest(new QuestSecondObelisk());
      blackempire.AddQuest(new QuestThirdObelisk());
      blackempire.AddQuest(new QuestYoggSaron());
      blackempire.AddQuest(new QuestBladeOfTheBlackEmpire(new QuestIntoTheVoid()));
    }
  }
}