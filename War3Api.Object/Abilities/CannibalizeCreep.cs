using System;
using System.Collections.Generic;
using System.Linq;
using War3Api.Object.Abilities;
using War3Api.Object.Enums;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class CannibalizeCreep : Ability
    {
        private readonly Lazy<ObjectProperty<float>> _dataHitPointsPerSecond;
        private readonly Lazy<ReadOnlyObjectProperty<bool>> _isDataHitPointsPerSecondModified;
        private readonly Lazy<ObjectProperty<float>> _dataMaxHitPoints;
        private readonly Lazy<ReadOnlyObjectProperty<bool>> _isDataMaxHitPointsModified;
        public CannibalizeCreep(): base(1851999041)
        {
            _dataHitPointsPerSecond = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataHitPointsPerSecond, SetDataHitPointsPerSecond));
            _isDataHitPointsPerSecondModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataHitPointsPerSecondModified));
            _dataMaxHitPoints = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataMaxHitPoints, SetDataMaxHitPoints));
            _isDataMaxHitPointsModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataMaxHitPointsModified));
        }

        public CannibalizeCreep(int newId): base(1851999041, newId)
        {
            _dataHitPointsPerSecond = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataHitPointsPerSecond, SetDataHitPointsPerSecond));
            _isDataHitPointsPerSecondModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataHitPointsPerSecondModified));
            _dataMaxHitPoints = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataMaxHitPoints, SetDataMaxHitPoints));
            _isDataMaxHitPointsModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataMaxHitPointsModified));
        }

        public CannibalizeCreep(string newRawcode): base(1851999041, newRawcode)
        {
            _dataHitPointsPerSecond = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataHitPointsPerSecond, SetDataHitPointsPerSecond));
            _isDataHitPointsPerSecondModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataHitPointsPerSecondModified));
            _dataMaxHitPoints = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataMaxHitPoints, SetDataMaxHitPoints));
            _isDataMaxHitPointsModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataMaxHitPointsModified));
        }

        public CannibalizeCreep(ObjectDatabase db): base(1851999041, db)
        {
            _dataHitPointsPerSecond = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataHitPointsPerSecond, SetDataHitPointsPerSecond));
            _isDataHitPointsPerSecondModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataHitPointsPerSecondModified));
            _dataMaxHitPoints = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataMaxHitPoints, SetDataMaxHitPoints));
            _isDataMaxHitPointsModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataMaxHitPointsModified));
        }

        public CannibalizeCreep(int newId, ObjectDatabase db): base(1851999041, newId, db)
        {
            _dataHitPointsPerSecond = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataHitPointsPerSecond, SetDataHitPointsPerSecond));
            _isDataHitPointsPerSecondModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataHitPointsPerSecondModified));
            _dataMaxHitPoints = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataMaxHitPoints, SetDataMaxHitPoints));
            _isDataMaxHitPointsModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataMaxHitPointsModified));
        }

        public CannibalizeCreep(string newRawcode, ObjectDatabase db): base(1851999041, newRawcode, db)
        {
            _dataHitPointsPerSecond = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataHitPointsPerSecond, SetDataHitPointsPerSecond));
            _isDataHitPointsPerSecondModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataHitPointsPerSecondModified));
            _dataMaxHitPoints = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataMaxHitPoints, SetDataMaxHitPoints));
            _isDataMaxHitPointsModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataMaxHitPointsModified));
        }

        public ObjectProperty<float> DataHitPointsPerSecond => _dataHitPointsPerSecond.Value;
        public ReadOnlyObjectProperty<bool> IsDataHitPointsPerSecondModified => _isDataHitPointsPerSecondModified.Value;
        public ObjectProperty<float> DataMaxHitPoints => _dataMaxHitPoints.Value;
        public ReadOnlyObjectProperty<bool> IsDataMaxHitPointsModified => _isDataMaxHitPointsModified.Value;
        private float GetDataHitPointsPerSecond(int level)
        {
            return _modifications[829317443, level].ValueAsFloat;
        }

        private void SetDataHitPointsPerSecond(int level, float value)
        {
            _modifications[829317443, level] = new LevelObjectDataModification{Id = 829317443, Type = ObjectDataType.Unreal, Value = value, Level = level, Pointer = 1};
        }

        private bool GetIsDataHitPointsPerSecondModified(int level)
        {
            return _modifications.ContainsKey(829317443, level);
        }

        private float GetDataMaxHitPoints(int level)
        {
            return _modifications[846094659, level].ValueAsFloat;
        }

        private void SetDataMaxHitPoints(int level, float value)
        {
            _modifications[846094659, level] = new LevelObjectDataModification{Id = 846094659, Type = ObjectDataType.Unreal, Value = value, Level = level, Pointer = 2};
        }

        private bool GetIsDataMaxHitPointsModified(int level)
        {
            return _modifications.ContainsKey(846094659, level);
        }
    }
}