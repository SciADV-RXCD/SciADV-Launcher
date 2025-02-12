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
            Globals.jsonSGConfigRead = File.ReadAllText(Globals.SGconfigFilePath);
            var jsonSGConfigData = JsonSerializer.Deserialize<SGCompleteConfig>(Globals.jsonSGConfigRead);
            Globals.SGMainGameCheck = jsonSGConfigData.SGMainGamePath;
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
            }
            else
            {
                MessageBox.Show("Game Missing!");
            }
        }
    }
}
