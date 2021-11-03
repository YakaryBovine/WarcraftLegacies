using System;
using System.Collections.Generic;
using System.Linq;
using War3Api.Object.Abilities;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class Locust : Ability
    {
        public Locust(): base(1668246593)
        {
        }

        public Locust(int newId): base(1668246593, newId)
        {
        }

        public Locust(string newRawcode): base(1668246593, newRawcode)
        {
        }

        public Locust(ObjectDatabase db): base(1668246593, db)
        {
        }

        public Locust(int newId, ObjectDatabase db): base(1668246593, newId, db)
        {
        }

        public Locust(string newRawcode, ObjectDatabase db): base(1668246593, newRawcode, db)
        {
        }
    }
}