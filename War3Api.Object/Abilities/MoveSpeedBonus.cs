using System;
using System.Collections.Generic;
using System.Linq;
using War3Api.Object.Abilities;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class MoveSpeedBonus : Ability
    {
        private readonly Lazy<ObjectProperty<int>> _dataMovementSpeedBonus;
        private readonly Lazy<ReadOnlyObjectProperty<bool>> _isDataMovementSpeedBonusModified;
        public MoveSpeedBonus(): base(1936542017)
        {
            _dataMovementSpeedBonus = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataMovementSpeedBonus, SetDataMovementSpeedBonus));
            _isDataMovementSpeedBonusModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataMovementSpeedBonusModified));
        }

        public MoveSpeedBonus(int newId): base(1936542017, newId)
        {
            _dataMovementSpeedBonus = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataMovementSpeedBonus, SetDataMovementSpeedBonus));
            _isDataMovementSpeedBonusModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataMovementSpeedBonusModified));
        }

        public MoveSpeedBonus(string newRawcode): base(1936542017, newRawcode)
        {
            _dataMovementSpeedBonus = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataMovementSpeedBonus, SetDataMovementSpeedBonus));
            _isDataMovementSpeedBonusModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataMovementSpeedBonusModified));
        }

        public MoveSpeedBonus(ObjectDatabase db): base(1936542017, db)
        {
            _dataMovementSpeedBonus = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataMovementSpeedBonus, SetDataMovementSpeedBonus));
            _isDataMovementSpeedBonusModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataMovementSpeedBonusModified));
        }

        public MoveSpeedBonus(int newId, ObjectDatabase db): base(1936542017, newId, db)
        {
            _dataMovementSpeedBonus = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataMovementSpeedBonus, SetDataMovementSpeedBonus));
            _isDataMovementSpeedBonusModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataMovementSpeedBonusModified));
        }

        public MoveSpeedBonus(string newRawcode, ObjectDatabase db): base(1936542017, newRawcode, db)
        {
            _dataMovementSpeedBonus = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataMovementSpeedBonus, SetDataMovementSpeedBonus));
            _isDataMovementSpeedBonusModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataMovementSpeedBonusModified));
        }

        public ObjectProperty<int> DataMovementSpeedBonus => _dataMovementSpeedBonus.Value;
        public ReadOnlyObjectProperty<bool> IsDataMovementSpeedBonusModified => _isDataMovementSpeedBonusModified.Value;
        private int GetDataMovementSpeedBonus(int level)
        {
            return _modifications[1651928393, level].ValueAsInt;
        }

        private void SetDataMovementSpeedBonus(int level, int value)
        {
            _modifications[1651928393, level] = new LevelObjectDataModification{Id = 1651928393, Type = ObjectDataType.Int, Value = value, Level = level, Pointer = 1};
        }

        private bool GetIsDataMovementSpeedBonusModified(int level)
        {
            return _modifications.ContainsKey(1651928393, level);
        }
    }
}