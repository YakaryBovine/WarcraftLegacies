using System;
using System.Collections.Generic;
using System.Linq;
using War3Api.Object.Abilities;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class RexxarStampede : Ability
    {
        public RexxarStampede(): base(1886614081)
        {
        }

        public RexxarStampede(int newId): base(1886614081, newId)
        {
        }

        public RexxarStampede(string newRawcode): base(1886614081, newRawcode)
        {
        }

        public RexxarStampede(ObjectDatabase db): base(1886614081, db)
        {
        }

        public RexxarStampede(int newId, ObjectDatabase db): base(1886614081, newId, db)
        {
        }

        public RexxarStampede(string newRawcode, ObjectDatabase db): base(1886614081, newRawcode, db)
        {
        }
    }
}