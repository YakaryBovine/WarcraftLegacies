//Displays each Faction)s starting quest after the cinematic phase ends

using AzerothWarsCSharp.MacroTools.FactionSystem;
using static War3Api.Common;
using static AzerothWarsCSharp.MacroTools.Libraries.GeneralHelpers;

namespace AzerothWarsCSharp.Source.Game_Logic
{
  public static class StartingQuestPopup
  {
    public static void Setup()
    {
      trigger trig = CreateTrigger();
      TriggerRegisterTimerEvent(trig, 63, false);
      TriggerAddAction(trig, () =>
      {
        foreach (var player in GetAllPlayers())
        {
          if (PlayerData.ByHandle(player)?.Faction.StartingQuest != null && GetLocalPlayer() == player)
          {
            PlayerData.ByHandle(player)?.Faction.StartingQuest.DisplayDiscovered();
          }
        }
      });
    }
  }
}