using AzerothWarsCSharp.MacroTools;
using AzerothWarsCSharp.Source.Game_Logic.GameEnd;
using AzerothWarsCSharp.Source.Libraries;

namespace AzerothWarsCSharp.Source.Hints
{
  public class HintVictory{
    public static void Setup( ){
      Hint.Register(new Hint($"Win the game by capturing {ControlPointVictory.GetControlPointsRequiredVictory()} Control Points."));
    }
  }
}
