﻿using AzerothWarsCSharp.MacroTools.QuestSystem;
using AzerothWarsCSharp.MacroTools.QuestSystem.UtilityStructs;
using static War3Api.Common;

namespace AzerothWarsCSharp.TestSource.Quests
{
  public sealed class ExampleQuestB : QuestData
  {
    public ExampleQuestB(QuestData otherQuest) : base("Better Quest", "Don't complete that other quest, he sucks.", "ReplaceableTextures\\CommandButtons\\BTNPaladin.blp")
    {
      AddQuestItem(new QuestItemDontCompleteQuest(otherQuest));
      AddQuestItem(new QuestItemBuild(FourCC("hbar"), 1));
    }

    protected override string RewardDescription => "No idea.";
    protected override string CompletionPopup => "Thanks for completing me instead of that other quest!";
  }
}