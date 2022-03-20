using AzerothWarsCSharp.MacroTools;
using AzerothWarsCSharp.Source.Libraries;
using AzerothWarsCSharp.Source.Libraries.QuestSystem.UtilityStructs;

namespace AzerothWarsCSharp.Source.Quests.Legion
{
  public class QuestConsumeTree{



    bool operator Global( ){
      return true;
    }

    protected override string CompletionPopup => 
      return "Archimonde has now consummed the World Tree && is now nigh unstoppable";
    }

    protected override string CompletionDescription => 
      return "By consuming the World Tree, Archimonde will obtain immense power. +80 to all stats. Additionally, the Druids faction will be eliminated.";
    }

    protected override void OnComplete(){
      unit whichUnit = LEGEND_ARCHIMONDE.Unit;
      FACTION_DRUIDS.obliterate();
      BlzSetUnitName(whichUnit, "Devourer of Worlds");
      AddSpecialEffectTarget("Abilities\\Weapons\\GreenDragonMissile\\GreenDragonMissile.mdl", whichUnit, "hand, right");
      AddSpecialEffectTarget("Abilities\\Weapons\\GreenDragonMissile\\GreenDragonMissile.mdl", whichUnit, "hand, left");
      GeneralHelpers.AddHeroAttributes(whichUnit, 80, 80, 80);
    }

    public  thistype ( ){
      thistype this = thistype.allocate("Twilight of the Gods", "Consuming the World Tree will grant Archimonde immeasurable power && eliminate his mortal enemies, the Druids of Kalimdor, forever.", "ReplaceableTextures\\CommandButtons\\BTNGlazeroth.blp");
      this.AddQuestItem(QuestItemChannelRect.create(gg_rct_ArchimondeChannel, "The World Tree", LEGEND_ARCHIMONDE, 420, 90));
      ;;
    }


  }
}
