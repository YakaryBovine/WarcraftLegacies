using static AzerothWarsCSharp.MacroTools.Libraries.GeneralHelpers;
using AzerothWarsCSharp.MacroTools.QuestSystem;
using AzerothWarsCSharp.MacroTools.QuestSystem.UtilityStructs;
using AzerothWarsCSharp.Source.Legends;
using AzerothWarsCSharp.Source.Setup;
using AzerothWarsCSharp.Source.Setup.FactionSetup;
using AzerothWarsCSharp.Source.Setup.QuestSetup;

namespace AzerothWarsCSharp.Source.Quests.Lordaeron
{
  public sealed class QuestLivingShadow : QuestData
  {
    public QuestLivingShadow() : base("The Living Embodiment of Shadow",
      "The Dark Fortress looming over the Twilight Highlands is a beacon of darkness. Destroy it and clear the surrounding lands of evil.",
      "ReplaceableTextures\\CommandButtons\\BTNShadow Orb.blp")
    {
      AddQuestItem(new QuestItemLegendInRect(LegendLordaeron.LegendUther, Regions.TwilightOutside.Rect, "Twilight Citadel"));
      AddQuestItem(new QuestItemLegendDead(LegendTwilight.LegendTwilightcitadel));
    }
    
    protected override string CompletionPopup =>
      "Uther has discovered the Living Embodiment of Shadow in the ruins of the Twilight Citadel";

    protected override string RewardDescription => "The Living Shadow and the Ashbringer Quest discovery";

    protected override void OnComplete()
    {
      UnitAddItemSafe(LegendLordaeron.LegendUther.Unit, ArtifactSetup.ArtifactLivingshadow.Item);
      LordaeronSetup.FactionLordaeron.AddQuest(LordaeronQuestSetup.TheAshbringer);
      LordaeronQuestSetup.TheAshbringer.Progress = QuestProgress.Incomplete;
    }
  }
}