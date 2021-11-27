library CheatRemove initializer OnInit requires TestSafety

  globals
    private constant string COMMAND     = "-remove"
    private string parameter = null
  endglobals

  private function Remove takes nothing returns nothing
    call RemoveUnit(GetEnumUnit())
  endfunction

  private function Actions takes nothing returns nothing
    local integer i = 0
    local string enteredString = GetEventPlayerChatString()
    local player p = GetTriggerPlayer()
    local integer pId = GetPlayerId(p)

    call ForGroupBJ( GetUnitsSelectedAll(p), function Remove )
    call DisplayTextToPlayer(p, 0, 0, "|cffD27575CHEAT:|r Permanently removing selected units.")   
  endfunction

  private function OnInit takes nothing returns nothing
    local trigger trig = CreateTrigger(  )
    local integer i = 0
    loop
    exitwhen i > MAX_PLAYERS
      call TriggerRegisterPlayerChatEvent( trig, Player(i), COMMAND, false )
      set i = i + 1
    endloop   
    call TriggerAddCondition(trig, Condition(function CheatCondition))
    call TriggerAddAction( trig, function Actions )
  endfunction

endlibrary