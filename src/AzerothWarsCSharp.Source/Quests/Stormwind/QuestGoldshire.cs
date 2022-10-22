using System.Collections.Generic;
using AzerothWarsCSharp.MacroTools;
using AzerothWarsCSharp.MacroTools.ControlPointSystem;
using AzerothWarsCSharp.MacroTools.FactionSystem;
using AzerothWarsCSharp.MacroTools.QuestSystem;
using AzerothWarsCSharp.MacroTools.QuestSystem.UtilityStructs;
using AzerothWarsCSharp.MacroTools.Wrappers;
using WCSharp.Shared.Data;

namespace AzerothWarsCSharp.Source.Quests.Stormwind
{
  public sealed class QuestGoldshire : QuestData
  {
    private readonly List<unit> _rescueUnits = new();

    public QuestGoldshire(Rectangle rescueRect, unit hogger) : base("The Scourge of Elwynn",
      "Hogger and his pack have taken over Goldshire, clear them out!",
      "ReplaceableTextures\\CommandButtons\\BTNGnoll.blp")
    {
      AddObjective(new ObjectiveKillUnit(hogger)); //Hogger
      AddObjective(new ObjectiveControlPoint(ControlPointManager.GetFromUnitType(FourCC("n00Z"))));
      AddObjective(new ObjectiveExpire(1335));
      AddObjective(new ObjectiveSelfExists());
      foreach (var unit in new GroupWrapper().EnumUnitsInRect(rescueRect).EmptyToList())
        if (GetOwningPlayer(unit) == Player(PLAYER_NEUTRAL_PASSIVE))
        {
          SetUnitInvulnerable(unit, true);
          _rescueUnits.Add(unit);
        }
    }

    protected override string CompletionPopup => "The Gnolls have been defeated, Goldshire is safe.";

    protected override string RewardDescription => "Control of all units in Goldshire";

    protected override void OnFail(Faction completingFaction)
    {
      foreach (var unit in _rescueUnits) unit.Rescue(Player(PLAYER_NEUTRAL_AGGRESSIVE));
    }

    protected override void OnComplete(Faction completingFaction)
    {
      foreach (var unit in _rescueUnits) unit.Rescue(completingFaction.Player);
    }
  }
}