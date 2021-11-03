using System;
using System.Collections.Generic;
using System.Linq;
using War3Api.Object.Abilities;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class NullRoarSummoner : Ability
    {
        private readonly Lazy<ObjectProperty<float>> _dataManaRegen;
        private readonly Lazy<ReadOnlyObjectProperty<bool>> _isDataManaRegenModified;
        private readonly Lazy<ObjectProperty<bool>> _dataPreferHostiles;
        private readonly Lazy<ReadOnlyObjectProperty<bool>> _isDataPreferHostilesModified;
        private readonly Lazy<ObjectProperty<bool>> _dataPreferFriendlies;
        private readonly Lazy<ReadOnlyObjectProperty<bool>> _isDataPreferFriendliesModified;
        private readonly Lazy<ObjectProperty<int>> _dataMaxUnits;
        private readonly Lazy<ReadOnlyObjectProperty<bool>> _isDataMaxUnitsModified;
        public NullRoarSummoner(): base(1819174977)
        {
            _dataManaRegen = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataManaRegen, SetDataManaRegen));
            _isDataManaRegenModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataManaRegenModified));
            _dataPreferHostiles = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataPreferHostiles, SetDataPreferHostiles));
            _isDataPreferHostilesModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataPreferHostilesModified));
            _dataPreferFriendlies = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataPreferFriendlies, SetDataPreferFriendlies));
            _isDataPreferFriendliesModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataPreferFriendliesModified));
            _dataMaxUnits = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataMaxUnits, SetDataMaxUnits));
            _isDataMaxUnitsModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataMaxUnitsModified));
        }

        public NullRoarSummoner(int newId): base(1819174977, newId)
        {
            _dataManaRegen = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataManaRegen, SetDataManaRegen));
            _isDataManaRegenModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataManaRegenModified));
            _dataPreferHostiles = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataPreferHostiles, SetDataPreferHostiles));
            _isDataPreferHostilesModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataPreferHostilesModified));
            _dataPreferFriendlies = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataPreferFriendlies, SetDataPreferFriendlies));
            _isDataPreferFriendliesModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataPreferFriendliesModified));
            _dataMaxUnits = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataMaxUnits, SetDataMaxUnits));
            _isDataMaxUnitsModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataMaxUnitsModified));
        }

        public NullRoarSummoner(string newRawcode): base(1819174977, newRawcode)
        {
            _dataManaRegen = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataManaRegen, SetDataManaRegen));
            _isDataManaRegenModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataManaRegenModified));
            _dataPreferHostiles = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataPreferHostiles, SetDataPreferHostiles));
            _isDataPreferHostilesModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataPreferHostilesModified));
            _dataPreferFriendlies = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataPreferFriendlies, SetDataPreferFriendlies));
            _isDataPreferFriendliesModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataPreferFriendliesModified));
            _dataMaxUnits = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataMaxUnits, SetDataMaxUnits));
            _isDataMaxUnitsModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataMaxUnitsModified));
        }

        public NullRoarSummoner(ObjectDatabase db): base(1819174977, db)
        {
            _dataManaRegen = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataManaRegen, SetDataManaRegen));
            _isDataManaRegenModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataManaRegenModified));
            _dataPreferHostiles = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataPreferHostiles, SetDataPreferHostiles));
            _isDataPreferHostilesModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataPreferHostilesModified));
            _dataPreferFriendlies = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataPreferFriendlies, SetDataPreferFriendlies));
            _isDataPreferFriendliesModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataPreferFriendliesModified));
            _dataMaxUnits = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataMaxUnits, SetDataMaxUnits));
            _isDataMaxUnitsModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataMaxUnitsModified));
        }

        public NullRoarSummoner(int newId, ObjectDatabase db): base(1819174977, newId, db)
        {
            _dataManaRegen = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataManaRegen, SetDataManaRegen));
            _isDataManaRegenModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataManaRegenModified));
            _dataPreferHostiles = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataPreferHostiles, SetDataPreferHostiles));
            _isDataPreferHostilesModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataPreferHostilesModified));
            _dataPreferFriendlies = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataPreferFriendlies, SetDataPreferFriendlies));
            _isDataPreferFriendliesModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataPreferFriendliesModified));
            _dataMaxUnits = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataMaxUnits, SetDataMaxUnits));
            _isDataMaxUnitsModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataMaxUnitsModified));
        }

        public NullRoarSummoner(string newRawcode, ObjectDatabase db): base(1819174977, newRawcode, db)
        {
            _dataManaRegen = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataManaRegen, SetDataManaRegen));
            _isDataManaRegenModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataManaRegenModified));
            _dataPreferHostiles = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataPreferHostiles, SetDataPreferHostiles));
            _isDataPreferHostilesModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataPreferHostilesModified));
            _dataPreferFriendlies = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataPreferFriendlies, SetDataPreferFriendlies));
            _isDataPreferFriendliesModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataPreferFriendliesModified));
            _dataMaxUnits = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataMaxUnits, SetDataMaxUnits));
            _isDataMaxUnitsModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataMaxUnitsModified));
        }

        public ObjectProperty<float> DataManaRegen => _dataManaRegen.Value;
        public ReadOnlyObjectProperty<bool> IsDataManaRegenModified => _isDataManaRegenModified.Value;
        public ObjectProperty<bool> DataPreferHostiles => _dataPreferHostiles.Value;
        public ReadOnlyObjectProperty<bool> IsDataPreferHostilesModified => _isDataPreferHostilesModified.Value;
        public ObjectProperty<bool> DataPreferFriendlies => _dataPreferFriendlies.Value;
        public ReadOnlyObjectProperty<bool> IsDataPreferFriendliesModified => _isDataPreferFriendliesModified.Value;
        public ObjectProperty<int> DataMaxUnits => _dataMaxUnits.Value;
        public ReadOnlyObjectProperty<bool> IsDataMaxUnitsModified => _isDataMaxUnitsModified.Value;
        private float GetDataManaRegen(int level)
        {
            return _modifications[878800722, level].ValueAsFloat;
        }

        private void SetDataManaRegen(int level, float value)
        {
            _modifications[878800722, level] = new LevelObjectDataModification{Id = 878800722, Type = ObjectDataType.Unreal, Value = value, Level = level, Pointer = 4};
        }

        private bool GetIsDataManaRegenModified(int level)
        {
            return _modifications.ContainsKey(878800722, level);
        }

        private bool GetDataPreferHostiles(int level)
        {
            return _modifications[895577938, level].ValueAsBool;
        }

        private void SetDataPreferHostiles(int level, bool value)
        {
            _modifications[895577938, level] = new LevelObjectDataModification{Id = 895577938, Type = ObjectDataType.Bool, Value = value, Level = level, Pointer = 5};
        }

        private bool GetIsDataPreferHostilesModified(int level)
        {
            return _modifications.ContainsKey(895577938, level);
        }

        private bool GetDataPreferFriendlies(int level)
        {
            return _modifications[912355154, level].ValueAsBool;
        }

        private void SetDataPreferFriendlies(int level, bool value)
        {
            _modifications[912355154, level] = new LevelObjectDataModification{Id = 912355154, Type = ObjectDataType.Bool, Value = value, Level = level, Pointer = 6};
        }

        private bool GetIsDataPreferFriendliesModified(int level)
        {
            return _modifications.ContainsKey(912355154, level);
        }

        private int GetDataMaxUnits(int level)
        {
            return _modifications[929132370, level].ValueAsInt;
        }

        private void SetDataMaxUnits(int level, int value)
        {
            _modifications[929132370, level] = new LevelObjectDataModification{Id = 929132370, Type = ObjectDataType.Int, Value = value, Level = level, Pointer = 7};
        }

        private bool GetIsDataMaxUnitsModified(int level)
        {
            return _modifications.ContainsKey(929132370, level);
        }
    }
}