using System;
using System.Collections.Generic;
using System.Linq;
using War3Api.Object.Abilities;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class HowlOfTerror : Ability
    {
        public HowlOfTerror(): base(1952998209)
        {
        }

        public HowlOfTerror(int newId): base(1952998209, newId)
        {
        }

        public HowlOfTerror(string newRawcode): base(1952998209, newRawcode)
        {
        }

        public HowlOfTerror(ObjectDatabase db): base(1952998209, db)
        {
        }

        public HowlOfTerror(int newId, ObjectDatabase db): base(1952998209, newId, db)
        {
        }

        public HowlOfTerror(string newRawcode, ObjectDatabase db): base(1952998209, newRawcode, db)
        {
        }
    }
}