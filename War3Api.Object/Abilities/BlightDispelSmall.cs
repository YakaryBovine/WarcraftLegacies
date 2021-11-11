using System;
using System.Collections.Generic;
using System.Linq;
using War3Api.Object.Abilities;
using War3Api.Object.Enums;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class BlightDispelSmall : Ability
    {
        private readonly Lazy<ObjectProperty<float>> _dataExpansionAmount;
        private readonly Lazy<ReadOnlyObjectProperty<bool>> _isDataExpansionAmountModified;
        private readonly Lazy<ObjectProperty<int>> _dataCreatesBlightRaw;
        private readonly Lazy<ReadOnlyObjectProperty<bool>> _isDataCreatesBlightModified;
        private readonly Lazy<ObjectProperty<bool>> _dataCreatesBlight;
        public BlightDispelSmall(): base(1935958593)
        {
            _dataExpansionAmount = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataExpansionAmount, SetDataExpansionAmount));
            _isDataExpansionAmountModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataExpansionAmountModified));
            _dataCreatesBlightRaw = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataCreatesBlightRaw, SetDataCreatesBlightRaw));
            _isDataCreatesBlightModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataCreatesBlightModified));
            _dataCreatesBlight = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataCreatesBlight, SetDataCreatesBlight));
        }

        public BlightDispelSmall(int newId): base(1935958593, newId)
        {
            _dataExpansionAmount = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataExpansionAmount, SetDataExpansionAmount));
            _isDataExpansionAmountModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataExpansionAmountModified));
            _dataCreatesBlightRaw = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataCreatesBlightRaw, SetDataCreatesBlightRaw));
            _isDataCreatesBlightModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataCreatesBlightModified));
            _dataCreatesBlight = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataCreatesBlight, SetDataCreatesBlight));
        }

        public BlightDispelSmall(string newRawcode): base(1935958593, newRawcode)
        {
            _dataExpansionAmount = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataExpansionAmount, SetDataExpansionAmount));
            _isDataExpansionAmountModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataExpansionAmountModified));
            _dataCreatesBlightRaw = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataCreatesBlightRaw, SetDataCreatesBlightRaw));
            _isDataCreatesBlightModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataCreatesBlightModified));
            _dataCreatesBlight = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataCreatesBlight, SetDataCreatesBlight));
        }

        public BlightDispelSmall(ObjectDatabase db): base(1935958593, db)
        {
            _dataExpansionAmount = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataExpansionAmount, SetDataExpansionAmount));
            _isDataExpansionAmountModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataExpansionAmountModified));
            _dataCreatesBlightRaw = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataCreatesBlightRaw, SetDataCreatesBlightRaw));
            _isDataCreatesBlightModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataCreatesBlightModified));
            _dataCreatesBlight = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataCreatesBlight, SetDataCreatesBlight));
        }

        public BlightDispelSmall(int newId, ObjectDatabase db): base(1935958593, newId, db)
        {
            _dataExpansionAmount = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataExpansionAmount, SetDataExpansionAmount));
            _isDataExpansionAmountModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataExpansionAmountModified));
            _dataCreatesBlightRaw = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataCreatesBlightRaw, SetDataCreatesBlightRaw));
            _isDataCreatesBlightModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataCreatesBlightModified));
            _dataCreatesBlight = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataCreatesBlight, SetDataCreatesBlight));
        }

        public BlightDispelSmall(string newRawcode, ObjectDatabase db): base(1935958593, newRawcode, db)
        {
            _dataExpansionAmount = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataExpansionAmount, SetDataExpansionAmount));
            _isDataExpansionAmountModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataExpansionAmountModified));
            _dataCreatesBlightRaw = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataCreatesBlightRaw, SetDataCreatesBlightRaw));
            _isDataCreatesBlightModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataCreatesBlightModified));
            _dataCreatesBlight = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataCreatesBlight, SetDataCreatesBlight));
        }

        public ObjectProperty<float> DataExpansionAmount => _dataExpansionAmount.Value;
        public ReadOnlyObjectProperty<bool> IsDataExpansionAmountModified => _isDataExpansionAmountModified.Value;
        public ObjectProperty<int> DataCreatesBlightRaw => _dataCreatesBlightRaw.Value;
        public ReadOnlyObjectProperty<bool> IsDataCreatesBlightModified => _isDataCreatesBlightModified.Value;
        public ObjectProperty<bool> DataCreatesBlight => _dataCreatesBlight.Value;
        private float GetDataExpansionAmount(int level)
        {
            return _modifications[828992578, level].ValueAsFloat;
        }

        private void SetDataExpansionAmount(int level, float value)
        {
            _modifications[828992578, level] = new LevelObjectDataModification{Id = 828992578, Type = ObjectDataType.Unreal, Value = value, Level = level, Pointer = 1};
        }

        private bool GetIsDataExpansionAmountModified(int level)
        {
            return _modifications.ContainsKey(828992578, level);
        }

        private int GetDataCreatesBlightRaw(int level)
        {
            return _modifications[845769794, level].ValueAsInt;
        }

        private void SetDataCreatesBlightRaw(int level, int value)
        {
            _modifications[845769794, level] = new LevelObjectDataModification{Id = 845769794, Type = ObjectDataType.Int, Value = value, Level = level, Pointer = 2};
        }

        private bool GetIsDataCreatesBlightModified(int level)
        {
            return _modifications.ContainsKey(845769794, level);
        }

        private bool GetDataCreatesBlight(int level)
        {
            return GetDataCreatesBlightRaw(level).ToBool(this);
        }

        private void SetDataCreatesBlight(int level, bool value)
        {
            SetDataCreatesBlightRaw(level, value.ToRaw(0, 1));
        }
    }
}