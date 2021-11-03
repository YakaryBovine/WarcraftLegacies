using System;
using System.Collections.Generic;
using System.Linq;
using War3Api.Object.Abilities;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class AvatarGarithos : Ability
    {
        public AvatarGarithos(): base(1986088513)
        {
        }

        public AvatarGarithos(int newId): base(1986088513, newId)
        {
        }

        public AvatarGarithos(string newRawcode): base(1986088513, newRawcode)
        {
        }

        public AvatarGarithos(ObjectDatabase db): base(1986088513, db)
        {
        }

        public AvatarGarithos(int newId, ObjectDatabase db): base(1986088513, newId, db)
        {
        }

        public AvatarGarithos(string newRawcode, ObjectDatabase db): base(1986088513, newRawcode, db)
        {
        }
    }
}