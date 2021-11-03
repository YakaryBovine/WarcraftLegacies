using System;
using System.Collections.Generic;
using System.Linq;
using War3Api.Object.Abilities;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class FrostguardFrostMelee : Ability
    {
        public FrostguardFrostMelee(): base(1952860481)
        {
        }

        public FrostguardFrostMelee(int newId): base(1952860481, newId)
        {
        }

        public FrostguardFrostMelee(string newRawcode): base(1952860481, newRawcode)
        {
        }

        public FrostguardFrostMelee(ObjectDatabase db): base(1952860481, db)
        {
        }

        public FrostguardFrostMelee(int newId, ObjectDatabase db): base(1952860481, newId, db)
        {
        }

        public FrostguardFrostMelee(string newRawcode, ObjectDatabase db): base(1952860481, newRawcode, db)
        {
        }
    }
}