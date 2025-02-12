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
            //TO USE ANY OF THESE VARIABLES IN ANY FORM, USE Globals.VARIABLENAME AND UNDER

            public static string TextReaderTool = "Tools\\TextReader\\nw.exe";
            public static string LocaleEmulatorTool = "Tools\\LocaleEmulator\\LEProc.exe";
            public static string VideoPlayerTool = "Tools\\VideoPlayer\\mpv.exe";
            public static string CHNMainGameCheck { get; set; }
        }
    }
}
