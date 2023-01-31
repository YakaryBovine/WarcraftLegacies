﻿using MacroTools.CommandSystem;
using MacroTools.Extensions;
using MacroTools.ShoreSystem;
using static War3Api.Common;

namespace MacroTools.Cheats
{
  /// <summary>
  /// A cheat <see cref="Command"/> that removes all of your units, then spawns a large, invulnerable peon at all registered {nameof(Shore)}s.
  /// </summary>
  public sealed class CheatShore : Command
  {
    /// <inheritdoc />
    public override string CommandText => "shores";

    /// <inheritdoc />
    public override int MinimumParameterCount => 0;

    /// <inheritdoc />
    public override CommandType Type => CommandType.Cheat;

    /// <inheritdoc />
    public override string Description => $"Removes all of your units, then spawns a large, invulnerable peon at all registered {nameof(Shore)}s.";

    private bool _executed;
    
    /// <inheritdoc />
    public override string Execute(player cheater, params string[] parameters)
    {
      if (_executed)
        return $"{nameof(CheatShore)} has already been executed and cannot be executed multiple times.";
      
      _executed = true;

      foreach (var unit in CreateGroup().EnumUnitsOfPlayer(cheater).EmptyToList()) 
        unit.Remove();

      foreach (var shore in ShoreManager.GetAllShores())
      {
        CreateUnit(cheater, FourCC("opeo"), shore.Position.X, shore.Position.Y, 0)
          .SetScale(7)
          .SetName(shore.Name)
          .SetInvulnerable(true);
      }

      return $"Created a peon at all registered {nameof(Shore)}s.";
    }
  }
}