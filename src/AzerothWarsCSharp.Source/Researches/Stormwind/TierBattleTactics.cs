// using AzerothWarsCSharp.MacroTools.FactionSystem;
//
// using static War3Api.Common;  using static AzerothWarsCSharp.MacroTools.GeneralHelpers;
// {
//   public class TierBattleTactics{
//
//     private static void Research( ){
//       StormwindSetup.Stormwind.ModObjectLimit(FourCC("h03K"), -Faction.UNLIMITED)      ;//Marshal
//       StormwindSetup.Stormwind.ModObjectLimit(FourCC("h014"), 12)              ;//Marshal (Offensive)
//       StormwindSetup.Stormwind.ModObjectLimit(FourCC("R03B"), Faction.UNLIMITED)       ;//Exploit Weakness
//       StormwindSetup.Stormwind.ModObjectLimit(FourCC("R02Z"), Faction.UNLIMITED)       ;//Reflective Plating
//     }
//
//     public static void Setup( ){
//       RegisterResearchFinishedAction(FourCC("R02Y"),  Research);
//     }
//
//   }
// }
