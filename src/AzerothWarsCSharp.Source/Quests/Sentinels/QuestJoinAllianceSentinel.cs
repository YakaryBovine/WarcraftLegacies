using AzerothWarsCSharp.MacroTools.QuestSystem;
using AzerothWarsCSharp.MacroTools.QuestSystem.UtilityStructs;

namespace AzerothWarsCSharp.Source.Quests.Sentinels
{
  public sealed class QuestJoinAllianceSentinel : QuestData
  {
    public QuestJoinAllianceSentinel() : base("Join the Alliance",
      "With a world ending threat happening, the Alliance has reached to the Night Elves to join them",
      "ReplaceableTextures\\CommandButtons\\BTNalliance.blp")
    {
      AddQuestItem(new QuestItemCastSpell(FourCC("A0IG"), true));
      AddQuestItem(new QuestItemControlLegend(LEGEND_TYRANDE, true));
      ;
      ;
    }


    protected override string CompletionPopup => "The Sentinels have joined the Alliance";

    protected override string CompletionDescription => "Join the Alliance team";


    protected override void OnComplete()
    {
      UnitRemoveAbilityBJ(FourCC("A0IG"), LEGEND_TYRANDE.Unit);
      Holder.Team = TEAM_ALLIANCE;
    }
  }
}