﻿using AzerothWarsCSharp.MacroTools.Spells;
using AzerothWarsCSharp.MacroTools.SpellSystem;

namespace AzerothWarsCSharp.Source.Setup.Spells
{
  public static class DruidsSpellSetup
  {
    public static void Setup()
    {
      SpellSystem.Register(new RegrowTrees(Constants.ABILITY_A01A_REGROW_TREES_BROWN_NORDRASSIL)
      {
        Radius = 8500
      });
      
      SpellSystem.Register(new RegrowTrees(Constants.ABILITY_A0G8_SACRED_GROUND_BROWN_MAIN_BUILDINGS)
      {
        Radius = 1500
      });
      
      SpellSystem.Register(new RegrowTrees(Constants.ABILITY_A04C_SEED_GROWTH)
      {
        Radius = 600
      });
    }
  }
}