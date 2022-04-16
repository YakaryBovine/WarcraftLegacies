using System.Collections.Generic;
using AzerothWarsCSharp.MacroTools.ControlPointSystem;
using AzerothWarsCSharp.MacroTools.QuestSystem;
using AzerothWarsCSharp.MacroTools.QuestSystem.UtilityStructs;
using AzerothWarsCSharp.MacroTools.Wrappers;
using AzerothWarsCSharp.Source.Setup.Legends;
using WCSharp.Shared.Data;
using static AzerothWarsCSharp.MacroTools.Libraries.GeneralHelpers;
using static War3Api.Common;

namespace AzerothWarsCSharp.Source.Quests.Twilight
{
  public sealed class QuestGrimBatol : QuestData
  {
    private readonly unit _grimBatol;
    private readonly List<unit> _rescueUnits = new();
    private readonly unit _waygateA;
    private readonly unit _waygateB;

    public QuestGrimBatol(Rectangle rescueRect, unit grimBatol, unit waygateA, unit waygateB) : base(
      "The Cursed Fortress",
      "The mountain fortress of Grim Batol will be the perfect stronghold for the Twilight hammer clan. It has served well in the past and will do so again.",
      "ReplaceableTextures\\CommandButtons\\BTNFortressWC2blp")
    {
      _grimBatol = grimBatol;
      _waygateA = waygateA;
      _waygateB = waygateB;
      AddQuestItem(new QuestItemLegendDead(LegendNeutral.LegendVaelastrasz));
      AddQuestItem(new QuestItemControlPoint(ControlPointManager.GetFromUnitType(FourCC("n03X"))));
      AddQuestItem(new QuestItemControlPoint(ControlPointManager.GetFromUnitType(FourCC("n04V"))));
      AddQuestItem(new QuestItemControlPoint(ControlPointManager.GetFromUnitType(FourCC("n09F"))));
      AddQuestItem(new QuestItemControlPoint(ControlPointManager.GetFromUnitType(FourCC("n08T"))));
      AddQuestItem(new QuestItemExpire(1428));
      AddQuestItem(new QuestItemSelfExists());
      ResearchId = Constants.UPGRADE_R06Y_QUEST_COMPLETED_THE_CURSED_FORTRESS;

      foreach (var unit in new GroupWrapper().EnumUnitsInRect(rescueRect).EmptyToList())
        if (GetOwningPlayer(unit) == Player(PLAYER_NEUTRAL_PASSIVE))
        {
          SetUnitInvulnerable(unit, true);
          _rescueUnits.Add(unit);
        }
    }

    //Todo: bad flavour
    protected override string CompletionPopup =>
      "Grim Batol is now under our control, and its military is now free to assist the " + Holder.Team.Name + ".";

    protected override string RewardDescription =>
      "Control of all units in Grim Batol and able to train Orcish Death Knights";

    protected override void OnFail()
    {
      foreach (var unit in _rescueUnits) UnitRescue(unit, Player(PLAYER_NEUTRAL_AGGRESSIVE));
    }

    protected override void OnComplete()
    {
      SetUnitOwner(_grimBatol, Holder.Player, true);
      WaygateActivate(_waygateA, true);
      WaygateActivate(_waygateB, true);
      foreach (var unit in _rescueUnits) UnitRescue(unit, Holder.Player);
    }
  }
}