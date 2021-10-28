﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using War3Api.Object;

namespace AzerothWarsCSharp.Launcher.ObjectFactory.Units
{
  public class UnitFactory : IObjectFactory<Unit>
  {
    private void GenerateTooltip(Unit unit)
    {
      var tooltipBuilder = new StringBuilder();
      tooltipBuilder.Append($"{Flavour}|n|n");
      tooltipBuilder.Append($"|c006969FFHit points|r: {unit.StatsHitPointsMaximumBase}|n");
      tooltipBuilder.Append($"|c006969FFAttack damage|r: {unit.DamageRangeString()}|n");
      tooltipBuilder.Append($"|c006969FFAbilities|r: ");
      foreach (var ability in unit.AbilitiesNormal)
      {
        tooltipBuilder.Append($"{ability.TextName}");
      }
      unit.TextTooltipExtended = tooltipBuilder.ToString();
    }

    /// <summary>
    /// Apply non-tooltip information from the factory to a unit being generated.
    /// </summary>
    /// <param name="unit"></param>
    protected void GenerateCore(Unit unit)
    {
#pragma warning disable CS0618 // Type or member is obsolete
      unit.TechtreeStructuresBuilt = StructuresBuilt;
      unit.StatsBuildTime = BuildTime;
      unit.ArtScalingValue = ScalingValue;
      unit.PathingCollisionSize = CollisionSize;
      unit.ArtButtonPositionX = ButtonPosition.X;
      unit.ArtButtonPositionY = ButtonPosition.Y;
      unit.CombatAttack1DamageBase = DamageBase;
      unit.CombatAttack1DamageNumberOfDice = DamageNumberOfDice;
      unit.CombatAttack1DamageSidesPerDie = DamageSidesPerDie;
      unit.StatsHitPointsMaximumBase = HitPoints;
      unit.TextName = Name;
      unit.ArtModelFile = ArtModelFile;
      unit.ArtIconGameInterface = $@"ReplaceableTextures\CommandButtons\BTN{Icon}.blp";
      unit.AbilitiesNormal = AbilitiesNormal;
      unit.ArtRequiredAnimationNames = RequiredAnimationNames;
      unit.CombatDefenseBase = Armor;
      unit.StatsGoldCost = GoldCost;
      unit.StatsFoodProduced = FoodProduced;
      unit.TechtreeUpgradesUsedRaw = ResearchesUsedRaw;
      unit.TechtreeUpgradesUsed = ResearchesUsed;
      unit.StatsUnitClassification = Classification;
      unit.StatsFoodCost = FoodCost;
      unit.CombatAttack1DamageBase = DamageBase1;
      unit.CombatAttack1DamageSidesPerDie = DamageSidesPerDie1;
      unit.StatsManaInitialAmount = StartingMana;
      unit.StatsManaMaximum = Mana;
      unit.TechtreeRevivesDeadHeroes = RevivesDeadHeroes;
      unit.PathingPlacementPreventedBy = PlacementPreventedBy;
      unit.PathingPlacementRequires = PlacementRequires;
      //Calculated
      unit.StatsRepairGoldCost = GoldCost;
      unit.StatsRepairLumberCost = LumberCost;
#pragma warning restore CS0618 // Type or member is obsolete
    }

    /// <summary>
    /// Generate a unit instance.
    /// </summary>
    public Unit Generate(string newRawCode, ObjectDatabase objectDatabase)
    {
      var newUnit = new Unit(BaseType, newRawCode, objectDatabase);
      GenerateCore(newUnit);
      GenerateTooltip(newUnit);
      return newUnit;
    }

    private IEnumerable<Unit> _structuresBuilt;
    public IEnumerable<Unit> StructuresBuilt
    {
      get
      {
        return _structuresBuilt ?? Parent?.StructuresBuilt ?? System.Array.Empty<Unit>();
      }
      set
      {
        _structuresBuilt = value;
      }
    }

    private int? _buildTime;
    public int BuildTime
    {
      get
      {
        return _buildTime ?? Parent?.BuildTime ?? 5;
      }
      set
      {
        _buildTime = value;
      }
    }

    private float? _scalingValue;
    public float ScalingValue
    {
      get
      {
        return _scalingValue ?? Parent?.ScalingValue ?? 1;
      }
      set
      {
        _scalingValue = value;
      }
    }

    private float? _collisionSize;
    public float CollisionSize
    {
      get
      {
        return _collisionSize ?? Parent?.CollisionSize ?? 1;
      }
      set
      {
        _collisionSize = value;
      }
    }

    private Point? _buttonPosition;
    public Point ButtonPosition
    {
      get
      {
        return _buttonPosition ?? Parent?.ButtonPosition ?? new Point(0, 0);
      }
      set
      {
        _buttonPosition = value;
      }
    }

    private string _flavour;
    public string Flavour
    {
      get
      {
        return _flavour ?? Parent?.Flavour ?? "PLACEHOLDERFLAVOR";
      }
      set
      {
        _flavour = value;
      }
    }


    private int? _damageBase;
    public int DamageBase
    {
      get
      {
        return _damageBase ?? Parent?.DamageBase ?? 0;
      }
      set
      {
        _damageBase = value;
      }
    }

    private int? _damageNumberOfDice;
    public int DamageNumberOfDice
    {
      get
      {
        return _damageNumberOfDice ?? Parent?.DamageNumberOfDice ?? 0;
      }
      set
      {
        _damageNumberOfDice = value;
      }
    }

    private int? _damageSidesPerDie;
    public int DamageSidesPerDie
    {
      get
      {
        return _damageSidesPerDie ?? Parent?.DamageSidesPerDie ?? 0;
      }
      set
      {
        _damageSidesPerDie = value;
      }
    }

    private int? _hitPoints;
    public int HitPoints
    {
      get
      {
        return _hitPoints ?? Parent?.HitPoints ?? 1;
      }
      set
      {
        _hitPoints = value;
      }
    }

    private int? _mana;
    /// <summary>
    /// How much maximum mana the unit has with which to cast abilities.
    /// </summary>
    public int Mana
    {
      get
      {
        return _mana ?? Parent?.Mana ?? 0;
      }
      set
      {
        _mana = value;
      }
    }

    private int? _startingMana;
    /// <summary>
    /// How much mana the unit has when it enters the map.
    /// </summary>
    public int StartingMana
    {
      get
      {
        return _startingMana ?? Parent?.StartingMana ?? 0;
      }
      set
      {
        _startingMana = value;
      }
    }

    private string _name;
    public string Name
    {
      get
      {
        return _name ?? Parent?.Name ?? "PLACEHOLDERNAME";
      }
      set
      {
        _name = value;
      }
    }

    private string _artModelFile;
    public string ArtModelFile
    {
      get
      {
        return _artModelFile ?? Parent?.ArtModelFile ?? @"units\human\Peasant\Peasant";
      }
      set
      {
        _artModelFile = value;
      }
    }

    private string _icon;
    public string Icon
    {
      get
      {
        return _icon ?? Parent?.Icon ?? @"Peasant";
      }
      set
      {
        _icon = value;
      }
    }

    private UnitType? _baseType;
    public UnitType BaseType
    {
      get
      {
        return _baseType ?? Parent?.BaseType ?? UnitType.Peasant_hpea;
      }
      set
      {
        _baseType = value;
      }
    }

    private IEnumerable<Ability> _abilitiesNormal;
    public IEnumerable<Ability> AbilitiesNormal
    {
      get
      {
        return _abilitiesNormal ?? Parent?.AbilitiesNormal ?? System.Array.Empty<Ability>();
      }
      set
      {
        _abilitiesNormal = value;
      }
    }

    private string _abilitiesNormalRaw;
    [Obsolete("This property is obsolete. Use AbilitiesNormal instead.", false)]
    public string AbilitiesNormalRaw
    {
      get
      {
        return _abilitiesNormalRaw ?? Parent?.AbilitiesNormalRaw ?? null;
      }
      set
      {
        _abilitiesNormalRaw = value;
      }
    }

    private IEnumerable<Upgrade> _researchesUsed;
    public IEnumerable<Upgrade> ResearchesUsed
    {
      get => _researchesUsed ?? Parent?.ResearchesUsed ?? System.Array.Empty<Upgrade>();
      set => _researchesUsed = value;
    }

    private string _researchesUsedRaw;
    [Obsolete("This property is obsolete. Use ResearchesUsed instead.", false)]
    public string ResearchesUsedRaw
    {
      get => _researchesUsedRaw ?? Parent?.ResearchesUsedRaw ?? "";
      set => _researchesUsedRaw = value;
    }

    private IEnumerable<string> _requiredAnimationNames;
    public IEnumerable<string> RequiredAnimationNames
    {
      get
      {
        return _requiredAnimationNames ?? Parent?.RequiredAnimationNames ?? System.Array.Empty<string>();
      }
      set
      {
        _requiredAnimationNames = value;
      }
    }

    private int? _armor = 0;
    public int Armor
    {
      get => _armor ?? Parent?.Armor ?? 0;
      set => _armor = value;
    }

    private int? _foodProduced = 0;
    public int FoodProduced
    {
      get => _foodProduced ?? Parent?.FoodProduced ?? 0;
      set => _foodProduced = value;
    }

    private int? _goldCost = 0;
    public int GoldCost
    {
      get => _goldCost ?? Parent?.GoldCost ?? 0;
      set => _goldCost = value;
    }

    private int? _lumberCost = 0;
    public int LumberCost
    {
      get => _lumberCost ?? Parent?.LumberCost ?? 0;
      set => _lumberCost = value;
    }

    private string _pathTexture;
    public string PathTexture
    {
      get => _pathTexture ?? Parent?.PathTexture ?? "";
      set => _pathTexture = value;
    }

    private int? _level = 0;
    /// <summary>
    /// The unit's level. Affects experience gained and gold bounty.
    /// </summary>
    public int Level
    {
      get => _level ?? Parent?.Level ?? 0;
      set => _level = value;
    }

    private IEnumerable<UnitClassification> _classification;
    /// <summary>
    /// Which unit classications the unit has; e.g. Ancient, Tauren.
    /// </summary>
    public IEnumerable<UnitClassification> Classification
    {
      get => _classification ?? Parent?.Classification ?? System.Array.Empty<UnitClassification>();
      set => _classification = value;
    }

    private int? _foodCost = 0;
    /// <summary>
    /// How much food this unit occupies.
    /// </summary>
    public int FoodCost
    {
      get => _foodCost ?? Parent?.FoodCost ?? 0;
      set => _foodCost = value;
    }

    private int? _damageBase1 = 0;
    /// <summary>
    /// The unit's base damage.
    /// </summary>
    public int DamageBase1
    {
      get => _damageBase1 ?? Parent?.DamageBase1 ?? 0;
      set => _damageBase1 = value;
    }

    private int? _damageSidesPerDie1 = 0;
    public int DamageSidesPerDie1
    {
      get => _damageSidesPerDie1 ?? Parent?.DamageSidesPerDie1 ?? 0;
      set => _damageSidesPerDie1 = value;
    }

    private IEnumerable<PathingPrevent> _placementRequires;
    public IEnumerable<PathingPrevent> PlacementRequires
    {
      get => _placementRequires ?? Parent?.PlacementRequires ?? System.Array.Empty<PathingPrevent>();
      set => _placementRequires = value;
    }

    private IEnumerable<PathingRequire> _placementPreventedBy;
    public IEnumerable<PathingRequire> PlacementPreventedBy
    {
      get => _placementPreventedBy ?? Parent?.PlacementPreventedBy ?? System.Array.Empty<PathingRequire>();
      set => _placementPreventedBy = value;
    }

    private bool? _revivesDeadHeroes;
    /// <summary>
    /// Whether the unit can revive dead heroes.
    /// </summary>
    public bool RevivesDeadHeroes
    {
      get => _revivesDeadHeroes ?? Parent?.RevivesDeadHeroes ?? false;
      set => _revivesDeadHeroes = value;
    }

    private RegenType? _regenType;
    /// <summary>
    /// In which circumstances the unit regenerates hit points.
    /// </summary>
    public RegenType RegenType
    {
      get => _regenType ?? Parent?.RegenType ?? RegenType.Always;
      set => _regenType = value;
    }

    private IEnumerable<Target> _targets1;
    /// <summary>
    /// Which targets the units first attack can can be used against.
    /// </summary>
    public IEnumerable<Target> Targets1
    {
      get => _targets1 ?? Parent?.Targets1 ?? Array.Empty<Target>();
      set => _targets1 = value;
    }

    private IEnumerable<Target> _targets2;
    /// <summary>
    /// Which targets the units second attack can can be used against.
    /// </summary>
    public IEnumerable<Target> Targets2
    {
      get => _targets2 ?? Parent?.Targets2 ?? Array.Empty<Target>();
      set => _targets2 = value;
    }

    public UnitFactory Parent { get; set; }

    public UnitFactory(UnitType baseType)
    {
      BaseType = baseType;
      Flavour = "";
    }
  }
}