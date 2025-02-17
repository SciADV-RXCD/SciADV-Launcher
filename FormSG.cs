using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SciADV_Launcher.FormCHNConfig;
using static SciADV_Launcher.FormSGConfig;

namespace SciADV_Launcher
{
    public partial class FormSG : Form
    {
        public FormSG()
        {
            InitializeComponent();
        }

        private void FormSG_Load(object sender, EventArgs e)
        {
            if (File.Exists(Globals.SGconfigFilePath))
            {
                Globals.jsonSGConfigRead = File.ReadAllText(Globals.SGconfigFilePath);
                var jsonSGConfigData = JsonSerializer.Deserialize<SGCompleteConfig>(Globals.jsonSGConfigRead);
                Globals.SGMainGameCheck = jsonSGConfigData.SGMainGamePath;
                Globals.SGHolyDayCalamitousBirthCheck = jsonSGConfigData.SGHolyDayCalamitousBirthPath;
                Globals.SGEgoisticPoriomaniaCheck = jsonSGConfigData.SGEgoisticPoriomaniaPath;

                Globals.SGBabelGrievedMazeDramaCDCheck = jsonSGConfigData.SGBabelGrievedMazeDramaCDPath;
            }
            else
            {
                Console.WriteLine(Globals.ConsoleOutputPrefix + "Config Missing! Please Configure the Launcher!");
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormSGConfig formSGConfig = new FormSGConfig();
            formSGConfig.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Globals.jsonSGConfigRead = File.ReadAllText(Globals.SGconfigFilePath);
            var jsonSGConfigData = JsonSerializer.Deserialize<SGCompleteConfig>(Globals.jsonSGConfigRead);
            Globals.SGMainGameCheck = jsonSGConfigData.SGMainGamePath;
            Globals.SGHolyDayCalamitousBirthCheck = jsonSGConfigData.SGHolyDayCalamitousBirthPath;
            Globals.SGEgoisticPoriomaniaCheck = jsonSGConfigData.SGEgoisticPoriomaniaPath;

            Globals.SGBabelGrievedMazeDramaCDCheck = jsonSGConfigData.SGBabelGrievedMazeDramaCDPath;
            Console.WriteLine(Globals.ConsoleOutputPrefix + "SG Config Reloaded!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // CHECK IF THE GAME PATH EXIST AND THEN SET THE NEW CURRENT DIRECTORY AND START THE GAME
            if (Globals.SGMainGameCheck != null)
            {
                Directory.SetCurrentDirectory(Globals.SGMainGameCheck);

                // STARTING THE GAME
                Process SGGame = new Process
                {
                    StartInfo =
                    {
                        FileName = "LauncherC0.exe"
                    }
                };
                SGGame.Start();
                Console.WriteLine(Globals.ConsoleOutputPrefix + "STEINS;GATE Launched!");
                ActiveForm.WindowState = FormWindowState.Minimized;
                Directory.SetCurrentDirectory(Globals.LauncherAppPath);
            }
            else
            {
                MessageBox.Show("Game Missing!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Globals.SGHolyDayCalamitousBirthCheck == null)
            {
                MessageBox.Show("Holy Day of the Calamitous Birth Missing!");
                return;
            }

            if (File.Exists($"{Globals.TextReaderPath}\\main.pdf"))
            {
                File.Delete($"{Globals.TextReaderPath}\\main.pdf");
                File.Copy(Globals.SGHolyDayCalamitousBirthCheck, Globals.TextReaderPath + "\\main.pdf");
                Console.WriteLine(Globals.ConsoleOutputPrefix + "Rewrote Text Reader Config File!");
            }
            else
            {
                File.Copy(Globals.SGHolyDayCalamitousBirthCheck, Globals.TextReaderPath + "\\main.pdf");
                Console.WriteLine(Globals.ConsoleOutputPrefix + "Wrote Text Reader Config File!");
            }

            Process HolyDayCalamitousBirthReader = new Process
            {
                StartInfo =
                {
                    FileName = Globals.TextReaderTool
                }
            };
            HolyDayCalamitousBirthReader.Start();
            Console.WriteLine(Globals.ConsoleOutputPrefix + "Holy Day of the Calamitous Birth Launched!");
            ActiveForm.WindowState = FormWindowState.Minimized;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (File.Exists($"{Globals.VideoPlayerPath}\\main.m3u"))
            {
                File.Delete($"{Globals.VideoPlayerPath}\\main.m3u");
                File.WriteAllText($"{Globals.VideoPlayerPath}\\main.m3u", Globals.SGEgoisticPoriomaniaCheck);
                Console.WriteLine(Globals.ConsoleOutputPrefix + "Rewrote Video Config File!");
            }
            else
            {
                File.WriteAllText($"{Globals.VideoPlayerPath}\\main.m3u", Globals.SGEgoisticPoriomaniaCheck);
                Console.WriteLine(Globals.ConsoleOutputPrefix + "Wrote Video Config File!");
            }
            Process EgoisticPoriomaniaViewer = new Process
            {
                StartInfo =
                {
                    FileName = Globals.VideoPlayerTool,
                    Arguments = $"{Globals.VideoPlayerPath}\\main.m3u"
                }
            };
            EgoisticPoriomaniaViewer.Start();
            Console.WriteLine(Globals.ConsoleOutputPrefix + "Egoistic Poriomania Launched!");
            ActiveForm.WindowState = FormWindowState.Minimized;
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        // Babel of the Grieved Maze Selector
        private void button10_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(button10, 0, button10.Height);
        }

        private void dramaCDFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists($"{Globals.VideoPlayerPath}\\main.m3u"))
            {
                File.Delete($"{Globals.VideoPlayerPath}\\main.m3u");
                File.Copy($"{Globals.SGBabelGrievedMazeDramaCDCheck}\\main.m3u", $"{Globals.VideoPlayerPath}\\main.m3u");
                Console.WriteLine(Globals.ConsoleOutputPrefix + "Rewrote Video Config File!");
            }
            else
            {
                File.Copy($"{Globals.SGBabelGrievedMazeDramaCDCheck}\\main.m3u", $"{Globals.VideoPlayerPath}\\main.m3u");
                Console.WriteLine(Globals.ConsoleOutputPrefix + "Wrote Video Config File!");
            }

            Process BabelGrievedMazeDramaCD = new Process()
            {
                StartInfo =
                {
                    FileName = Globals.VideoPlayerTool,
                    Arguments = $"{Globals.VideoPlayerPath}\\main.m3u"
                }
            };
            BabelGrievedMazeDramaCD.Start();
            Console.WriteLine(Globals.ConsoleOutputPrefix + "Babel of the Grieved Maze Drama CD Launched!");
            ActiveForm.WindowState = FormWindowState.Minimized;
        }

        private void mangaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists($"{Globals.TextReaderPath}\\main.pdf"))
            {
                File.Delete($"{Globals.TextReaderPath}\\main.pdf");
                File.Copy($"{Globals.SGBabelGrievedMazeMangaCheck}\\main.pdf", $"{Globals.TextReaderPath}\\main.pdf");
                Console.WriteLine(Globals.ConsoleOutputPrefix + "Rewrote Text Reader Config File!");
            }
            else
            {
                File.Copy($"{Globals.SGBabelGrievedMazeMangaCheck}\\main.pdf", $"{Globals.TextReaderPath}\\main.pdf");
                Console.WriteLine(Globals.ConsoleOutputPrefix + "Wrote Text Reader Config File!");
            }

            Process BabelGrievedMazeManga = new Process()
            {
                StartInfo =
                {
                    FileName = Globals.TextReaderTool
                }
            };
            BabelGrievedMazeManga.Start();
            Console.WriteLine(Globals.ConsoleOutputPrefix + "Babel of the Grieved Maze Manga Launched!");
            ActiveForm.WindowState = FormWindowState.Minimized;
        }
    }
}
