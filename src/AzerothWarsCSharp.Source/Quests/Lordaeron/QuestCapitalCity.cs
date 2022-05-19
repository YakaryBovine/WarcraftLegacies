using System.Collections.Generic;
using AzerothWarsCSharp.MacroTools;
using AzerothWarsCSharp.MacroTools.QuestSystem;
using AzerothWarsCSharp.MacroTools.QuestSystem.UtilityStructs;
using AzerothWarsCSharp.MacroTools.Wrappers;
using AzerothWarsCSharp.Source.Setup.Legends;
using WCSharp.Shared.Data;
using static War3Api.Common;


namespace AzerothWarsCSharp.Source.Quests.Lordaeron
{
  public sealed class QuestCapitalCity : QuestData
  {
    private readonly List<unit> _rescueUnits = new();
    private readonly unit _unitToMakeInvulnerable;

    public QuestCapitalCity(Rectangle rescueRect, unit unitToMakeInvulnerable, IEnumerable<QuestData> prequisites) :
      base("Hearthlands",
        "The territories of Lordaeron are fragmented. Regain control of the old Alliance's hold to secure the kingdom.",
        "ReplaceableTextures\\CommandButtons\\BTNCastle.blp")
    {
      AddQuestItem(new QuestItemControlLegend(LegendNeutral.LegendCaerdarrow, false));
      foreach (var prequisite in prequisites) AddQuestItem(new QuestItemCompleteQuest(prequisite));
      AddQuestItem(new QuestItemExpire(1472));
      AddQuestItem(new QuestItemSelfExists());
      ResearchId = FourCC("R04Y");
      _unitToMakeInvulnerable = unitToMakeInvulnerable;
      foreach (var unit in new GroupWrapper().EnumUnitsInRect(rescueRect.Rect).EmptyToList())
        if (GetOwningPlayer(unit) == Player(PLAYER_NEUTRAL_PASSIVE))
        {
          SetUnitInvulnerable(unit, true);
          _rescueUnits.Add(unit);
        }
    }

    protected override string CompletionPopup =>
      "Capital City has been liberated, and its military is now free to assist the " + Holder.Team.Name + ".";

    protected override string RewardDescription => "Control of all units in Capital City";

    protected override void OnFail()
    {
      foreach (var unit in _rescueUnits) unit.Rescue(Player(PLAYER_NEUTRAL_AGGRESSIVE));
      LegendLordaeron.LegendUther.AddUnitDependency(LegendLordaeron.LegendCapitalpalace.Unit);
    }

    protected override void OnComplete()
    {
      foreach (var unit in _rescueUnits) unit.Rescue(Player(PLAYER_NEUTRAL_AGGRESSIVE));
      SetUnitInvulnerable(_unitToMakeInvulnerable, true);
      if (GetLocalPlayer() == Holder.Player)
        PlayThematicMusic("war3mapImported\\CapitalCity.mp3");
      LegendLordaeron.LegendUther.AddUnitDependency(LegendLordaeron.LegendCapitalpalace.Unit);
    }
  }
}