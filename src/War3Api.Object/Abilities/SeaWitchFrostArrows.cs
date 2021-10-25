using System;
using System.Collections.Generic;
using System.Linq;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class SeaWitchFrostArrows : Ability
    {
        private readonly Lazy<ObjectProperty<float>> _dataExtraDamage;
        private readonly Lazy<ObjectProperty<float>> _dataMovementSpeedFactor;
        private readonly Lazy<ObjectProperty<float>> _dataAttackSpeedFactor;
        private readonly Lazy<ObjectProperty<int>> _dataStackFlagsRaw;
        private readonly Lazy<ObjectProperty<StackFlags>> _dataStackFlags;
        public SeaWitchFrostArrows(): base(1634094657)
        {
            _dataExtraDamage = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataExtraDamage, SetDataExtraDamage));
            _dataMovementSpeedFactor = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataMovementSpeedFactor, SetDataMovementSpeedFactor));
            _dataAttackSpeedFactor = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataAttackSpeedFactor, SetDataAttackSpeedFactor));
            _dataStackFlagsRaw = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataStackFlagsRaw, SetDataStackFlagsRaw));
            _dataStackFlags = new Lazy<ObjectProperty<StackFlags>>(() => new ObjectProperty<StackFlags>(GetDataStackFlags, SetDataStackFlags));
        }

        public SeaWitchFrostArrows(int newId): base(1634094657, newId)
        {
            _dataExtraDamage = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataExtraDamage, SetDataExtraDamage));
            _dataMovementSpeedFactor = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataMovementSpeedFactor, SetDataMovementSpeedFactor));
            _dataAttackSpeedFactor = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataAttackSpeedFactor, SetDataAttackSpeedFactor));
            _dataStackFlagsRaw = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataStackFlagsRaw, SetDataStackFlagsRaw));
            _dataStackFlags = new Lazy<ObjectProperty<StackFlags>>(() => new ObjectProperty<StackFlags>(GetDataStackFlags, SetDataStackFlags));
        }

        public SeaWitchFrostArrows(string newRawcode): base(1634094657, newRawcode)
        {
            _dataExtraDamage = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataExtraDamage, SetDataExtraDamage));
            _dataMovementSpeedFactor = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataMovementSpeedFactor, SetDataMovementSpeedFactor));
            _dataAttackSpeedFactor = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataAttackSpeedFactor, SetDataAttackSpeedFactor));
            _dataStackFlagsRaw = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataStackFlagsRaw, SetDataStackFlagsRaw));
            _dataStackFlags = new Lazy<ObjectProperty<StackFlags>>(() => new ObjectProperty<StackFlags>(GetDataStackFlags, SetDataStackFlags));
        }

        public SeaWitchFrostArrows(ObjectDatabase db): base(1634094657, db)
        {
            _dataExtraDamage = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataExtraDamage, SetDataExtraDamage));
            _dataMovementSpeedFactor = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataMovementSpeedFactor, SetDataMovementSpeedFactor));
            _dataAttackSpeedFactor = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataAttackSpeedFactor, SetDataAttackSpeedFactor));
            _dataStackFlagsRaw = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataStackFlagsRaw, SetDataStackFlagsRaw));
            _dataStackFlags = new Lazy<ObjectProperty<StackFlags>>(() => new ObjectProperty<StackFlags>(GetDataStackFlags, SetDataStackFlags));
        }

        public SeaWitchFrostArrows(int newId, ObjectDatabase db): base(1634094657, newId, db)
        {
            _dataExtraDamage = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataExtraDamage, SetDataExtraDamage));
            _dataMovementSpeedFactor = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataMovementSpeedFactor, SetDataMovementSpeedFactor));
            _dataAttackSpeedFactor = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataAttackSpeedFactor, SetDataAttackSpeedFactor));
            _dataStackFlagsRaw = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataStackFlagsRaw, SetDataStackFlagsRaw));
            _dataStackFlags = new Lazy<ObjectProperty<StackFlags>>(() => new ObjectProperty<StackFlags>(GetDataStackFlags, SetDataStackFlags));
        }

        public SeaWitchFrostArrows(string newRawcode, ObjectDatabase db): base(1634094657, newRawcode, db)
        {
            _dataExtraDamage = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataExtraDamage, SetDataExtraDamage));
            _dataMovementSpeedFactor = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataMovementSpeedFactor, SetDataMovementSpeedFactor));
            _dataAttackSpeedFactor = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataAttackSpeedFactor, SetDataAttackSpeedFactor));
            _dataStackFlagsRaw = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataStackFlagsRaw, SetDataStackFlagsRaw));
            _dataStackFlags = new Lazy<ObjectProperty<StackFlags>>(() => new ObjectProperty<StackFlags>(GetDataStackFlags, SetDataStackFlags));
        }

        public ObjectProperty<float> DataExtraDamage => _dataExtraDamage.Value;
        public ObjectProperty<float> DataMovementSpeedFactor => _dataMovementSpeedFactor.Value;
        public ObjectProperty<float> DataAttackSpeedFactor => _dataAttackSpeedFactor.Value;
        public ObjectProperty<int> DataStackFlagsRaw => _dataStackFlagsRaw.Value;
        public ObjectProperty<StackFlags> DataStackFlags => _dataStackFlags.Value;
        private float GetDataExtraDamage(int level)
        {
            return _modifications[828465992, level].ValueAsFloat;
        }

        private void SetDataExtraDamage(int level, float value)
        {
            _modifications[828465992, level] = new LevelObjectDataModification{Id = 828465992, Type = ObjectDataType.Unreal, Value = value, Level = level, Pointer = 1};
        }

        private float GetDataMovementSpeedFactor(int level)
        {
            return _modifications[845243208, level].ValueAsFloat;
        }

        private void SetDataMovementSpeedFactor(int level, float value)
        {
            _modifications[845243208, level] = new LevelObjectDataModification{Id = 845243208, Type = ObjectDataType.Unreal, Value = value, Level = level, Pointer = 2};
        }

        private float GetDataAttackSpeedFactor(int level)
        {
            return _modifications[862020424, level].ValueAsFloat;
        }

        private void SetDataAttackSpeedFactor(int level, float value)
        {
            _modifications[862020424, level] = new LevelObjectDataModification{Id = 862020424, Type = ObjectDataType.Unreal, Value = value, Level = level, Pointer = 3};
        }

        private int GetDataStackFlagsRaw(int level)
        {
            return _modifications[878797640, level].ValueAsInt;
        }

        private void SetDataStackFlagsRaw(int level, int value)
        {
            _modifications[878797640, level] = new LevelObjectDataModification{Id = 878797640, Type = ObjectDataType.Int, Value = value, Level = level, Pointer = 4};
        }

        private StackFlags GetDataStackFlags(int level)
        {
            return GetDataStackFlagsRaw(level).ToStackFlags(this);
        }

        private void SetDataStackFlags(int level, StackFlags value)
        {
            SetDataStackFlagsRaw(level, value.ToRaw(null, null));
        }
    }
}