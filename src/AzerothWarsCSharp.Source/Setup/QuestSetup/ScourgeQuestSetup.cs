using AzerothWarsCSharp.MacroTools;
using AzerothWarsCSharp.MacroTools.QuestSystem.UtilityStructs;
using AzerothWarsCSharp.Source.Quests.Scourge;
using AzerothWarsCSharp.Source.Setup.FactionSetup;

namespace AzerothWarsCSharp.Source.Setup.QuestSetup
{
  public static class ScourgeQuestSetup
  {
    public static void Setup()
    {
      QuestSpiderWar questSpiderWar = new(PreplacedUnitSystem.GetUnitByUnitType(Constants.UNIT_QUEEN_NEZAR_AZRET));
      QuestKelthuzad questKelthuzad = new();
      QuestDrakUnlock questDrakUnlock = new();
      QuestPlague questPlague = new();
      QuestSapphiron questSapphiron = new(PreplacedUnitSystem.GetUnitByUnitType(Constants.UNIT_SAPPHIRON_CREEP));
      QuestCorruptArthas questCorruptArthas = new();
      QuestNaxxramas questNaxxramas = new(PreplacedUnitSystem.GetUnitByUnitType(Constants.UNIT_NAXXRAMAS_SCOURGE));
      QuestCivilWar questCivilWar = new();
      QuestLichKingArthas questLichKingArthas =
        new(PreplacedUnitSystem.GetUnitByUnitType(Constants.UNIT_UTGARDE_KEEP_SCOURGE));

      questNaxxramas.AddQuestItem(new QuestItemCompleteQuest(questKelthuzad));

      //Setup
      ScourgeSetup.FactionScourge.AddQuest(questSpiderWar);
      ScourgeSetup.FactionScourge.StartingQuest = questSpiderWar;
      ScourgeSetup.FactionScourge.AddQuest(questDrakUnlock);
      ScourgeSetup.FactionScourge.AddQuest(questPlague);
      ScourgeSetup.FactionScourge.AddQuest(questSapphiron);
      //Early duel
      ScourgeSetup.FactionScourge.AddQuest(questCorruptArthas);
      ScourgeSetup.FactionScourge.AddQuest(questKelthuzad);
      ScourgeSetup.FactionScourge.AddQuest(questNaxxramas);
      ScourgeSetup.FactionScourge.AddQuest(questCivilWar);
      //Misc
      ScourgeSetup.FactionScourge.AddQuest(questLichKingArthas);
    }
  }
}