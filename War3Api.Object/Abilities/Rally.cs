using System;
using System.Collections.Generic;
using System.Linq;
using War3Api.Object.Abilities;
using War3Api.Object.Enums;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class Rally : Ability
    {
        public Rally(): base(1818317377)
        {
        }

        public Rally(int newId): base(1818317377, newId)
        {
        }

        public Rally(string newRawcode): base(1818317377, newRawcode)
        {
        }

        public Rally(ObjectDatabase db): base(1818317377, db)
        {
        }

        public Rally(int newId, ObjectDatabase db): base(1818317377, newId, db)
        {
        }

        public Rally(string newRawcode, ObjectDatabase db): base(1818317377, newRawcode, db)
        {
        }
    }
}