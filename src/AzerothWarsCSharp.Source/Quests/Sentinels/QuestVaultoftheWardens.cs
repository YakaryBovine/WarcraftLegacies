using AzerothWarsCSharp.MacroTools;
using AzerothWarsCSharp.Source.Libraries;
using AzerothWarsCSharp.Source.Libraries.MacroTools;
using AzerothWarsCSharp.Source.Libraries.QuestSystem.UtilityStructs;

namespace AzerothWarsCSharp.Source.Quests.Sentinels
{
  public class QuestVaultoftheWardens{

  
    private const int RESEARCH_ID = FourCC(R06H);
    private const int WARDEN_ID = FourCC(h045);
  


    protected override string CompletionPopup => 
      return "With the Broken Isles && the Tomb of Sargeras secured, work has begun on a maximum security prison named the Vault of the Wardens.";
    }

    protected override string CompletionDescription => 
      return "The Vault of the Wardens && 4 free Wardens appear at the Broken Isles, && you learn to train Wardens";
    }

    protected override void OnComplete(){
      CreateUnit(this.Holder.Player, FourCC(n04G), GetRectCenterX(gg_rct_VaultoftheWardens), GetRectCenterY(gg_rct_VaultoftheWardens), 220);
      GeneralHelpers.CreateUnits(this.Holder.Player, WARDEN_ID, GetRectCenterX(gg_rct_VaultoftheWardens), GetRectCenterY(gg_rct_VaultoftheWardens), 270, 4);
      SetPlayerTechResearched(Holder.Player, RESEARCH_ID, 1);
      DisplayUnitTypeAcquired(Holder.Player, WARDEN_ID, "You can now train Wardens from the Vault of the Wardens, Sentinel Enclaves, && your capitals.");
    }

    private void OnAdd( ){
      this.Holder.ModObjectLimit(WARDEN_ID, 8);
      this.Holder.ModObjectLimit(RESEARCH_ID, 1);
    }

    public  thistype ( ){
      thistype this = thistype.allocate("Vault of the Wardens", "In millenia past, the most vile entities of Azeroth were imprisoned in a facility near Zin-Ashari. The Broken Isles, now raised from the sea floor, would be a strategic location for a newer edition of such a prison.", "ReplaceableTextures\\CommandButtons\\BTNReincarnationWarden.blp");
      this.AddQuestItem(QuestItemControlPoint.create(ControlPoint.GetFromUnitType(FourCC(n05Y))));
      this.AddQuestItem(QuestItemSelfExists.create());
      ;;
    }


  }
}
