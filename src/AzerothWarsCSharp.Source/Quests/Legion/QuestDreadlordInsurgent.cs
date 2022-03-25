using AzerothWarsCSharp.MacroTools.FactionSystem;
using AzerothWarsCSharp.MacroTools.QuestSystem;
using AzerothWarsCSharp.MacroTools.QuestSystem.UtilityStructs;
using AzerothWarsCSharp.Source.Legends;
using AzerothWarsCSharp.Source.Setup;
using AzerothWarsCSharp.Source.Setup.FactionSetup;

namespace AzerothWarsCSharp.Source.Quests.Legion
{
  public sealed class QuestDreadlordInsurgent : QuestData
  {
    public QuestDreadlordInsurgent() : base("Dreadlord Insurgent",
      "Varimathras has branched out and tried to take control of the Plaguelands, Sylvanas will try and make him join her cause.",
      "ReplaceableTextures\\CommandButtons\\BTNHeroDreadLord.blp")
    {
      AddQuestItem(new QuestItemResearch(FourCC("R08H"), FourCC("n040")));
    }


    protected override string CompletionPopup =>
      "The Dreadlord has quickly fallen to Sylvanas && forced to join the Forsaken ";

    protected override string CompletionDescription =>
      "You lose everything, but will spawn with a small army, Varimathras && Lilian Voss near Capital City";

    protected override void OnComplete()
    {
      LegionSetup.FACTION_LEGION.ModObjectLimit(FourCC("Utic"), -Faction.UNLIMITED); //Tichondrius
      LegionSetup.FACTION_LEGION.ModObjectLimit(FourCC("Umal"), -Faction.UNLIMITED); //maglanis
      LegionSetup.FACTION_LEGION.ModObjectLimit(FourCC("U00L"), -Faction.UNLIMITED); //Anatheron

      LegionSetup.FACTION_LEGION.ModObjectLimit(FourCC("E01O"), 1); //Lilian
      LegionSetup.FACTION_LEGION.ModObjectLimit(FourCC("Uvar"), 1); //Vari

      Holder.Team = TeamSetup.TeamForsaken;
      Holder.Name = "|cff8080ffInsurgents|r";
      Holder.Icon = "ReplaceableTextures\\CommandButtons\\BTNHeroDreadLord.blp";
      SetPlayerColor(Holder.Player, PLAYER_COLOR_LIGHT_BLUE);

      LegendForsaken.LEGEND_VARIMATHRAS.StartingXp = GetHeroXP(LegendLegion.LEGEND_TICHONDRIUS.Unit);
      LegendLegion.LEGEND_LILIAN.StartingXp = GetHeroXP(LegendLegion.LEGEND_MALGANIS.Unit);
      Holder.Obliterate();
      LegendLegion.LEGEND_LILIAN.Spawn(Holder.Player, 7254, 7833, 110);
      LegendForsaken.LEGEND_VARIMATHRAS.Spawn(Holder.Player, 7254, 7833, 110);
      CreateUnits(Holder.Player, FourCC("n04J"), Regions.Vandermar_Village.Center.X,
        Regions.Vandermar_Village.Center.Y, 270, 12);
      CreateUnits(Holder.Player, FourCC("u00D"), Regions.Vandermar_Village.Center.X,
        Regions.Vandermar_Village.Center.Y, 270, 6);
      CreateUnits(Holder.Player, FourCC("ninc"), Regions.Vandermar_Village.Center.X,
        Regions.Vandermar_Village.Center.Y, 270, 12);
      CreateUnits(Holder.Player, FourCC("u007"), Regions.Vandermar_Village.Center.X,
        Regions.Vandermar_Village.Center.Y, 270, 2);
      AdjustPlayerStateBJ(2000, Holder.Player, PLAYER_STATE_RESOURCE_GOLD);
      AdjustPlayerStateBJ(900, Holder.Player, PLAYER_STATE_RESOURCE_LUMBER);
      if (GetLocalPlayer() == Holder.Player)
        SetCameraPosition(Regions.Vandermar_Village.Center.X,
          Regions.Vandermar_Village.Center.Y);
    }
  }
}