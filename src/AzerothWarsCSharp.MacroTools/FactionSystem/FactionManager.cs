﻿using System;
using System.Collections.Generic;
using System.Linq;
using static War3Api.Common;

namespace AzerothWarsCSharp.MacroTools.FactionSystem
{
  /// <summary>
  ///   Responsible for the management of all <see cref="Faction" />s and <see cref="Team" />s in the game.
  /// </summary>
  public static class FactionManager
  {
    private static readonly Dictionary<string, Team> TeamsByName = new();
    private static readonly List<Team> AllTeams = new();
    private static readonly Dictionary<string, Faction> FactionsByName = new();

    /// <summary>
    ///   Fired when a <see cref="Faction" /> is registered to the <see cref="FactionManager" />.
    /// </summary>
    public static event EventHandler<Faction>? FactionRegistered;

    /// <summary>
    /// Fired when any <see cref="Faction"/> changes its name.
    /// </summary>
    public static event EventHandler<Faction>? AnyFactionNameChanged; //todo: remove this; shouldn't need static events of this nature

    private static void OnFactionNameChange(object? sender, FactionNameChangeEventArgs args)
    {
      try
      {
        FactionsByName.Remove(args.PreviousName);
        FactionsByName.Add(args.Faction.Name, args.Faction);
        AnyFactionNameChanged?.Invoke(args.Faction, args.Faction);
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex);
      }
    }

    public static IEnumerable<Team> GetAllTeams()
    {
      return AllTeams.ToList();
    }

    public static bool TeamWithNameExists(string teamName)
    {
      return TeamsByName.ContainsKey(teamName.ToLower());
    }

    public static Team GetTeamByName(string teamName)
    {
      return TeamsByName[teamName.ToLower()];
    }

    public static Faction? GetFromPlayer(player whichPlayer)
    {
      return PlayerData.ByHandle(whichPlayer)?.Faction;
    }

    public static bool FactionWithNameExists(string name)
    {
      return FactionsByName.ContainsKey(name.ToLower());
    }

    public static Faction GetFromName(string name)
    {
      return FactionsByName[name.ToLower()];
    }

    /// <summary>
    ///   Registers a <see cref="Faction" /> to the <see cref="FactionManager" />,
    ///   allowing it to be retrieved globally and fire global events.
    /// </summary>
    public static void Register(Faction faction)
    {
      if (!FactionsByName.ContainsKey(faction.Name.ToLower()))
      {
        FactionsByName[faction.Name.ToLower()] = faction;
        FactionRegistered?.Invoke(faction, faction);
        faction.NameChanged += OnFactionNameChange;
      }
      else
      {
        throw new Exception($"Attempted to register faction that already exists with name {faction}.");
      }

      FactionRegistered?.Invoke(faction, faction);
    }

    /// <summary>
    ///   Registers a <see cref="Team" /> to the <see cref="FactionManager" />,
    ///   allowing it to be retrieved globally and fire global events.
    /// </summary>
    public static void Register(Team team)
    {
      if (!TeamsByName.ContainsKey(team.Name.ToLower()))
      {
        TeamsByName[team.Name.ToLower()] = team;
        AllTeams.Add(team);
      }
      else
      {
        throw new Exception(
          $"Attempted to register a {nameof(Team)} named {team.Name}, but there is already a registered {nameof(Team)} with that name.");
      }
    }
  }
}