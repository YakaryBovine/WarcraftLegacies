﻿using System.Collections.Generic;
using System.Drawing;
using System.Text;
using War3Api.Object;

namespace AzerothWarsCSharp.Launcher.ObjectFactory.Units
{
  public class UnitFactory
  {
    protected readonly Unit _unit;

    private void GenerateTooltip()
    {
      var tooltipBuilder = new StringBuilder();
      tooltipBuilder.Append($"{Flavour}|n|n");
      tooltipBuilder.Append($"|c006969FFHit points|r: {_unit.StatsHitPointsMaximumBase}|n");
      tooltipBuilder.Append($"|c006969FFAttack damage|r: {_unit.DamageRangeString()}|n");
      tooltipBuilder.Append($"|c006969FFAbilities|r: ");
      foreach (var ability in _unit.AbilitiesNormal)
      {
        tooltipBuilder.Append($"{ability.TextName}");
      }

      _unit.TextTooltipExtended = tooltipBuilder.ToString();
    }

    /// <summary>
    /// Generate the unabstracted, serializable version of this unit.
    /// </summary>
    public Unit Generate()
    {
      GenerateTooltip();
      return _unit;
    }

    public IEnumerable<Unit> StructuresBuilt
    {
      set
      {
        _unit.TechtreeStructuresBuilt = value;
      }
    }

    public int BuildTime
    {
      set
      {
        _unit.StatsBuildTime = value;
      }
    }

    public float ScalingValue
    {
      set
      {
        _unit.ArtScalingValue = value;
      }
    }

    public float SelectionScale
    {
      set
      {
        _unit.ArtSelectionScale = value;
      }
    }

    public float CollisionSize
    {
      set
      {
        _unit.PathingCollisionSize = value;
      }
    }

    public Point ButtonPosition
    {
      set
      {
        _unit.ArtButtonPositionX = value.X;
        _unit.ArtButtonPositionY = value.Y;
        _unit.TextHotkey = Utils.GetHotkeyByButtonPosition(value);
      }
    }

    public string Flavour
    {
      get;
      set;
    }

    public int DamageBase
    {
      set
      {
        _unit.CombatAttack1DamageBase = value;
      }
    }

    public int DamageNumberOfDice
    {
      set
      {
        _unit.CombatAttack1DamageNumberOfDice = value;
      }
    }

    public int DamageSidesPerDie
    {
      set
      {
        _unit.CombatAttack1DamageSidesPerDie = value;
      }
    }

    public int HitPoints
    {
      set
      {
        _unit.StatsHitPointsMaximumBase = value;
      }
    }

    public string TextName
    {
      set { _unit.TextName = value; }
    }

    public string ArtModelFile
    {
      set { _unit.ArtModelFile = value; }
    }

    public string ArtIconGameInterface
    {
      set { _unit.ArtIconGameInterface = value; }
    }

    public IEnumerable<Ability> AbilitiesNormal
    {
      set { _unit.AbilitiesNormal = value; }
    }

    public UnitFactory(UnitType baseType, string newRawCode)
    {
      _unit = new Unit(baseType, newRawCode);
      Flavour = "";
    }
  }
}