using System;
using System.Collections.Generic;
using System.Linq;
using War3Api.Object.Abilities;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class Frenzy : Ability
    {
        private readonly Lazy<ObjectProperty<float>> _dataAttackSpeedIncrease;
        private readonly Lazy<ReadOnlyObjectProperty<bool>> _isDataAttackSpeedIncreaseModified;
        private readonly Lazy<ObjectProperty<float>> _dataMovementSpeedIncrease;
        private readonly Lazy<ReadOnlyObjectProperty<bool>> _isDataMovementSpeedIncreaseModified;
        private readonly Lazy<ObjectProperty<float>> _dataScalingFactor;
        private readonly Lazy<ReadOnlyObjectProperty<bool>> _isDataScalingFactorModified;
        public Frenzy(): base(2038064705)
        {
            _dataAttackSpeedIncrease = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataAttackSpeedIncrease, SetDataAttackSpeedIncrease));
            _isDataAttackSpeedIncreaseModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataAttackSpeedIncreaseModified));
            _dataMovementSpeedIncrease = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataMovementSpeedIncrease, SetDataMovementSpeedIncrease));
            _isDataMovementSpeedIncreaseModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataMovementSpeedIncreaseModified));
            _dataScalingFactor = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataScalingFactor, SetDataScalingFactor));
            _isDataScalingFactorModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataScalingFactorModified));
        }

        public Frenzy(int newId): base(2038064705, newId)
        {
            _dataAttackSpeedIncrease = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataAttackSpeedIncrease, SetDataAttackSpeedIncrease));
            _isDataAttackSpeedIncreaseModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataAttackSpeedIncreaseModified));
            _dataMovementSpeedIncrease = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataMovementSpeedIncrease, SetDataMovementSpeedIncrease));
            _isDataMovementSpeedIncreaseModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataMovementSpeedIncreaseModified));
            _dataScalingFactor = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataScalingFactor, SetDataScalingFactor));
            _isDataScalingFactorModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataScalingFactorModified));
        }

        public Frenzy(string newRawcode): base(2038064705, newRawcode)
        {
            _dataAttackSpeedIncrease = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataAttackSpeedIncrease, SetDataAttackSpeedIncrease));
            _isDataAttackSpeedIncreaseModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataAttackSpeedIncreaseModified));
            _dataMovementSpeedIncrease = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataMovementSpeedIncrease, SetDataMovementSpeedIncrease));
            _isDataMovementSpeedIncreaseModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataMovementSpeedIncreaseModified));
            _dataScalingFactor = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataScalingFactor, SetDataScalingFactor));
            _isDataScalingFactorModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataScalingFactorModified));
        }

        public Frenzy(ObjectDatabase db): base(2038064705, db)
        {
            _dataAttackSpeedIncrease = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataAttackSpeedIncrease, SetDataAttackSpeedIncrease));
            _isDataAttackSpeedIncreaseModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataAttackSpeedIncreaseModified));
            _dataMovementSpeedIncrease = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataMovementSpeedIncrease, SetDataMovementSpeedIncrease));
            _isDataMovementSpeedIncreaseModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataMovementSpeedIncreaseModified));
            _dataScalingFactor = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataScalingFactor, SetDataScalingFactor));
            _isDataScalingFactorModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataScalingFactorModified));
        }

        public Frenzy(int newId, ObjectDatabase db): base(2038064705, newId, db)
        {
            _dataAttackSpeedIncrease = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataAttackSpeedIncrease, SetDataAttackSpeedIncrease));
            _isDataAttackSpeedIncreaseModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataAttackSpeedIncreaseModified));
            _dataMovementSpeedIncrease = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataMovementSpeedIncrease, SetDataMovementSpeedIncrease));
            _isDataMovementSpeedIncreaseModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataMovementSpeedIncreaseModified));
            _dataScalingFactor = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataScalingFactor, SetDataScalingFactor));
            _isDataScalingFactorModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataScalingFactorModified));
        }

        public Frenzy(string newRawcode, ObjectDatabase db): base(2038064705, newRawcode, db)
        {
            _dataAttackSpeedIncrease = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataAttackSpeedIncrease, SetDataAttackSpeedIncrease));
            _isDataAttackSpeedIncreaseModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataAttackSpeedIncreaseModified));
            _dataMovementSpeedIncrease = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataMovementSpeedIncrease, SetDataMovementSpeedIncrease));
            _isDataMovementSpeedIncreaseModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataMovementSpeedIncreaseModified));
            _dataScalingFactor = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataScalingFactor, SetDataScalingFactor));
            _isDataScalingFactorModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataScalingFactorModified));
        }

        public ObjectProperty<float> DataAttackSpeedIncrease => _dataAttackSpeedIncrease.Value;
        public ReadOnlyObjectProperty<bool> IsDataAttackSpeedIncreaseModified => _isDataAttackSpeedIncreaseModified.Value;
        public ObjectProperty<float> DataMovementSpeedIncrease => _dataMovementSpeedIncrease.Value;
        public ReadOnlyObjectProperty<bool> IsDataMovementSpeedIncreaseModified => _isDataMovementSpeedIncreaseModified.Value;
        public ObjectProperty<float> DataScalingFactor => _dataScalingFactor.Value;
        public ReadOnlyObjectProperty<bool> IsDataScalingFactorModified => _isDataScalingFactorModified.Value;
        private float GetDataAttackSpeedIncrease(int level)
        {
            return _modifications[829385794, level].ValueAsFloat;
        }

        private void SetDataAttackSpeedIncrease(int level, float value)
        {
            _modifications[829385794, level] = new LevelObjectDataModification{Id = 829385794, Type = ObjectDataType.Unreal, Value = value, Level = level, Pointer = 1};
        }

        private bool GetIsDataAttackSpeedIncreaseModified(int level)
        {
            return _modifications.ContainsKey(829385794, level);
        }

        private float GetDataMovementSpeedIncrease(int level)
        {
            return _modifications[846163010, level].ValueAsFloat;
        }

        private void SetDataMovementSpeedIncrease(int level, float value)
        {
            _modifications[846163010, level] = new LevelObjectDataModification{Id = 846163010, Type = ObjectDataType.Unreal, Value = value, Level = level, Pointer = 2};
        }

        private bool GetIsDataMovementSpeedIncreaseModified(int level)
        {
            return _modifications.ContainsKey(846163010, level);
        }

        private float GetDataScalingFactor(int level)
        {
            return _modifications[862940226, level].ValueAsFloat;
        }

        private void SetDataScalingFactor(int level, float value)
        {
            _modifications[862940226, level] = new LevelObjectDataModification{Id = 862940226, Type = ObjectDataType.Unreal, Value = value, Level = level, Pointer = 3};
        }

        private bool GetIsDataScalingFactorModified(int level)
        {
            return _modifications.ContainsKey(862940226, level);
        }
    }
}