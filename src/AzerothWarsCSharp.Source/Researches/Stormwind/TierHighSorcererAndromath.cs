// using static War3Api.Common;  using static AzerothWarsCSharp.MacroTools.GeneralHelpers;
// {
//   public class TierHighSorcererAndromath{
//
//   
//     private const int DEMI_UNITTYPE_ID = FourCC("h05X");
//   
//
//     private static void Research( ){
//       CreateUnit(StormwindSetup.Stormwind.Player, DEMI_UNITTYPE_ID, GetUnitX(GetTriggerUnit()), GetUnitY(GetTriggerUnit()), 0);
//     }
//
//     public static void Setup( ){
//       RegisterResearchFinishedAction(FourCC("R03X"),  Research);
//       StormwindSetup.Stormwind.ModObjectLimit(DEMI_UNITTYPE_ID, 1);
//     }
//
//   }
// }
