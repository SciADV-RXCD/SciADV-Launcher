using SciADV_Launcher.Properties;
using System.Runtime.InteropServices;




namespace SciADV_Launcher
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        [DllImport("kernel32.dll")] static extern bool AllocConsole();
        [DllImport("kernel32.dll")] static extern bool AttachConsole(int pw);
        public static bool _hasConsole, _keepConsoleOpen;
        static public void EnsureConsole()
        {
            _hasConsole = _hasConsole || AttachConsole(-1);
            _keepConsoleOpen = !_hasConsole || _keepConsoleOpen;
            _hasConsole = _hasConsole || AllocConsole();
        }



        private void FormMain_Load(object sender, EventArgs e)
        {
            button1.Hide();

            if (Directory.Exists("Config") == false)
            {
                Directory.CreateDirectory("Config");
            }
            if (Directory.Exists("Tools") == false)
            {
                Directory.CreateDirectory("Tools");
                Directory.CreateDirectory("Tools\\TextReader");
                Directory.CreateDirectory("Tools\\VideoPlayer");
                Directory.CreateDirectory("Tools\\LocaleEmulator");
            }

            if (File.Exists(Globals.TextReaderTool) == false | File.Exists(Globals.VideoPlayerTool) == false | File.Exists(Globals.LocaleEmulatorTool) == false)
            {
                MessageBox.Show("Some Tools are Missing!\nPlease let the Launcher Download them!");
                FormMainConfig formMainConfig = new FormMainConfig();
                formMainConfig.ShowDialog();
            }

            if (Program.Args != null && Program.Args.Length > 0)
            {
                if (Program.Args[0] == "-debug")
                {
                    button1.Show();
                    this.Text = "SciADV Laucher - DEBUG MODE";
                    this.Refresh();

                    EnsureConsole();

                    if (_keepConsoleOpen)
                    {
                        Console.WriteLine("################################");
                        Console.WriteLine("#####   SciADV  Launcher   #####");
                        Console.WriteLine("#####  DEBUG MODE ENABLED  #####");
                        Console.WriteLine("################################");
                        SendKeys.SendWait("{ENTER}");
                        Console.Read();
                    }
                    else
                    {
                        Console.WriteLine("################################");
                        Console.WriteLine("#####   SciADV  Launcher   #####");
                        Console.WriteLine("#####  DEBUG MODE ENABLED  #####");
                        Console.WriteLine("################################");
                        SendKeys.SendWait("{ENTER}");
                        Console.Read();
                    }
                }
            }

        }


        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormCHN formCHN = new FormCHN();
            formCHN.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormDebug formDebug = new FormDebug();
            formDebug.ShowDialog();
            /*
            
            */
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormSG formSG = new FormSG();
            formSG.ShowDialog();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMainConfig formMainConfig = new FormMainConfig();
            formMainConfig.ShowDialog();
        }
    }
}
