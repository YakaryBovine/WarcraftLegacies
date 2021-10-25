using System;
using System.Collections.Generic;
using System.Linq;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class Revenge : Ability
    {
        public Revenge(): base(1735291457)
        {
        }

        public Revenge(int newId): base(1735291457, newId)
        {
        }

        public Revenge(string newRawcode): base(1735291457, newRawcode)
        {
        }

        public Revenge(ObjectDatabase db): base(1735291457, db)
        {
        }

        public Revenge(int newId, ObjectDatabase db): base(1735291457, newId, db)
        {
        }

        public Revenge(string newRawcode, ObjectDatabase db): base(1735291457, newRawcode, db)
        {
        }
    }
}