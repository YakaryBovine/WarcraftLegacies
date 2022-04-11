using System;
using AzerothWarsCSharp.MacroTools.Factions;
using WCSharp.Shared.Data;

using static War3Api.Common;

namespace AzerothWarsCSharp.MacroTools.QuestSystem
{
  public abstract class QuestItemData
  {
    private string _description = "";
    private effect _mapEffect; //The visual effect that appears on the map, usually a Circle of Power
    private minimapicon _minimapIcon;
    private effect _overheadEffect;

    private QuestItemData _parentQuestItem;
    private QuestProgress _progress = QuestProgress.Incomplete;

    public QuestItemData()
    {
      OverheadEffectPath = "Abilities\\Spells\\Other\\TalkToMe\\TalkToMe";
    }

    /// <summary>
    ///   Where the <see cref="QuestItemData" /> can be completed.
    /// </summary>
    public virtual Point Position { get; }

    /// <summary>
    ///   Whether or not the <see cref="QuestItemData" /> should display a position.
    /// </summary>
    public bool DisplaysPosition { get; protected init; }

    /// <summary>
    ///   Overhead effects get rendered over the target widget.
    /// </summary>
    public widget TargetWidget { get; set; }

    /// <summary>
    ///   The file path for the overhead effect to use for this item.
    /// </summary>
    private string OverheadEffectPath { get; }

    protected string MapEffectPath { get; init; }

    internal QuestItemData ParentQuestItem
    {
      set => _parentQuestItem = value;
    }

    internal QuestData ParentQuest { get; set; }

    internal questitem QuestItem { get; set; }

    /// <summary>
    ///   Whether or not this can be seen as a bullet point in the quest log.
    /// </summary>
    public bool ShowsInQuestLog { get; protected init; } = true;

    public Faction Holder => ParentQuest != null ? ParentQuest.Holder : _parentQuestItem?.Holder;

    public bool ProgressLocked
    {
      get
      {
        if (ParentQuest != null) return ParentQuest.ProgressLocked;

        return _parentQuestItem == null || _parentQuestItem.ProgressLocked;
      }
    }

    public QuestProgress Progress
    {
      get => _progress;
      set
      {
        if (ProgressLocked || _progress == value) return;

        _progress = value;
        if (ShowsInQuestLog)
          if (value == QuestProgress.Incomplete)
          {
            QuestItemSetCompleted(QuestItem, false);
            if (GetLocalPlayer() == Holder.Player) ShowLocal();

            ShowSync();
          }
          else if (value == QuestProgress.Complete)
          {
            QuestItemSetCompleted(QuestItem, true);
            if (GetLocalPlayer() == Holder.Player) HideLocal();

            HideSync();
          }
          else if (value == QuestProgress.Undiscovered)
          {
            QuestItemSetCompleted(QuestItem, false);
          }
          else if (value == QuestProgress.Failed)
          {
            QuestItemSetCompleted(QuestItem, false);
          }

        ProgressChanged?.Invoke(this, this);
      }
    }

    public string Description
    {
      get => _description;
      set
      {
        _description = value;
        if (QuestItem != null) QuestItemSetDescription(QuestItem, _description);
      }
    }

    /// <summary>
    ///   The texture path for the icon that appears showing where this <see cref="QuestItemData" />
    ///   can be completed.
    /// </summary>
    public string PingPath { get; protected init; } = "MinimapQuestObjectivePrimary";

    public event EventHandler<QuestItemData> ProgressChanged;

    /// <summary>
    ///   Runs when a <see cref="QuestData" /> with this <see cref="QuestItemData" /> is added to a <see cref="Faction" />.
    /// </summary>
    internal virtual void OnAdd()
    {
    }

    //Shows the local aspects of this QuestItem, namely the minimap icon.
    public void ShowLocal()
    {
      if (Progress == QuestProgress.Incomplete &&
          ParentQuest.Progress == QuestProgress.Incomplete)
      {
        if (_minimapIcon == null && Position.X != 0 && Position.Y != 0)
          _minimapIcon = CreateMinimapIcon(Position.X, Position.Y, 255, 255, 0, SkinManagerGetLocalPath(PingPath),
            FOG_OF_WAR_MASKED);
        else if (_minimapIcon != null) SetMinimapIconVisible(_minimapIcon, true);
      }
    }

    //Shows the synchronous aspects of this QuestItem, namely the visible target circle.
    public void ShowSync()
    {
      if (Progress == QuestProgress.Incomplete && ParentQuest.Progress == QuestProgress.Incomplete)
      {
        string effectPath;
        if (MapEffectPath != null && _mapEffect == null)
        {
          effectPath = GetLocalPlayer() == Holder.Player ? MapEffectPath : "";
          _mapEffect = AddSpecialEffect(effectPath, Position.X, Position.Y);
          BlzSetSpecialEffectColorByPlayer(_mapEffect, Holder.Player);
          BlzSetSpecialEffectHeight(_mapEffect, 100 + Environment.GetPositionZ(Position.X, Position.Y));
        }

        if (OverheadEffectPath != null && _overheadEffect == null && TargetWidget != null)
        {
          effectPath = GetLocalPlayer() == Holder.Player ? OverheadEffectPath : "";
          _overheadEffect = AddSpecialEffectTarget(effectPath, TargetWidget, "overhead");
        }
      }
    }

    //Hides the synchronous aspects of this QuestItem, namely the minimap icon.
    public void HideLocal()
    {
      if (_minimapIcon != null) SetMinimapIconVisible(_minimapIcon, false);
    }

    //Hides the synchronous aspects of this QuestItem, namely the minimap icon.
    public void HideSync()
    {
      if (_mapEffect != null)
      {
        DestroyEffect(_mapEffect);
        _mapEffect = null;
      }

      if (OverheadEffectPath != null)
      {
        DestroyEffect(_overheadEffect);
        _overheadEffect = null;
      }
    }
  }
}