using MacroTools.FactionSystem;
using MacroTools.QuestSystem;
using WarcraftLegacies.Source.Quests.Lordaeron;
using WarcraftLegacies.Source.Setup.FactionSetup;
using WarcraftLegacies.Source.Setup.Legends;

namespace WarcraftLegacies.Source.Setup.QuestSetup
{
  /// <summary>
  /// Setup of all quests for the Lordaeron <see cref="Faction"/>
  /// </summary>
  public static class LordaeronQuestSetup
  {
    public static QuestData TheAshbringer { get; private set; }

    public static void Setup()
    {
      var lordaeron = LordaeronSetup.Lordaeron;
      var kingTerenas = LegendLordaeron.Terenas?.Unit;

      if (lordaeron != null && kingTerenas != null)
      {
        var questStrahnbrad = new QuestStrahnbrad(Regions.StrahnbradUnlock);
        var questStratholme = new QuestStratholme(Regions.StratholmeUnlock);
        lordaeron.AddQuest(questStratholme);
        lordaeron.StartingQuest = questStratholme;
        lordaeron.AddQuest(questStrahnbrad);
        lordaeron.AddQuest(new QuestCapitalCity(Regions.Terenas, kingTerenas,
          new QuestData[]
          {
          questStrahnbrad,
          questStratholme
          }));
        lordaeron.AddQuest(new QuestMograine());
        lordaeron.AddQuest(new QuestShoresOfNorthrend());
        lordaeron.AddQuest(new QuestThunderEagle());
        lordaeron.AddQuest(new QuestKingArthas(kingTerenas));
        lordaeron.AddQuest(new QuestLivingShadow());
        lordaeron.AddQuest(new QuestKingdomOfManLordaeron());
        lordaeron.AddQuest(new QuestGarithosCrusade());
        lordaeron.AddQuest(new QuestGarithosMindControl());
        TheAshbringer = new QuestAshbringer();
      }
    }
  }
}