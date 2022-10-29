﻿using AzerothWarsCSharp.MacroTools;

namespace AzerothWarsCSharp.Source.Setup
{
  public static class TurnResearchSetup
  {
    public static void Setup()
    {
      TurnResearch.Register(new TurnResearch(Constants.UPGRADE_R08I_TURN_22_HAS_PASSED, 22));
      TurnResearch.Register(new TurnResearch(Constants.UPGRADE_R067_TURN_6_HAS_PASSED, 6));
      TurnResearch.Register(new TurnResearch(Constants.UPGRADE_R04J_TURN_18_HAS_PASSED, 18));
      TurnResearch.Register(new TurnResearch(Constants.UPGRADE_R04N_TURN_3_HAS_PASSED, 3));
      TurnResearch.Register(new TurnResearch(Constants.UPGRADE_R08C_TURN_10_HAS_PASSED, 10));
    }
  }
}