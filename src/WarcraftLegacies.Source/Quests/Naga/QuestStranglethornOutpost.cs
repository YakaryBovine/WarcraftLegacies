﻿using System.Collections.Generic;
using MacroTools.Extensions;
using MacroTools.FactionSystem;
using MacroTools.ObjectiveSystem.Objectives.FactionBased;
using MacroTools.ObjectiveSystem.Objectives.LegendBased;
using MacroTools.ObjectiveSystem.Objectives.TimeBased;
using MacroTools.QuestSystem;
using WarcraftLegacies.Source.Setup.Legends;
using WCSharp.Shared.Data;
using static War3Api.Common;

namespace WarcraftLegacies.Source.Quests.Naga
{
  /// <summary>
  /// </summary>
  public sealed class QuestStranglethornOutpost : QuestData
  {
    private readonly List<unit> _rescueUnits;

    /// <summary>
    /// Initializes a new instance of the <see cref="QuestStranglethornOutpost"/> class.
    /// </summary>
    /// <param name="rescueRect"></param>
    public QuestStranglethornOutpost(Rectangle rescueRect) : base("The Cape of Stranglethorn",
      $"The Ruins in the Cape of Stranglethorn are an old Naga outpost, they could serve Illidan well",
      "ReplaceableTextures\\CommandButtons\\BTNIllidariSpawningGrounds.blp")
    {
      AddObjective(new ObjectiveLegendInRect(LegendNaga.LegendVashj, rescueRect, "the Cape of Stranglethorn"));
      AddObjective(new ObjectiveExpire(1250));
      AddObjective(new ObjectiveSelfExists());
      _rescueUnits = rescueRect.PrepareUnitsForRescue(RescuePreparationMode.HideAll);
      Required = true;
    }

    /// <inheritdoc />
    protected override string RewardFlavour => "The outpost in Stranglethorn is now built";

    /// <inheritdoc />
    protected override string RewardDescription => $"Gain control of the Stranglethorn Outpost";

    /// <inheritdoc />
    protected override void OnFail(Faction completingFaction)
    {
      Player(PLAYER_NEUTRAL_AGGRESSIVE).RescueGroup(_rescueUnits);
    }

    /// <inheritdoc />
    protected override void OnComplete(Faction completingFaction)
    {
      completingFaction.Player.RescueGroup(_rescueUnits);
    }
  }
}