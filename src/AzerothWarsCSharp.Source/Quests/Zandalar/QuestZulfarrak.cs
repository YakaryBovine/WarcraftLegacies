using AzerothWarsCSharp.MacroTools;
using AzerothWarsCSharp.MacroTools.QuestSystem;
using AzerothWarsCSharp.MacroTools.QuestSystem.UtilityStructs;
using AzerothWarsCSharp.Source.Libraries;

namespace AzerothWarsCSharp.Source.Quests.Zandalar
{
  public sealed class QuestZulfarrak : QuestData{

  
    private const int GAHZRILLA_RESEARCH = FourCC("R02F");
    private const int GAHZRILLA_ID = FourCC("H06Q");
  


    protected override string CompletionPopup => 
      return "ZulFourCC("farrak has fallen. The Sandfury trolls lend their might to the " + this.Holder.Team.Name + ", you can train Storm Wyrms && Gahz")rilla awakens from its slumber.";
    }

    protected override string CompletionDescription => 
      return "Control of ZulFourCC("farrak, 300 gold tribute, enable to train Storm Wyrm && you can summon the hero Gahz")rilla from the Altar of Conquerors";
    }

    protected override void OnComplete(){
      unit u;
      group tempGroup;
      tempGroup = CreateGroup();
      GroupEnumUnitsInRect(tempGroup, gg_rct_Zulfarrak, null);
      u = FirstOfGroup(tempGroup);
      while(true){
        if ( u == null){ break; }
        if (GetOwningPlayer(u) == Player(PLAYER_NEUTRAL_PASSIVE) || GetOwningPlayer(u) == Player(PLAYER_NEUTRAL_AGGRESSIVE)){
          if (IsUnitType(u, UNIT_TYPE_HERO)){
            KillUnit(u);
          }else {
            GeneralHelpers.UnitRescue(u, this.Holder.Player);
          }
        }
        GroupRemoveUnit(tempGroup, u);
        u = FirstOfGroup(tempGroup);
      }
      DestroyGroup(tempGroup);
      SetPlayerTechResearched(Holder.Player, GAHZRILLA_RESEARCH, 1);
      AdjustPlayerStateBJ( 300, this.Holder.Player, PLAYER_STATE_RESOURCE_GOLD );
      SetUnitOwner(LEGEND_ZULFARRAK.Unit, this.Holder.Player, true);
    }

    private void OnAdd( ){
      this.Holder.ModObjectLimit(GAHZRILLA_RESEARCH, UNLIMITED);
      this.Holder.ModObjectLimit(GAHZRILLA_ID, 1);
    }

    public  thistype ( ){
      thistype this = thistype.allocate("Fury of the Sands", "The Sandfury Trolls of ZulFourCC("farrak are openly hostile to visitors, but they share a common heritage with the Zandalari Trolls. An adequate display of force could bring them around.", "ReplaceableTextures\\CommandButtons\\BTNDarkTroll.blp"");
      this.AddQuestItem(new QuestItemControlLegend(LEGEND_ZULFARRAK, false));
      ;;
    }


  }
}
