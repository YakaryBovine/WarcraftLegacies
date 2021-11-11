using System;
using System.Collections.Generic;
using System.Linq;
using War3Api.Object.Abilities;
using War3Api.Object.Enums;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class RuneManaRestoreGreaterAoe : Ability
    {
        public RuneManaRestoreGreaterAoe(): base(1735217217)
        {
        }

        public RuneManaRestoreGreaterAoe(int newId): base(1735217217, newId)
        {
        }

        public RuneManaRestoreGreaterAoe(string newRawcode): base(1735217217, newRawcode)
        {
        }

        public RuneManaRestoreGreaterAoe(ObjectDatabase db): base(1735217217, db)
        {
        }

        public RuneManaRestoreGreaterAoe(int newId, ObjectDatabase db): base(1735217217, newId, db)
        {
        }

        public RuneManaRestoreGreaterAoe(string newRawcode, ObjectDatabase db): base(1735217217, newRawcode, db)
        {
        }
    }
}