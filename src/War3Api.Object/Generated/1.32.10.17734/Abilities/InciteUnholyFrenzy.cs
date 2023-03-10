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
    public sealed class InciteUnholyFrenzy : Ability
    {
        private readonly Lazy<ObjectProperty<int>> _dataPreferHostilesRaw;
        private readonly Lazy<ReadOnlyObjectProperty<bool>> _isDataPreferHostilesModified;
        private readonly Lazy<ObjectProperty<bool>> _dataPreferHostiles;
        private readonly Lazy<ObjectProperty<int>> _dataPreferFriendliesRaw;
        private readonly Lazy<ReadOnlyObjectProperty<bool>> _isDataPreferFriendliesModified;
        private readonly Lazy<ObjectProperty<bool>> _dataPreferFriendlies;
        private readonly Lazy<ObjectProperty<int>> _dataMaxUnits;
        private readonly Lazy<ReadOnlyObjectProperty<bool>> _isDataMaxUnitsModified;
        private readonly Lazy<ObjectProperty<float>> _dataAttackSpeedBonus;
        private readonly Lazy<ReadOnlyObjectProperty<bool>> _isDataAttackSpeedBonusModified;
        private readonly Lazy<ObjectProperty<float>> _dataDamagePerSecond;
        private readonly Lazy<ReadOnlyObjectProperty<bool>> _isDataDamagePerSecondModified;
        private readonly Lazy<ObjectProperty<int>> _dataRequiresUndeadTargetRaw;
        private readonly Lazy<ReadOnlyObjectProperty<bool>> _isDataRequiresUndeadTargetModified;
        private readonly Lazy<ObjectProperty<bool>> _dataRequiresUndeadTarget;
        private readonly Lazy<ObjectProperty<int>> _dataLeaveTargetAliveRaw;
        private readonly Lazy<ReadOnlyObjectProperty<bool>> _isDataLeaveTargetAliveModified;
        private readonly Lazy<ObjectProperty<bool>> _dataLeaveTargetAlive;
        private readonly Lazy<ObjectProperty<string>> _dataTargetsAllowedForBuffRaw;
        private readonly Lazy<ReadOnlyObjectProperty<bool>> _isDataTargetsAllowedForBuffModified;
        private readonly Lazy<ObjectProperty<IEnumerable<Target>>> _dataTargetsAllowedForBuff;
        public InciteUnholyFrenzy(): base(1718973761)
        {
            _dataPreferHostilesRaw = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataPreferHostilesRaw, SetDataPreferHostilesRaw));
            _isDataPreferHostilesModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataPreferHostilesModified));
            _dataPreferHostiles = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataPreferHostiles, SetDataPreferHostiles));
            _dataPreferFriendliesRaw = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataPreferFriendliesRaw, SetDataPreferFriendliesRaw));
            _isDataPreferFriendliesModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataPreferFriendliesModified));
            _dataPreferFriendlies = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataPreferFriendlies, SetDataPreferFriendlies));
            _dataMaxUnits = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataMaxUnits, SetDataMaxUnits));
            _isDataMaxUnitsModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataMaxUnitsModified));
            _dataAttackSpeedBonus = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataAttackSpeedBonus, SetDataAttackSpeedBonus));
            _isDataAttackSpeedBonusModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataAttackSpeedBonusModified));
            _dataDamagePerSecond = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamagePerSecond, SetDataDamagePerSecond));
            _isDataDamagePerSecondModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataDamagePerSecondModified));
            _dataRequiresUndeadTargetRaw = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataRequiresUndeadTargetRaw, SetDataRequiresUndeadTargetRaw));
            _isDataRequiresUndeadTargetModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataRequiresUndeadTargetModified));
            _dataRequiresUndeadTarget = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataRequiresUndeadTarget, SetDataRequiresUndeadTarget));
            _dataLeaveTargetAliveRaw = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataLeaveTargetAliveRaw, SetDataLeaveTargetAliveRaw));
            _isDataLeaveTargetAliveModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataLeaveTargetAliveModified));
            _dataLeaveTargetAlive = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataLeaveTargetAlive, SetDataLeaveTargetAlive));
            _dataTargetsAllowedForBuffRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataTargetsAllowedForBuffRaw, SetDataTargetsAllowedForBuffRaw));
            _isDataTargetsAllowedForBuffModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataTargetsAllowedForBuffModified));
            _dataTargetsAllowedForBuff = new Lazy<ObjectProperty<IEnumerable<Target>>>(() => new ObjectProperty<IEnumerable<Target>>(GetDataTargetsAllowedForBuff, SetDataTargetsAllowedForBuff));
        }

        public InciteUnholyFrenzy(int newId): base(1718973761, newId)
        {
            _dataPreferHostilesRaw = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataPreferHostilesRaw, SetDataPreferHostilesRaw));
            _isDataPreferHostilesModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataPreferHostilesModified));
            _dataPreferHostiles = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataPreferHostiles, SetDataPreferHostiles));
            _dataPreferFriendliesRaw = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataPreferFriendliesRaw, SetDataPreferFriendliesRaw));
            _isDataPreferFriendliesModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataPreferFriendliesModified));
            _dataPreferFriendlies = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataPreferFriendlies, SetDataPreferFriendlies));
            _dataMaxUnits = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataMaxUnits, SetDataMaxUnits));
            _isDataMaxUnitsModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataMaxUnitsModified));
            _dataAttackSpeedBonus = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataAttackSpeedBonus, SetDataAttackSpeedBonus));
            _isDataAttackSpeedBonusModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataAttackSpeedBonusModified));
            _dataDamagePerSecond = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamagePerSecond, SetDataDamagePerSecond));
            _isDataDamagePerSecondModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataDamagePerSecondModified));
            _dataRequiresUndeadTargetRaw = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataRequiresUndeadTargetRaw, SetDataRequiresUndeadTargetRaw));
            _isDataRequiresUndeadTargetModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataRequiresUndeadTargetModified));
            _dataRequiresUndeadTarget = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataRequiresUndeadTarget, SetDataRequiresUndeadTarget));
            _dataLeaveTargetAliveRaw = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataLeaveTargetAliveRaw, SetDataLeaveTargetAliveRaw));
            _isDataLeaveTargetAliveModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataLeaveTargetAliveModified));
            _dataLeaveTargetAlive = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataLeaveTargetAlive, SetDataLeaveTargetAlive));
            _dataTargetsAllowedForBuffRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataTargetsAllowedForBuffRaw, SetDataTargetsAllowedForBuffRaw));
            _isDataTargetsAllowedForBuffModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataTargetsAllowedForBuffModified));
            _dataTargetsAllowedForBuff = new Lazy<ObjectProperty<IEnumerable<Target>>>(() => new ObjectProperty<IEnumerable<Target>>(GetDataTargetsAllowedForBuff, SetDataTargetsAllowedForBuff));
        }

        public InciteUnholyFrenzy(string newRawcode): base(1718973761, newRawcode)
        {
            _dataPreferHostilesRaw = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataPreferHostilesRaw, SetDataPreferHostilesRaw));
            _isDataPreferHostilesModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataPreferHostilesModified));
            _dataPreferHostiles = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataPreferHostiles, SetDataPreferHostiles));
            _dataPreferFriendliesRaw = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataPreferFriendliesRaw, SetDataPreferFriendliesRaw));
            _isDataPreferFriendliesModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataPreferFriendliesModified));
            _dataPreferFriendlies = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataPreferFriendlies, SetDataPreferFriendlies));
            _dataMaxUnits = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataMaxUnits, SetDataMaxUnits));
            _isDataMaxUnitsModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataMaxUnitsModified));
            _dataAttackSpeedBonus = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataAttackSpeedBonus, SetDataAttackSpeedBonus));
            _isDataAttackSpeedBonusModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataAttackSpeedBonusModified));
            _dataDamagePerSecond = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamagePerSecond, SetDataDamagePerSecond));
            _isDataDamagePerSecondModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataDamagePerSecondModified));
            _dataRequiresUndeadTargetRaw = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataRequiresUndeadTargetRaw, SetDataRequiresUndeadTargetRaw));
            _isDataRequiresUndeadTargetModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataRequiresUndeadTargetModified));
            _dataRequiresUndeadTarget = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataRequiresUndeadTarget, SetDataRequiresUndeadTarget));
            _dataLeaveTargetAliveRaw = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataLeaveTargetAliveRaw, SetDataLeaveTargetAliveRaw));
            _isDataLeaveTargetAliveModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataLeaveTargetAliveModified));
            _dataLeaveTargetAlive = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataLeaveTargetAlive, SetDataLeaveTargetAlive));
            _dataTargetsAllowedForBuffRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataTargetsAllowedForBuffRaw, SetDataTargetsAllowedForBuffRaw));
            _isDataTargetsAllowedForBuffModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataTargetsAllowedForBuffModified));
            _dataTargetsAllowedForBuff = new Lazy<ObjectProperty<IEnumerable<Target>>>(() => new ObjectProperty<IEnumerable<Target>>(GetDataTargetsAllowedForBuff, SetDataTargetsAllowedForBuff));
        }

        public InciteUnholyFrenzy(ObjectDatabaseBase db): base(1718973761, db)
        {
            _dataPreferHostilesRaw = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataPreferHostilesRaw, SetDataPreferHostilesRaw));
            _isDataPreferHostilesModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataPreferHostilesModified));
            _dataPreferHostiles = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataPreferHostiles, SetDataPreferHostiles));
            _dataPreferFriendliesRaw = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataPreferFriendliesRaw, SetDataPreferFriendliesRaw));
            _isDataPreferFriendliesModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataPreferFriendliesModified));
            _dataPreferFriendlies = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataPreferFriendlies, SetDataPreferFriendlies));
            _dataMaxUnits = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataMaxUnits, SetDataMaxUnits));
            _isDataMaxUnitsModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataMaxUnitsModified));
            _dataAttackSpeedBonus = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataAttackSpeedBonus, SetDataAttackSpeedBonus));
            _isDataAttackSpeedBonusModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataAttackSpeedBonusModified));
            _dataDamagePerSecond = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamagePerSecond, SetDataDamagePerSecond));
            _isDataDamagePerSecondModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataDamagePerSecondModified));
            _dataRequiresUndeadTargetRaw = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataRequiresUndeadTargetRaw, SetDataRequiresUndeadTargetRaw));
            _isDataRequiresUndeadTargetModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataRequiresUndeadTargetModified));
            _dataRequiresUndeadTarget = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataRequiresUndeadTarget, SetDataRequiresUndeadTarget));
            _dataLeaveTargetAliveRaw = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataLeaveTargetAliveRaw, SetDataLeaveTargetAliveRaw));
            _isDataLeaveTargetAliveModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataLeaveTargetAliveModified));
            _dataLeaveTargetAlive = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataLeaveTargetAlive, SetDataLeaveTargetAlive));
            _dataTargetsAllowedForBuffRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataTargetsAllowedForBuffRaw, SetDataTargetsAllowedForBuffRaw));
            _isDataTargetsAllowedForBuffModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataTargetsAllowedForBuffModified));
            _dataTargetsAllowedForBuff = new Lazy<ObjectProperty<IEnumerable<Target>>>(() => new ObjectProperty<IEnumerable<Target>>(GetDataTargetsAllowedForBuff, SetDataTargetsAllowedForBuff));
        }

        public InciteUnholyFrenzy(int newId, ObjectDatabaseBase db): base(1718973761, newId, db)
        {
            _dataPreferHostilesRaw = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataPreferHostilesRaw, SetDataPreferHostilesRaw));
            _isDataPreferHostilesModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataPreferHostilesModified));
            _dataPreferHostiles = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataPreferHostiles, SetDataPreferHostiles));
            _dataPreferFriendliesRaw = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataPreferFriendliesRaw, SetDataPreferFriendliesRaw));
            _isDataPreferFriendliesModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataPreferFriendliesModified));
            _dataPreferFriendlies = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataPreferFriendlies, SetDataPreferFriendlies));
            _dataMaxUnits = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataMaxUnits, SetDataMaxUnits));
            _isDataMaxUnitsModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataMaxUnitsModified));
            _dataAttackSpeedBonus = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataAttackSpeedBonus, SetDataAttackSpeedBonus));
            _isDataAttackSpeedBonusModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataAttackSpeedBonusModified));
            _dataDamagePerSecond = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamagePerSecond, SetDataDamagePerSecond));
            _isDataDamagePerSecondModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataDamagePerSecondModified));
            _dataRequiresUndeadTargetRaw = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataRequiresUndeadTargetRaw, SetDataRequiresUndeadTargetRaw));
            _isDataRequiresUndeadTargetModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataRequiresUndeadTargetModified));
            _dataRequiresUndeadTarget = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataRequiresUndeadTarget, SetDataRequiresUndeadTarget));
            _dataLeaveTargetAliveRaw = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataLeaveTargetAliveRaw, SetDataLeaveTargetAliveRaw));
            _isDataLeaveTargetAliveModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataLeaveTargetAliveModified));
            _dataLeaveTargetAlive = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataLeaveTargetAlive, SetDataLeaveTargetAlive));
            _dataTargetsAllowedForBuffRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataTargetsAllowedForBuffRaw, SetDataTargetsAllowedForBuffRaw));
            _isDataTargetsAllowedForBuffModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataTargetsAllowedForBuffModified));
            _dataTargetsAllowedForBuff = new Lazy<ObjectProperty<IEnumerable<Target>>>(() => new ObjectProperty<IEnumerable<Target>>(GetDataTargetsAllowedForBuff, SetDataTargetsAllowedForBuff));
        }

        public InciteUnholyFrenzy(string newRawcode, ObjectDatabaseBase db): base(1718973761, newRawcode, db)
        {
            _dataPreferHostilesRaw = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataPreferHostilesRaw, SetDataPreferHostilesRaw));
            _isDataPreferHostilesModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataPreferHostilesModified));
            _dataPreferHostiles = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataPreferHostiles, SetDataPreferHostiles));
            _dataPreferFriendliesRaw = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataPreferFriendliesRaw, SetDataPreferFriendliesRaw));
            _isDataPreferFriendliesModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataPreferFriendliesModified));
            _dataPreferFriendlies = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataPreferFriendlies, SetDataPreferFriendlies));
            _dataMaxUnits = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataMaxUnits, SetDataMaxUnits));
            _isDataMaxUnitsModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataMaxUnitsModified));
            _dataAttackSpeedBonus = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataAttackSpeedBonus, SetDataAttackSpeedBonus));
            _isDataAttackSpeedBonusModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataAttackSpeedBonusModified));
            _dataDamagePerSecond = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamagePerSecond, SetDataDamagePerSecond));
            _isDataDamagePerSecondModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataDamagePerSecondModified));
            _dataRequiresUndeadTargetRaw = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataRequiresUndeadTargetRaw, SetDataRequiresUndeadTargetRaw));
            _isDataRequiresUndeadTargetModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataRequiresUndeadTargetModified));
            _dataRequiresUndeadTarget = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataRequiresUndeadTarget, SetDataRequiresUndeadTarget));
            _dataLeaveTargetAliveRaw = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataLeaveTargetAliveRaw, SetDataLeaveTargetAliveRaw));
            _isDataLeaveTargetAliveModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataLeaveTargetAliveModified));
            _dataLeaveTargetAlive = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataLeaveTargetAlive, SetDataLeaveTargetAlive));
            _dataTargetsAllowedForBuffRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataTargetsAllowedForBuffRaw, SetDataTargetsAllowedForBuffRaw));
            _isDataTargetsAllowedForBuffModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataTargetsAllowedForBuffModified));
            _dataTargetsAllowedForBuff = new Lazy<ObjectProperty<IEnumerable<Target>>>(() => new ObjectProperty<IEnumerable<Target>>(GetDataTargetsAllowedForBuff, SetDataTargetsAllowedForBuff));
        }

        public ObjectProperty<int> DataPreferHostilesRaw => _dataPreferHostilesRaw.Value;
        public ReadOnlyObjectProperty<bool> IsDataPreferHostilesModified => _isDataPreferHostilesModified.Value;
        public ObjectProperty<bool> DataPreferHostiles => _dataPreferHostiles.Value;
        public ObjectProperty<int> DataPreferFriendliesRaw => _dataPreferFriendliesRaw.Value;
        public ReadOnlyObjectProperty<bool> IsDataPreferFriendliesModified => _isDataPreferFriendliesModified.Value;
        public ObjectProperty<bool> DataPreferFriendlies => _dataPreferFriendlies.Value;
        public ObjectProperty<int> DataMaxUnits => _dataMaxUnits.Value;
        public ReadOnlyObjectProperty<bool> IsDataMaxUnitsModified => _isDataMaxUnitsModified.Value;
        public ObjectProperty<float> DataAttackSpeedBonus => _dataAttackSpeedBonus.Value;
        public ReadOnlyObjectProperty<bool> IsDataAttackSpeedBonusModified => _isDataAttackSpeedBonusModified.Value;
        public ObjectProperty<float> DataDamagePerSecond => _dataDamagePerSecond.Value;
        public ReadOnlyObjectProperty<bool> IsDataDamagePerSecondModified => _isDataDamagePerSecondModified.Value;
        public ObjectProperty<int> DataRequiresUndeadTargetRaw => _dataRequiresUndeadTargetRaw.Value;
        public ReadOnlyObjectProperty<bool> IsDataRequiresUndeadTargetModified => _isDataRequiresUndeadTargetModified.Value;
        public ObjectProperty<bool> DataRequiresUndeadTarget => _dataRequiresUndeadTarget.Value;
        public ObjectProperty<int> DataLeaveTargetAliveRaw => _dataLeaveTargetAliveRaw.Value;
        public ReadOnlyObjectProperty<bool> IsDataLeaveTargetAliveModified => _isDataLeaveTargetAliveModified.Value;
        public ObjectProperty<bool> DataLeaveTargetAlive => _dataLeaveTargetAlive.Value;
        public ObjectProperty<string> DataTargetsAllowedForBuffRaw => _dataTargetsAllowedForBuffRaw.Value;
        public ReadOnlyObjectProperty<bool> IsDataTargetsAllowedForBuffModified => _isDataTargetsAllowedForBuffModified.Value;
        public ObjectProperty<IEnumerable<Target>> DataTargetsAllowedForBuff => _dataTargetsAllowedForBuff.Value;
        private int GetDataPreferHostilesRaw(int level)
        {
            return _modifications.GetModification(895577938, level).ValueAsInt;
        }

        private void SetDataPreferHostilesRaw(int level, int value)
        {
            _modifications[895577938, level] = new LevelObjectDataModification{Id = 895577938, Type = ObjectDataType.Int, Value = value, Level = level, Pointer = 5};
        }

        private bool GetIsDataPreferHostilesModified(int level)
        {
            return _modifications.ContainsKey(895577938, level);
        }

        private bool GetDataPreferHostiles(int level)
        {
            return GetDataPreferHostilesRaw(level).ToBool(this);
        }

        private void SetDataPreferHostiles(int level, bool value)
        {
            SetDataPreferHostilesRaw(level, value.ToRaw(0, 1));
        }

        private int GetDataPreferFriendliesRaw(int level)
        {
            return _modifications.GetModification(912355154, level).ValueAsInt;
        }

        private void SetDataPreferFriendliesRaw(int level, int value)
        {
            _modifications[912355154, level] = new LevelObjectDataModification{Id = 912355154, Type = ObjectDataType.Int, Value = value, Level = level, Pointer = 6};
        }

        private bool GetIsDataPreferFriendliesModified(int level)
        {
            return _modifications.ContainsKey(912355154, level);
        }

        private bool GetDataPreferFriendlies(int level)
        {
            return GetDataPreferFriendliesRaw(level).ToBool(this);
        }

        private void SetDataPreferFriendlies(int level, bool value)
        {
            SetDataPreferFriendliesRaw(level, value.ToRaw(0, 1));
        }

        private int GetDataMaxUnits(int level)
        {
            return _modifications.GetModification(929132370, level).ValueAsInt;
        }

        private void SetDataMaxUnits(int level, int value)
        {
            _modifications[929132370, level] = new LevelObjectDataModification{Id = 929132370, Type = ObjectDataType.Int, Value = value, Level = level, Pointer = 7};
        }

        private bool GetIsDataMaxUnitsModified(int level)
        {
            return _modifications.ContainsKey(929132370, level);
        }

        private float GetDataAttackSpeedBonus(int level)
        {
            return _modifications.GetModification(828794965, level).ValueAsFloat;
        }

        private void SetDataAttackSpeedBonus(int level, float value)
        {
            _modifications[828794965, level] = new LevelObjectDataModification{Id = 828794965, Type = ObjectDataType.Unreal, Value = value, Level = level, Pointer = 1};
        }

        private bool GetIsDataAttackSpeedBonusModified(int level)
        {
            return _modifications.ContainsKey(828794965, level);
        }

        private float GetDataDamagePerSecond(int level)
        {
            return _modifications.GetModification(845572181, level).ValueAsFloat;
        }

        private void SetDataDamagePerSecond(int level, float value)
        {
            _modifications[845572181, level] = new LevelObjectDataModification{Id = 845572181, Type = ObjectDataType.Unreal, Value = value, Level = level, Pointer = 2};
        }

        private bool GetIsDataDamagePerSecondModified(int level)
        {
            return _modifications.ContainsKey(845572181, level);
        }

        private int GetDataRequiresUndeadTargetRaw(int level)
        {
            return _modifications.GetModification(828798293, level).ValueAsInt;
        }

        private void SetDataRequiresUndeadTargetRaw(int level, int value)
        {
            _modifications[828798293, level] = new LevelObjectDataModification{Id = 828798293, Type = ObjectDataType.Int, Value = value, Level = level, Pointer = 3};
        }

        private bool GetIsDataRequiresUndeadTargetModified(int level)
        {
            return _modifications.ContainsKey(828798293, level);
        }

        private bool GetDataRequiresUndeadTarget(int level)
        {
            return GetDataRequiresUndeadTargetRaw(level).ToBool(this);
        }

        private void SetDataRequiresUndeadTarget(int level, bool value)
        {
            SetDataRequiresUndeadTargetRaw(level, value.ToRaw(0, 1));
        }

        private int GetDataLeaveTargetAliveRaw(int level)
        {
            return _modifications.GetModification(845575509, level).ValueAsInt;
        }

        private void SetDataLeaveTargetAliveRaw(int level, int value)
        {
            _modifications[845575509, level] = new LevelObjectDataModification{Id = 845575509, Type = ObjectDataType.Int, Value = value, Level = level, Pointer = 4};
        }

        private bool GetIsDataLeaveTargetAliveModified(int level)
        {
            return _modifications.ContainsKey(845575509, level);
        }

        private bool GetDataLeaveTargetAlive(int level)
        {
            return GetDataLeaveTargetAliveRaw(level).ToBool(this);
        }

        private void SetDataLeaveTargetAlive(int level, bool value)
        {
            SetDataLeaveTargetAliveRaw(level, value.ToRaw(0, 1));
        }

        private string GetDataTargetsAllowedForBuffRaw(int level)
        {
            return _modifications.GetModification(862352725, level).ValueAsString;
        }

        private void SetDataTargetsAllowedForBuffRaw(int level, string value)
        {
            _modifications[862352725, level] = new LevelObjectDataModification{Id = 862352725, Type = ObjectDataType.String, Value = value, Level = level, Pointer = 8};
        }

        private bool GetIsDataTargetsAllowedForBuffModified(int level)
        {
            return _modifications.ContainsKey(862352725, level);
        }

        private IEnumerable<Target> GetDataTargetsAllowedForBuff(int level)
        {
            return GetDataTargetsAllowedForBuffRaw(level).ToIEnumerableTarget(this);
        }

        private void SetDataTargetsAllowedForBuff(int level, IEnumerable<Target> value)
        {
            SetDataTargetsAllowedForBuffRaw(level, value.ToRaw(null, null));
        }
    }
}