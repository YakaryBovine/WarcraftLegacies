using System;
using System.Collections.Generic;
using System.Linq;
using War3Api.Object.Abilities;
using War3Api.Object.Enums;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class SpellShield : Ability
    {
        public SpellShield(): base(1936936513)
        {
        }

        public SpellShield(int newId): base(1936936513, newId)
        {
        }

        public SpellShield(string newRawcode): base(1936936513, newRawcode)
        {
        }

        public SpellShield(ObjectDatabase db): base(1936936513, db)
        {
        }

        public SpellShield(int newId, ObjectDatabase db): base(1936936513, newId, db)
        {
        }

        public SpellShield(string newRawcode, ObjectDatabase db): base(1936936513, newRawcode, db)
        {
        }
    }
}