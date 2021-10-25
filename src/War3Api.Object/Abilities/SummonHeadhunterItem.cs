using System;
using System.Collections.Generic;
using System.Linq;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class SummonHeadhunterItem : Ability
    {
        private readonly Lazy<ObjectProperty<string>> _dataSummonedUnitRaw;
        private readonly Lazy<ObjectProperty<Unit>> _dataSummonedUnit;
        private readonly Lazy<ObjectProperty<int>> _dataNumberOfSummonedUnits;
        public SummonHeadhunterItem(): base(1752385857)
        {
            _dataSummonedUnitRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataSummonedUnitRaw, SetDataSummonedUnitRaw));
            _dataSummonedUnit = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataSummonedUnit, SetDataSummonedUnit));
            _dataNumberOfSummonedUnits = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataNumberOfSummonedUnits, SetDataNumberOfSummonedUnits));
        }

        public SummonHeadhunterItem(int newId): base(1752385857, newId)
        {
            _dataSummonedUnitRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataSummonedUnitRaw, SetDataSummonedUnitRaw));
            _dataSummonedUnit = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataSummonedUnit, SetDataSummonedUnit));
            _dataNumberOfSummonedUnits = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataNumberOfSummonedUnits, SetDataNumberOfSummonedUnits));
        }

        public SummonHeadhunterItem(string newRawcode): base(1752385857, newRawcode)
        {
            _dataSummonedUnitRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataSummonedUnitRaw, SetDataSummonedUnitRaw));
            _dataSummonedUnit = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataSummonedUnit, SetDataSummonedUnit));
            _dataNumberOfSummonedUnits = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataNumberOfSummonedUnits, SetDataNumberOfSummonedUnits));
        }

        public SummonHeadhunterItem(ObjectDatabase db): base(1752385857, db)
        {
            _dataSummonedUnitRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataSummonedUnitRaw, SetDataSummonedUnitRaw));
            _dataSummonedUnit = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataSummonedUnit, SetDataSummonedUnit));
            _dataNumberOfSummonedUnits = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataNumberOfSummonedUnits, SetDataNumberOfSummonedUnits));
        }

        public SummonHeadhunterItem(int newId, ObjectDatabase db): base(1752385857, newId, db)
        {
            _dataSummonedUnitRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataSummonedUnitRaw, SetDataSummonedUnitRaw));
            _dataSummonedUnit = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataSummonedUnit, SetDataSummonedUnit));
            _dataNumberOfSummonedUnits = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataNumberOfSummonedUnits, SetDataNumberOfSummonedUnits));
        }

        public SummonHeadhunterItem(string newRawcode, ObjectDatabase db): base(1752385857, newRawcode, db)
        {
            _dataSummonedUnitRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataSummonedUnitRaw, SetDataSummonedUnitRaw));
            _dataSummonedUnit = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataSummonedUnit, SetDataSummonedUnit));
            _dataNumberOfSummonedUnits = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataNumberOfSummonedUnits, SetDataNumberOfSummonedUnits));
        }

        public ObjectProperty<string> DataSummonedUnitRaw => _dataSummonedUnitRaw.Value;
        public ObjectProperty<Unit> DataSummonedUnit => _dataSummonedUnit.Value;
        public ObjectProperty<int> DataNumberOfSummonedUnits => _dataNumberOfSummonedUnits.Value;
        private string GetDataSummonedUnitRaw(int level)
        {
            return _modifications[828797775, level].ValueAsString;
        }

        private void SetDataSummonedUnitRaw(int level, string value)
        {
            _modifications[828797775, level] = new LevelObjectDataModification{Id = 828797775, Type = ObjectDataType.String, Value = value, Level = level};
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
    }
}