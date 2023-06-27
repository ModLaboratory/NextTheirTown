﻿using System.Collections.Generic;
using UnityEngine;

namespace TownOfThem.Roles.Crew
{
    public class Sheriff : Role
    {
        public static Sheriff Instance = new();
        public static new Color color = new Color(248, 205, 70);
        public static new Sprite button = ModHelpers.LoadSprite("TownOfThem.Resources.SheriffKillButton.png");
        public static new List<PlayerControl> players
        {
            get
            {
                List<PlayerControl> p = new();
                foreach(var a in SelectRolesPatch.pr)
                {
                    if (a.Value == roleID)
                    {
                        p.Add(a.Key);
                    }
                }
                return p;
            }
        }
        public static PlayerControl target;
        public static new int roleID
        {
            get
            {
                return (int)RoleId.Sheriff;
            }
        }
        public static new bool enable
        {
            get
            {
                return CreateCustomObjects.CustomGameOptions.Sheriff.getBool();
            }
        }
        public static new int maxPlayerCount
        {
            get
            {
                return (int)CreateCustomObjects.CustomGameOptions.SheriffMaxPlayer.selections[CreateCustomObjects.CustomGameOptions.SheriffMaxPlayer.selection];
            }
        }
        public static int cd
        {
            get
            {
                return (int)CreateCustomObjects.CustomGameOptions.SheriffCooldown.selections[CreateCustomObjects.CustomGameOptions.SheriffCooldown.selection];
            }
        }
        public static int limit {
            get
            {
                return (int)CreateCustomObjects.CustomGameOptions.SheriffKillLimit.selections[CreateCustomObjects.CustomGameOptions.SheriffKillLimit.selection];
            }
        }
        public override void reset()
        {

        }
    }
}