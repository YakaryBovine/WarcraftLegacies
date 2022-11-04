﻿using static War3Api.Common;
using WCSharp.Shared.Data;

namespace MacroTools.Extensions
{
  /// <summary>
  /// Provides a series of useful extensions for the native Warcraft 3 destructable class.
  /// </summary>
  public static class DestructableExtensions
  {
    /// <summary>
    /// Returns the position of the destructable.
    /// </summary>
    public static Point GetPosition(this destructable destructable) =>
      new(GetDestructableX(destructable), GetDestructableY(destructable));
  }
}