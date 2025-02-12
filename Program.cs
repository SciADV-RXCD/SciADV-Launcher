using System.Runtime.InteropServices;

namespace SciADV_Launcher
{
    internal static class Program
    {
        internal static string[] Args;

        
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Args = args;
            ApplicationConfiguration.Initialize();
            Application.Run(new FormMain());
        }
    }
}