﻿using AzerothWarsCSharp.MacroTools.FactionSystem;
using WCSharp.Buffs;

namespace AzerothWarsCSharp.Source.Buffs
{
  public sealed class CorruptBuildingBuff : PassiveBuff
  {
    private readonly int _bonusIncome;
    private readonly int _bonusHealth;

    public CorruptBuildingBuff(unit caster, unit target, int bonusIncome, int bonusHealth) : base(caster, target)
    {
      _bonusIncome = bonusIncome;
      _bonusHealth = bonusHealth;
      EffectString = @"Units\Undead\PlagueCloud\PlagueCloudtarget.mdl";
      EffectAttachmentPoint = "overhead";
    }
    
    public override void OnApply()
    {
      CastingPlayer.AddBonusIncome(_bonusIncome);
      BlzSetUnitMaxHP(Target, BlzGetUnitMaxHP(Target) + _bonusHealth);
    }

    public override void OnDispose()
    {
      CastingPlayer.AddBonusIncome(-_bonusIncome);
      BlzSetUnitMaxHP(Target, BlzGetUnitMaxHP(Target) - _bonusHealth);
    }
  }
}