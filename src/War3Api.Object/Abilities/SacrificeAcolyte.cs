using System;
using System.Collections.Generic;
using System.Linq;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class SacrificeAcolyte : Ability
    {
        public SacrificeAcolyte(): base(1835101249)
        {
        }

        public SacrificeAcolyte(int newId): base(1835101249, newId)
        {
        }

        public SacrificeAcolyte(string newRawcode): base(1835101249, newRawcode)
        {
        }

        public SacrificeAcolyte(ObjectDatabase db): base(1835101249, db)
        {
        }

        public SacrificeAcolyte(int newId, ObjectDatabase db): base(1835101249, newId, db)
        {
        }

        public SacrificeAcolyte(string newRawcode, ObjectDatabase db): base(1835101249, newRawcode, db)
        {
        }
    }
}