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

        string CHNconfigFilePath = "Config/CHNConfig.json";
        string TextReaderTool = "Tools\\TextReader\\nw.exe";
        string TextReaderPath = "Tools\\TextReader\\";
        string jsonConfigRead;
        string CHNGamePath;
        string CHNChaosGatePath;
        //string CHNLoveChuChuPath;
        string CHNChaosChatPath;
        string ConsoleOutputPrefix = "[ SciADV Launcher ] ";

        private void FormCHN_Load(object sender, EventArgs e)
        {
            if (File.Exists(CHNconfigFilePath))
            {
                jsonConfigRead = File.ReadAllText(CHNconfigFilePath);
                var jsonConfigData = JsonSerializer.Deserialize<CHNCompleteConfig>(jsonConfigRead);
                CHNGamePath = jsonConfigData.CHNMainGamePath;
                CHNChaosGatePath = jsonConfigData.CHNChaosGatePath;
                //CHNLoveChuChuPath = jsonConfigData.CHNLoveChuChuPath;
                CHNChaosChatPath = jsonConfigData.CHNChaosChatPath;
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
            if (CHNGamePath != null)
            {
                Directory.SetCurrentDirectory(CHNGamePath);

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
            jsonConfigRead = File.ReadAllText(CHNconfigFilePath);
            var jsonConfigData = JsonSerializer.Deserialize<CHNCompleteConfig>(jsonConfigRead);
            CHNGamePath = jsonConfigData.CHNMainGamePath;
            CHNChaosGatePath = jsonConfigData.CHNChaosGatePath;
            //CHNLoveChuChuPath = jsonConfigData.CHNLoveChuChuPath;
            CHNChaosChatPath = jsonConfigData.CHNChaosChatPath;
            Console.WriteLine(ConsoleOutputPrefix + "CHN Config Reloaded!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CHNChaosGatePath == null)
            {
                MessageBox.Show("Chaos;Gate Missing!");
                return;
            }

            if (File.Exists($"{TextReaderPath}\\main.pdf"))
            {
                File.Delete($"{TextReaderPath}\\main.pdf");
                File.Copy(CHNChaosGatePath, TextReaderPath + "\\main.pdf");
            }
            else
            {
                File.Copy(CHNChaosGatePath, TextReaderPath + "\\main.pdf");
            }

            Process ChaosGateReader = new Process
            {
                StartInfo =
                {
                    FileName = TextReaderTool
                }
            };
            ChaosGateReader.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (CHNChaosChatPath == null)
            {
                MessageBox.Show("Chaos;Chat Missing!");
                return;
            }

            if (File.Exists($"{TextReaderPath}\\main.pdf"))
            {
                File.Delete($"{TextReaderPath}\\main.pdf");
                File.Copy(CHNChaosChatPath, TextReaderPath + "\\main.pdf");
            }
            else
            {
                File.Copy(CHNChaosChatPath, TextReaderPath + "\\main.pdf");
            }

            Process ChaosChatReader = new Process
            {
                StartInfo =
                {
                    FileName = TextReaderTool
                }
            };
            ChaosChatReader.Start();
        }
    }
}
