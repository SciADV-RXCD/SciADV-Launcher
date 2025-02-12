using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Diagnostics;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SciADV_Launcher.FormCHNConfig;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SciADV_Launcher
{
    public partial class FormCHN : Form
    {
        public FormCHN()
        {
            InitializeComponent();
        }

        private void FormCHN_Load(object sender, EventArgs e)
        {
            if (File.Exists(Globals.CHNconfigFilePath))
            {
                Globals.jsonCHNConfigRead = File.ReadAllText(Globals.CHNconfigFilePath);
                var jsonCHNConfigData = JsonSerializer.Deserialize<CHNCompleteConfig>(Globals.jsonCHNConfigRead);
                Globals.CHNMainGameCheck = jsonCHNConfigData.CHNMainGamePath;
                Globals.CHNChaosGateCheck = jsonCHNConfigData.CHNChaosGatePath;
                //Globals.CHNLoveChuChuCheck = jsonCHNConfigData.CHNLoveChuChuPath;
                Globals.CHNChaosChatCheck = jsonCHNConfigData.CHNChaosChatPath;
            }
            else
            {
                MessageBox.Show("Config Missing! Please Configure the Launcher!");
                return;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormCHNConfig formCHNConfig = new FormCHNConfig();
            formCHNConfig.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // CHECK IF THE GAME PATH EXIST AND THEN SET THE NEW CURRENT DIRECTORY AND START THE GAME
            if (Globals.CHNMainGameCheck != null)
            {
                Directory.SetCurrentDirectory(Globals.CHNMainGameCheck);

                // STARTING THE GAME
                Process CHNGame = new Process
                {
                    StartInfo =
                    {
                        FileName = "Game_Steam.exe"
                    }
                };

                CHNGame.Start();
            }
            else
            {
                MessageBox.Show("Game Missing!");
            }
        }

        // RELOAD CONFIG BUTTON
        private void button6_Click(object sender, EventArgs e)
        {
            Globals.jsonCHNConfigRead = File.ReadAllText(Globals.CHNconfigFilePath);
            var jsonCHNConfigData = JsonSerializer.Deserialize<CHNCompleteConfig>(Globals.jsonCHNConfigRead);
            Globals.CHNMainGameCheck = jsonCHNConfigData.CHNMainGamePath;
            Globals.CHNChaosGateCheck = jsonCHNConfigData.CHNChaosGatePath;
            //Globals.CHNLoveChuChuCheck = jsonCHNConfigData.CHNLoveChuChuPath;
            Globals.CHNChaosChatCheck = jsonCHNConfigData.CHNChaosChatPath;
            Console.WriteLine(Globals.ConsoleOutputPrefix + "CHN Config Reloaded!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Globals.CHNChaosGateCheck == null)
            {
                MessageBox.Show("Chaos;Gate Missing!");
                return;
            }

            if (File.Exists($"{Globals.TextReaderPath}\\main.pdf"))
            {
                File.Delete($"{Globals.TextReaderPath}\\main.pdf");
                File.Copy(Globals.CHNChaosGateCheck, Globals.TextReaderPath + "\\main.pdf");
            }
            else
            {
                File.Copy(Globals.CHNChaosGateCheck, Globals.TextReaderPath + "\\main.pdf");
            }

            Process ChaosGateReader = new Process
            {
                StartInfo =
                {
                    FileName = Globals.TextReaderTool
                }
            };
            ChaosGateReader.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Globals.CHNChaosChatCheck == null)
            {
                MessageBox.Show("Chaos;Chat Missing!");
                return;
            }

            if (File.Exists($"{Globals.TextReaderPath}\\main.pdf"))
            {
                File.Delete($"{Globals.TextReaderPath}\\main.pdf");
                File.Copy(Globals.CHNChaosChatCheck, Globals.TextReaderPath + "\\main.pdf");
            }
            else
            {
                File.Copy(Globals.CHNChaosChatCheck, Globals.TextReaderPath + "\\main.pdf");
            }

            Process ChaosChatReader = new Process
            {
                StartInfo =
                {
                    FileName = Globals.TextReaderTool
                }
            };
            ChaosChatReader.Start();
        }
    }
}
