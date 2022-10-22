﻿using System.Collections.Generic;
using AzerothWarsCSharp.MacroTools;
using AzerothWarsCSharp.MacroTools.FactionSystem;
using WCSharp.Events;
using WCSharp.Shared.Data;

namespace AzerothWarsCSharp.Source.GameLogic
{
  /// <summary>
  /// Responsible for preventing Shipyards from being constructed in specific areas.
  /// </summary>
  public static class ShipyardBanZones
  {
    /// <summary>
    /// Prevents Shipyards from being constructed in the provided areas.
    /// </summary>
    public static void Setup(IEnumerable<Rectangle> banZones)
    {
      foreach (var unitType in UnitType.GetAll())
      {
        if (unitType.Category == UnitCategory.Shipyard)
        {
          PlayerUnitEvents.Register(PlayerUnitEvent.UnitTypeFinishesConstruction, () =>
          {
            var constructedStructure = GetConstructedStructure();
            foreach (var banZone in banZones)
            {
              if (!banZone.Contains(GetUnitX(constructedStructure), GetUnitY(constructedStructure))) continue;
              GetOwningPlayer(constructedStructure).AddGold(GetUnitGoldCost(GetUnitTypeId(constructedStructure)));
              GetOwningPlayer(constructedStructure).AddLumber(GetUnitWoodCost(GetUnitTypeId(constructedStructure)));
              KillUnit(constructedStructure);
            }
          });
        }
      }
    }
  }
}