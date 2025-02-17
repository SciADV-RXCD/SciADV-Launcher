using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SciADV_Launcher
{
    public partial class FormCHNConfig : Form
    {
        public FormCHNConfig()
        {
            InitializeComponent();
        }

        private void FormCHNConfig_Load(object sender, EventArgs e)
        {
            label2.Hide();
            if (File.Exists(Globals.CHNconfigFilePath))
            {
                Globals.jsonCHNConfigRead = File.ReadAllText(Globals.CHNconfigFilePath);
                var jsonCHNConfigData = JsonSerializer.Deserialize<CHNCompleteConfig>(Globals.jsonCHNConfigRead);
                
                Globals.CHNMainGameCheck = jsonCHNConfigData.CHNMainGamePath;
                
                Globals.CHNChaosGateCheck = jsonCHNConfigData.CHNChaosGatePath;
                
                Globals.CHNLoveChuChuCheck = jsonCHNConfigData.CHNLoveChuChuPath;
                
                Globals.CHNChaosChatCheck = jsonCHNConfigData.CHNChaosChatPath;
                if (jsonCHNConfigData.CHNMainGamePath == null)
                {
                    textBox1.Text = "Game Missing!";
                }
                else
                {
                    textBox1.Text = jsonCHNConfigData.CHNMainGamePath;
                }
                if (jsonCHNConfigData.CHNChaosGatePath == null)
                {
                    textBox2.Text = "Novel Missing!";
                }
                else
                {
                    textBox2.Text = jsonCHNConfigData.CHNChaosGatePath;
                }
                if (jsonCHNConfigData.CHNLoveChuChuPath == null)
                {
                    textBox3.Text = "Game Missing!";
                }
                else
                {
                    textBox3.Text = jsonCHNConfigData.CHNLoveChuChuPath;
                }
                if (jsonCHNConfigData.CHNChaosChatPath == null)
                {
                    textBox4.Text = "Novel Missing!";
                }
                else
                {
                    textBox4.Text = jsonCHNConfigData.CHNChaosChatPath;
                }
            }
            else
            {
                textBox1.Text = "Game Missing!";
                textBox2.Text = "Novel Missing!";
                textBox3.Text = "Game Missing!";
                textBox4.Text = "Novel Missing!";
            }
        }

        

        public class CHNCompleteConfig
        {
            public string CHNMainGamePath { get; set; }
            public string CHNChaosGatePath { get; set; }
            public string CHNLoveChuChuPath { get; set; }
            public string CHNChaosChatPath { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog CHNMainGame = new FolderBrowserDialog();
            if (CHNMainGame.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists($"{CHNMainGame.SelectedPath}\\Game_Steam.exe"))
                {
                    textBox1.Text = CHNMainGame.SelectedPath;
                    Globals.CHNMainGameCheck = CHNMainGame.SelectedPath;
                }
                else
                {
                    MessageBox.Show("The selected Directory is invalid, please select the Folder that contains the \"Game_Steam.exe\" file.");
                }
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var CHNPaths = new CHNCompleteConfig
            {
                CHNMainGamePath = Globals.CHNMainGameCheck,
                CHNChaosGatePath = Globals.CHNChaosGateCheck,
                CHNLoveChuChuPath = Globals.CHNLoveChuChuCheck,
                CHNChaosChatPath = Globals.CHNChaosChatCheck
            };
            Globals.jsonCHNPaths = JsonSerializer.Serialize(CHNPaths);

            File.WriteAllText(Globals.CHNconfigFilePath, Globals.jsonCHNPaths);
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
            Console.WriteLine(Globals.ConsoleOutputPrefix + "CHN Config Saved!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog CHNChaosGate = new OpenFileDialog
            {
                Filter = "PDF Files (*.pdf)|*.pdf",
                FilterIndex = 1,
                Multiselect = false
            };
            if (CHNChaosGate.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = CHNChaosGate.FileName;
                Globals.CHNChaosGateCheck = CHNChaosGate.FileName;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog CHNLoveChuChu = new OpenFileDialog
            {
                Filter = "Vita3K (Vita3K.exe)|Vita3K.exe",
                FilterIndex = 1,
                Multiselect = false
            };
            if (CHNLoveChuChu.ShowDialog() == DialogResult.OK)
            {
                textBox3.Text = CHNLoveChuChu.FileName;
                Globals.CHNLoveChuChuCheck = CHNLoveChuChu.FileName;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog CHNChaosChat = new OpenFileDialog
            {
                Filter = "PDF Files (*.pdf)|*.pdf",
                FilterIndex = 1,
                Multiselect = false
            };
            if (CHNChaosChat.ShowDialog() == DialogResult.OK)
            {
                textBox4.Text = CHNChaosChat.FileName;
                Globals.CHNChaosChatCheck = CHNChaosChat.FileName;
            }
        }
    }
}
