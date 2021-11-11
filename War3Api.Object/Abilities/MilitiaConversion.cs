using System;
using System.Collections.Generic;
using System.Linq;
using War3Api.Object.Abilities;
using War3Api.Object.Enums;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class MilitiaConversion : Ability
    {
        public MilitiaConversion(): base(1667853633)
        {
        }

        public MilitiaConversion(int newId): base(1667853633, newId)
        {
        }

        public MilitiaConversion(string newRawcode): base(1667853633, newRawcode)
        {
        }

        public MilitiaConversion(ObjectDatabase db): base(1667853633, db)
        {
        }

        public MilitiaConversion(int newId, ObjectDatabase db): base(1667853633, newId, db)
        {
        }

        public MilitiaConversion(string newRawcode, ObjectDatabase db): base(1667853633, newRawcode, db)
        {
        }
    }
}