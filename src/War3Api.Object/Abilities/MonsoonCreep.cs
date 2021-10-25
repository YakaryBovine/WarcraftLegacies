using System;
using System.Collections.Generic;
using System.Linq;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class MonsoonCreep : Ability
    {
        private readonly Lazy<ObjectProperty<float>> _dataDamageDealt;
        private readonly Lazy<ObjectProperty<float>> _dataDamageInterval;
        private readonly Lazy<ObjectProperty<float>> _dataBuildingReduction;
        public MonsoonCreep(): base(1869431617)
        {
            _dataDamageDealt = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamageDealt, SetDataDamageDealt));
            _dataDamageInterval = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamageInterval, SetDataDamageInterval));
            _dataBuildingReduction = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataBuildingReduction, SetDataBuildingReduction));
        }

        public MonsoonCreep(int newId): base(1869431617, newId)
        {
            _dataDamageDealt = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamageDealt, SetDataDamageDealt));
            _dataDamageInterval = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamageInterval, SetDataDamageInterval));
            _dataBuildingReduction = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataBuildingReduction, SetDataBuildingReduction));
        }

        public MonsoonCreep(string newRawcode): base(1869431617, newRawcode)
        {
            _dataDamageDealt = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamageDealt, SetDataDamageDealt));
            _dataDamageInterval = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamageInterval, SetDataDamageInterval));
            _dataBuildingReduction = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataBuildingReduction, SetDataBuildingReduction));
        }

        public MonsoonCreep(ObjectDatabase db): base(1869431617, db)
        {
            _dataDamageDealt = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamageDealt, SetDataDamageDealt));
            _dataDamageInterval = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamageInterval, SetDataDamageInterval));
            _dataBuildingReduction = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataBuildingReduction, SetDataBuildingReduction));
        }

        public MonsoonCreep(int newId, ObjectDatabase db): base(1869431617, newId, db)
        {
            _dataDamageDealt = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamageDealt, SetDataDamageDealt));
            _dataDamageInterval = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamageInterval, SetDataDamageInterval));
            _dataBuildingReduction = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataBuildingReduction, SetDataBuildingReduction));
        }

        public MonsoonCreep(string newRawcode, ObjectDatabase db): base(1869431617, newRawcode, db)
        {
            _dataDamageDealt = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamageDealt, SetDataDamageDealt));
            _dataDamageInterval = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamageInterval, SetDataDamageInterval));
            _dataBuildingReduction = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataBuildingReduction, SetDataBuildingReduction));
        }

        public ObjectProperty<float> DataDamageDealt => _dataDamageDealt.Value;
        public ObjectProperty<float> DataDamageInterval => _dataDamageInterval.Value;
        public ObjectProperty<float> DataBuildingReduction => _dataBuildingReduction.Value;
        private float GetDataDamageDealt(int level)
        {
            return _modifications[828797765, level].ValueAsFloat;
        }

        private void SetDataDamageDealt(int level, float value)
        {
            _modifications[828797765, level] = new LevelObjectDataModification{Id = 828797765, Type = ObjectDataType.Unreal, Value = value, Level = level, Pointer = 1};
        }

        private float GetDataDamageInterval(int level)
        {
            return _modifications[845574981, level].ValueAsFloat;
        }

        private void SetDataDamageInterval(int level, float value)
        {
            _modifications[845574981, level] = new LevelObjectDataModification{Id = 845574981, Type = ObjectDataType.Unreal, Value = value, Level = level, Pointer = 2};
        }

        private float GetDataBuildingReduction(int level)
        {
            return _modifications[862352197, level].ValueAsFloat;
        }

        private void SetDataBuildingReduction(int level, float value)
        {
            _modifications[862352197, level] = new LevelObjectDataModification{Id = 862352197, Type = ObjectDataType.Unreal, Value = value, Level = level, Pointer = 3};
        }
    }
}