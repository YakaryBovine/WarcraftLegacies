using AzerothWarsCSharp.MacroTools.FactionSystem;
using AzerothWarsCSharp.Source.Game_Logic;
using static War3Api.Common;
using static AzerothWarsCSharp.MacroTools.Libraries.GeneralHelpers;

namespace AzerothWarsCSharp.Source.Commands
{
  /// <summary>
  ///   Invites the specified <see cref="Faction" />'s <see cref="player" /> to the sender's <see cref="Team" />.
  /// </summary>
  public static class InviteCommand
  {
    private const string COMMAND = "-invite ";

    private static void Actions()
    {
      string enteredString = GetEventPlayerChatString();
      var triggerPlayer = GetTriggerPlayer();

      if (OpenAllianceVote.AreAlliancesOpen)
      {
        if (SubString(enteredString, 0, StringLength(COMMAND)) == COMMAND)
        {
          string content = SubString(enteredString, StringLength(COMMAND), StringLength(enteredString));
          content = StringCase(content, false);

          if (!FactionManager.FactionWithNameExists(content))
          {
            DisplayTextToPlayer(triggerPlayer, 0, 0, $"There is no Faction with the name {content}.");
            return;
          }

          var targetFaction = FactionManager.GetFromName(content);

          if (triggerPlayer.GetFaction() == targetFaction)
          {
            DisplayTextToPlayer(triggerPlayer, 0, 0, "You can'invite yourself to your own team.");
            return;
          }

          if (targetFaction.Player == null)
          {
            DisplayTextToPlayer(triggerPlayer, 0, 0,
              $"There is no player with the Faction {targetFaction.PrefixCol} {targetFaction.Name}|r.");
            return;
          }

          if (targetFaction.Player != null) triggerPlayer.GetFaction()?.Team?.Invite(targetFaction);
        }
      }
      else
      {
        DisplayTextToPlayer(triggerPlayer, 0, 0, "You can!ally yet");
      }
    }

    public static void Setup()
    {
      trigger trig = CreateTrigger();
      foreach (var player in GetAllPlayers()) TriggerRegisterPlayerChatEvent(trig, player, COMMAND, false);
      TriggerAddAction(trig, Actions);
    }
  }
}