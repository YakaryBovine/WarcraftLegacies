using System;
using AzerothWarsCSharp.MacroTools.FactionSystem;
using WCSharp.Events;
using AzerothWarsCSharp.MacroTools.ArtifactSystem;

namespace AzerothWarsCSharp.Source.Researches.Ironforge
{
  public static class TitanForgeArtifact
  {
    private const int ResearchId = Constants.UPGRADE_R08K_TITANFORGE_ARTIFACT_IRONFORGE;

    private static void Research()
    {
      try
      {
        var heldItem = UnitItemInSlot(GetTriggerUnit(), 0);
        if (heldItem != null)
        {
          var heldArtifact = ArtifactManager.GetFromTypeId(GetItemTypeId(heldItem));
          if (heldArtifact != null)
          {
            heldArtifact.Titanforge();
          }
          else
          {
            GetTriggerPlayer().AdjustPlayerState(PLAYER_STATE_RESOURCE_LUMBER, 75);
          }
        }
        SetPlayerTechResearched(GetTriggerPlayer(), ResearchId, 0);
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex);
      }
    }

    public static void Setup()
    {
      PlayerUnitEvents.Register(PlayerUnitEvent.ResearchIsFinished, Research, ResearchId);
    }
  }
}