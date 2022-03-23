using AzerothWarsCSharp.MacroTools.FactionSystem;
using AzerothWarsCSharp.MacroTools.QuestSystem;
using AzerothWarsCSharp.MacroTools.QuestSystem.UtilityStructs;

namespace AzerothWarsCSharp.Source.Quests.Draenei
{
  public sealed class QuestBrokenOne : QuestData{

  
    private const int QUESTRESEARCH_ID = FourCC("R083")   ;//This research is given when the quest is completed
  



    protected override string CompletionPopup => 
      return "The hero Nobundo is now trainable at the Altar";
    }

    protected override string CompletionDescription => 
      return "Nobundo will join the survivors on the Exodar";
    }

    public  thistype ( ){
      thistype this = thistype.allocate("The Broken One", "The great shaman Nobundo is fighting to enable Velen && most of the Draenei to escape. If the Draenei hold out long enough, he might have time to join the survivors aboard the Exodar", "ReplaceableTextures\\CommandButtons\\BTNAkamanew.blp");
      this.AddQuestItem(new QuestItemTime(720));
      this.AddQuestItem(new QuestItemControlPoint(ControlPoint.GetFromUnitType(FourCC("n02O"))));
      this.ResearchId = QUESTRESEARCH_ID;
      ;;
    }


  }
}
