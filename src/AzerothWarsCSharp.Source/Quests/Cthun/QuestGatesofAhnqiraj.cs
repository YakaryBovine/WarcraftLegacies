using AzerothWarsCSharp.MacroTools.QuestSystem;
using AzerothWarsCSharp.MacroTools.QuestSystem.UtilityStructs;

using static War3Api.Common; using static War3Api.Blizzard;

namespace AzerothWarsCSharp.Source.Quests.Cthun
{
  public sealed class QuestGatesofAhnqiraj : QuestData
  {
    private readonly unit _bigGate;
    private readonly unit _waygateA;
    private readonly unit _waygateB;
    
    protected override string CompletionPopup => "The Old God C'thun has awaken and now ready to unleash the Qiraji on the world of Azeorth.";
    
    protected override string RewardDescription => "Gain control of C'thun and enable you to open the Gates of Ahn'qiraj";
      
    protected override void OnComplete()
    {
      WaygateActivate(_waygateA, true);
      ShowUnit(_waygateA, true);
      WaygateSetDestinationLocBJ(_waygateA, GetRectCenter(Regions.WorldTunnelEntrance.Rect));
      
      WaygateActivate(_waygateB, true);
      ShowUnit(_waygateB, true);
      WaygateSetDestinationLocBJ(_waygateB, GetRectCenter(Regions.WorldTunnelExit.Rect));
      
      SetUnitInvulnerable(_bigGate, false);
      PlayThematicMusicBJ("war3mapImported\\CthunTheme.mp3");
    }
      
    public QuestGatesofAhnqiraj(unit bigGate, unit waygateA, unit waygateB) : base("The Gates of Ahn'qiraj",
      "At the conclusion of the War of the Shifting Sands, the Dragonflights sealed the Qiraji behind the Scarab Wall. Now centuries later, C'thun is once again ready to open the gates to his ancient empire.",
      "ReplaceableTextures\\CommandButtons\\BTNScarabMedal.blp")
    {
      _bigGate = bigGate;
      _waygateA = waygateA;
      _waygateB = waygateB;
      Global = true;
      AddQuestItem(new QuestItemCastSpell(FourCC("A0O1"), true));
    }
  }
}