using MacroTools;
using WarcraftLegacies.Source.Quests.Quelthalas;
using WarcraftLegacies.Source.Setup.FactionSetup;
using WCSharp.Shared.Data;

namespace WarcraftLegacies.Source.Setup.QuestSetup
{
  public static class QuelthalasQuestSetup
  {
    public static void Setup()
    {
      var quelthalas = QuelthalasSetup.Quelthalas;
      var newQuest = quelthalas.AddQuest(new QuestSilvermoon(Regions.SunwellAmbient,
        PreplacedUnitSystem.GetUnit(Constants.UNIT_H00D_ELVEN_RUNESTONE_QUEL_THALAS, new Point(20477, 17447))));
      quelthalas.StartingQuest = newQuest;
      var theBloodElves = quelthalas.AddQuest(new QuestTheBloodElves(Regions.BloodElfSecondChanceSpawn));
      quelthalas.AddQuest(new QuestQueldanil(Regions.QuelDanil_Lodge.Rect));
      quelthalas.AddQuest(new QuestTempestKeep(Regions.TempestKeepHide, theBloodElves));
    }
  }
}