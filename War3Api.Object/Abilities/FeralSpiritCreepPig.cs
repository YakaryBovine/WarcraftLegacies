using System;
using System.Collections.Generic;
using System.Linq;
using War3Api.Object.Abilities;
using War3Api.Object.Enums;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class FeralSpiritCreepPig : Ability
    {
        private readonly Lazy<ObjectProperty<string>> _dataSummonedUnitRaw;
        private readonly Lazy<ReadOnlyObjectProperty<bool>> _isDataSummonedUnitModified;
        private readonly Lazy<ObjectProperty<Unit>> _dataSummonedUnit;
        private readonly Lazy<ObjectProperty<int>> _dataNumberOfSummonedUnits;
        private readonly Lazy<ReadOnlyObjectProperty<bool>> _isDataNumberOfSummonedUnitsModified;
        public FeralSpiritCreepPig(): base(963855169)
        {
            _dataSummonedUnitRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataSummonedUnitRaw, SetDataSummonedUnitRaw));
            _isDataSummonedUnitModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataSummonedUnitModified));
            _dataSummonedUnit = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataSummonedUnit, SetDataSummonedUnit));
            _dataNumberOfSummonedUnits = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataNumberOfSummonedUnits, SetDataNumberOfSummonedUnits));
            _isDataNumberOfSummonedUnitsModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataNumberOfSummonedUnitsModified));
        }

        public FeralSpiritCreepPig(int newId): base(963855169, newId)
        {
            _dataSummonedUnitRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataSummonedUnitRaw, SetDataSummonedUnitRaw));
            _isDataSummonedUnitModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataSummonedUnitModified));
            _dataSummonedUnit = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataSummonedUnit, SetDataSummonedUnit));
            _dataNumberOfSummonedUnits = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataNumberOfSummonedUnits, SetDataNumberOfSummonedUnits));
            _isDataNumberOfSummonedUnitsModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataNumberOfSummonedUnitsModified));
        }

        public FeralSpiritCreepPig(string newRawcode): base(963855169, newRawcode)
        {
            _dataSummonedUnitRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataSummonedUnitRaw, SetDataSummonedUnitRaw));
            _isDataSummonedUnitModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataSummonedUnitModified));
            _dataSummonedUnit = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataSummonedUnit, SetDataSummonedUnit));
            _dataNumberOfSummonedUnits = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataNumberOfSummonedUnits, SetDataNumberOfSummonedUnits));
            _isDataNumberOfSummonedUnitsModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataNumberOfSummonedUnitsModified));
        }

        public FeralSpiritCreepPig(ObjectDatabase db): base(963855169, db)
        {
            _dataSummonedUnitRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataSummonedUnitRaw, SetDataSummonedUnitRaw));
            _isDataSummonedUnitModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataSummonedUnitModified));
            _dataSummonedUnit = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataSummonedUnit, SetDataSummonedUnit));
            _dataNumberOfSummonedUnits = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataNumberOfSummonedUnits, SetDataNumberOfSummonedUnits));
            _isDataNumberOfSummonedUnitsModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataNumberOfSummonedUnitsModified));
        }

        public FeralSpiritCreepPig(int newId, ObjectDatabase db): base(963855169, newId, db)
        {
            _dataSummonedUnitRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataSummonedUnitRaw, SetDataSummonedUnitRaw));
            _isDataSummonedUnitModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataSummonedUnitModified));
            _dataSummonedUnit = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataSummonedUnit, SetDataSummonedUnit));
            _dataNumberOfSummonedUnits = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataNumberOfSummonedUnits, SetDataNumberOfSummonedUnits));
            _isDataNumberOfSummonedUnitsModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataNumberOfSummonedUnitsModified));
        }

        public FeralSpiritCreepPig(string newRawcode, ObjectDatabase db): base(963855169, newRawcode, db)
        {
            _dataSummonedUnitRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataSummonedUnitRaw, SetDataSummonedUnitRaw));
            _isDataSummonedUnitModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataSummonedUnitModified));
            _dataSummonedUnit = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataSummonedUnit, SetDataSummonedUnit));
            _dataNumberOfSummonedUnits = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataNumberOfSummonedUnits, SetDataNumberOfSummonedUnits));
            _isDataNumberOfSummonedUnitsModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataNumberOfSummonedUnitsModified));
        }

        public ObjectProperty<string> DataSummonedUnitRaw => _dataSummonedUnitRaw.Value;
        public ReadOnlyObjectProperty<bool> IsDataSummonedUnitModified => _isDataSummonedUnitModified.Value;
        public ObjectProperty<Unit> DataSummonedUnit => _dataSummonedUnit.Value;
        public ObjectProperty<int> DataNumberOfSummonedUnits => _dataNumberOfSummonedUnits.Value;
        public ReadOnlyObjectProperty<bool> IsDataNumberOfSummonedUnitsModified => _isDataNumberOfSummonedUnitsModified.Value;
        private string GetDataSummonedUnitRaw(int level)
        {
            return _modifications[828797775, level].ValueAsString;
        }

        private void SetDataSummonedUnitRaw(int level, string value)
        {
            _modifications[828797775, level] = new LevelObjectDataModification{Id = 828797775, Type = ObjectDataType.String, Value = value, Level = level};
        }

        private bool GetIsDataSummonedUnitModified(int level)
        {
            return _modifications.ContainsKey(828797775, level);
        }

        private Unit GetDataSummonedUnit(int level)
        {
            return GetDataSummonedUnitRaw(level).ToUnit(this);
        }

        private void SetDataSummonedUnit(int level, Unit value)
        {
            SetDataSummonedUnitRaw(level, value.ToRaw(null, null));
        }

        private int GetDataNumberOfSummonedUnits(int level)
        {
            return _modifications[845574991, level].ValueAsInt;
        }

        private void SetDataNumberOfSummonedUnits(int level, int value)
        {
            _modifications[845574991, level] = new LevelObjectDataModification{Id = 845574991, Type = ObjectDataType.Int, Value = value, Level = level, Pointer = 2};
        }

        private bool GetIsDataNumberOfSummonedUnitsModified(int level)
        {
            return _modifications.ContainsKey(845574991, level);
        }
    }
}