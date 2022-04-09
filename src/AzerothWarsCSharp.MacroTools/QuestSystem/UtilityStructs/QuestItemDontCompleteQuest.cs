namespace AzerothWarsCSharp.MacroTools.QuestSystem.UtilityStructs
{
  public sealed class QuestItemDontCompleteQuest : QuestItemData{


    private QuestData target = 0;
    private static int count = 0;
    private static thistype[] byIndex;

    private void OnAdd( ){
      this.Progress = QuestProgress.Complete;
    }

    public void OnQuestProgressChanged( ){
      if (target.Progress == QuestProgress.Complete){
        this.Progress = QuestProgress.Failed;
      }
    }

    public static void OnAnyQuestProgressChanged( ){
      var i = 0;
      thistype loopItem;
      while(true){
        if ( i == thistype.count){ break; }
        loopItem = thistype.byIndex[i];
        if (loopItem.target == GetTriggerQuest()){
          loopItem.OnQuestProgressChanged();
        }
        i = i + 1;
      }
    }

    public QuestItemDontcompleteQuest(QuestData target){


      if (target == 0){
        BJDebugMsg("Parameter target of QuestItemDontCompleteQuest can!be 0");
      }

      this.target = target;
      this.Description = "Do !complete the quest " + target.Title;
      thistype.byIndex[thistype.count] = this;
      thistype.count = thistype.count + 1;
      
    }



    public static void Setup( ){
      trigger trig = CreateTrigger();
      QuestProgressChanged.register(trig);
      TriggerAddAction(trig,  OnAnyQuestProgressChanged);
    }

  }
}
