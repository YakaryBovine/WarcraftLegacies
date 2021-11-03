using System;
using System.Collections.Generic;
using System.Linq;
using War3Api.Object.Abilities;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class AuraRegenerationStatue : Ability
    {
        private readonly Lazy<ObjectProperty<float>> _dataAmountOfHitPointsRegenerated;
        private readonly Lazy<ReadOnlyObjectProperty<bool>> _isDataAmountOfHitPointsRegeneratedModified;
        private readonly Lazy<ObjectProperty<bool>> _dataPercentage;
        private readonly Lazy<ReadOnlyObjectProperty<bool>> _isDataPercentageModified;
        public AuraRegenerationStatue(): base(1919050049)
        {
            _dataAmountOfHitPointsRegenerated = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataAmountOfHitPointsRegenerated, SetDataAmountOfHitPointsRegenerated));
            _isDataAmountOfHitPointsRegeneratedModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataAmountOfHitPointsRegeneratedModified));
            _dataPercentage = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataPercentage, SetDataPercentage));
            _isDataPercentageModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataPercentageModified));
        }

        public AuraRegenerationStatue(int newId): base(1919050049, newId)
        {
            _dataAmountOfHitPointsRegenerated = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataAmountOfHitPointsRegenerated, SetDataAmountOfHitPointsRegenerated));
            _isDataAmountOfHitPointsRegeneratedModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataAmountOfHitPointsRegeneratedModified));
            _dataPercentage = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataPercentage, SetDataPercentage));
            _isDataPercentageModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataPercentageModified));
        }

        public AuraRegenerationStatue(string newRawcode): base(1919050049, newRawcode)
        {
            _dataAmountOfHitPointsRegenerated = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataAmountOfHitPointsRegenerated, SetDataAmountOfHitPointsRegenerated));
            _isDataAmountOfHitPointsRegeneratedModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataAmountOfHitPointsRegeneratedModified));
            _dataPercentage = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataPercentage, SetDataPercentage));
            _isDataPercentageModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataPercentageModified));
        }

        public AuraRegenerationStatue(ObjectDatabase db): base(1919050049, db)
        {
            _dataAmountOfHitPointsRegenerated = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataAmountOfHitPointsRegenerated, SetDataAmountOfHitPointsRegenerated));
            _isDataAmountOfHitPointsRegeneratedModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataAmountOfHitPointsRegeneratedModified));
            _dataPercentage = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataPercentage, SetDataPercentage));
            _isDataPercentageModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataPercentageModified));
        }

        public AuraRegenerationStatue(int newId, ObjectDatabase db): base(1919050049, newId, db)
        {
            _dataAmountOfHitPointsRegenerated = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataAmountOfHitPointsRegenerated, SetDataAmountOfHitPointsRegenerated));
            _isDataAmountOfHitPointsRegeneratedModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataAmountOfHitPointsRegeneratedModified));
            _dataPercentage = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataPercentage, SetDataPercentage));
            _isDataPercentageModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataPercentageModified));
        }

        public AuraRegenerationStatue(string newRawcode, ObjectDatabase db): base(1919050049, newRawcode, db)
        {
            _dataAmountOfHitPointsRegenerated = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataAmountOfHitPointsRegenerated, SetDataAmountOfHitPointsRegenerated));
            _isDataAmountOfHitPointsRegeneratedModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataAmountOfHitPointsRegeneratedModified));
            _dataPercentage = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataPercentage, SetDataPercentage));
            _isDataPercentageModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataPercentageModified));
        }

        public ObjectProperty<float> DataAmountOfHitPointsRegenerated => _dataAmountOfHitPointsRegenerated.Value;
        public ReadOnlyObjectProperty<bool> IsDataAmountOfHitPointsRegeneratedModified => _isDataAmountOfHitPointsRegeneratedModified.Value;
        public ObjectProperty<bool> DataPercentage => _dataPercentage.Value;
        public ReadOnlyObjectProperty<bool> IsDataPercentageModified => _isDataPercentageModified.Value;
        private float GetDataAmountOfHitPointsRegenerated(int level)
        {
            return _modifications[829579599, level].ValueAsFloat;
        }

        private void SetDataAmountOfHitPointsRegenerated(int level, float value)
        {
            _modifications[829579599, level] = new LevelObjectDataModification{Id = 829579599, Type = ObjectDataType.Unreal, Value = value, Level = level, Pointer = 1};
        }

        private bool GetIsDataAmountOfHitPointsRegeneratedModified(int level)
        {
            return _modifications.ContainsKey(829579599, level);
        }

        private bool GetDataPercentage(int level)
        {
            return _modifications[846356815, level].ValueAsBool;
        }

        private void SetDataPercentage(int level, bool value)
        {
            _modifications[846356815, level] = new LevelObjectDataModification{Id = 846356815, Type = ObjectDataType.Bool, Value = value, Level = level, Pointer = 2};
        }

        private bool GetIsDataPercentageModified(int level)
        {
            return _modifications.ContainsKey(846356815, level);
        }
    }
}