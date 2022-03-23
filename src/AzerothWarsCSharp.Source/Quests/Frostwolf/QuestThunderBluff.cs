//If the Centaur Khan dies, OR a time elapses, give Thunder Bluff to a Horde player.

using AzerothWarsCSharp.MacroTools;
using AzerothWarsCSharp.MacroTools.QuestSystem;
using AzerothWarsCSharp.MacroTools.QuestSystem.UtilityStructs;
using AzerothWarsCSharp.Source.Libraries;

namespace AzerothWarsCSharp.Source.Quests.Frostwolf
{
  public sealed class QuestThunderBluff : QuestData{

  
    private group ThunderBluffUnits;
    private const int QUEST_RESEARCH_ID = FourCC("R05I");
  



    protected override string CompletionPopup => 

    }

    protected override string CompletionDescription => 
      return "Control of Thunder Bluff";
    }

    private void OnFail( ){
      GeneralHelpers.RescueNeutralUnitsInRect(gg_rct_ThunderBluff, Player(PLAYER_NEUTRAL_AGGRESSIVE));
    }

    protected override void OnComplete(){
      GeneralHelpers.RescueNeutralUnitsInRect(gg_rct_ThunderBluff, this.Holder.Player);
      if (GetLocalPlayer() == this.Holder.Player){
        PlayThematicMusicBJ( "war3mapImported\\TaurenTheme.mp3" );
      }
    }

    public  thistype ( ){
      thistype this = thistype.allocate("The Long March", "The Tauren have been wandering for too long. The plains of Mulgore would offer respite from this endless journey.", "ReplaceableTextures\\CommandButtons\\BTNCentaurKhan.blp");
      this.AddQuestItem(new QuestItemLegendDead(LEGEND_CENTAURKHAN));
      this.AddQuestItem(new QuestItemAnyUnitInRect(gg_rct_ThunderBluff, "Thunder Bluff", true));
      this.AddQuestItem(new QuestItemExpire(1455));
      this.AddQuestItem(new QuestItemSelfExists());
      this.ResearchId = QUEST_RESEARCH_ID;
      ;;
    }


    public static void Setup( ){
      //Setup initially invulnerable and hidden group at Thunder Bluff
      group tempGroup = CreateGroup();
      unit u;
      var i = 0;
      ThunderBluffUnits = CreateGroup();
      GroupEnumUnitsInRect(tempGroup, gg_rct_ThunderBluff, null);
      while(true){
        u = FirstOfGroup(tempGroup);
        if ( u == null){ break; }
        if (GetOwningPlayer(u) == Player(PLAYER_NEUTRAL_PASSIVE)){
          SetUnitInvulnerable(u, true);
          GroupAddUnit(ThunderBluffUnits, u);
        }
        GroupRemoveUnit(tempGroup, u);
        i = i + 1;
      }
      DestroyGroup(tempGroup);
      tempGroup = null;

    }

  }
}
