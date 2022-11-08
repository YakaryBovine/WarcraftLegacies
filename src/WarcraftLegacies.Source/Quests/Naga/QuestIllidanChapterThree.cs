using System.Collections.Generic;
using MacroTools.Extensions;
using MacroTools.FactionSystem;
using MacroTools.QuestSystem;
using MacroTools.QuestSystem.UtilityStructs;
using MacroTools.Wrappers;
using WarcraftLegacies.Source.Setup.FactionSetup;
using WarcraftLegacies.Source.Setup.Legends;
using WarcraftLegacies.Source.Setup.QuestSetup;
using WCSharp.Shared.Data;
using static War3Api.Common;

namespace WarcraftLegacies.Source.Quests.Naga
{
  public sealed class QuestIllidanChapterThree : QuestData
  {
    private static readonly int RitualId = FourCC("A0KY");
    private readonly List<unit> _rescueUnits = new();
    private readonly unit _unitToMakeInvulnerable;

    public QuestIllidanChapterThree(Rectangle rescueRect, unit unitToMakeInvulnerable) : base(
      "Chapter Three: Dwellers from the Deep",
      "Awakening the Naga will give Illidan the army he needs to achieve his goals.",
      "ReplaceableTextures\\CommandButtons\\BTNNagaMyrmidon.blp")
    {
      _unitToMakeInvulnerable = unitToMakeInvulnerable;
      //AddObjective(new ObjectiveLegendReachRect(LegendNaga.LegendIllidan, Regions.StartQuest3, "the exit")); Todo: ask Sebas what this was doing
      AddObjective(new ObjectiveLegendReachRect(LegendNaga.LegendIllidan, Regions.MaelstromAmbient, "the Maelstrom"));
      AddObjective(new ObjectiveCastSpell(RitualId, true));

      foreach (var unit in new GroupWrapper().EnumUnitsInRect(rescueRect).EmptyToList())
        if (GetOwningPlayer(unit) == Player(PLAYER_NEUTRAL_PASSIVE))
        {
          SetUnitInvulnerable(unit, true);
          _rescueUnits.Add(unit);
        }
    }

    protected override string CompletionPopup => "Illidan must awaken the Naga from the depth of the ocean";

    protected override string RewardDescription => "Nazjatar and the Naga's loyalty";

    protected override void OnComplete(Faction completingFaction)
    {
      foreach (var unit in _rescueUnits) unit.Rescue(completingFaction.Player);
      foreach (var unit in _rescueUnits) unit.Rescue(completingFaction.Player);
      IllidariSetup.Illidari.AddQuest(NagaQuestSetup.REDEMPTION_PATH);
      NagaQuestSetup.REDEMPTION_PATH.Progress = QuestProgress.Undiscovered;
      IllidariSetup.Illidari.AddQuest(NagaQuestSetup.EXILE_PATH);
      NagaQuestSetup.EXILE_PATH.Progress = QuestProgress.Undiscovered;
      IllidariSetup.Illidari.AddQuest(NagaQuestSetup.MADNESS_PATH);
      NagaQuestSetup.MADNESS_PATH.Progress = QuestProgress.Undiscovered;
      IllidariSetup.Illidari.AddQuest(NagaQuestSetup.CONQUER_BLACK_TEMPLE);
      NagaQuestSetup.CONQUER_BLACK_TEMPLE.Progress = QuestProgress.Undiscovered;
      IllidariSetup.Illidari.AddQuest(NagaQuestSetup.KILL_FROZEN_THRONE);
      NagaQuestSetup.KILL_FROZEN_THRONE.Progress = QuestProgress.Undiscovered;
      SetUnitInvulnerable(_unitToMakeInvulnerable, true);
    }
  }
}