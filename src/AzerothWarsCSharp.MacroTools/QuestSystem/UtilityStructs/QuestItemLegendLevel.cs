using AzerothWarsCSharp.MacroTools.FactionSystem;

namespace AzerothWarsCSharp.MacroTools.QuestSystem.UtilityStructs
{
  public sealed class QuestItemLegendLevel : QuestItemData
  {
    private static int count = 0;
    private static thistype[] byIndex;
    private readonly int level;


    private readonly Legend target = 0;

    public QuestItemLegendLevel(Legend target, int level)
    {
      Description = target.Name + " is level " + I2S(level);
      this.target = target;
      this.level = level;
      thistype.byIndex[thistype.count] = this;
      thistype.count = thistype.count + 1;
    }

    private void OnLevel()
    {
      if (GetHeroLevel(target.Unit) >= level) Progress = QuestProgress.Complete;
    }

    private static void OnAnyLevel()
    {
      var i = 0;
      thistype loopItem;
      Legend triggerLegend = Legend.ByHandle(GetTriggerUnit());
      while (true)
      {
        if (i == thistype.count) break;
        loopItem = thistype.byIndex[i];
        if (loopItem.target == triggerLegend) loopItem.OnLevel();
        i = i + 1;
      }
    }

    private static void onInit()
    {
      PlayerUnitEventAddAction(EVENT_PLAYER_HERO_LEVEL, thistype.OnAnyLevel); //TODO: use filtered events
    }
  }
}