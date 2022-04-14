using AzerothWarsCSharp.MacroTools.FactionSystem;
using static War3Api.Common;
using static AzerothWarsCSharp.MacroTools.Libraries.GeneralHelpers;

namespace AzerothWarsCSharp.Source.Commands
{
  /// <summary>
  /// A command that causes a player to leave their <see cref="Team"/> and be given a solo Team with their <see cref="Faction"/> as the name.
  /// </summary>
  public static class UnallyCommand
  {
    private const string COMMAND = "-unally";
    
    private static void Actions()
    {
      PlayerData triggerPlayerData = PlayerData.ByHandle(GetTriggerPlayer());
      triggerPlayerData.Faction.Unally();
    }

    public static void Setup()
    {
      trigger trig = CreateTrigger();
      foreach (var player in GetAllPlayers())
      {
        TriggerRegisterPlayerChatEvent(trig, player, COMMAND, true);
      }

      TriggerAddAction(trig, Actions);
    }
  }
}