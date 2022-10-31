using MacroTools.QuestSystem;
using WarcraftLegacies.Source.Quests.Ironforge;
using WarcraftLegacies.Source.Setup.FactionSetup;

namespace WarcraftLegacies.Source.Setup.QuestSetup
{
  public static class IronforgeQuestSetup
  {
    public static void Setup()
    {
      var ironforge = IronforgeSetup.Ironforge;
      QuestData newQuest = ironforge.AddQuest(new QuestThelsamar(Regions.ThelUnlock));
      ironforge.StartingQuest = newQuest;
      ironforge.AddQuest(new QuestDunMorogh());
      ironforge.AddQuest(new QuestDominion(Regions.IronforgeAmbient));
      ironforge.AddQuest(new QuestGnomeregan(Regions.Gnomergan));
      ironforge.AddQuest(new QuestDarkIron());
      ironforge.AddQuest(new QuestWildhammer());
    }
  }
}