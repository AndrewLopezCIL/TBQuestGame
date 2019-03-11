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
    }
}
