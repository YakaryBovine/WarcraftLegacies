using System;
using System.Collections.Generic;
using System.Linq;
using War3Api.Object.Abilities;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class BlightGrowthSmall : Ability
    {
        private readonly Lazy<ObjectProperty<float>> _dataExpansionAmount;
        private readonly Lazy<ReadOnlyObjectProperty<bool>> _isDataExpansionAmountModified;
        private readonly Lazy<ObjectProperty<bool>> _dataCreatesBlight;
        private readonly Lazy<ReadOnlyObjectProperty<bool>> _isDataCreatesBlightModified;
        public BlightGrowthSmall(): base(1936155201)
        {
            _dataExpansionAmount = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataExpansionAmount, SetDataExpansionAmount));
            _isDataExpansionAmountModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataExpansionAmountModified));
            _dataCreatesBlight = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataCreatesBlight, SetDataCreatesBlight));
            _isDataCreatesBlightModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataCreatesBlightModified));
        }

        public BlightGrowthSmall(int newId): base(1936155201, newId)
        {
            _dataExpansionAmount = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataExpansionAmount, SetDataExpansionAmount));
            _isDataExpansionAmountModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataExpansionAmountModified));
            _dataCreatesBlight = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataCreatesBlight, SetDataCreatesBlight));
            _isDataCreatesBlightModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataCreatesBlightModified));
        }

        public BlightGrowthSmall(string newRawcode): base(1936155201, newRawcode)
        {
            _dataExpansionAmount = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataExpansionAmount, SetDataExpansionAmount));
            _isDataExpansionAmountModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataExpansionAmountModified));
            _dataCreatesBlight = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataCreatesBlight, SetDataCreatesBlight));
            _isDataCreatesBlightModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataCreatesBlightModified));
        }

        public BlightGrowthSmall(ObjectDatabase db): base(1936155201, db)
        {
            _dataExpansionAmount = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataExpansionAmount, SetDataExpansionAmount));
            _isDataExpansionAmountModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataExpansionAmountModified));
            _dataCreatesBlight = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataCreatesBlight, SetDataCreatesBlight));
            _isDataCreatesBlightModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataCreatesBlightModified));
        }

        public BlightGrowthSmall(int newId, ObjectDatabase db): base(1936155201, newId, db)
        {
            _dataExpansionAmount = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataExpansionAmount, SetDataExpansionAmount));
            _isDataExpansionAmountModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataExpansionAmountModified));
            _dataCreatesBlight = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataCreatesBlight, SetDataCreatesBlight));
            _isDataCreatesBlightModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataCreatesBlightModified));
        }

        public BlightGrowthSmall(string newRawcode, ObjectDatabase db): base(1936155201, newRawcode, db)
        {
            _dataExpansionAmount = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataExpansionAmount, SetDataExpansionAmount));
            _isDataExpansionAmountModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataExpansionAmountModified));
            _dataCreatesBlight = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataCreatesBlight, SetDataCreatesBlight));
            _isDataCreatesBlightModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataCreatesBlightModified));
        }

        public ObjectProperty<float> DataExpansionAmount => _dataExpansionAmount.Value;
        public ReadOnlyObjectProperty<bool> IsDataExpansionAmountModified => _isDataExpansionAmountModified.Value;
        public ObjectProperty<bool> DataCreatesBlight => _dataCreatesBlight.Value;
        public ReadOnlyObjectProperty<bool> IsDataCreatesBlightModified => _isDataCreatesBlightModified.Value;
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

        private bool GetDataCreatesBlight(int level)
        {
            return _modifications[845769794, level].ValueAsBool;
        }

        private void SetDataCreatesBlight(int level, bool value)
        {
            _modifications[845769794, level] = new LevelObjectDataModification{Id = 845769794, Type = ObjectDataType.Bool, Value = value, Level = level, Pointer = 2};
        }

        private bool GetIsDataCreatesBlightModified(int level)
        {
            return _modifications.ContainsKey(845769794, level);
        }
    }
}