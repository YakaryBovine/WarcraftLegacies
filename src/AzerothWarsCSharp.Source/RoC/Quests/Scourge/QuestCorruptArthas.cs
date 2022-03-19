using AzerothWarsCSharp.Source.Main.Libraries.QuestSystem.UtilityStructs;

namespace AzerothWarsCSharp.Source.RoC.Quests.Scourge
{
  public class QuestCorruptArthas{

  
    private const int HERO_ID = FourCC(Uear);
    private const int RESEARCH_ID = FourCC(R01K);
  


    protected override string CompletionPopup => 
      return "Having failed to protect his people, Arthas seizes the cursed runeblade Frostmourne as the instrument of his vengeance. The malevolence of the blade overwhelms him. Arthas is now a loyal Death Knight of the Scourge, && will soon become its greatest champion.";
    }

    protected override string CompletionDescription => 
      return "You can train Arthas Menethil from the Altar of Darkness";
    }

    protected override void OnComplete(){
      UnitDropAllItems(LEGEND_ARTHAS.Unit);
      RemoveUnit(LEGEND_ARTHAS.Unit);
      LEGEND_ARTHAS.Unit = null;
      LEGEND_ARTHAS.PlayerColor = PLAYER_COLOR_PURPLE;
      LEGEND_ARTHAS.StartingXp = 7000;
      LEGEND_ARTHAS.UnitType = FourCC(Uear);
      LEGEND_ARTHAS.ClearUnitDependencies();
      SetPlayerTechResearched(this.Holder.Player, RESEARCH_ID, 1);
    }

    private void OnAdd( ){
      Holder.ModObjectLimit(RESEARCH_ID, UNLIMITED);
      Holder.ModObjectLimit(HERO_ID, 1);
    }

    public  thistype ( ){
      thistype this = thistype.allocate("The Culling", "When the city of Stratholme, Prince Arthas will abandon his people && join the Scourge as their champion.", "ReplaceableTextures\\CommandButtons\\BTNHeroDeathKnight.blp");
      this.AddQuestItem(QuestItemLegendDead.create(LEGEND_STRATHOLME));
      this.AddQuestItem(QuestItemEitherOf.create(QuestItemLegendDead.create(LEGEND_ARTHAS), QuestItemFactionDefeated.create(FACTION_LORDAERON)));
      this.AddQuestItem(QuestItemSelfExists.create());
      ;;
    }


  }
}
