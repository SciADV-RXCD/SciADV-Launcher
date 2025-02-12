using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SciADV_Launcher
{
    public partial class FormSGConfig : Form
    {
        public FormSGConfig()
        {
            InitializeComponent();
        }

        private void FormSGConfig_Load(object sender, EventArgs e)
        {
            label2.Hide();
            if (File.Exists(SGconfigFilePath))
            {
                jsonConfigRead = File.ReadAllText(SGconfigFilePath);
                var jsonConfigData = JsonSerializer.Deserialize<SGCompleteConfig>(jsonConfigRead);
                textBox1.Text = jsonConfigData.SGMainGamePath;
                SGMainGameCheck = jsonConfigData.SGMainGamePath;
                textBox2.Text = jsonConfigData.SGHolyDayCalamitousBirthPath;
                SGHolyDayCalamitousBirthCheck = jsonConfigData.SGHolyDayCalamitousBirthPath;
                if (jsonConfigData.SGMainGamePath == null)
                {
                    textBox1.Text = "Game Missing!";
                }
                if(jsonConfigData.SGHolyDayCalamitousBirthPath == null)
                {
                    textBox2.Text = "Novel Missing!";
                }
            }
            else
            {
                textBox1.Text = "Game Missing!";
                textBox2.Text = "Novel Missing!";
            }
        }

        string SGconfigFilePath = "Config/SGConfig.json";
        string SGMainGameCheck;
        string SGHolyDayCalamitousBirthCheck;
        string jsonConfigRead;
        string jsonSGPaths;
        string ConsoleOutputPrefix = "[ SciADV Launcher ] ";

        public class SGCompleteConfig
        {
            public string SGMainGamePath { get; set; }
            public string SGHolyDayCalamitousBirthPath { get; set; }
            public string SGEgoisticPoriomaniaPath { get; set; }
            public string SGLoadRegionDejaVuPath { get; set; }
            public string SGPosterioriExistencePath { get; set; }
            public string SGVariantSpaceOctetPath { get; set; }
            public string SGDarlingsEmbracePath { get; set; }
            public string SGBabelGrievedMazePath { get; set; }
            public string SGArcLightInfinityPath { get; set; }
            public string SGHydeDarkDimensionPath { get; set; }
            public string SGRebellionMissingRingPath { get; set; }
            public string SGDistantValhallaPath { get; set; }
            public string SGBraunianMotionLoveHatePath { get; set; }
            public string SGSanrioChanceEncounterGoldigPartyPath { get; set; }
            public string SGTimeLongAgoPath { get; set; }
            public string SGEpigraphShortcutPath { get; set; }
            public string SGOkabeBirthdaySpecialPath { get; set; }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var SGPaths = new SGCompleteConfig
            {
                SGMainGamePath = SGMainGameCheck,
                SGHolyDayCalamitousBirthPath = SGHolyDayCalamitousBirthCheck
            };
            jsonSGPaths = JsonSerializer.Serialize(SGPaths);

            File.WriteAllText(SGconfigFilePath, jsonSGPaths);
            if (label2.Visible == true)
            {
                label2.Hide();
                await Task.Delay(250);
                label2.Show();
            }
            else
            {
                label2.Show();
            }
            Console.WriteLine(ConsoleOutputPrefix + "SG Config Saved!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog SGMainGame = new FolderBrowserDialog();
            if (SGMainGame.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists($"{SGMainGame.SelectedPath}\\LauncherC0.exe"))
                {
                    textBox1.Text = SGMainGame.SelectedPath;
                    SGMainGameCheck = SGMainGame.SelectedPath;
                }
                else
                {
                    MessageBox.Show("The selected Directory is invalid, please select the Folder that contains the \"LauncherC0.exe\" file.");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog SGHolyDayCalamitousBirth = new OpenFileDialog
            {
                Filter = "|HolyDayCalamitousBirthComplete.pdf",
                FilterIndex = 1,
                Multiselect = false
            };
            if (SGHolyDayCalamitousBirth.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = SGHolyDayCalamitousBirth.FileName;
                SGHolyDayCalamitousBirthCheck = SGHolyDayCalamitousBirth.FileName;
            }
        }
    }
}
