using System;
using System.Collections.Generic;
using System.Linq;
using War3Api.Object.Abilities;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class OrbOfGuldan : Ability
    {
        public OrbOfGuldan(): base(1684490561)
        {
        }

        public OrbOfGuldan(int newId): base(1684490561, newId)
        {
        }

        public OrbOfGuldan(string newRawcode): base(1684490561, newRawcode)
        {
        }

        public OrbOfGuldan(ObjectDatabase db): base(1684490561, db)
        {
        }

        public OrbOfGuldan(int newId, ObjectDatabase db): base(1684490561, newId, db)
        {
        }

        public OrbOfGuldan(string newRawcode, ObjectDatabase db): base(1684490561, newRawcode, db)
        {
        }
    }
}