﻿using System;
using MacroTools.Buffs;
using MacroTools.Extensions;
using MacroTools.FactionSystem;
using MacroTools.PassiveAbilitySystem;
using MacroTools.Powers;
using WCSharp.Buffs;
using static War3Api.Common;

namespace WarcraftLegacies.Source.Mechanics.Goblins
{
   /// <summary>
   /// Oil producers use oil instead of mana. The oil is provided by the owner's <see cref="OilPower"/> if they have one.
   /// They also periodically add oil to the power.
   /// </summary>
   public sealed class OilProducer : PassiveAbility
   {
      private readonly float _income;

      public OilProducer(int unitTypeId, float income) : base(unitTypeId)
      {
         _income = income;
      }

      public override void OnCreated(unit createdUnit)
      {
         var owningFaction = createdUnit.OwningPlayer().GetFaction();
         var oilPower = owningFaction?.GetPowerByType<OilPower>();
         if (oilPower == null)
         {
            throw new Exception(
               $"Oil user {GetUnitName(GetTriggerUnit())} was created but owning faction {owningFaction?.Name} doesn't have a power that stores oil.");
         }

         var oilBuff = new OilProducerBuff(createdUnit, _income, oilPower);
         BuffSystem.Add(oilBuff);
      }
   }
}