﻿using MacroTools;
using WarcraftLegacies.Source.Quests.Naga;
using WarcraftLegacies.Source.Setup.FactionSetup;
using WCSharp.Shared.Data;

namespace WarcraftLegacies.Source.Setup.QuestSetup
{
  public static class NagaQuestSetup
  {
    public static void Setup()
    {
      var naga = IllidanSetup.Illidan;
      {
        // //Early duel
        //
        naga.AddQuest(new QuestAetheneumTomb(Regions.AethneumCatacombs));

      }

    }
  }
}