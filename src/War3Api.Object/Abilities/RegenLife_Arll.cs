using System;
using System.Collections.Generic;
using System.Linq;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class RegenLife_Arll : Ability
    {
        private readonly Lazy<ObjectProperty<int>> _dataHitPointsRegeneratedPerSecond;
        public RegenLife_Arll(): base(1819046465)
        {
            _dataHitPointsRegeneratedPerSecond = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataHitPointsRegeneratedPerSecond, SetDataHitPointsRegeneratedPerSecond));
        }

        public RegenLife_Arll(int newId): base(1819046465, newId)
        {
            _dataHitPointsRegeneratedPerSecond = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataHitPointsRegeneratedPerSecond, SetDataHitPointsRegeneratedPerSecond));
        }

        public RegenLife_Arll(string newRawcode): base(1819046465, newRawcode)
        {
            _dataHitPointsRegeneratedPerSecond = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataHitPointsRegeneratedPerSecond, SetDataHitPointsRegeneratedPerSecond));
        }

        public RegenLife_Arll(ObjectDatabase db): base(1819046465, db)
        {
            _dataHitPointsRegeneratedPerSecond = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataHitPointsRegeneratedPerSecond, SetDataHitPointsRegeneratedPerSecond));
        }

        public RegenLife_Arll(int newId, ObjectDatabase db): base(1819046465, newId, db)
        {
            _dataHitPointsRegeneratedPerSecond = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataHitPointsRegeneratedPerSecond, SetDataHitPointsRegeneratedPerSecond));
        }

        public RegenLife_Arll(string newRawcode, ObjectDatabase db): base(1819046465, newRawcode, db)
        {
            _dataHitPointsRegeneratedPerSecond = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataHitPointsRegeneratedPerSecond, SetDataHitPointsRegeneratedPerSecond));
        }

        public ObjectProperty<int> DataHitPointsRegeneratedPerSecond => _dataHitPointsRegeneratedPerSecond.Value;
        private int GetDataHitPointsRegeneratedPerSecond(int level)
        {
            return _modifications[1919969353, level].ValueAsInt;
        }

        private void SetDataHitPointsRegeneratedPerSecond(int level, int value)
        {
            _modifications[1919969353, level] = new LevelObjectDataModification{Id = 1919969353, Type = ObjectDataType.Int, Value = value, Level = level, Pointer = 1};
        }
    }
}