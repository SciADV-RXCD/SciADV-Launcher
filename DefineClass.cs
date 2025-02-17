using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SciADV_Launcher
{
    internal class DefineClass
    {
        public class Globals
        {
            //DEFINE ALL USED VARIABLES HERE
            //TO USE ANY OF THESE VARIABLES IN ANY FORM, USE Globals.VARIABLENAME

            // ########## LAUNCHER STRINGS START ##########
            //Launcher Related Strings
            public static string LauncherAppPath = Path.GetDirectoryName(Application.ExecutablePath);
            public static string TextReaderTool = $"{LauncherAppPath}\\Tools\\TextReader\\nw.exe";
            public static string TextReaderPath = $"{LauncherAppPath}\\Tools\\TextReader\\";
            public static string LocaleEmulatorTool = $"{LauncherAppPath}\\Tools\\LocaleEmulator\\LEProc.exe";
            public static string JapaneseLocaleGUID = "-runas 3d7196a5-2eca-4669-aa05-af20d5b911de ";
            public static string VideoPlayerTool = $"{LauncherAppPath}\\Tools\\VideoPlayer\\mpv.exe";
            public static string VideoPlayerPath = $"{LauncherAppPath}\\Tools\\VideoPlayer\\";
            public static string ConsoleOutputPrefix = "[ SciADV Launcher ] ";
            // ########## LAUNCHER STRINGS  END  ##########



            // ########## CHN STRINGS START ##########
            // CHN System Strings
            public static string CHNconfigFilePath = $"{LauncherAppPath}\\Config\\CHNConfig.json";
            public static string jsonCHNConfigRead { get; set; }
            public static string jsonCHNPaths { get; set; }
            // CHN Content Checks
            public static string CHNMainGameCheck { get; set; }
            public static string CHNChaosGateCheck { get; set; }
            public static string CHNLoveChuChuCheck { get; set; }
            public static string CHNChaosChatCheck { get; set; }
            // ########## CHN STRINGS  END  ##########

            

            // ########## SG STRINGS START ##########
            // SG System Strings
            public static string SGconfigFilePath = $"{LauncherAppPath}\\Config\\SGConfig.json";
            public static string jsonSGConfigRead { get; set; }
            public static string jsonSGPaths { get; set; }
            public static string[] allBabelGrievedMazeDramaCDFiles { get; set; }
            public static string[] allBabelGrievedMazeMangaFiles { get; set; }
            // SG Content Checks
            public static string SGMainGameCheck { get; set; }
            public static string SGHolyDayCalamitousBirthCheck { get; set; }
            public static string SGEgoisticPoriomaniaCheck { get; set; }
            public static string SGLoadRegionDejaVuCheck { get; set; }
            public static string SGPosterioriExistenceCheck { get; set; }
            public static string SGVariantSpaceOctetCheck { get; set; }
            public static string SGDarlingsEmbraceCheck { get; set; }
            public static string SGBabelGrievedMazeDramaCDCheck { get; set; }
            public static string SGBabelGrievedMazeMangaCheck { get; set; }
            public static string SGArcLightInfinityCheck { get; set; }
            public static string SGHydeDarkDimensionCheck { get; set; }
            public static string SGRebellionMissingRingCheck { get; set; }
            public static string SGDistantValhallaCheck { get; set; }
            public static string SGBraunianMotionLoveHateCheck { get; set; }
            public static string SGSanrioChanceEncounterGoldigPartyCheck { get; set; }
            public static string SGTimeLongAgoCheck { get; set; }
            public static string SGEpigraphShortcutCheck { get; set; }
            public static string SGOkabeBirthdaySpecialCheck { get; set; }
            // ########## SG STRINGS  END  ##########
        }
    }
}
