using AzerothWarsCSharp.MacroTools.QuestSystem;
using AzerothWarsCSharp.MacroTools.QuestSystem.UtilityStructs;

namespace AzerothWarsCSharp.Source.Quests.Twilight
{
  public sealed class QuestCataclysm : QuestData
  {
    private static readonly int CataclysmResearch = FourCC("R05E");

    private Global()
    {
      return true;
    }

    public QuestCataclysm()
    {
      thistype this = thistype.allocate("The Cataclysm", "The Old GodFourCC("s will is finnicky,
        you are !privy to when their plan will be in motion, but when it is,
        your cult will be ready to welcome it.", "ReplaceableTextures\\CommandButtons\\BTNDeathwing.blp");
      AddQuestItem(new QuestItemControlLegend(LEGEND_DEATHWING, false));
    }

    protected override string CompletionPopup => "Deathwing is here, Doomsday is at hand, the Cataclysm as begun!";

    protected override string CompletionDescription =>
      "Cultists all over the world join your cause actively, Deathwing as a super demihero && the 2 elemental ascendant heroes.";


    bool operator

    protected override void OnComplete()
    {
      SetPlayerTechResearched(Holder.Player, CataclysmResearch, 1);
      PlayThematicMusicBJ("war3mapImported\\TwilightTheme.mp3");
      SetPlayerTechResearched(FACTION_CTHUN.Player, FourCC("R07D"), 1);
      IssueImmediateOrderBJ(gg_unit_h02U_2413, "unrobogoblin");
    }

    protected override void OnAdd()
    {
      Holder.ModObjectLimit(CataclysmResearch, UNLIMITED);
    }
  }
}