

namespace AzerothWarsCSharp.Source.Main.Cheats
{
  public class CheatMana{

    //**CONFIG
    
    private const string COMMAND     = "-mana ";
    private boolean[] Toggle;
    
    //*ENDCONFIG

    private static void Spell( ){
      if (Toggle[GetPlayerId(GetTriggerPlayer())]){
        SetUnitManaPercentBJ(GetTriggerUnit(), 100);
      }
    }

    private static void Actions( ){
      if (!TestSafety.CheatCondition())
      {
        return;
      }
      var i = 0;
      string enteredString = GetEventPlayerChatString();
      player p = GetTriggerPlayer();
      var pId = GetPlayerId(p);
      string parameter = SubString(enteredString, StringLength(COMMAND), StringLength(enteredString));

      if (parameter == "on"){
        Toggle[pId] = true;
        DisplayTextToPlayer(p, 0, 0, "|cffD27575CHEAT:|r Infinite mana activated.");
      }else if (parameter == "off"){
        Toggle[pId] = false;
        DisplayTextToPlayer(p, 0, 0, "|cffD27575CHEAT:|r Infinite mana deactivated.");
      }
    }

    public static void Setup( ){
      trigger trig = CreateTrigger();
      foreach (var player in GetAllPlayers())
      {
        TriggerRegisterPlayerChatEvent(trig, player, COMMAND, false);
      }
      TriggerAddAction(trig, Actions);

      PlayerUnitEventAddAction(EVENT_PLAYER_UNIT_SPELL_ENDCAST,  Spell);
    }

  }
}
