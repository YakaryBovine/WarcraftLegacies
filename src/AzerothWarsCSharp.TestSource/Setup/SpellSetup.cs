﻿using AzerothWarsCSharp.MacroTools.Spells;
using AzerothWarsCSharp.MacroTools.SpellSystem;
using static War3Api.Common;

namespace AzerothWarsCSharp.TestSource.Setup
{
  public static class SpellSetup
  {
    public static void Setup()
    {
      var summonGraniteGolems = new SummonUnits(FourCC("AHbn"))
      {
        SummonUnitTypeId = FourCC("nggr"),
        SummonCount = 4,
        Duration = 60,
        Radius = 400,
        AngleOffset = 45,
        Effect = @"war3mapImported\Earth NovaTarget.mdx"
      };
      SpellSystem.Register(summonGraniteGolems);

      var massSimulacrum = new MassSimulacrum(FourCC("AHfs"))
      {
        Radius = 150,
        CountBase = 2,
        CountLevel = 4,
        Duration = 60,
        Effect = @"war3mapImported\Soul Discharge Blue.mdx",
        EffectScale = 1.1f,
        EffectTarget = @"Abilities\Spells\Items\AIil\AIilTarget.mdl",
        EffectScaleTarget = 1.0f,
        HealthBonusBase = -0.5f,
        HealthBonusLevel = 0.2f,
        DamageBonusBase = -0.5f,
        DamageBonusLevel = 0.2f,
      };
      SpellSystem.Register(massSimulacrum);
      
      var executeFootman = new Execute(FourCC("hfoo"));
      SpellSystem.Register(executeFootman);

      var animalCompanion = new AnimalCompanion(FourCC("hfoo"), FourCC("nqb1"))
      {
        Duration = 12
      };
      SpellSystem.Register(animalCompanion);
    }
  }
}