using System;
using System.Collections.Generic;
using System.Linq;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class CoupleInstantArcher : Ability
    {
        private readonly Lazy<ObjectProperty<string>> _dataResultingUnitTypeRaw;
        private readonly Lazy<ObjectProperty<Unit>> _dataResultingUnitType;
        private readonly Lazy<ObjectProperty<string>> _dataPartnerUnitTypeRaw;
        private readonly Lazy<ObjectProperty<Unit>> _dataPartnerUnitType;
        private readonly Lazy<ObjectProperty<bool>> _dataMoveToPartner;
        public CoupleInstantArcher(): base(846160705)
        {
            _dataResultingUnitTypeRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataResultingUnitTypeRaw, SetDataResultingUnitTypeRaw));
            _dataResultingUnitType = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataResultingUnitType, SetDataResultingUnitType));
            _dataPartnerUnitTypeRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataPartnerUnitTypeRaw, SetDataPartnerUnitTypeRaw));
            _dataPartnerUnitType = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataPartnerUnitType, SetDataPartnerUnitType));
            _dataMoveToPartner = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataMoveToPartner, SetDataMoveToPartner));
        }

        public CoupleInstantArcher(int newId): base(846160705, newId)
        {
            _dataResultingUnitTypeRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataResultingUnitTypeRaw, SetDataResultingUnitTypeRaw));
            _dataResultingUnitType = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataResultingUnitType, SetDataResultingUnitType));
            _dataPartnerUnitTypeRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataPartnerUnitTypeRaw, SetDataPartnerUnitTypeRaw));
            _dataPartnerUnitType = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataPartnerUnitType, SetDataPartnerUnitType));
            _dataMoveToPartner = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataMoveToPartner, SetDataMoveToPartner));
        }

        public CoupleInstantArcher(string newRawcode): base(846160705, newRawcode)
        {
            _dataResultingUnitTypeRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataResultingUnitTypeRaw, SetDataResultingUnitTypeRaw));
            _dataResultingUnitType = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataResultingUnitType, SetDataResultingUnitType));
            _dataPartnerUnitTypeRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataPartnerUnitTypeRaw, SetDataPartnerUnitTypeRaw));
            _dataPartnerUnitType = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataPartnerUnitType, SetDataPartnerUnitType));
            _dataMoveToPartner = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataMoveToPartner, SetDataMoveToPartner));
        }

        public CoupleInstantArcher(ObjectDatabase db): base(846160705, db)
        {
            _dataResultingUnitTypeRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataResultingUnitTypeRaw, SetDataResultingUnitTypeRaw));
            _dataResultingUnitType = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataResultingUnitType, SetDataResultingUnitType));
            _dataPartnerUnitTypeRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataPartnerUnitTypeRaw, SetDataPartnerUnitTypeRaw));
            _dataPartnerUnitType = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataPartnerUnitType, SetDataPartnerUnitType));
            _dataMoveToPartner = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataMoveToPartner, SetDataMoveToPartner));
        }

        public CoupleInstantArcher(int newId, ObjectDatabase db): base(846160705, newId, db)
        {
            _dataResultingUnitTypeRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataResultingUnitTypeRaw, SetDataResultingUnitTypeRaw));
            _dataResultingUnitType = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataResultingUnitType, SetDataResultingUnitType));
            _dataPartnerUnitTypeRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataPartnerUnitTypeRaw, SetDataPartnerUnitTypeRaw));
            _dataPartnerUnitType = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataPartnerUnitType, SetDataPartnerUnitType));
            _dataMoveToPartner = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataMoveToPartner, SetDataMoveToPartner));
        }

        public CoupleInstantArcher(string newRawcode, ObjectDatabase db): base(846160705, newRawcode, db)
        {
            _dataResultingUnitTypeRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataResultingUnitTypeRaw, SetDataResultingUnitTypeRaw));
            _dataResultingUnitType = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataResultingUnitType, SetDataResultingUnitType));
            _dataPartnerUnitTypeRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataPartnerUnitTypeRaw, SetDataPartnerUnitTypeRaw));
            _dataPartnerUnitType = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataPartnerUnitType, SetDataPartnerUnitType));
            _dataMoveToPartner = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataMoveToPartner, SetDataMoveToPartner));
        }

        public ObjectProperty<string> DataResultingUnitTypeRaw => _dataResultingUnitTypeRaw.Value;
        public ObjectProperty<Unit> DataResultingUnitType => _dataResultingUnitType.Value;
        public ObjectProperty<string> DataPartnerUnitTypeRaw => _dataPartnerUnitTypeRaw.Value;
        public ObjectProperty<Unit> DataPartnerUnitType => _dataPartnerUnitType.Value;
        public ObjectProperty<bool> DataMoveToPartner => _dataMoveToPartner.Value;
        private string GetDataResultingUnitTypeRaw(int level)
        {
            return _modifications[1969319779, level].ValueAsString;
        }

        private void SetDataResultingUnitTypeRaw(int level, string value)
        {
            _modifications[1969319779, level] = new LevelObjectDataModification{Id = 1969319779, Type = ObjectDataType.String, Value = value, Level = level};
        }

        private Unit GetDataResultingUnitType(int level)
        {
            return GetDataResultingUnitTypeRaw(level).ToUnit(this);
        }

        private void SetDataResultingUnitType(int level, Unit value)
        {
            SetDataResultingUnitTypeRaw(level, value.ToRaw(null, null));
        }

        private string GetDataPartnerUnitTypeRaw(int level)
        {
            return _modifications[828469091, level].ValueAsString;
        }

        private void SetDataPartnerUnitTypeRaw(int level, string value)
        {
            _modifications[828469091, level] = new LevelObjectDataModification{Id = 828469091, Type = ObjectDataType.String, Value = value, Level = level, Pointer = 1};
        }

        private Unit GetDataPartnerUnitType(int level)
        {
            return GetDataPartnerUnitTypeRaw(level).ToUnit(this);
        }

        private void SetDataPartnerUnitType(int level, Unit value)
        {
            SetDataPartnerUnitTypeRaw(level, value.ToRaw(null, null));
        }

        private bool GetDataMoveToPartner(int level)
        {
            return _modifications[845246307, level].ValueAsBool;
        }

        private void SetDataMoveToPartner(int level, bool value)
        {
            _modifications[845246307, level] = new LevelObjectDataModification{Id = 845246307, Type = ObjectDataType.Bool, Value = value, Level = level, Pointer = 2};
        }
    }
}