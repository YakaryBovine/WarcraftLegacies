using System;
using System.Collections.Generic;
using System.Linq;
using War3Api.Object.Abilities;
using War3Api.Object.Enums;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class SummonLobstrokPrawns : Ability
    {
        public SummonLobstrokPrawns(): base(1886155585)
        {
        }

        public SummonLobstrokPrawns(int newId): base(1886155585, newId)
        {
        }

        public SummonLobstrokPrawns(string newRawcode): base(1886155585, newRawcode)
        {
        }

        public SummonLobstrokPrawns(ObjectDatabase db): base(1886155585, db)
        {
        }

        public SummonLobstrokPrawns(int newId, ObjectDatabase db): base(1886155585, newId, db)
        {
        }

        public SummonLobstrokPrawns(string newRawcode, ObjectDatabase db): base(1886155585, newRawcode, db)
        {
        }
    }
}