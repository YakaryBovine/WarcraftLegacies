using System;
using System.Collections.Generic;
using System.Linq;
using War3Api.Object.Abilities;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class LiquidFire : Ability
    {
        private readonly Lazy<ObjectProperty<float>> _dataExtraDamagePerSecond;
        private readonly Lazy<ReadOnlyObjectProperty<bool>> _isDataExtraDamagePerSecondModified;
        private readonly Lazy<ObjectProperty<float>> _dataMovementSpeedReduction;
        private readonly Lazy<ReadOnlyObjectProperty<bool>> _isDataMovementSpeedReductionModified;
        private readonly Lazy<ObjectProperty<float>> _dataAttackSpeedReduction;
        private readonly Lazy<ReadOnlyObjectProperty<bool>> _isDataAttackSpeedReductionModified;
        private readonly Lazy<ObjectProperty<bool>> _dataRepairsAllowed;
        private readonly Lazy<ReadOnlyObjectProperty<bool>> _isDataRepairsAllowedModified;
        public LiquidFire(): base(1902734401)
        {
            _dataExtraDamagePerSecond = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataExtraDamagePerSecond, SetDataExtraDamagePerSecond));
            _isDataExtraDamagePerSecondModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataExtraDamagePerSecondModified));
            _dataMovementSpeedReduction = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataMovementSpeedReduction, SetDataMovementSpeedReduction));
            _isDataMovementSpeedReductionModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataMovementSpeedReductionModified));
            _dataAttackSpeedReduction = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataAttackSpeedReduction, SetDataAttackSpeedReduction));
            _isDataAttackSpeedReductionModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataAttackSpeedReductionModified));
            _dataRepairsAllowed = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataRepairsAllowed, SetDataRepairsAllowed));
            _isDataRepairsAllowedModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataRepairsAllowedModified));
        }

        public LiquidFire(int newId): base(1902734401, newId)
        {
            _dataExtraDamagePerSecond = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataExtraDamagePerSecond, SetDataExtraDamagePerSecond));
            _isDataExtraDamagePerSecondModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataExtraDamagePerSecondModified));
            _dataMovementSpeedReduction = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataMovementSpeedReduction, SetDataMovementSpeedReduction));
            _isDataMovementSpeedReductionModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataMovementSpeedReductionModified));
            _dataAttackSpeedReduction = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataAttackSpeedReduction, SetDataAttackSpeedReduction));
            _isDataAttackSpeedReductionModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataAttackSpeedReductionModified));
            _dataRepairsAllowed = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataRepairsAllowed, SetDataRepairsAllowed));
            _isDataRepairsAllowedModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataRepairsAllowedModified));
        }

        public LiquidFire(string newRawcode): base(1902734401, newRawcode)
        {
            _dataExtraDamagePerSecond = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataExtraDamagePerSecond, SetDataExtraDamagePerSecond));
            _isDataExtraDamagePerSecondModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataExtraDamagePerSecondModified));
            _dataMovementSpeedReduction = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataMovementSpeedReduction, SetDataMovementSpeedReduction));
            _isDataMovementSpeedReductionModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataMovementSpeedReductionModified));
            _dataAttackSpeedReduction = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataAttackSpeedReduction, SetDataAttackSpeedReduction));
            _isDataAttackSpeedReductionModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataAttackSpeedReductionModified));
            _dataRepairsAllowed = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataRepairsAllowed, SetDataRepairsAllowed));
            _isDataRepairsAllowedModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataRepairsAllowedModified));
        }

        public LiquidFire(ObjectDatabase db): base(1902734401, db)
        {
            _dataExtraDamagePerSecond = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataExtraDamagePerSecond, SetDataExtraDamagePerSecond));
            _isDataExtraDamagePerSecondModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataExtraDamagePerSecondModified));
            _dataMovementSpeedReduction = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataMovementSpeedReduction, SetDataMovementSpeedReduction));
            _isDataMovementSpeedReductionModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataMovementSpeedReductionModified));
            _dataAttackSpeedReduction = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataAttackSpeedReduction, SetDataAttackSpeedReduction));
            _isDataAttackSpeedReductionModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataAttackSpeedReductionModified));
            _dataRepairsAllowed = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataRepairsAllowed, SetDataRepairsAllowed));
            _isDataRepairsAllowedModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataRepairsAllowedModified));
        }

        public LiquidFire(int newId, ObjectDatabase db): base(1902734401, newId, db)
        {
            _dataExtraDamagePerSecond = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataExtraDamagePerSecond, SetDataExtraDamagePerSecond));
            _isDataExtraDamagePerSecondModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataExtraDamagePerSecondModified));
            _dataMovementSpeedReduction = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataMovementSpeedReduction, SetDataMovementSpeedReduction));
            _isDataMovementSpeedReductionModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataMovementSpeedReductionModified));
            _dataAttackSpeedReduction = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataAttackSpeedReduction, SetDataAttackSpeedReduction));
            _isDataAttackSpeedReductionModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataAttackSpeedReductionModified));
            _dataRepairsAllowed = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataRepairsAllowed, SetDataRepairsAllowed));
            _isDataRepairsAllowedModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataRepairsAllowedModified));
        }

        public LiquidFire(string newRawcode, ObjectDatabase db): base(1902734401, newRawcode, db)
        {
            _dataExtraDamagePerSecond = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataExtraDamagePerSecond, SetDataExtraDamagePerSecond));
            _isDataExtraDamagePerSecondModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataExtraDamagePerSecondModified));
            _dataMovementSpeedReduction = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataMovementSpeedReduction, SetDataMovementSpeedReduction));
            _isDataMovementSpeedReductionModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataMovementSpeedReductionModified));
            _dataAttackSpeedReduction = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataAttackSpeedReduction, SetDataAttackSpeedReduction));
            _isDataAttackSpeedReductionModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataAttackSpeedReductionModified));
            _dataRepairsAllowed = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataRepairsAllowed, SetDataRepairsAllowed));
            _isDataRepairsAllowedModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataRepairsAllowedModified));
        }

        public ObjectProperty<float> DataExtraDamagePerSecond => _dataExtraDamagePerSecond.Value;
        public ReadOnlyObjectProperty<bool> IsDataExtraDamagePerSecondModified => _isDataExtraDamagePerSecondModified.Value;
        public ObjectProperty<float> DataMovementSpeedReduction => _dataMovementSpeedReduction.Value;
        public ReadOnlyObjectProperty<bool> IsDataMovementSpeedReductionModified => _isDataMovementSpeedReductionModified.Value;
        public ObjectProperty<float> DataAttackSpeedReduction => _dataAttackSpeedReduction.Value;
        public ReadOnlyObjectProperty<bool> IsDataAttackSpeedReductionModified => _isDataAttackSpeedReductionModified.Value;
        public ObjectProperty<bool> DataRepairsAllowed => _dataRepairsAllowed.Value;
        public ReadOnlyObjectProperty<bool> IsDataRepairsAllowedModified => _isDataRepairsAllowedModified.Value;
        private float GetDataExtraDamagePerSecond(int level)
        {
            return _modifications[829516140, level].ValueAsFloat;
        }

        private void SetDataExtraDamagePerSecond(int level, float value)
        {
            _modifications[829516140, level] = new LevelObjectDataModification{Id = 829516140, Type = ObjectDataType.Unreal, Value = value, Level = level, Pointer = 1};
        }

        private bool GetIsDataExtraDamagePerSecondModified(int level)
        {
            return _modifications.ContainsKey(829516140, level);
        }

        private float GetDataMovementSpeedReduction(int level)
        {
            return _modifications[846293356, level].ValueAsFloat;
        }

        private void SetDataMovementSpeedReduction(int level, float value)
        {
            _modifications[846293356, level] = new LevelObjectDataModification{Id = 846293356, Type = ObjectDataType.Unreal, Value = value, Level = level, Pointer = 2};
        }

        private bool GetIsDataMovementSpeedReductionModified(int level)
        {
            return _modifications.ContainsKey(846293356, level);
        }

        private float GetDataAttackSpeedReduction(int level)
        {
            return _modifications[863070572, level].ValueAsFloat;
        }

        private void SetDataAttackSpeedReduction(int level, float value)
        {
            _modifications[863070572, level] = new LevelObjectDataModification{Id = 863070572, Type = ObjectDataType.Unreal, Value = value, Level = level, Pointer = 3};
        }

        private bool GetIsDataAttackSpeedReductionModified(int level)
        {
            return _modifications.ContainsKey(863070572, level);
        }

        private bool GetDataRepairsAllowed(int level)
        {
            return _modifications[879847788, level].ValueAsBool;
        }

        private void SetDataRepairsAllowed(int level, bool value)
        {
            _modifications[879847788, level] = new LevelObjectDataModification{Id = 879847788, Type = ObjectDataType.Bool, Value = value, Level = level, Pointer = 4};
        }

        private bool GetIsDataRepairsAllowedModified(int level)
        {
            return _modifications.ContainsKey(879847788, level);
        }
    }
}