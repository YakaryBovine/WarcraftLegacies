using System;
using System.Collections.Generic;
using System.Linq;
using War3Api.Object.Abilities;
using War3Api.Object.Enums;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class InnerFireCreep : Ability
    {
        private readonly Lazy<ObjectProperty<float>> _dataDamageIncrease;
        private readonly Lazy<ReadOnlyObjectProperty<bool>> _isDataDamageIncreaseModified;
        private readonly Lazy<ObjectProperty<int>> _dataDefenseIncrease;
        private readonly Lazy<ReadOnlyObjectProperty<bool>> _isDataDefenseIncreaseModified;
        private readonly Lazy<ObjectProperty<float>> _dataAutocastRange;
        private readonly Lazy<ReadOnlyObjectProperty<bool>> _isDataAutocastRangeModified;
        private readonly Lazy<ObjectProperty<float>> _dataLifeRegenRate;
        private readonly Lazy<ReadOnlyObjectProperty<bool>> _isDataLifeRegenRateModified;
        public InnerFireCreep(): base(1718174529)
        {
            _dataDamageIncrease = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamageIncrease, SetDataDamageIncrease));
            _isDataDamageIncreaseModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataDamageIncreaseModified));
            _dataDefenseIncrease = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataDefenseIncrease, SetDataDefenseIncrease));
            _isDataDefenseIncreaseModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataDefenseIncreaseModified));
            _dataAutocastRange = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataAutocastRange, SetDataAutocastRange));
            _isDataAutocastRangeModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataAutocastRangeModified));
            _dataLifeRegenRate = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataLifeRegenRate, SetDataLifeRegenRate));
            _isDataLifeRegenRateModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataLifeRegenRateModified));
        }

        public InnerFireCreep(int newId): base(1718174529, newId)
        {
            _dataDamageIncrease = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamageIncrease, SetDataDamageIncrease));
            _isDataDamageIncreaseModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataDamageIncreaseModified));
            _dataDefenseIncrease = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataDefenseIncrease, SetDataDefenseIncrease));
            _isDataDefenseIncreaseModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataDefenseIncreaseModified));
            _dataAutocastRange = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataAutocastRange, SetDataAutocastRange));
            _isDataAutocastRangeModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataAutocastRangeModified));
            _dataLifeRegenRate = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataLifeRegenRate, SetDataLifeRegenRate));
            _isDataLifeRegenRateModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataLifeRegenRateModified));
        }

        public InnerFireCreep(string newRawcode): base(1718174529, newRawcode)
        {
            _dataDamageIncrease = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamageIncrease, SetDataDamageIncrease));
            _isDataDamageIncreaseModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataDamageIncreaseModified));
            _dataDefenseIncrease = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataDefenseIncrease, SetDataDefenseIncrease));
            _isDataDefenseIncreaseModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataDefenseIncreaseModified));
            _dataAutocastRange = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataAutocastRange, SetDataAutocastRange));
            _isDataAutocastRangeModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataAutocastRangeModified));
            _dataLifeRegenRate = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataLifeRegenRate, SetDataLifeRegenRate));
            _isDataLifeRegenRateModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataLifeRegenRateModified));
        }

        public InnerFireCreep(ObjectDatabase db): base(1718174529, db)
        {
            _dataDamageIncrease = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamageIncrease, SetDataDamageIncrease));
            _isDataDamageIncreaseModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataDamageIncreaseModified));
            _dataDefenseIncrease = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataDefenseIncrease, SetDataDefenseIncrease));
            _isDataDefenseIncreaseModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataDefenseIncreaseModified));
            _dataAutocastRange = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataAutocastRange, SetDataAutocastRange));
            _isDataAutocastRangeModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataAutocastRangeModified));
            _dataLifeRegenRate = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataLifeRegenRate, SetDataLifeRegenRate));
            _isDataLifeRegenRateModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataLifeRegenRateModified));
        }

        public InnerFireCreep(int newId, ObjectDatabase db): base(1718174529, newId, db)
        {
            _dataDamageIncrease = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamageIncrease, SetDataDamageIncrease));
            _isDataDamageIncreaseModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataDamageIncreaseModified));
            _dataDefenseIncrease = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataDefenseIncrease, SetDataDefenseIncrease));
            _isDataDefenseIncreaseModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataDefenseIncreaseModified));
            _dataAutocastRange = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataAutocastRange, SetDataAutocastRange));
            _isDataAutocastRangeModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataAutocastRangeModified));
            _dataLifeRegenRate = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataLifeRegenRate, SetDataLifeRegenRate));
            _isDataLifeRegenRateModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataLifeRegenRateModified));
        }

        public InnerFireCreep(string newRawcode, ObjectDatabase db): base(1718174529, newRawcode, db)
        {
            _dataDamageIncrease = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamageIncrease, SetDataDamageIncrease));
            _isDataDamageIncreaseModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataDamageIncreaseModified));
            _dataDefenseIncrease = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataDefenseIncrease, SetDataDefenseIncrease));
            _isDataDefenseIncreaseModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataDefenseIncreaseModified));
            _dataAutocastRange = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataAutocastRange, SetDataAutocastRange));
            _isDataAutocastRangeModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataAutocastRangeModified));
            _dataLifeRegenRate = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataLifeRegenRate, SetDataLifeRegenRate));
            _isDataLifeRegenRateModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataLifeRegenRateModified));
        }

        public ObjectProperty<float> DataDamageIncrease => _dataDamageIncrease.Value;
        public ReadOnlyObjectProperty<bool> IsDataDamageIncreaseModified => _isDataDamageIncreaseModified.Value;
        public ObjectProperty<int> DataDefenseIncrease => _dataDefenseIncrease.Value;
        public ReadOnlyObjectProperty<bool> IsDataDefenseIncreaseModified => _isDataDefenseIncreaseModified.Value;
        public ObjectProperty<float> DataAutocastRange => _dataAutocastRange.Value;
        public ReadOnlyObjectProperty<bool> IsDataAutocastRangeModified => _isDataAutocastRangeModified.Value;
        public ObjectProperty<float> DataLifeRegenRate => _dataLifeRegenRate.Value;
        public ReadOnlyObjectProperty<bool> IsDataLifeRegenRateModified => _isDataLifeRegenRateModified.Value;
        private float GetDataDamageIncrease(int level)
        {
            return _modifications[828796489, level].ValueAsFloat;
        }

        private void SetDataDamageIncrease(int level, float value)
        {
            _modifications[828796489, level] = new LevelObjectDataModification{Id = 828796489, Type = ObjectDataType.Unreal, Value = value, Level = level, Pointer = 1};
        }

        private bool GetIsDataDamageIncreaseModified(int level)
        {
            return _modifications.ContainsKey(828796489, level);
        }

        private int GetDataDefenseIncrease(int level)
        {
            return _modifications[845573705, level].ValueAsInt;
        }

        private void SetDataDefenseIncrease(int level, int value)
        {
            _modifications[845573705, level] = new LevelObjectDataModification{Id = 845573705, Type = ObjectDataType.Int, Value = value, Level = level, Pointer = 2};
        }

        private bool GetIsDataDefenseIncreaseModified(int level)
        {
            return _modifications.ContainsKey(845573705, level);
        }

        private float GetDataAutocastRange(int level)
        {
            return _modifications[862350921, level].ValueAsFloat;
        }

        private void SetDataAutocastRange(int level, float value)
        {
            _modifications[862350921, level] = new LevelObjectDataModification{Id = 862350921, Type = ObjectDataType.Unreal, Value = value, Level = level, Pointer = 3};
        }

        private bool GetIsDataAutocastRangeModified(int level)
        {
            return _modifications.ContainsKey(862350921, level);
        }

        private float GetDataLifeRegenRate(int level)
        {
            return _modifications[879128137, level].ValueAsFloat;
        }

        private void SetDataLifeRegenRate(int level, float value)
        {
            _modifications[879128137, level] = new LevelObjectDataModification{Id = 879128137, Type = ObjectDataType.Unreal, Value = value, Level = level, Pointer = 4};
        }

        private bool GetIsDataLifeRegenRateModified(int level)
        {
            return _modifications.ContainsKey(879128137, level);
        }
    }
}