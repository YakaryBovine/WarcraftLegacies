using System;
using System.Collections.Generic;
using System.Linq;
using War3Api.Object.Abilities;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class RuneRestoreAoe : Ability
    {
        public RuneRestoreAoe(): base(1634881601)
        {
        }

        public RuneRestoreAoe(int newId): base(1634881601, newId)
        {
        }

        public RuneRestoreAoe(string newRawcode): base(1634881601, newRawcode)
        {
        }

        public RuneRestoreAoe(ObjectDatabase db): base(1634881601, db)
        {
        }

        public RuneRestoreAoe(int newId, ObjectDatabase db): base(1634881601, newId, db)
        {
        }

        public RuneRestoreAoe(string newRawcode, ObjectDatabase db): base(1634881601, newRawcode, db)
        {
        }
    }
}