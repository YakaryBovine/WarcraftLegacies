using AzerothWarsCSharp.MacroTools;
using AzerothWarsCSharp.MacroTools.FactionSystem;

namespace AzerothWarsCSharp.Source.Legends
{
  public static class LegendIronforge{

  
    public static Legend LEGEND_DAGRAN { get; private set; }
    public static Legend LEGEND_FALSTAD { get; private set; }
    public static Legend LEGEND_MAGNI { get; private set; }
    public static Legend LEGEND_GREATFORGE { get; private set; }
    public static Legend LEGEND_THELSAMAR { get; private set; }
  

    public static void Setup( ){
      LEGEND_DAGRAN = new Legend();
      LEGEND_DAGRAN.UnitType = FourCC("H03G");
      LEGEND_DAGRAN.StartingXp = 1000;

      LEGEND_FALSTAD = new Legend();
      LEGEND_FALSTAD.UnitType = FourCC("H028");
      LEGEND_FALSTAD.StartingXp = 1000;

      LEGEND_MAGNI = new Legend();
      LEGEND_MAGNI.UnitType = FourCC("H00S");
      LEGEND_MAGNI.AddUnitDependency(PreplacedUnitSystem.GetUnitByUnitType(FourCC("h001")));
      LEGEND_MAGNI.DeathMessage = "King Magni Bronzebeard has died.";
      LEGEND_MAGNI.Essential = true;
      LEGEND_MAGNI.StartingXp = 1000;

      LEGEND_GREATFORGE = new Legend();
      LEGEND_GREATFORGE.Unit = PreplacedUnitSystem.GetUnitByUnitType(FourCC("h001"));
      LEGEND_GREATFORGE.DeathMessage = "The Great Forge has been extinguished.";
      LEGEND_GREATFORGE.IsCapital = true;

      LEGEND_THELSAMAR = new Legend();
      LEGEND_THELSAMAR.Unit = PreplacedUnitSystem.GetUnitByUnitType(FourCC("h05H"));
    }

  }
}
