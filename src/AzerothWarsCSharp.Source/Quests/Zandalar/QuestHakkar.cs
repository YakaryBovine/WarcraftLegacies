using AzerothWarsCSharp.MacroTools.ControlPointSystem;
using AzerothWarsCSharp.MacroTools.FactionSystem;
using AzerothWarsCSharp.MacroTools.QuestSystem;
using AzerothWarsCSharp.MacroTools.QuestSystem.UtilityStructs;
using AzerothWarsCSharp.Source.Setup;
using AzerothWarsCSharp.Source.Setup.Legends;

namespace AzerothWarsCSharp.Source.Quests.Zandalar
{
  public sealed class QuestHakkar : QuestData
  {
    public QuestHakkar() : base("The Binding of the Soulflayer",
      "Hakkar is the most dangerous and powerful of the Troll gods. Only by fusing the Demon Soul would the Zandalari be able to control Hakkar and bind him to their will.",
      "ReplaceableTextures\\CommandButtons\\BTNWindSerpent2blp")
    {
      AddObjective(new ObjectiveAcquireArtifact(ArtifactSetup.ArtifactZinrokh));
      AddObjective(new ObjectiveArtifactInRect(ArtifactSetup.ArtifactZinrokh, Regions.DrownedTemple,
        "The Drowned Temple"));
      AddObjective(new ObjectiveControlPoint(ControlPointManager.GetFromUnitType(FourCC("n00U"))));
      Global = true;
    }

    protected override string CompletionPopup => "Hakkar has emerged from the Drowned Temple";

    protected override string RewardDescription => "Gain the demigod hero Hakkar";

    protected override void OnComplete(Faction completingFaction)
    {
      LegendTroll.LEGEND_HAKKAR.Spawn(completingFaction.Player, Regions.DrownedTemple.Center, 270);
      SetHeroLevel(LegendTroll.LEGEND_HAKKAR.Unit, 12, false);
    }
  }
}