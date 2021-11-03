using System;
using System.Collections.Generic;
using System.Linq;
using War3Api.Object.Abilities;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class ItemRegenMana : Ability
    {
        private readonly Lazy<ObjectProperty<float>> _dataManaRegenerationBonusAsFractionOfNormal;
        private readonly Lazy<ReadOnlyObjectProperty<bool>> _isDataManaRegenerationBonusAsFractionOfNormalModified;
        public ItemRegenMana(): base(1836206401)
        {
            _dataManaRegenerationBonusAsFractionOfNormal = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataManaRegenerationBonusAsFractionOfNormal, SetDataManaRegenerationBonusAsFractionOfNormal));
            _isDataManaRegenerationBonusAsFractionOfNormalModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataManaRegenerationBonusAsFractionOfNormalModified));
        }

        public ItemRegenMana(int newId): base(1836206401, newId)
        {
            _dataManaRegenerationBonusAsFractionOfNormal = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataManaRegenerationBonusAsFractionOfNormal, SetDataManaRegenerationBonusAsFractionOfNormal));
            _isDataManaRegenerationBonusAsFractionOfNormalModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataManaRegenerationBonusAsFractionOfNormalModified));
        }

        public ItemRegenMana(string newRawcode): base(1836206401, newRawcode)
        {
            _dataManaRegenerationBonusAsFractionOfNormal = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataManaRegenerationBonusAsFractionOfNormal, SetDataManaRegenerationBonusAsFractionOfNormal));
            _isDataManaRegenerationBonusAsFractionOfNormalModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataManaRegenerationBonusAsFractionOfNormalModified));
        }

        public ItemRegenMana(ObjectDatabase db): base(1836206401, db)
        {
            _dataManaRegenerationBonusAsFractionOfNormal = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataManaRegenerationBonusAsFractionOfNormal, SetDataManaRegenerationBonusAsFractionOfNormal));
            _isDataManaRegenerationBonusAsFractionOfNormalModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataManaRegenerationBonusAsFractionOfNormalModified));
        }

        public ItemRegenMana(int newId, ObjectDatabase db): base(1836206401, newId, db)
        {
            _dataManaRegenerationBonusAsFractionOfNormal = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataManaRegenerationBonusAsFractionOfNormal, SetDataManaRegenerationBonusAsFractionOfNormal));
            _isDataManaRegenerationBonusAsFractionOfNormalModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataManaRegenerationBonusAsFractionOfNormalModified));
        }

        public ItemRegenMana(string newRawcode, ObjectDatabase db): base(1836206401, newRawcode, db)
        {
            _dataManaRegenerationBonusAsFractionOfNormal = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataManaRegenerationBonusAsFractionOfNormal, SetDataManaRegenerationBonusAsFractionOfNormal));
            _isDataManaRegenerationBonusAsFractionOfNormalModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataManaRegenerationBonusAsFractionOfNormalModified));
        }

        public ObjectProperty<float> DataManaRegenerationBonusAsFractionOfNormal => _dataManaRegenerationBonusAsFractionOfNormal.Value;
        public ReadOnlyObjectProperty<bool> IsDataManaRegenerationBonusAsFractionOfNormalModified => _isDataManaRegenerationBonusAsFractionOfNormalModified.Value;
        private float GetDataManaRegenerationBonusAsFractionOfNormal(int level)
        {
            return _modifications[1886547273, level].ValueAsFloat;
        }

        private void SetDataManaRegenerationBonusAsFractionOfNormal(int level, float value)
        {
            _modifications[1886547273, level] = new LevelObjectDataModification{Id = 1886547273, Type = ObjectDataType.Unreal, Value = value, Level = level, Pointer = 1};
        }

        private bool GetIsDataManaRegenerationBonusAsFractionOfNormalModified(int level)
        {
            return _modifications.ContainsKey(1886547273, level);
        }
    }
}