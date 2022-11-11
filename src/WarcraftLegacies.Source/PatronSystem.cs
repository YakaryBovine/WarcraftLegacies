﻿using System;
using MacroTools;
using WCSharp.Shared.Data;
using static War3Api.Common;

namespace WarcraftLegacies.Source
{
  /// <summary>
  /// Responsible for renaming units on the map to their appropriate Patreon Patron.
  /// </summary>
  public static class PatronSystem
  {
    private static int TierToUnitType(PatronTier tier)
    {
      if (tier == PatronTier.One)
        return Constants.UNIT_NHMC_PATRONS_FOOTMAN_TIER_1_PATRON;
      if (tier == PatronTier.Two)
        return Constants.UNIT_NFRO_PATRONS_KNIGHT_TIER_2_PATRON;
      throw new ArgumentOutOfRangeException(nameof(tier), tier, null);
    }

    private static void SetupPatron(string name, PatronTier tier, Point position)
    {
      var unit = PreplacedUnitSystem.GetUnit(TierToUnitType(tier), position);
      BlzSetUnitName(unit, $"{name} - Tier {(int)tier} Patron");
    }

    /// <summary>
    /// Renames some units on the map to be named after Patreon Patrons.
    /// </summary>
    public static void Setup()
    {
      SetupPatron("bredbrodak", PatronTier.Two, Regions.Quelthalas.Center);
      SetupPatron("Dromoka", PatronTier.Two, Regions.AlteracAmbient.Center);
      SetupPatron("Bocelot", PatronTier.Two, Regions.TyrsFall.Center);
      SetupPatron("Eagleman", PatronTier.Two, Regions.Stromgarde.Center);
    }
  }
}