﻿using AzerothWarsCSharp.Common.Constants;
using AzerothWarsCSharp.Source.Libraries.Commands;
using static War3Api.Common;
using static War3Api.Blizzard;

namespace AzerothWarsCSharp.Source.Cheats
{
  /// <summary>
  /// A cheat to give the user control of other players.
  /// </summary>
  public static class CheatControl
  {
    public static void Setup()
    {
      CommandSystem.Register(new CheatCommand("control", (player triggerPlayer, string[] arguments) =>
      {
        var target = arguments[0];
        if (target == "all")
        {
          for (var i = 0; i < PlayerConstants.PlayerSlotCount; i++)
          {
            SetPlayerAllianceStateBJ(Player(i), triggerPlayer, bj_ALLIANCE_ALLIED_ADVUNITS);
            CommandSystem.Display(triggerPlayer, "Granted control of all players.");
          }
        }
        else
        {
          if (int.TryParse(arguments[0], out var playerId))
          {
            SetPlayerAllianceStateBJ(Player(int.Parse(target)), triggerPlayer, bj_ALLIANCE_ALLIED_ADVUNITS);
            CommandSystem.Display(triggerPlayer, "Granted control of player " + GetPlayerName(Player(playerId)));
          }
        }
      }));
    }
  }
}