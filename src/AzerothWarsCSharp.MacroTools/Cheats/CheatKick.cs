using AzerothWarsCSharp.MacroTools.FactionSystem;
using static War3Api.Common;
using static AzerothWarsCSharp.MacroTools.Libraries.GeneralHelpers;

namespace AzerothWarsCSharp.MacroTools.Cheats
{
  public static class CheatKick
  {
    private const string COMMAND = "-kick ";
    private static string? _parameter;

    private static void Actions()
    {
      if (!TestSafety.CheatCondition()) return;

      string enteredString = GetEventPlayerChatString();
      player p = GetTriggerPlayer();
      var kickId = 0;

      _parameter = SubString(enteredString, StringLength(COMMAND), StringLength(enteredString));
      kickId = S2I(_parameter);

      var faction = Person.ByHandle(Player(kickId)).Faction;
      if (faction != null)
        faction.ScoreStatus = ScoreStatus.Defeated;
      DisplayTextToPlayer(p, 0, 0,
        "|cffD27575CHEAT:|r Attempted to kick player " + GetPlayerName(Player(kickId)) + ".");
    }

    public static void Setup()
    {
      trigger trig = CreateTrigger();
      foreach (var player in GetAllPlayers()) TriggerRegisterPlayerChatEvent(trig, player, COMMAND, false);

      TriggerAddAction(trig, Actions);
    }
  }
}