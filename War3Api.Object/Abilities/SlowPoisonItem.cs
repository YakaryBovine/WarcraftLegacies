using System;
using System.Collections.Generic;
using System.Linq;
using War3Api.Object.Abilities;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class SlowPoisonItem : Ability
    {
        public SlowPoisonItem(): base(2054375745)
        {
        }

        public SlowPoisonItem(int newId): base(2054375745, newId)
        {
        }

        public SlowPoisonItem(string newRawcode): base(2054375745, newRawcode)
        {
        }

        public SlowPoisonItem(ObjectDatabase db): base(2054375745, db)
        {
        }

        public SlowPoisonItem(int newId, ObjectDatabase db): base(2054375745, newId, db)
        {
        }

        public SlowPoisonItem(string newRawcode, ObjectDatabase db): base(2054375745, newRawcode, db)
        {
        }
    }
}