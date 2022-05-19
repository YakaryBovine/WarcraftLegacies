using AzerothWarsCSharp.MacroTools.QuestSystem;
using AzerothWarsCSharp.MacroTools.QuestSystem.UtilityStructs;
using AzerothWarsCSharp.Source.Setup.Legends;
using static War3Api.Common;

namespace AzerothWarsCSharp.Source.Quests.Goblin
{
  public sealed class QuestLumberMarket : QuestData
  {
    protected override string CompletionPopup => "The World Tree is ours, our lumber supplies will never run out!";

    protected override string RewardDescription =>
      "Shredders will gain cleaving attack and 500 hit points. You will gain 30000 lumber.";

    protected override void OnComplete()
    {
      AdjustPlayerStateBJ(30000, Holder.Player, PLAYER_STATE_RESOURCE_LUMBER);
    }

    public QuestLumberMarket() : base("Lumber Market Krash",
      "The World Tree would provide enough lumber to completely crash the lumber market, forcing our Shredders to specialise more on war.",
      "ReplaceableTextures\\CommandButtons\\BTNJunkGolem.blp")
    {
      AddQuestItem(new QuestItemControlLegend(LegendDruids.LegendNordrassil, false));
      ResearchId = FourCC("R07Z");
    }
  }
}