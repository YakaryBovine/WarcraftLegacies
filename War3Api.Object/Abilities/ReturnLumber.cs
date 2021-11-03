using System;
using System.Collections.Generic;
using System.Linq;
using War3Api.Object.Abilities;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class ReturnLumber : Ability
    {
        private readonly Lazy<ObjectProperty<bool>> _dataAcceptsGold;
        private readonly Lazy<ReadOnlyObjectProperty<bool>> _isDataAcceptsGoldModified;
        private readonly Lazy<ObjectProperty<bool>> _dataAcceptsLumber;
        private readonly Lazy<ReadOnlyObjectProperty<bool>> _isDataAcceptsLumberModified;
        public ReturnLumber(): base(1835823681)
        {
            _dataAcceptsGold = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataAcceptsGold, SetDataAcceptsGold));
            _isDataAcceptsGoldModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataAcceptsGoldModified));
            _dataAcceptsLumber = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataAcceptsLumber, SetDataAcceptsLumber));
            _isDataAcceptsLumberModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataAcceptsLumberModified));
        }

        public ReturnLumber(int newId): base(1835823681, newId)
        {
            _dataAcceptsGold = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataAcceptsGold, SetDataAcceptsGold));
            _isDataAcceptsGoldModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataAcceptsGoldModified));
            _dataAcceptsLumber = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataAcceptsLumber, SetDataAcceptsLumber));
            _isDataAcceptsLumberModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataAcceptsLumberModified));
        }

        public ReturnLumber(string newRawcode): base(1835823681, newRawcode)
        {
            _dataAcceptsGold = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataAcceptsGold, SetDataAcceptsGold));
            _isDataAcceptsGoldModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataAcceptsGoldModified));
            _dataAcceptsLumber = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataAcceptsLumber, SetDataAcceptsLumber));
            _isDataAcceptsLumberModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataAcceptsLumberModified));
        }

        public ReturnLumber(ObjectDatabase db): base(1835823681, db)
        {
            _dataAcceptsGold = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataAcceptsGold, SetDataAcceptsGold));
            _isDataAcceptsGoldModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataAcceptsGoldModified));
            _dataAcceptsLumber = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataAcceptsLumber, SetDataAcceptsLumber));
            _isDataAcceptsLumberModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataAcceptsLumberModified));
        }

        public ReturnLumber(int newId, ObjectDatabase db): base(1835823681, newId, db)
        {
            _dataAcceptsGold = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataAcceptsGold, SetDataAcceptsGold));
            _isDataAcceptsGoldModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataAcceptsGoldModified));
            _dataAcceptsLumber = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataAcceptsLumber, SetDataAcceptsLumber));
            _isDataAcceptsLumberModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataAcceptsLumberModified));
        }

        public ReturnLumber(string newRawcode, ObjectDatabase db): base(1835823681, newRawcode, db)
        {
            _dataAcceptsGold = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataAcceptsGold, SetDataAcceptsGold));
            _isDataAcceptsGoldModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataAcceptsGoldModified));
            _dataAcceptsLumber = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataAcceptsLumber, SetDataAcceptsLumber));
            _isDataAcceptsLumberModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataAcceptsLumberModified));
        }

        public ObjectProperty<bool> DataAcceptsGold => _dataAcceptsGold.Value;
        public ReadOnlyObjectProperty<bool> IsDataAcceptsGoldModified => _isDataAcceptsGoldModified.Value;
        public ObjectProperty<bool> DataAcceptsLumber => _dataAcceptsLumber.Value;
        public ReadOnlyObjectProperty<bool> IsDataAcceptsLumberModified => _isDataAcceptsLumberModified.Value;
        private bool GetDataAcceptsGold(int level)
        {
            return _modifications[829322322, level].ValueAsBool;
        }

        private void SetDataAcceptsGold(int level, bool value)
        {
            _modifications[829322322, level] = new LevelObjectDataModification{Id = 829322322, Type = ObjectDataType.Bool, Value = value, Level = level, Pointer = 1};
        }

        private bool GetIsDataAcceptsGoldModified(int level)
        {
            return _modifications.ContainsKey(829322322, level);
        }

        private bool GetDataAcceptsLumber(int level)
        {
            return _modifications[846099538, level].ValueAsBool;
        }

        private void SetDataAcceptsLumber(int level, bool value)
        {
            _modifications[846099538, level] = new LevelObjectDataModification{Id = 846099538, Type = ObjectDataType.Bool, Value = value, Level = level, Pointer = 2};
        }

        private bool GetIsDataAcceptsLumberModified(int level)
        {
            return _modifications.ContainsKey(846099538, level);
        }
    }
}