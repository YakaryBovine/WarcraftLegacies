using AzerothWarsCSharp.MacroTools;
using AzerothWarsCSharp.Source.Libraries;

namespace AzerothWarsCSharp.Source.UnitTypes
{
  public class UnitTypesNeutral{

    public static void Setup( ){
      UnitType unitType = 0;

      unitType = UnitType.create(FourCC(h059))      ;//Gilneas City Building
      unitType.UnitCategory = UNITCATEGORY_FARM;

      unitType = UnitType.create(FourCC(h00I))      ;//Windmill
      unitType.UnitCategory = UNITCATEGORY_FARM;
    }

  }
}
