﻿using AzerothWarsCSharp.MacroTools;
using AzerothWarsCSharp.MacroTools.FactionSystem;
using AzerothWarsCSharp.MacroTools.QuestSystem;
using AzerothWarsCSharp.MacroTools.QuestSystem.UtilityStructs;
using AzerothWarsCSharp.MacroTools.Wrappers;
using AzerothWarsCSharp.Source.Setup;
using AzerothWarsCSharp.Source.Setup.Legends;
using WCSharp.Shared.Data;

namespace AzerothWarsCSharp.Source.Quests.Quelthalas
{
   public sealed class QuestTempestKeep : QuestData
   {
      public QuestTempestKeep() : base("In Search of Masters",
         "The Blood Elves are starved for magic; they need to search for more powerful sources of it. Maybe Outland is the answer to their plight.",
         @"ReplaceableTextures\CommandButtons\BTNBloodelvenWarrior.blp")
      {
         AddObjective(new ObjectiveCastSpell(Constants.ABILITY_A0IP_GO_TO_OUTLAND_AND_BUILD_TEMPEST_KEEP_KAEL_PATH,
            true));
         AddObjective(new ObjectiveControlLegend(LegendQuelthalas.LegendKael, true));
         ResearchId = Constants.UPGRADE_R073_QUEST_COMPLETED_TEMPEST_KEEP;
      }

      protected override void OnComplete(Faction completingFaction)
      {
         LegendQuelthalas.LegendKael.Unit?.SetOwner(Player(PLAYER_NEUTRAL_AGGRESSIVE));
         completingFaction.Obliterate();
         LegendQuelthalas.LegendKael.Unit?.SetOwner(completingFaction.Player ?? Player(GetBJPlayerNeutralVictim()));

         var greatTreachery = new QuestGreatTreachery(Constants.ABILITY_A0IF_PERFORM_THE_GREAT_TREACHERY_FACTION_SELECT,
            Constants.ABILITY_A0IK_STAY_LOYAL_TO_THE_ILLIDARI_FACTION_SELECT);
         completingFaction.AddQuest(greatTreachery);
         greatTreachery.DisplayDiscovered(completingFaction);

         completingFaction.ModObjectLimit(Constants.UNIT_H00Q_KING_OF_QUEL_THALAS_QUEL_THALAS,
            -Faction.UNLIMITED);
         completingFaction.ModObjectLimit(Constants.UNIT_HVWD_RANGER_GENERAL_OF_SILVERMOON_QUEL_THALAS,
            -Faction.UNLIMITED);
         completingFaction.ModObjectLimit(Constants.UNIT_N075_VEREESA_WINDRUNNER_QUEL_THALAS_DEMI,
            -Faction.UNLIMITED);
         completingFaction.ModObjectLimit(Constants.UNIT_N00A_FARSTRIDER_QUEL_THALAS,
            -Faction.UNLIMITED);
         completingFaction.ModObjectLimit(Constants.UNIT_HHES_SWORDSMAN_QUEL_THALAS,
            -Faction.UNLIMITED);
         completingFaction.ModObjectLimit(Constants.UNIT_NBEL_SUNFURY_WARRIOR_QUEL_THALAS,
            Faction.UNLIMITED);
         completingFaction.ModObjectLimit(Constants.UNIT_N09S_BLOOD_ELVEN_RANGER_QUEL_THALAS, 6);
         completingFaction.ModObjectLimit(Constants.UNIT_N02F_FELBLOOD_WARLOCK_QUEL_THALAS, 6);
         completingFaction.ModObjectLimit(Constants.UNIT_E01B_ARCANE_ANNIHILATOR_QUELTHALAS, 6);
         completingFaction.ModObjectLimit(Constants.UNIT_H00Q_KING_OF_QUEL_THALAS_QUEL_THALAS,
            -Faction.UNLIMITED);
         completingFaction.ModObjectLimit(Constants.UNIT_HVWD_RANGER_GENERAL_OF_SILVERMOON_QUEL_THALAS,
            -Faction.UNLIMITED);
         LegendQuelthalas.LegendAnasterian.Unit?.Remove();
         LegendQuelthalas.LegendSylvanas.Unit?.Remove();

         LegendQuelthalas.LegendKael.Unit?.SetPosition(new Point(4067, -21695));
         LegendQuelthalas.LegendKael.Unit?.SetPosition(new Point(4067, -21695));

         UnitRemoveAbility(LegendQuelthalas.LegendKael.Unit,
            Constants.ABILITY_A0IP_GO_TO_OUTLAND_AND_BUILD_TEMPEST_KEEP_KAEL_PATH);
         SetPlayerTechResearched(completingFaction.Player,
            Constants.UPGRADE_R076_KIL_JAEDEN_HAS_MADE_HIS_OFFER_TO_KAEL_QUELTHALAS, 1);

         foreach (var unit in new GroupWrapper().EnumUnitsInRect(Regions.TempestKeep).EmptyToList())
         {
            unit.Rescue(completingFaction.Player ?? Player(GetBJPlayerNeutralVictim()));
         }

         //foreach (var unit in new GroupWrapper().EnumUnitsInRect(Regions.TempestKeep2).EmptyToList())
         //{
         //   unit.Rescue(completingFaction.Player);
         //}

         completingFaction.Player?.SetTeam(TeamSetup.Naga);
         UnitAddAbility(LegendQuelthalas.LegendKael.Unit,
            Constants.ABILITY_A0IK_STAY_LOYAL_TO_THE_ILLIDARI_FACTION_SELECT);
         UnitAddAbility(LegendQuelthalas.LegendKael.Unit,
            Constants.ABILITY_A0IF_PERFORM_THE_GREAT_TREACHERY_FACTION_SELECT);

         completingFaction.Gold += 2000;
         completingFaction.Lumber += 4000;

         completingFaction.Name = "Blood Elves";
         completingFaction.Icon = "ReplaceableTextures\\CommandButtons\\BTNBloodMage2.blp";

         if (GetLocalPlayer() == completingFaction.Player)
         {
            SetCameraPosition(Regions.TempestKeepSpawn.Center.X, Regions.TempestKeepSpawn.Center.Y);
         }
      }

      protected override string CompletionPopup => "The Tempest Keep has been constructed.";

      protected override string RewardDescription =>
         "Control of the Tempest Keep"; //Todo; this doesn't describe what the quest does at all
   }
}