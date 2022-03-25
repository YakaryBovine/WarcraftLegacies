using AzerothWarsCSharp.MacroTools;
using AzerothWarsCSharp.MacroTools.QuestSystem;
using AzerothWarsCSharp.MacroTools.QuestSystem.UtilityStructs;
using AzerothWarsCSharp.Source.Legends;

namespace AzerothWarsCSharp.Source.Quests.Legion
{
  public sealed class QuestLegionKillLordaeron : QuestData
  {
    public QuestLegionKillLordaeron() : base("Token Resistance",
      "The Kingdom of Lordaeron must be eliminated to pave the way for the Legion's arrival.",
      "ReplaceableTextures\\CommandButtons\\BTNTichondrius.blp")
    {
      AddQuestItem(new QuestItemLegendDead(LegendLordaeron.LEGEND_CAPITALPALACE));
      AddQuestItem(new QuestItemLegendDead(LegendLordaeron.LEGEND_STRATHOLME));
      AddQuestItem(new QuestItemLegendDead(LegendLordaeron.LEGEND_TYRSHAND));
    }

    protected override string CompletionPopup =>
      "The Kingdom of Lordaeron has fallen, eliminating AzerothFourCC(s vanguard against the Legion.";

    protected override string CompletionDescription => "Tichondrius gains 15 Strength, Agility && Intelligence";

    protected override void OnComplete()
    {
      Display.DisplayHeroReward(LegendLegion.LEGEND_TICHONDRIUS.Unit, 15, 15, 15, 0);
      AddHeroAttributes(LegendLegion.LEGEND_TICHONDRIUS.Unit, 15, 15, 15);
    }
  }
}