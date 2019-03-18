﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBQuestGame.Models;
namespace TBQuestGame.DataLayer
{
    public class GameData
    {
        public static Player PlayerData()
        {
            return new Player()
            {
                Id = 1,
                Name = "Player",
                BasicAttack = 3.2,
                Gold = 0,
                Health = 100,
                Shield = 0,
                IsAlive = true,
                LocationId = 0,
                QuestPoints = 0,
                SkillOneAttack = 0,
                SkillTwoAttack = 0,
                SkillThreeAttack = 0,
                ThirdEyeAttack = 0,
                StateOfAction = Character.ActionType.Neutral
            };

        }
        public static List<string> GameMapData()
        {
            List<string> mapLocations = new List<string>();
            mapLocations.Add("Kardon Dungeon");
            mapLocations.Add("Yin Village");
            mapLocations.Add("Dark Forests");
            mapLocations.Add("Vickren Dungeon");
            mapLocations.Add("Rohand Village");
            return mapLocations;
        }
        public static GameMapCoordinates InitialGameMapLocation()
        {
            return new GameMapCoordinates() { Row = 0, Column = 0 };
        }
        public static Map GameMap()
        {
            int rows = 3;
            int columns = 4;

            Map gameMap = new Map(rows, columns);
             
            gameMap.MapLocations[0, 0] = new Location()
            {
                Id = 4,
                Name = "The Dark Forest Swamp",
                Description = "The Dark Forest Swamp is home to dangerous swamp like creatures that aren't very fond of humans.",
                Accessible = true
            };
            gameMap.MapLocations[0, 1] = new Location()
            {
                Id = 1,
                Name = "Yin Village",
                Description = "Yin Village used to be home to humans, but was over ran by a group of bandits.",
                Accessible = true
            };
             
            gameMap.MapLocations[1, 1] = new Location()
            {
                Id = 2,
                Name = "Vickren Dungeon",
                Description = "Vickren Dungeon is where the Goblin Master resides... [ BOSS ROOM ]",
                Accessible = true
            };
            gameMap.MapLocations[1, 2] = new Location()
            {
                Id = 2,
                Name = "Kardon Dungeon",
                Description = "Kardon Dungeon is where the Great Kardon Dragon resides... [ BOSS ROOM ]",
                Accessible = false
            }; 
            gameMap.MapLocations[2, 0] = new Location()
            {
                Id = 3,
                Name = "Rohand Village",
                Description = "Rohand Village is home to the only humans left on the planet.",
                Accessible = false };
            gameMap.MapLocations[2, 1] = new Location()
            {
                Id = 4,
                Name = "The Dark Forest",
                Description = "The Dark Forest is home to many evil forces that try and wipe out humanity.", Accessible = true
            }; 
            return gameMap;
        }
        public static List<string> InitialMessages()
        {
            return new List<string>()
            {
                "Welcome to the text-based game called Swendiver. In this game you will go on an adventure killing monsters and doing quests, " +
                "following an exciting storyline, leveling up your character.",
                "Swendiver was created by Andrew Lopez.",
                " Enjoy the game!"
           };
        }
    }
}