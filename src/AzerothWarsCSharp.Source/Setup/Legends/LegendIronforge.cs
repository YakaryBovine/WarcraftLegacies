using AzerothWarsCSharp.MacroTools;
using AzerothWarsCSharp.MacroTools.FactionSystem;
using WCSharp.Shared.Data;

namespace AzerothWarsCSharp.Source.Setup.Legends
{
  public static class LegendIronforge
  {
    public static Legend LegendDagran { get; private set; }
    public static Legend LegendFalstad { get; private set; }
    public static Legend LegendMagni { get; private set; }
    public static Legend LegendGreatforge { get; private set; }
    public static Legend LegendThelsamar { get; private set; }

    public static void Setup()
    {
      LegendDagran = new Legend
      {
        UnitType = FourCC("H03G"),
        StartingXp = 1000
      };
      Legend.Register(LegendDagran);

      LegendFalstad = new Legend
      {
        UnitType = FourCC("H028"),
        StartingXp = 1000
      };
      Legend.Register(LegendFalstad);

      LegendMagni = new Legend
      {
        UnitType = FourCC("H00S"),
        DeathMessage = "King Magni Bronzebeard has died.", //Todo: bad flavour
        StartingXp = 1000
      };
      LegendMagni.AddUnitDependency(PreplacedUnitSystem.GetUnit(FourCC("h001")));
      Legend.Register(LegendMagni);

      LegendGreatforge = new Legend
      {
        Unit = PreplacedUnitSystem.GetUnit(FourCC("h001")),
        DeathMessage = "The Great Forge has been extinguished." //Todo: mediocre flavour
      };
      Legend.Register(LegendGreatforge);
      LegendGreatforge.AddProtector(PreplacedUnitSystem.GetUnit(Constants.UNIT_H07K_IMPROVED_CANNON_TOWER_IRONFORGE, new Point(10509, -5976)));
      LegendGreatforge.AddProtector(PreplacedUnitSystem.GetUnit(Constants.UNIT_H07K_IMPROVED_CANNON_TOWER_IRONFORGE, new Point(10710, -5974)));

      LegendThelsamar = new Legend
      {
        Unit = PreplacedUnitSystem.GetUnit(FourCC("h05H"))
      };
      Legend.Register(LegendThelsamar);
    }
  }
}