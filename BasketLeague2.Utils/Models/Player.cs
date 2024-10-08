﻿using BasketLeague2.Utils.Utils;

namespace BasketLeague2.Utils.Models;

public class Player
{
    public int Codigo { get; set; }
    public string Name { get; set; } = "";
    public string Nickname { get; set; } = "";
    public int Team { get; set; }

    public int InsideScoring { get; set; }
    public int OutsideScoring { get; set; }
    public int Athleticism { get; set; }
    public int Playmaking { get; set; }
    public int Rebounding { get; set; }
    public int Defending { get; set; }
    public double Overall { get; set; }

    public Player()
    {
    }

    public Player(string name, string nickname, int team, int insideScoring, int outsideScoring, int athleticism,
        int playmaking, int rebounding, int defending)
    {
        Name = name;
        Nickname = nickname;
        Team = team;
        InsideScoring = insideScoring;
        OutsideScoring = outsideScoring;
        Athleticism = athleticism;
        Playmaking = playmaking;
        Rebounding = rebounding;
        Defending = defending;
        Overall = CalculateOverall();
        if (CalculateShiny())
        {
            Nickname = $"Shiny {Nickname}";
        }
    }

    public Player(int insideScoring, int outsideScoring, int athleticism, int playmaking, int rebounding,
        int defending)
    {
        Name = RandomNameGenerator.GenerateName();
        Nickname = RandomNameGenerator.GenerateNickname();
        InsideScoring = insideScoring;
        OutsideScoring = outsideScoring;
        Athleticism = athleticism;
        Playmaking = playmaking;
        Rebounding = rebounding;
        Defending = defending;
        Overall = CalculateOverall();
        if (CalculateShiny())
        {
            Nickname = $"Shiny {Nickname}";
        }
    }

    public static List<Player> CustomRandomPlayer(int num, int min, int max)
    {
        Random random = new();
        List<Player> players = new();
        for (var i = 0; i < num; i++)
        {
            players.Add(new Player(random.Next(min, max), random.Next(min, max), random.Next(min, max),
                random.Next(min, max), random.Next(min, max), random.Next(min, max)));
        }

        return players;
    }

    public double CalculateOverall()
    {
        return (InsideScoring + OutsideScoring + Athleticism + Playmaking + Rebounding + Defending) / 6.0;
    }

    /// <summary>
    /// Calculates if the player is shiny (1 in every 36)
    /// </summary>
    /// <returns></returns>
    private bool CalculateShiny()
    {
        return (InsideScoring + OutsideScoring + Athleticism + Playmaking + Rebounding + Defending) % 34 == 0;
    }
}