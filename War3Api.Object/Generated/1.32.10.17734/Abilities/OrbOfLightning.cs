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
    public sealed class OrbOfLightning : Ability
    {
        private readonly Lazy<ObjectProperty<float>> _dataDamageBonus;
        private readonly Lazy<ReadOnlyObjectProperty<bool>> _isDataDamageBonusModified;
        private readonly Lazy<ObjectProperty<int>> _dataEnabledAttackIndex;
        private readonly Lazy<ReadOnlyObjectProperty<bool>> _isDataEnabledAttackIndexModified;
        private readonly Lazy<ObjectProperty<float>> _dataData_Iob2;
        private readonly Lazy<ReadOnlyObjectProperty<bool>> _isDataData_Iob2Modified;
        private readonly Lazy<ObjectProperty<float>> _dataData_Iob3;
        private readonly Lazy<ReadOnlyObjectProperty<bool>> _isDataData_Iob3Modified;
        private readonly Lazy<ObjectProperty<float>> _dataData_Iob4;
        private readonly Lazy<ReadOnlyObjectProperty<bool>> _isDataData_Iob4Modified;
        private readonly Lazy<ObjectProperty<string>> _dataEffectAbilityRaw;
        private readonly Lazy<ReadOnlyObjectProperty<bool>> _isDataEffectAbilityModified;
        private readonly Lazy<ObjectProperty<Ability>> _dataEffectAbility;
        public OrbOfLightning(): base(1819035969)
        {
            _dataDamageBonus = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamageBonus, SetDataDamageBonus));
            _isDataDamageBonusModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataDamageBonusModified));
            _dataEnabledAttackIndex = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataEnabledAttackIndex, SetDataEnabledAttackIndex));
            _isDataEnabledAttackIndexModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataEnabledAttackIndexModified));
            _dataData_Iob2 = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataData_Iob2, SetDataData_Iob2));
            _isDataData_Iob2Modified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataData_Iob2Modified));
            _dataData_Iob3 = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataData_Iob3, SetDataData_Iob3));
            _isDataData_Iob3Modified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataData_Iob3Modified));
            _dataData_Iob4 = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataData_Iob4, SetDataData_Iob4));
            _isDataData_Iob4Modified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataData_Iob4Modified));
            _dataEffectAbilityRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataEffectAbilityRaw, SetDataEffectAbilityRaw));
            _isDataEffectAbilityModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataEffectAbilityModified));
            _dataEffectAbility = new Lazy<ObjectProperty<Ability>>(() => new ObjectProperty<Ability>(GetDataEffectAbility, SetDataEffectAbility));
        }

        public OrbOfLightning(int newId): base(1819035969, newId)
        {
            _dataDamageBonus = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamageBonus, SetDataDamageBonus));
            _isDataDamageBonusModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataDamageBonusModified));
            _dataEnabledAttackIndex = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataEnabledAttackIndex, SetDataEnabledAttackIndex));
            _isDataEnabledAttackIndexModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataEnabledAttackIndexModified));
            _dataData_Iob2 = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataData_Iob2, SetDataData_Iob2));
            _isDataData_Iob2Modified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataData_Iob2Modified));
            _dataData_Iob3 = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataData_Iob3, SetDataData_Iob3));
            _isDataData_Iob3Modified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataData_Iob3Modified));
            _dataData_Iob4 = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataData_Iob4, SetDataData_Iob4));
            _isDataData_Iob4Modified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataData_Iob4Modified));
            _dataEffectAbilityRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataEffectAbilityRaw, SetDataEffectAbilityRaw));
            _isDataEffectAbilityModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataEffectAbilityModified));
            _dataEffectAbility = new Lazy<ObjectProperty<Ability>>(() => new ObjectProperty<Ability>(GetDataEffectAbility, SetDataEffectAbility));
        }

        public OrbOfLightning(string newRawcode): base(1819035969, newRawcode)
        {
            _dataDamageBonus = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamageBonus, SetDataDamageBonus));
            _isDataDamageBonusModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataDamageBonusModified));
            _dataEnabledAttackIndex = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataEnabledAttackIndex, SetDataEnabledAttackIndex));
            _isDataEnabledAttackIndexModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataEnabledAttackIndexModified));
            _dataData_Iob2 = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataData_Iob2, SetDataData_Iob2));
            _isDataData_Iob2Modified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataData_Iob2Modified));
            _dataData_Iob3 = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataData_Iob3, SetDataData_Iob3));
            _isDataData_Iob3Modified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataData_Iob3Modified));
            _dataData_Iob4 = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataData_Iob4, SetDataData_Iob4));
            _isDataData_Iob4Modified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataData_Iob4Modified));
            _dataEffectAbilityRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataEffectAbilityRaw, SetDataEffectAbilityRaw));
            _isDataEffectAbilityModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataEffectAbilityModified));
            _dataEffectAbility = new Lazy<ObjectProperty<Ability>>(() => new ObjectProperty<Ability>(GetDataEffectAbility, SetDataEffectAbility));
        }

        public OrbOfLightning(ObjectDatabaseBase db): base(1819035969, db)
        {
            _dataDamageBonus = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamageBonus, SetDataDamageBonus));
            _isDataDamageBonusModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataDamageBonusModified));
            _dataEnabledAttackIndex = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataEnabledAttackIndex, SetDataEnabledAttackIndex));
            _isDataEnabledAttackIndexModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataEnabledAttackIndexModified));
            _dataData_Iob2 = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataData_Iob2, SetDataData_Iob2));
            _isDataData_Iob2Modified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataData_Iob2Modified));
            _dataData_Iob3 = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataData_Iob3, SetDataData_Iob3));
            _isDataData_Iob3Modified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataData_Iob3Modified));
            _dataData_Iob4 = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataData_Iob4, SetDataData_Iob4));
            _isDataData_Iob4Modified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataData_Iob4Modified));
            _dataEffectAbilityRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataEffectAbilityRaw, SetDataEffectAbilityRaw));
            _isDataEffectAbilityModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataEffectAbilityModified));
            _dataEffectAbility = new Lazy<ObjectProperty<Ability>>(() => new ObjectProperty<Ability>(GetDataEffectAbility, SetDataEffectAbility));
        }

        public OrbOfLightning(int newId, ObjectDatabaseBase db): base(1819035969, newId, db)
        {
            _dataDamageBonus = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamageBonus, SetDataDamageBonus));
            _isDataDamageBonusModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataDamageBonusModified));
            _dataEnabledAttackIndex = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataEnabledAttackIndex, SetDataEnabledAttackIndex));
            _isDataEnabledAttackIndexModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataEnabledAttackIndexModified));
            _dataData_Iob2 = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataData_Iob2, SetDataData_Iob2));
            _isDataData_Iob2Modified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataData_Iob2Modified));
            _dataData_Iob3 = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataData_Iob3, SetDataData_Iob3));
            _isDataData_Iob3Modified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataData_Iob3Modified));
            _dataData_Iob4 = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataData_Iob4, SetDataData_Iob4));
            _isDataData_Iob4Modified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataData_Iob4Modified));
            _dataEffectAbilityRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataEffectAbilityRaw, SetDataEffectAbilityRaw));
            _isDataEffectAbilityModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataEffectAbilityModified));
            _dataEffectAbility = new Lazy<ObjectProperty<Ability>>(() => new ObjectProperty<Ability>(GetDataEffectAbility, SetDataEffectAbility));
        }

        public OrbOfLightning(string newRawcode, ObjectDatabaseBase db): base(1819035969, newRawcode, db)
        {
            _dataDamageBonus = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamageBonus, SetDataDamageBonus));
            _isDataDamageBonusModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataDamageBonusModified));
            _dataEnabledAttackIndex = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataEnabledAttackIndex, SetDataEnabledAttackIndex));
            _isDataEnabledAttackIndexModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataEnabledAttackIndexModified));
            _dataData_Iob2 = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataData_Iob2, SetDataData_Iob2));
            _isDataData_Iob2Modified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataData_Iob2Modified));
            _dataData_Iob3 = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataData_Iob3, SetDataData_Iob3));
            _isDataData_Iob3Modified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataData_Iob3Modified));
            _dataData_Iob4 = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataData_Iob4, SetDataData_Iob4));
            _isDataData_Iob4Modified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataData_Iob4Modified));
            _dataEffectAbilityRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataEffectAbilityRaw, SetDataEffectAbilityRaw));
            _isDataEffectAbilityModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataEffectAbilityModified));
            _dataEffectAbility = new Lazy<ObjectProperty<Ability>>(() => new ObjectProperty<Ability>(GetDataEffectAbility, SetDataEffectAbility));
        }

        public ObjectProperty<float> DataDamageBonus => _dataDamageBonus.Value;
        public ReadOnlyObjectProperty<bool> IsDataDamageBonusModified => _isDataDamageBonusModified.Value;
        public ObjectProperty<int> DataEnabledAttackIndex => _dataEnabledAttackIndex.Value;
        public ReadOnlyObjectProperty<bool> IsDataEnabledAttackIndexModified => _isDataEnabledAttackIndexModified.Value;
        public ObjectProperty<float> DataData_Iob2 => _dataData_Iob2.Value;
        public ReadOnlyObjectProperty<bool> IsDataData_Iob2Modified => _isDataData_Iob2Modified.Value;
        public ObjectProperty<float> DataData_Iob3 => _dataData_Iob3.Value;
        public ReadOnlyObjectProperty<bool> IsDataData_Iob3Modified => _isDataData_Iob3Modified.Value;
        public ObjectProperty<float> DataData_Iob4 => _dataData_Iob4.Value;
        public ReadOnlyObjectProperty<bool> IsDataData_Iob4Modified => _isDataData_Iob4Modified.Value;
        public ObjectProperty<string> DataEffectAbilityRaw => _dataEffectAbilityRaw.Value;
        public ReadOnlyObjectProperty<bool> IsDataEffectAbilityModified => _isDataEffectAbilityModified.Value;
        public ObjectProperty<Ability> DataEffectAbility => _dataEffectAbility.Value;
        private float GetDataDamageBonus(int level)
        {
            return _modifications.GetModification(1835099209, level).ValueAsFloat;
        }

        private void SetDataDamageBonus(int level, float value)
        {
            _modifications[1835099209, level] = new LevelObjectDataModification{Id = 1835099209, Type = ObjectDataType.Unreal, Value = value, Level = level, Pointer = 1};
        }

        private bool GetIsDataDamageBonusModified(int level)
        {
            return _modifications.ContainsKey(1835099209, level);
        }

        private int GetDataEnabledAttackIndex(int level)
        {
            return _modifications.GetModification(895643465, level).ValueAsInt;
        }

        private void SetDataEnabledAttackIndex(int level, int value)
        {
            _modifications[895643465, level] = new LevelObjectDataModification{Id = 895643465, Type = ObjectDataType.Int, Value = value, Level = level, Pointer = 5};
        }

        private bool GetIsDataEnabledAttackIndexModified(int level)
        {
            return _modifications.ContainsKey(895643465, level);
        }

        private float GetDataData_Iob2(int level)
        {
            return _modifications.GetModification(845311817, level).ValueAsFloat;
        }

        private void SetDataData_Iob2(int level, float value)
        {
            _modifications[845311817, level] = new LevelObjectDataModification{Id = 845311817, Type = ObjectDataType.Unreal, Value = value, Level = level, Pointer = 2};
        }

        private bool GetIsDataData_Iob2Modified(int level)
        {
            return _modifications.ContainsKey(845311817, level);
        }

        private float GetDataData_Iob3(int level)
        {
            return _modifications.GetModification(862089033, level).ValueAsFloat;
        }

        private void SetDataData_Iob3(int level, float value)
        {
            _modifications[862089033, level] = new LevelObjectDataModification{Id = 862089033, Type = ObjectDataType.Unreal, Value = value, Level = level, Pointer = 3};
        }

        private bool GetIsDataData_Iob3Modified(int level)
        {
            return _modifications.ContainsKey(862089033, level);
        }

        private float GetDataData_Iob4(int level)
        {
            return _modifications.GetModification(878866249, level).ValueAsFloat;
        }

        private void SetDataData_Iob4(int level, float value)
        {
            _modifications[878866249, level] = new LevelObjectDataModification{Id = 878866249, Type = ObjectDataType.Unreal, Value = value, Level = level, Pointer = 4};
        }

        private bool GetIsDataData_Iob4Modified(int level)
        {
            return _modifications.ContainsKey(878866249, level);
        }

        private string GetDataEffectAbilityRaw(int level)
        {
            return _modifications.GetModification(1969385289, level).ValueAsString;
        }

        private void SetDataEffectAbilityRaw(int level, string value)
        {
            _modifications[1969385289, level] = new LevelObjectDataModification{Id = 1969385289, Type = ObjectDataType.String, Value = value, Level = level};
        }

        private bool GetIsDataEffectAbilityModified(int level)
        {
            return _modifications.ContainsKey(1969385289, level);
        }

        private Ability GetDataEffectAbility(int level)
        {
            return GetDataEffectAbilityRaw(level).ToAbility(this);
        }

        private void SetDataEffectAbility(int level, Ability value)
        {
            SetDataEffectAbilityRaw(level, value.ToRaw(null, null));
        }
    }
}