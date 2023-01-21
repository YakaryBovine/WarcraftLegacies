using System.Linq;
using MacroTools.CommandSystem;
using MacroTools.Extensions;
using static War3Api.Common;

namespace MacroTools.Cheats
{
  public sealed class CheatSpawn : Command
  {
    /// <inheritdoc />
    public override string CommandText => "spawn";

    /// <inheritdoc />
    public override int ParameterCount => 2;
    
    /// <inheritdoc />
    public override CommandType Type => CommandType.Cheat;
    
    /// <inheritdoc />
    public override string Description => "Spawns the specified units or items the specified number of times.";
    
    private static void SpawnUnitsOrItems(unit whichUnit, int typeId, int count)
    {
      for (var i = 0; i < count; i++)
      {
        CreateUnit(GetTriggerPlayer(), typeId, GetUnitX(whichUnit), GetUnitY(whichUnit), 0);
        CreateItem(typeId, GetUnitX(whichUnit), GetUnitY(whichUnit));
      }
    }

    /// <inheritdoc />
    public override string Execute(player cheater, params string[] parameters)
    {
      var objectTypeId = FourCC(parameters[0]);
      if (objectTypeId == 0)
        return "You must specify a valid object type ID as the first parameter.";

      if (!int.TryParse(parameters[1], out var count))
        return "You must specify a valid count as the second parameter.";

      var firstSelectedUnit = CreateGroup().EnumSelectedUnits(cheater).EmptyToList().First();
      SpawnUnitsOrItems(firstSelectedUnit, objectTypeId, count);
      return $"Attempted to spawn {count} of object {GetObjectName(objectTypeId)}.";
    }
  }
}