using System;
using System.Collections.Generic;
using System.Linq;
using War3Api.Object.Abilities;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class BuildNightElf : Ability
    {
        public BuildNightElf(): base(1969374529)
        {
        }

        public BuildNightElf(int newId): base(1969374529, newId)
        {
        }

        public BuildNightElf(string newRawcode): base(1969374529, newRawcode)
        {
        }

        public BuildNightElf(ObjectDatabase db): base(1969374529, db)
        {
        }

        public BuildNightElf(int newId, ObjectDatabase db): base(1969374529, newId, db)
        {
        }

        public BuildNightElf(string newRawcode, ObjectDatabase db): base(1969374529, newRawcode, db)
        {
        }
    }
}