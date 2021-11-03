using System;
using System.Collections.Generic;
using System.Linq;
using War3Api.Object.Abilities;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class PermanentInvisibility : Ability
    {
        private readonly Lazy<ObjectProperty<bool>> _dataAutoAcquireAttackTargets;
        private readonly Lazy<ReadOnlyObjectProperty<bool>> _isDataAutoAcquireAttackTargetsModified;
        public PermanentInvisibility(): base(1986621505)
        {
            _dataAutoAcquireAttackTargets = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataAutoAcquireAttackTargets, SetDataAutoAcquireAttackTargets));
            _isDataAutoAcquireAttackTargetsModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataAutoAcquireAttackTargetsModified));
        }

        public PermanentInvisibility(int newId): base(1986621505, newId)
        {
            _dataAutoAcquireAttackTargets = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataAutoAcquireAttackTargets, SetDataAutoAcquireAttackTargets));
            _isDataAutoAcquireAttackTargetsModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataAutoAcquireAttackTargetsModified));
        }

        public PermanentInvisibility(string newRawcode): base(1986621505, newRawcode)
        {
            _dataAutoAcquireAttackTargets = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataAutoAcquireAttackTargets, SetDataAutoAcquireAttackTargets));
            _isDataAutoAcquireAttackTargetsModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataAutoAcquireAttackTargetsModified));
        }

        public PermanentInvisibility(ObjectDatabase db): base(1986621505, db)
        {
            _dataAutoAcquireAttackTargets = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataAutoAcquireAttackTargets, SetDataAutoAcquireAttackTargets));
            _isDataAutoAcquireAttackTargetsModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataAutoAcquireAttackTargetsModified));
        }

        public PermanentInvisibility(int newId, ObjectDatabase db): base(1986621505, newId, db)
        {
            _dataAutoAcquireAttackTargets = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataAutoAcquireAttackTargets, SetDataAutoAcquireAttackTargets));
            _isDataAutoAcquireAttackTargetsModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataAutoAcquireAttackTargetsModified));
        }

        public PermanentInvisibility(string newRawcode, ObjectDatabase db): base(1986621505, newRawcode, db)
        {
            _dataAutoAcquireAttackTargets = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataAutoAcquireAttackTargets, SetDataAutoAcquireAttackTargets));
            _isDataAutoAcquireAttackTargetsModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataAutoAcquireAttackTargetsModified));
        }

        public ObjectProperty<bool> DataAutoAcquireAttackTargets => _dataAutoAcquireAttackTargets.Value;
        public ReadOnlyObjectProperty<bool> IsDataAutoAcquireAttackTargetsModified => _isDataAutoAcquireAttackTargetsModified.Value;
        private bool GetDataAutoAcquireAttackTargets(int level)
        {
            return _modifications[829384775, level].ValueAsBool;
        }

        private void SetDataAutoAcquireAttackTargets(int level, bool value)
        {
            _modifications[829384775, level] = new LevelObjectDataModification{Id = 829384775, Type = ObjectDataType.Bool, Value = value, Level = level, Pointer = 1};
        }

        private bool GetIsDataAutoAcquireAttackTargetsModified(int level)
        {
            return _modifications.ContainsKey(829384775, level);
        }
    }
}