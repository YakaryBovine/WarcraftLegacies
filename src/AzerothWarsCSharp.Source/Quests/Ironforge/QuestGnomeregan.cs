using System.Collections.Generic;
using AzerothWarsCSharp.MacroTools;
using AzerothWarsCSharp.MacroTools.QuestSystem;
using AzerothWarsCSharp.MacroTools.QuestSystem.UtilityStructs;
using AzerothWarsCSharp.MacroTools.Wrappers;
using WCSharp.Shared.Data;
using static War3Api.Common;
using static AzerothWarsCSharp.MacroTools.Libraries.GeneralHelpers;

namespace AzerothWarsCSharp.Source.Quests.Ironforge
{
  public sealed class QuestGnomeregan : QuestData
  {
    private static readonly int QuestResearchId = FourCC("R05Q");
    private readonly List<unit> _rescueUnits = new();

    public QuestGnomeregan(Rectangle rescueRect) : base("The City of Invention",
      "The people of Gnomeregan have long been unable to assist the Alliance in its wars due an infestation of troggs and Ice Trolls. Resolve their conflicts for them to gain their services.",
      "ReplaceableTextures\\CommandButtons\\BTNFlyingMachine.blp")
    {
      AddQuestItem(new QuestItemKillUnit(PreplacedUnitSystem.GetUnit(FourCC("nitw")))); //Ice Troll Warlord
      AddQuestItem(new QuestItemSelfExists());
      foreach (var unit in new GroupWrapper().EnumUnitsInRect(rescueRect).EmptyToList())
        if (GetOwningPlayer(unit) == Player(PLAYER_NEUTRAL_PASSIVE))
        {
          SetUnitInvulnerable(unit, true);
          _rescueUnits.Add(unit);
        }
    }

    protected override string CompletionPopup =>
      "Gnomeregan has been literated, and its military is now free to assist the " + Holder.Team.Name + ".";

    protected override string RewardDescription => "Control of all units in Gnomeregan";

    protected override void OnFail()
    {
      foreach (var unit in _rescueUnits) UnitRescue(unit, Player(PLAYER_NEUTRAL_AGGRESSIVE));
    }

    protected override void OnComplete()
    {
      SetPlayerTechResearched(Holder.Player, FourCC("R05Q"), 1);
      foreach (var unit in _rescueUnits) UnitRescue(unit, Holder.Player);
    }

    protected override void OnAdd()
    {
      Holder.ModObjectLimit(QuestResearchId, 1);
    }
  }
}