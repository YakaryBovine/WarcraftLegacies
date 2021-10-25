using System;
using System.Collections.Generic;
using System.Linq;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class PassiveOrcTrollRegenerationRotr : Ability
    {
        public PassiveOrcTrollRegenerationRotr(): base(1920233281)
        {
        }

        public PassiveOrcTrollRegenerationRotr(int newId): base(1920233281, newId)
        {
        }

        public PassiveOrcTrollRegenerationRotr(string newRawcode): base(1920233281, newRawcode)
        {
        }

        public PassiveOrcTrollRegenerationRotr(ObjectDatabase db): base(1920233281, db)
        {
        }

        public PassiveOrcTrollRegenerationRotr(int newId, ObjectDatabase db): base(1920233281, newId, db)
        {
        }

        public PassiveOrcTrollRegenerationRotr(string newRawcode, ObjectDatabase db): base(1920233281, newRawcode, db)
        {
        }
    }
}