using System.Collections.Generic;
using MacroTools.Extensions;
using MacroTools.FactionSystem;
using MacroTools.LegendSystem;
using MacroTools.ObjectiveSystem.Objectives.LegendBased;
using MacroTools.QuestSystem;

namespace WarcraftLegacies.Source.Quests.Legion
{
  public sealed class QuestLegionKillLordaeron : QuestData
  {
    private readonly LegendaryHero _tichondrius;

    public QuestLegionKillLordaeron(IEnumerable<Capital> capitalTargets, LegendaryHero tichondrius) : base("Token Resistance",
      "The Kingdom of Lordaeron must be eliminated to pave the way for the Legion's arrival.",
      "ReplaceableTextures\\CommandButtons\\BTNTichondrius.blp")
    {
      _tichondrius = tichondrius;
      foreach (var capital in capitalTargets)
        AddObjective(new ObjectiveCapitalDead(capital));
    }

    /// <inheritdoc/>
    protected override string RewardFlavour =>
      "The Kingdom of Lordaeron has fallen, eliminating Azeroth's vanguard against the Legion.";

    /// <inheritdoc/>
    protected override string RewardDescription => "Tichondrius gains 15 Strength, Agility and Intelligence";

    /// <inheritdoc/>
    protected override void OnComplete(Faction completingFaction)
    {
      _tichondrius.Unit?.DisplayHeroReward(15, 15, 15, 0);
      _tichondrius.Unit?.AddHeroAttributes(15, 15, 15);
    }
  }
}