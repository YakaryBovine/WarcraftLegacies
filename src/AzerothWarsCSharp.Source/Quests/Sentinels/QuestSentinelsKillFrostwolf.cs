using AzerothWarsCSharp.MacroTools.QuestSystem;
using AzerothWarsCSharp.MacroTools.QuestSystem.UtilityStructs;

namespace AzerothWarsCSharp.Source.Quests.Sentinels
{
  public sealed class QuestSentinelsKillFrostwolf : QuestData{

  
    private static readonly int ResearchId = FourCC("R052");
    private static readonly int AmaraId = FourCC("h03I");
  


    protected override string CompletionPopup => "The Frostwolves have been ousted from Kalimdor, along with their Tauren allies. They will !be missed.";

    protected override string CompletionDescription => "The demihero Amara && the hero Jarod";

    protected override void OnComplete(){
      SetPlayerTechResearched(Holder.Player, ResearchId, 1);
      DisplayUnitTypeAcquired(Holder.Player, AmaraId, "You can now revive Amara from the Altar of Elders.");
    }

    protected override void OnAdd( ){
      Holder.ModObjectLimit(AmaraId, 1);
      Holder.ModObjectLimit(ResearchId, UNLIMITED);
    }

    public  thistype ( ){
      thistype this = thistype.allocate("Drive Them Back", "The Frostwolf Clan is beginning to seize a firm foothold within the Barrens && on the plains of Mulgore. They must be driven back.", "ReplaceableTextures\\CommandButtons\\BTNThrall.blp");
      AddQuestItem(new QuestItemLegendDead(LEGEND_THUNDERBLUFF));
      ;;
    }


  }
}
