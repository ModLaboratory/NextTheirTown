﻿global using Hazel;
global using static TownOfThem.Language.Translation;
global using HarmonyLib;
using BepInEx;
using BepInEx.IL2CPP;
using BepInEx.Logging;
using BepInEx.Configuration;
using System;
using System.Runtime;
using BepInEx.Unity.IL2CPP;
using System.Text;

namespace TownOfThem
{
    
    [BepInPlugin(ModGUID, "TownOfThem", ModVer)]
    [BepInProcess("Among Us.exe")]
    public class Main : BasePlugin
    {

        public static DateTime ExpireTime = new DateTime();
        public static DateTime BuildTime = new DateTime();
        public static bool IsBeta = false;
        internal static new ManualLogSource Log;
        public static Main Instance;
        public static bool ModDamaged = false;
        public static int optionsPage = 0;
        public const string ModGUID = "cn.JieGe.TownOfThem";
        public const string ModName = "<size=130%><color=#FF8C00>Town Of Them</color></size>";
        public const string ModVer = "0.0.0.1";
        public static readonly string GithubLink = "https://github.com/JieGeLovesDengDuaLang/TownOfThem";
        public static readonly string BilibiliLink = "https://space.bilibili.com/483236840";
        public static ConfigEntry<bool> EnableDevMode;


        public static bool IsMeeting = false;


        public Harmony Harmony { get; } = new Harmony(ModGUID);
        public override void Load()
        {
            Log = base.Log;
            EnableDevMode = Config.Bind("TownOfThemMod", "EnableDevMode", false, "Enable developer mode");
            
            Log.LogInfo("Town Of Them loaded!");
 
            
            Harmony.PatchAll();
        }
    }
}
