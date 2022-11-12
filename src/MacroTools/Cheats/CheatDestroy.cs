﻿using MacroTools.ArtifactSystem;
using MacroTools.CheatSystem;
using static War3Api.Common;

namespace MacroTools.Cheats
{
  /// <summary>
  /// Destroys an <see cref="Artifact"/>.
  /// </summary>
  public sealed class CheatDestroy : Cheat
  {
    /// <inheritdoc />
    public override string Command => "destroy";

    /// <inheritdoc />
    public override int ParameterCount => 1;
    
    /// <inheritdoc />
    public override string Execute(player cheater, params string[] parameters)
    {
      var artifact = ArtifactManager.GetFromName(parameters[0]);
      if (artifact == null)
      {
        return $"You must specify the name of a registered {nameof(Artifact)} as the first parameter.";
      }
      ArtifactManager.Destroy(artifact);
      return $"Destroying {GetItemName(artifact.Item)}";
    }
  }
}