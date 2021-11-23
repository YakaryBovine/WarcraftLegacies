using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using War3Api.Object.Abilities;
using War3Api.Object.Enums;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class FirelordSoulBurn : Ability
    {
        private readonly Lazy<ObjectProperty<float>> _dataDamageAmount;
        private readonly Lazy<ReadOnlyObjectProperty<bool>> _isDataDamageAmountModified;
        private readonly Lazy<ObjectProperty<float>> _dataDamagePeriod;
        private readonly Lazy<ReadOnlyObjectProperty<bool>> _isDataDamagePeriodModified;
        private readonly Lazy<ObjectProperty<float>> _dataDamagePenalty;
        private readonly Lazy<ReadOnlyObjectProperty<bool>> _isDataDamagePenaltyModified;
        private readonly Lazy<ObjectProperty<float>> _dataData_Nso4;
        private readonly Lazy<ReadOnlyObjectProperty<bool>> _isDataData_Nso4Modified;
        private readonly Lazy<ObjectProperty<float>> _dataData_Nso5;
        private readonly Lazy<ReadOnlyObjectProperty<bool>> _isDataData_Nso5Modified;
        public FirelordSoulBurn(): base(1869827649)
        {
            _dataDamageAmount = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamageAmount, SetDataDamageAmount));
            _isDataDamageAmountModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataDamageAmountModified));
            _dataDamagePeriod = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamagePeriod, SetDataDamagePeriod));
            _isDataDamagePeriodModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataDamagePeriodModified));
            _dataDamagePenalty = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamagePenalty, SetDataDamagePenalty));
            _isDataDamagePenaltyModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataDamagePenaltyModified));
            _dataData_Nso4 = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataData_Nso4, SetDataData_Nso4));
            _isDataData_Nso4Modified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataData_Nso4Modified));
            _dataData_Nso5 = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataData_Nso5, SetDataData_Nso5));
            _isDataData_Nso5Modified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataData_Nso5Modified));
        }

        public FirelordSoulBurn(int newId): base(1869827649, newId)
        {
            _dataDamageAmount = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamageAmount, SetDataDamageAmount));
            _isDataDamageAmountModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataDamageAmountModified));
            _dataDamagePeriod = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamagePeriod, SetDataDamagePeriod));
            _isDataDamagePeriodModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataDamagePeriodModified));
            _dataDamagePenalty = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamagePenalty, SetDataDamagePenalty));
            _isDataDamagePenaltyModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataDamagePenaltyModified));
            _dataData_Nso4 = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataData_Nso4, SetDataData_Nso4));
            _isDataData_Nso4Modified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataData_Nso4Modified));
            _dataData_Nso5 = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataData_Nso5, SetDataData_Nso5));
            _isDataData_Nso5Modified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataData_Nso5Modified));
        }

        public FirelordSoulBurn(string newRawcode): base(1869827649, newRawcode)
        {
            _dataDamageAmount = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamageAmount, SetDataDamageAmount));
            _isDataDamageAmountModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataDamageAmountModified));
            _dataDamagePeriod = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamagePeriod, SetDataDamagePeriod));
            _isDataDamagePeriodModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataDamagePeriodModified));
            _dataDamagePenalty = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamagePenalty, SetDataDamagePenalty));
            _isDataDamagePenaltyModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataDamagePenaltyModified));
            _dataData_Nso4 = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataData_Nso4, SetDataData_Nso4));
            _isDataData_Nso4Modified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataData_Nso4Modified));
            _dataData_Nso5 = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataData_Nso5, SetDataData_Nso5));
            _isDataData_Nso5Modified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataData_Nso5Modified));
        }

        public FirelordSoulBurn(ObjectDatabaseBase db): base(1869827649, db)
        {
            _dataDamageAmount = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamageAmount, SetDataDamageAmount));
            _isDataDamageAmountModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataDamageAmountModified));
            _dataDamagePeriod = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamagePeriod, SetDataDamagePeriod));
            _isDataDamagePeriodModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataDamagePeriodModified));
            _dataDamagePenalty = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamagePenalty, SetDataDamagePenalty));
            _isDataDamagePenaltyModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataDamagePenaltyModified));
            _dataData_Nso4 = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataData_Nso4, SetDataData_Nso4));
            _isDataData_Nso4Modified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataData_Nso4Modified));
            _dataData_Nso5 = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataData_Nso5, SetDataData_Nso5));
            _isDataData_Nso5Modified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataData_Nso5Modified));
        }

        public FirelordSoulBurn(int newId, ObjectDatabaseBase db): base(1869827649, newId, db)
        {
            _dataDamageAmount = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamageAmount, SetDataDamageAmount));
            _isDataDamageAmountModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataDamageAmountModified));
            _dataDamagePeriod = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamagePeriod, SetDataDamagePeriod));
            _isDataDamagePeriodModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataDamagePeriodModified));
            _dataDamagePenalty = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamagePenalty, SetDataDamagePenalty));
            _isDataDamagePenaltyModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataDamagePenaltyModified));
            _dataData_Nso4 = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataData_Nso4, SetDataData_Nso4));
            _isDataData_Nso4Modified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataData_Nso4Modified));
            _dataData_Nso5 = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataData_Nso5, SetDataData_Nso5));
            _isDataData_Nso5Modified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataData_Nso5Modified));
        }

        public FirelordSoulBurn(string newRawcode, ObjectDatabaseBase db): base(1869827649, newRawcode, db)
        {
            _dataDamageAmount = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamageAmount, SetDataDamageAmount));
            _isDataDamageAmountModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataDamageAmountModified));
            _dataDamagePeriod = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamagePeriod, SetDataDamagePeriod));
            _isDataDamagePeriodModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataDamagePeriodModified));
            _dataDamagePenalty = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamagePenalty, SetDataDamagePenalty));
            _isDataDamagePenaltyModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataDamagePenaltyModified));
            _dataData_Nso4 = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataData_Nso4, SetDataData_Nso4));
            _isDataData_Nso4Modified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataData_Nso4Modified));
            _dataData_Nso5 = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataData_Nso5, SetDataData_Nso5));
            _isDataData_Nso5Modified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataData_Nso5Modified));
        }

        public ObjectProperty<float> DataDamageAmount => _dataDamageAmount.Value;
        public ReadOnlyObjectProperty<bool> IsDataDamageAmountModified => _isDataDamageAmountModified.Value;
        public ObjectProperty<float> DataDamagePeriod => _dataDamagePeriod.Value;
        public ReadOnlyObjectProperty<bool> IsDataDamagePeriodModified => _isDataDamagePeriodModified.Value;
        public ObjectProperty<float> DataDamagePenalty => _dataDamagePenalty.Value;
        public ReadOnlyObjectProperty<bool> IsDataDamagePenaltyModified => _isDataDamagePenaltyModified.Value;
        public ObjectProperty<float> DataData_Nso4 => _dataData_Nso4.Value;
        public ReadOnlyObjectProperty<bool> IsDataData_Nso4Modified => _isDataData_Nso4Modified.Value;
        public ObjectProperty<float> DataData_Nso5 => _dataData_Nso5.Value;
        public ReadOnlyObjectProperty<bool> IsDataData_Nso5Modified => _isDataData_Nso5Modified.Value;
        private float GetDataDamageAmount(int level)
        {
            return _modifications.GetModification(829387598, level).ValueAsFloat;
        }

        private void SetDataDamageAmount(int level, float value)
        {
            _modifications[829387598, level] = new LevelObjectDataModification{Id = 829387598, Type = ObjectDataType.Unreal, Value = value, Level = level, Pointer = 1};
        }

        private bool GetIsDataDamageAmountModified(int level)
        {
            return _modifications.ContainsKey(829387598, level);
        }

        private float GetDataDamagePeriod(int level)
        {
            return _modifications.GetModification(846164814, level).ValueAsFloat;
        }

        private void SetDataDamagePeriod(int level, float value)
        {
            _modifications[846164814, level] = new LevelObjectDataModification{Id = 846164814, Type = ObjectDataType.Unreal, Value = value, Level = level, Pointer = 2};
        }

        private bool GetIsDataDamagePeriodModified(int level)
        {
            return _modifications.ContainsKey(846164814, level);
        }

        private float GetDataDamagePenalty(int level)
        {
            return _modifications.GetModification(862942030, level).ValueAsFloat;
        }

        private void SetDataDamagePenalty(int level, float value)
        {
            _modifications[862942030, level] = new LevelObjectDataModification{Id = 862942030, Type = ObjectDataType.Unreal, Value = value, Level = level, Pointer = 3};
        }

        private bool GetIsDataDamagePenaltyModified(int level)
        {
            return _modifications.ContainsKey(862942030, level);
        }

        private float GetDataData_Nso4(int level)
        {
            return _modifications.GetModification(879719246, level).ValueAsFloat;
        }

        private void SetDataData_Nso4(int level, float value)
        {
            _modifications[879719246, level] = new LevelObjectDataModification{Id = 879719246, Type = ObjectDataType.Unreal, Value = value, Level = level, Pointer = 4};
        }

        private bool GetIsDataData_Nso4Modified(int level)
        {
            return _modifications.ContainsKey(879719246, level);
        }

        private float GetDataData_Nso5(int level)
        {
            return _modifications.GetModification(896496462, level).ValueAsFloat;
        }

        private void SetDataData_Nso5(int level, float value)
        {
            _modifications[896496462, level] = new LevelObjectDataModification{Id = 896496462, Type = ObjectDataType.Unreal, Value = value, Level = level, Pointer = 5};
        }

        private bool GetIsDataData_Nso5Modified(int level)
        {
            return _modifications.ContainsKey(896496462, level);
        }
    }
}