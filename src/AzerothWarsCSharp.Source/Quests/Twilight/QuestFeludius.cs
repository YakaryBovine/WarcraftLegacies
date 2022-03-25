using AzerothWarsCSharp.MacroTools.FactionSystem;
using AzerothWarsCSharp.MacroTools.QuestSystem;
using AzerothWarsCSharp.MacroTools.QuestSystem.UtilityStructs;

namespace AzerothWarsCSharp.Source.Quests.Twilight
{
  public sealed class QuestFeludius : QuestData
  {
    private static readonly int ResearchId = FourCC("R07T");


    public QuestFeludius()
    {
      thistype this = thistype.allocate("Gift of the Windlord",
        "Bringing the Legendary Sword, Thunderfury, to Uldum will grant us the favors of AlFourCC("akir,
        the great Wind Elemental Lord", "ReplaceableTextures\\CommandButtons\\BTNfuryoftheair.blp");
      AddQuestItem(new QuestItemControlPoint(ControlPoint.GetFromUnitType(FourCC("n0BD"))));
      AddQuestItem(new QuestItemArtifactInRect(ARTIFACT_THUNDERFURY, Regions.UldumAmbiance.Rect, "Uldum"));
      base.ResearchId = ResearchId;
    }


    protected override string CompletionPopup => "The great AlFourCC(akir has joined us!";

    protected override string CompletionDescription => "You can summon Al-akir from the Altar";
  }
}