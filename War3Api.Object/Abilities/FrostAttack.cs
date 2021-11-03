using System;
using System.Collections.Generic;
using System.Linq;
using War3Api.Object.Abilities;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class FrostAttack : Ability
    {
        public FrostAttack(): base(1634887233)
        {
        }

        public FrostAttack(int newId): base(1634887233, newId)
        {
        }

        public FrostAttack(string newRawcode): base(1634887233, newRawcode)
        {
        }

        public FrostAttack(ObjectDatabase db): base(1634887233, db)
        {
        }

        public FrostAttack(int newId, ObjectDatabase db): base(1634887233, newId, db)
        {
        }

        public FrostAttack(string newRawcode, ObjectDatabase db): base(1634887233, newRawcode, db)
        {
        }
    }
}