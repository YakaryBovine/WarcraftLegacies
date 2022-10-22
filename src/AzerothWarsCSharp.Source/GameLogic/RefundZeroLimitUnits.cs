using AzerothWarsCSharp.MacroTools.FactionSystem;
using WCSharp.Events;


namespace AzerothWarsCSharp.Source.GameLogic
{
  /// <summary>
  ///   If a unit with a tech limit of 0 is trained or revived, delete and refund it instantly.
  /// </summary>
  public static class RefundZeroLimitUnits
  {
    private static void VerifyUnitIntegrity(unit whichUnit)
    {
      var player = GetOwningPlayer(whichUnit);
      if (player.GetObjectLimit(GetUnitTypeId(whichUnit)) != 0) 
        return;
      player.AdjustPlayerState(PLAYER_STATE_RESOURCE_GOLD, GetUnitGoldCost(GetUnitTypeId(whichUnit)));
      player.AdjustPlayerState(PLAYER_STATE_RESOURCE_LUMBER, GetUnitWoodCost(GetUnitTypeId(whichUnit)));
      RemoveUnit(whichUnit);
    }

    /// <summary>
    /// Registers triggers that cause the following:
    /// <para>Whenever a unit with a tech limit of 0 is trained or revived, delete and refund it instantly.</para>
    /// </summary>
    public static void Setup()
    {
      PlayerUnitEvents.Register(PlayerUnitEvent.UnitTypeFinishesTraining,
        () => { VerifyUnitIntegrity(GetTrainedUnit()); });
      PlayerUnitEvents.Register(PlayerUnitEvent.HeroTypeFinishesRevive,
        () => { VerifyUnitIntegrity(GetRevivingUnit()); });
    }
  }
}