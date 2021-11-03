using System;
using System.Collections.Generic;
using System.Linq;
using War3Api.Object.Abilities;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class ShadowMeld : Ability
    {
        private readonly Lazy<ObjectProperty<float>> _dataFadeDuration;
        private readonly Lazy<ReadOnlyObjectProperty<bool>> _isDataFadeDurationModified;
        private readonly Lazy<ObjectProperty<float>> _dataDayNightDuration;
        private readonly Lazy<ReadOnlyObjectProperty<bool>> _isDataDayNightDurationModified;
        private readonly Lazy<ObjectProperty<float>> _dataActionDuration;
        private readonly Lazy<ReadOnlyObjectProperty<bool>> _isDataActionDurationModified;
        private readonly Lazy<ObjectProperty<bool>> _dataPermanentCloak;
        private readonly Lazy<ReadOnlyObjectProperty<bool>> _isDataPermanentCloakModified;
        public ShadowMeld(): base(1835561793)
        {
            _dataFadeDuration = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataFadeDuration, SetDataFadeDuration));
            _isDataFadeDurationModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataFadeDurationModified));
            _dataDayNightDuration = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDayNightDuration, SetDataDayNightDuration));
            _isDataDayNightDurationModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataDayNightDurationModified));
            _dataActionDuration = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataActionDuration, SetDataActionDuration));
            _isDataActionDurationModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataActionDurationModified));
            _dataPermanentCloak = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataPermanentCloak, SetDataPermanentCloak));
            _isDataPermanentCloakModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataPermanentCloakModified));
        }

        public ShadowMeld(int newId): base(1835561793, newId)
        {
            _dataFadeDuration = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataFadeDuration, SetDataFadeDuration));
            _isDataFadeDurationModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataFadeDurationModified));
            _dataDayNightDuration = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDayNightDuration, SetDataDayNightDuration));
            _isDataDayNightDurationModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataDayNightDurationModified));
            _dataActionDuration = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataActionDuration, SetDataActionDuration));
            _isDataActionDurationModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataActionDurationModified));
            _dataPermanentCloak = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataPermanentCloak, SetDataPermanentCloak));
            _isDataPermanentCloakModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataPermanentCloakModified));
        }

        public ShadowMeld(string newRawcode): base(1835561793, newRawcode)
        {
            _dataFadeDuration = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataFadeDuration, SetDataFadeDuration));
            _isDataFadeDurationModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataFadeDurationModified));
            _dataDayNightDuration = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDayNightDuration, SetDataDayNightDuration));
            _isDataDayNightDurationModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataDayNightDurationModified));
            _dataActionDuration = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataActionDuration, SetDataActionDuration));
            _isDataActionDurationModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataActionDurationModified));
            _dataPermanentCloak = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataPermanentCloak, SetDataPermanentCloak));
            _isDataPermanentCloakModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataPermanentCloakModified));
        }

        public ShadowMeld(ObjectDatabase db): base(1835561793, db)
        {
            _dataFadeDuration = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataFadeDuration, SetDataFadeDuration));
            _isDataFadeDurationModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataFadeDurationModified));
            _dataDayNightDuration = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDayNightDuration, SetDataDayNightDuration));
            _isDataDayNightDurationModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataDayNightDurationModified));
            _dataActionDuration = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataActionDuration, SetDataActionDuration));
            _isDataActionDurationModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataActionDurationModified));
            _dataPermanentCloak = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataPermanentCloak, SetDataPermanentCloak));
            _isDataPermanentCloakModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataPermanentCloakModified));
        }

        public ShadowMeld(int newId, ObjectDatabase db): base(1835561793, newId, db)
        {
            _dataFadeDuration = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataFadeDuration, SetDataFadeDuration));
            _isDataFadeDurationModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataFadeDurationModified));
            _dataDayNightDuration = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDayNightDuration, SetDataDayNightDuration));
            _isDataDayNightDurationModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataDayNightDurationModified));
            _dataActionDuration = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataActionDuration, SetDataActionDuration));
            _isDataActionDurationModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataActionDurationModified));
            _dataPermanentCloak = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataPermanentCloak, SetDataPermanentCloak));
            _isDataPermanentCloakModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataPermanentCloakModified));
        }

        public ShadowMeld(string newRawcode, ObjectDatabase db): base(1835561793, newRawcode, db)
        {
            _dataFadeDuration = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataFadeDuration, SetDataFadeDuration));
            _isDataFadeDurationModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataFadeDurationModified));
            _dataDayNightDuration = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDayNightDuration, SetDataDayNightDuration));
            _isDataDayNightDurationModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataDayNightDurationModified));
            _dataActionDuration = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataActionDuration, SetDataActionDuration));
            _isDataActionDurationModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataActionDurationModified));
            _dataPermanentCloak = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataPermanentCloak, SetDataPermanentCloak));
            _isDataPermanentCloakModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataPermanentCloakModified));
        }

        public ObjectProperty<float> DataFadeDuration => _dataFadeDuration.Value;
        public ReadOnlyObjectProperty<bool> IsDataFadeDurationModified => _isDataFadeDurationModified.Value;
        public ObjectProperty<float> DataDayNightDuration => _dataDayNightDuration.Value;
        public ReadOnlyObjectProperty<bool> IsDataDayNightDurationModified => _isDataDayNightDurationModified.Value;
        public ObjectProperty<float> DataActionDuration => _dataActionDuration.Value;
        public ReadOnlyObjectProperty<bool> IsDataActionDurationModified => _isDataActionDurationModified.Value;
        public ObjectProperty<bool> DataPermanentCloak => _dataPermanentCloak.Value;
        public ReadOnlyObjectProperty<bool> IsDataPermanentCloakModified => _isDataPermanentCloakModified.Value;
        private float GetDataFadeDuration(int level)
        {
            return _modifications[829253715, level].ValueAsFloat;
        }

        private void SetDataFadeDuration(int level, float value)
        {
            _modifications[829253715, level] = new LevelObjectDataModification{Id = 829253715, Type = ObjectDataType.Unreal, Value = value, Level = level, Pointer = 1};
        }

        private bool GetIsDataFadeDurationModified(int level)
        {
            return _modifications.ContainsKey(829253715, level);
        }

        private float GetDataDayNightDuration(int level)
        {
            return _modifications[846030931, level].ValueAsFloat;
        }

        private void SetDataDayNightDuration(int level, float value)
        {
            _modifications[846030931, level] = new LevelObjectDataModification{Id = 846030931, Type = ObjectDataType.Unreal, Value = value, Level = level, Pointer = 2};
        }

        private bool GetIsDataDayNightDurationModified(int level)
        {
            return _modifications.ContainsKey(846030931, level);
        }

        private float GetDataActionDuration(int level)
        {
            return _modifications[862808147, level].ValueAsFloat;
        }

        private void SetDataActionDuration(int level, float value)
        {
            _modifications[862808147, level] = new LevelObjectDataModification{Id = 862808147, Type = ObjectDataType.Unreal, Value = value, Level = level, Pointer = 3};
        }

        private bool GetIsDataActionDurationModified(int level)
        {
            return _modifications.ContainsKey(862808147, level);
        }

        private bool GetDataPermanentCloak(int level)
        {
            return _modifications[879585363, level].ValueAsBool;
        }

        private void SetDataPermanentCloak(int level, bool value)
        {
            _modifications[879585363, level] = new LevelObjectDataModification{Id = 879585363, Type = ObjectDataType.Bool, Value = value, Level = level, Pointer = 4};
        }

        private bool GetIsDataPermanentCloakModified(int level)
        {
            return _modifications.ContainsKey(879585363, level);
        }
    }
}