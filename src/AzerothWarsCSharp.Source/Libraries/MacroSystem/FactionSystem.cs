﻿using System.Collections.Generic;
using System.Linq;
using static War3Api.Common;

namespace AzerothWarsCSharp.Source.Libraries.MacroSystem
{
  public static class FactionSystem
  {
    private static readonly List<Faction> AllFactions = new();
    private static readonly List<Team> AllTeams = new();

    public static List<Faction> GetAllFactions()
    {
      return AllFactions.ToList();
    }

    public static List<Team> GetAllTeams()
    {
      return AllTeams.ToList();
    }
    
    public static void Add(Team team)
    {
      AllTeams.Add(team);
    }

    public static void Add(Faction faction)
    {
      AllFactions.Add(faction);
    }
  }
}