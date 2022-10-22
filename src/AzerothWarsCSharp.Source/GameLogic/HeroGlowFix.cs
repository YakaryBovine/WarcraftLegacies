using AzerothWarsCSharp.MacroTools.FactionSystem;
using WCSharp.Events;
using static War3Api.Common;

namespace AzerothWarsCSharp.Source.GameLogic
{
  /// <summary>
  /// Responsible for managing hero glow colours.
  /// </summary>
  public static class HeroGlowFix
  {
    /// <summary>
    /// Causes heroes trained to have their colours manually set to the colour indicated by their <see cref="Legend"/>
    /// class. This avoids a Warcraft 3 issue wherein revived heroes do not have their attachment colours updated to match their colour.
    /// </summary>
    public static void Setup()
    {
      PlayerUnitEvents.Register(PlayerUnitEvent.HeroTypeFinishesRevive, () =>
      {
        var revivedLegend = Legend.GetFromUnit(GetTriggerUnit());
        SetUnitColor(GetTriggerUnit(),
          revivedLegend is {HasCustomColor: true}
            ? revivedLegend.PlayerColor
            : GetTriggerPlayer().GetFaction()?.PlayerColor);
      });
    }
  }
}