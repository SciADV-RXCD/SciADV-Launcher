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

        string SGconfigFilePath = "Config/SGConfig.json";
        string TextReaderTool = "Tools\\TextReader\\nw.exe";
        string TextReaderPath = "Tools\\TextReader\\";
        string jsonConfigRead;
        string SGGamePath;
        string ConsoleOutputPrefix = "[ SciADV Launcher ] ";

        private void FormSG_Load(object sender, EventArgs e)
        {
            if (File.Exists(SGconfigFilePath))
            {
                jsonConfigRead = File.ReadAllText(SGconfigFilePath);
                var jsonConfigData = JsonSerializer.Deserialize<SGCompleteConfig>(jsonConfigRead);
                SGGamePath = jsonConfigData.SGMainGamePath;
            }
            else
            {
                MessageBox.Show("Config Missing! Please Configure the Launcher!");
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
            jsonConfigRead = File.ReadAllText(SGconfigFilePath);
            var jsonConfigData = JsonSerializer.Deserialize<SGCompleteConfig>(jsonConfigRead);
            SGGamePath = jsonConfigData.SGMainGamePath;
            Console.WriteLine(ConsoleOutputPrefix + "SG Config Reloaded!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // CHECK IF THE GAME PATH EXIST AND THEN SET THE NEW CURRENT DIRECTORY AND START THE GAME
            if (SGGamePath != null)
            {
                Directory.SetCurrentDirectory(SGGamePath);

                // STARTING THE GAME
                Process SGGame = new Process
                {
                    StartInfo =
                    {
                        FileName = "LauncherC0.exe"
                    }
                };

                SGGame.Start();
            }
            else
            {
                MessageBox.Show("Game Missing!");
            }
        }
    }
}
