using AzerothWarsCSharp.MacroTools.FactionSystem;
using AzerothWarsCSharp.MacroTools.QuestSystem;
using AzerothWarsCSharp.MacroTools.QuestSystem.UtilityStructs;
using AzerothWarsCSharp.Source.Setup;
using AzerothWarsCSharp.Source.Setup.FactionSetup;
using AzerothWarsCSharp.Source.Setup.Legends;

namespace AzerothWarsCSharp.Source.Quests.Naga
{
  public sealed class QuestFrozenThrone : QuestData
  {
    public QuestFrozenThrone() : base("A Symphony of Frost and Flame",
      "Kil'jaeden has ordered Illidan to destroy the Frozen Throne, and he shall obey.",
      "ReplaceableTextures\\CommandButtons\\BTNMetamorphosis.blp")
    {
      AddObjective(new ObjectiveKillUnit(LegendScourge.LegendLichking.Unit));
      AddObjective(new ObjectiveResearch(Constants.UPGRADE_R063_PATH_OF_EXILE_NAGA, Constants.UNIT_N055_TEMPLE_OF_TIDES_GREEN_NAGA));
      Global = true;
    }

    protected override string CompletionPopup =>
      "As a reward for his mission, Illidan and his followers have been welcomed into the ranks of the Burning Legion";

    protected override string RewardDescription => "The Illidari team will join the Burning Legion in their team";
    
    protected override void OnComplete(Faction completingFaction)
    {
      if (completingFaction.Player?.GetTeam() == TeamSetup.Naga)
      {
        completingFaction.Player.SetTeam(TeamSetup.Legion);
        UnitAddAbility(LegendQuelthalas.LegendKael.Unit, Constants.ABILITY_A0R7_INSTILL_RAGE_YOGG);
      }

      if (FelHordeSetup.FelHorde.Player?.GetTeam() == TeamSetup.Naga)
        FelHordeSetup.FelHorde.Player?.SetTeam(TeamSetup.Legion);
      IllidariSetup.Illidari.Player?.SetTeam(TeamSetup.Legion);
    }
  }
}