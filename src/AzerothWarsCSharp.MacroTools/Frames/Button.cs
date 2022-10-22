﻿using AzerothWarsCSharp.MacroTools.Wrappers;
using static War3Api.Common;

namespace AzerothWarsCSharp.MacroTools.Frames
{
   public delegate void OnClickAction(player triggerPlayer);

   /// <summary>
   /// A user interface element which can be clicked to produce an effect.
   /// </summary>
   public sealed class Button : Frame
   {
      private readonly TriggerWrapper _onClickTrigger;

      public Button(string name, framehandle parent, int priority) : base(name, parent,
         priority)
      {
      }

      public Button(string name, Frame parent, int priority) : base(name, parent, priority)
      {
      }

      public Button(string name, Frame parent) : base(name, parent)
      {
      }

      public Button(string typeName, string name, Frame parent, string inherits = null) : base(typeName, name, parent,
         inherits)
      {
      }

      public OnClickAction OnClick
      {
         init
         {
            _onClickTrigger = new TriggerWrapper();
            _onClickTrigger.RegisterFrameEvent(Handle, FRAMEEVENT_CONTROL_CLICK);
            _onClickTrigger.AddAction(() => value(GetTriggerPlayer()));
         }
      }

      public string Text
      {
         get => BlzFrameGetText(Handle);
         set => BlzFrameSetText(Handle, value);
      }
   }
}