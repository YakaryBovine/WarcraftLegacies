using System.Collections.Generic;
using System.Linq;
using AzerothWarsCSharp.MacroTools;
using AzerothWarsCSharp.MacroTools.ControlPointSystem;
using AzerothWarsCSharp.MacroTools.FactionSystem;
using AzerothWarsCSharp.MacroTools.QuestSystem;
using AzerothWarsCSharp.MacroTools.QuestSystem.UtilityStructs;
using AzerothWarsCSharp.MacroTools.Wrappers;
using AzerothWarsCSharp.Source.Mechanics.BlackEmpire;
using static War3Api.Common;

namespace AzerothWarsCSharp.Source.Quests.BlackEmpire
{
  public sealed class QuestThirdObelisk : QuestData
  {
    private static readonly int QuestResearchId = FourCC("R07K");
    private readonly List<destructable> _gates;
    private readonly List<unit> _rescueUnits = new();

    public QuestThirdObelisk(List<rect> rescueRects, IEnumerable<destructable> gates) : base("Merging of Realities",
      "Reality frays at the seams as madness threatents to overtake it. Once an Obelisk has been established in the Twilight Highlands, the mirror worlds of Azeroth and Ny'alotha will finally be one, and the Black empire will be unleashed.",
      "ReplaceableTextures\\CommandButtons\\BTNHorrorSoul.blp")
    {
      AddObjective(new ObjectiveObelisk(ControlPointManager.GetFromUnitType(FourCC("n02S"))));
      AddObjective(new ObjectiveObelisk(ControlPointManager.GetFromUnitType(FourCC("n04V"))));
      AddObjective(new ObjectiveObelisk(ControlPointManager.GetFromUnitType(FourCC("n0BD"))));
      AddObjective(new ObjectiveExpire(1800));
      Global = true;

      AddObjective(new ObjectiveObelisk(ControlPointManager.GetFromUnitType(FourCC("n0BD"))));
      foreach (var rescueRect in rescueRects)
      foreach (var unit in new GroupWrapper().EnumUnitsInRect(rescueRect).EmptyToList())
      {
        SetUnitInvulnerable(unit, true);
        _rescueUnits.Add(unit);
      }

      _gates = gates.ToList();
      foreach (var gate in _gates)
      {
        SetDestructableInvulnerable(gate, true);
      }

      Required = true;
    }

    protected override string CompletionPopup =>
      "The Merging of Realities has come to pass. The Ny'alothan portals to Storm Peaks, Northern Highlands, and Tanaris have been permanently opened.";

    protected override string RewardDescription =>
      "The Ny'alothan portals to Storm Peaks, Northern Highlands, and Tanaris will be permanently opened";

    //Opens the central portals in Nyalotha permanently.
    private void OpenPortals(Faction completingFaction)
    {
      completingFaction.ModObjectLimit(FourCC("u02E"), -Faction.UNLIMITED); //Herald
      completingFaction.SetObjectLevel(QuestResearchId, 1);
      BlackEmpirePortalSetup.TwilightHighlandsPortal.State = BlackEmpirePortalState.Open;
      BlackEmpirePortalSetup.TanarisPortal.State = BlackEmpirePortalState.Open;
      BlackEmpirePortalSetup.NorthrendPortal.State = BlackEmpirePortalState.Open;

      KillUnit(HeraldBuff.Instance?.Caster);
      BlackEmpirePortalManager.GoToNext();
      if (GetLocalPlayer() == completingFaction.Player) SetCameraPosition(-25528, -1979);

      foreach (var gate in _gates)
      {
        RemoveDestructable(gate);
      }

      _gates.Clear();
    }

    protected override void OnComplete(Faction completingFaction)
    {
      foreach (var unit in _rescueUnits) unit.Rescue(completingFaction.Player);

      PlayThematicMusic("war3mapImported\\BlackEmpireTheme.mp3");
      OpenPortals(completingFaction);
    }

    protected override void OnFail(Faction completingFaction)
    {
      OpenPortals(completingFaction);
    }
  }
}