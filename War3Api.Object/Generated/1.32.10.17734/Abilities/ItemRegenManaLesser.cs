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
    public sealed class ItemRegenManaLesser : Ability
    {
        private readonly Lazy<ObjectProperty<float>> _dataManaRegenerationBonusasFractionOfNormal;
        private readonly Lazy<ReadOnlyObjectProperty<bool>> _isDataManaRegenerationBonusasFractionOfNormalModified;
        public ItemRegenManaLesser(): base(1852983617)
        {
            _dataManaRegenerationBonusasFractionOfNormal = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataManaRegenerationBonusasFractionOfNormal, SetDataManaRegenerationBonusasFractionOfNormal));
            _isDataManaRegenerationBonusasFractionOfNormalModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataManaRegenerationBonusasFractionOfNormalModified));
        }

        public ItemRegenManaLesser(int newId): base(1852983617, newId)
        {
            _dataManaRegenerationBonusasFractionOfNormal = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataManaRegenerationBonusasFractionOfNormal, SetDataManaRegenerationBonusasFractionOfNormal));
            _isDataManaRegenerationBonusasFractionOfNormalModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataManaRegenerationBonusasFractionOfNormalModified));
        }

        public ItemRegenManaLesser(string newRawcode): base(1852983617, newRawcode)
        {
            _dataManaRegenerationBonusasFractionOfNormal = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataManaRegenerationBonusasFractionOfNormal, SetDataManaRegenerationBonusasFractionOfNormal));
            _isDataManaRegenerationBonusasFractionOfNormalModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataManaRegenerationBonusasFractionOfNormalModified));
        }

        public ItemRegenManaLesser(ObjectDatabaseBase db): base(1852983617, db)
        {
            _dataManaRegenerationBonusasFractionOfNormal = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataManaRegenerationBonusasFractionOfNormal, SetDataManaRegenerationBonusasFractionOfNormal));
            _isDataManaRegenerationBonusasFractionOfNormalModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataManaRegenerationBonusasFractionOfNormalModified));
        }

        public ItemRegenManaLesser(int newId, ObjectDatabaseBase db): base(1852983617, newId, db)
        {
            _dataManaRegenerationBonusasFractionOfNormal = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataManaRegenerationBonusasFractionOfNormal, SetDataManaRegenerationBonusasFractionOfNormal));
            _isDataManaRegenerationBonusasFractionOfNormalModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataManaRegenerationBonusasFractionOfNormalModified));
        }

        public ItemRegenManaLesser(string newRawcode, ObjectDatabaseBase db): base(1852983617, newRawcode, db)
        {
            _dataManaRegenerationBonusasFractionOfNormal = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataManaRegenerationBonusasFractionOfNormal, SetDataManaRegenerationBonusasFractionOfNormal));
            _isDataManaRegenerationBonusasFractionOfNormalModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataManaRegenerationBonusasFractionOfNormalModified));
        }

        public ObjectProperty<float> DataManaRegenerationBonusasFractionOfNormal => _dataManaRegenerationBonusasFractionOfNormal.Value;
        public ReadOnlyObjectProperty<bool> IsDataManaRegenerationBonusasFractionOfNormalModified => _isDataManaRegenerationBonusasFractionOfNormalModified.Value;
        private float GetDataManaRegenerationBonusasFractionOfNormal(int level)
        {
            return _modifications.GetModification(1886547273, level).ValueAsFloat;
        }

        private void SetDataManaRegenerationBonusasFractionOfNormal(int level, float value)
        {
            _modifications[1886547273, level] = new LevelObjectDataModification{Id = 1886547273, Type = ObjectDataType.Unreal, Value = value, Level = level, Pointer = 1};
        }

        private bool GetIsDataManaRegenerationBonusasFractionOfNormalModified(int level)
        {
            return _modifications.ContainsKey(1886547273, level);
        }
    }
}