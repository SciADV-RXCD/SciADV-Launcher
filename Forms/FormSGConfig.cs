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
            if (File.Exists(Globals.SGconfigFilePath))
            {
                Globals.jsonSGConfigRead = File.ReadAllText(Globals.SGconfigFilePath);
                var jsonSGConfigData = JsonSerializer.Deserialize<SGCompleteConfig>(Globals.jsonSGConfigRead);

                Globals.SGMainGameCheck = jsonSGConfigData.SGMainGamePath;
                Globals.SGHolyDayCalamitousBirthCheck = jsonSGConfigData.SGHolyDayCalamitousBirthPath;
                Globals.SGEgoisticPoriomaniaCheck = jsonSGConfigData.SGEgoisticPoriomaniaPath;
                Globals.SGLoadRegionDejaVuCheck = jsonSGConfigData.SGLoadRegionDejaVuPath;
                Globals.SGPosterioriExistenceCheck = jsonSGConfigData.SGPosterioriExistencePath;
                Globals.SGVariantSpaceOctetCheck = jsonSGConfigData.SGVariantSpaceOctetPath;
                Globals.SGDarlingsEmbraceCheck = jsonSGConfigData.SGDarlingsEmbracePath;
                Globals.SGBabelGrievedMazeDramaCDCheck = jsonSGConfigData.SGBabelGrievedMazeDramaCDPath;
                Globals.SGBabelGrievedMazeMangaCheck = jsonSGConfigData.SGBabelGrievedMazeMangaPath;
                Globals.SGArcLightInfinityCheck = jsonSGConfigData.SGArcLightInfinityPath;
                Globals.SGHydeDarkDimensionCheck = jsonSGConfigData.SGHydeDarkDimensionPath;
                Globals.SGRebellionMissingRingCheck = jsonSGConfigData.SGRebellionMissingRingPath;
                Globals.SGDistantValhallaCheck = jsonSGConfigData.SGDistantValhallaPath;
                Globals.SGBraunianMotionLoveHateCheck = jsonSGConfigData.SGBraunianMotionLoveHatePath;
                Globals.SGSanrioChanceEncounterGoldigPartyCheck = jsonSGConfigData.SGSanrioChanceEncounterGoldigPartyPath;
                Globals.SGTimeLongAgoCheck = jsonSGConfigData.SGTimeLongAgoPath;
                Globals.SGEpigraphShortcutCheck = jsonSGConfigData.SGEpigraphShortcutPath;
                Globals.SGOkabeBirthdaySpecialCheck = jsonSGConfigData.SGOkabeBirthdaySpecialPath;

                if (jsonSGConfigData.SGMainGamePath == null)
                {
                    textBox1.Text = "Game Missing!";
                }
                else
                {
                    textBox1.Text = jsonSGConfigData.SGMainGamePath;
                }
                if (jsonSGConfigData.SGHolyDayCalamitousBirthPath == null)
                {
                    textBox2.Text = "Novel Missing!";
                }
                else
                {
                    textBox2.Text = jsonSGConfigData.SGHolyDayCalamitousBirthPath;
                }
                if (jsonSGConfigData.SGEgoisticPoriomaniaPath == null)
                {
                    textBox3.Text = "Video Missing!";
                }
                else
                {
                    textBox3.Text = jsonSGConfigData.SGEgoisticPoriomaniaPath;
                }
                if (jsonSGConfigData.SGLoadRegionDejaVuPath == null)
                {
                    textBox4.Text = "Video Missing!";
                }
                else
                {
                    textBox4.Text = jsonSGConfigData.SGLoadRegionDejaVuPath;
                }
                if (jsonSGConfigData.SGPosterioriExistencePath == null)
                {
                    textBox5.Text = "Drama CD Missing!";
                }
                else
                {
                    textBox5.Text = jsonSGConfigData.SGPosterioriExistencePath;
                }
                if (jsonSGConfigData.SGVariantSpaceOctetPath == null)
                {
                    textBox6.Text = "Game Missing!";
                }
                else
                {
                    textBox6.Text = jsonSGConfigData.SGVariantSpaceOctetPath;
                }
                if (jsonSGConfigData.SGDarlingsEmbracePath == null)
                {
                    textBox7.Text = "Game Missing!";
                }
                else
                {
                    textBox7.Text = jsonSGConfigData.SGDarlingsEmbracePath;
                }
                if (jsonSGConfigData.SGBabelGrievedMazeDramaCDPath == null)
                {
                    textBox8.Text = "Drama CD Missing!";
                }
                else
                {
                    textBox8.Text = jsonSGConfigData.SGBabelGrievedMazeDramaCDPath;
                }
                if (jsonSGConfigData.SGBabelGrievedMazeMangaPath == null)
                {
                    textBox18.Text = "Manga Missing!";
                }
                else
                {
                    textBox18.Text = jsonSGConfigData.SGBabelGrievedMazeMangaPath;
                }
                if (jsonSGConfigData.SGArcLightInfinityPath == null)
                {
                    textBox9.Text = "Drama CD Missing!";
                }
                else
                {
                    textBox9.Text = jsonSGConfigData.SGArcLightInfinityPath;
                }
                if (jsonSGConfigData.SGHydeDarkDimensionPath == null)
                {
                    textBox10.Text = "Drama CD Missing!";
                }
                else
                {
                    textBox10.Text = jsonSGConfigData.SGHydeDarkDimensionPath;
                }
                if (jsonSGConfigData.SGRebellionMissingRingPath == null)
                {
                    textBox11.Text = "Manga Missing!";
                }
                else
                {
                    textBox11.Text = jsonSGConfigData.SGRebellionMissingRingPath;
                }
                if (jsonSGConfigData.SGDistantValhallaPath == null)
                {
                    textBox12.Text = "Novel Missing!";
                }
                else
                {
                    textBox12.Text = jsonSGConfigData.SGDistantValhallaPath;
                }
                if (jsonSGConfigData.SGBraunianMotionLoveHatePath == null)
                {
                    textBox13.Text = "Manga Missing!";
                }
                else
                {
                    textBox13.Text = jsonSGConfigData.SGBraunianMotionLoveHatePath;
                }
                if (jsonSGConfigData.SGSanrioChanceEncounterGoldigPartyPath == null)
                {
                    textBox14.Text = "Game Missing!";
                }
                else
                {
                    textBox14.Text = jsonSGConfigData.SGSanrioChanceEncounterGoldigPartyPath;
                }
                if (jsonSGConfigData.SGTimeLongAgoPath == null)
                {
                    textBox15.Text = "Manga Missing!";
                }
                else
                {
                    textBox15.Text = jsonSGConfigData.SGTimeLongAgoPath;
                }
                if (jsonSGConfigData.SGEpigraphShortcutPath == null)
                {
                    textBox16.Text = "Manga Missing!";
                }
                else
                {
                    textBox16.Text = jsonSGConfigData.SGEpigraphShortcutPath;
                }
                if (jsonSGConfigData.SGOkabeBirthdaySpecialPath == null)
                {
                    textBox17.Text = "Novel Missing!";
                }
                else
                {
                    textBox17.Text = jsonSGConfigData.SGOkabeBirthdaySpecialPath;
                }
            }
            else
            {
                textBox1.Text = "Game Missing!";
                textBox2.Text = "Novel Missing!";
                textBox3.Text = "Video Missing!";
                textBox4.Text = "Video Missing!";
                textBox5.Text = "Drama CD Missing!";
                textBox6.Text = "Game Missing!";
                textBox7.Text = "Game Missing!";
                textBox8.Text = "Manga Missing!";
                textBox9.Text = "Drama CD Missing!";
                textBox10.Text = "Drama CD Missing!";
                textBox11.Text = "Manga Missing!";
                textBox12.Text = "Novel Missing!";
                textBox13.Text = "Manga Missing!";
                textBox14.Text = "Game Missing!";
                textBox15.Text = "Manga Missing!";
                textBox16.Text = "Manga Missing!";
                textBox17.Text = "Novel Missing!";
            }
        }

        public class SGCompleteConfig
        {
            public string SGMainGamePath { get; set; }
            public string SGHolyDayCalamitousBirthPath { get; set; }
            public string SGEgoisticPoriomaniaPath { get; set; }
            public string SGLoadRegionDejaVuPath { get; set; }
            public string SGPosterioriExistencePath { get; set; }
            public string SGVariantSpaceOctetPath { get; set; }
            public string SGDarlingsEmbracePath { get; set; }
            public string SGBabelGrievedMazeDramaCDPath { get; set; }
            public string SGBabelGrievedMazeMangaPath { get; set; }
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
                SGMainGamePath = Globals.SGMainGameCheck,
                SGHolyDayCalamitousBirthPath = Globals.SGHolyDayCalamitousBirthCheck,
                SGEgoisticPoriomaniaPath = Globals.SGEgoisticPoriomaniaCheck,
                SGLoadRegionDejaVuPath = Globals.SGLoadRegionDejaVuCheck,
                SGPosterioriExistencePath = Globals.SGPosterioriExistenceCheck,
                SGVariantSpaceOctetPath = Globals.SGVariantSpaceOctetCheck,
                SGDarlingsEmbracePath = Globals.SGDarlingsEmbraceCheck,
                SGBabelGrievedMazeDramaCDPath = Globals.SGBabelGrievedMazeDramaCDCheck,
                SGBabelGrievedMazeMangaPath = Globals.SGBabelGrievedMazeMangaCheck,
                SGArcLightInfinityPath = Globals.SGArcLightInfinityCheck,
                SGHydeDarkDimensionPath = Globals.SGHydeDarkDimensionCheck,
                SGRebellionMissingRingPath = Globals.SGRebellionMissingRingCheck,
                SGDistantValhallaPath = Globals.SGDistantValhallaCheck,
                SGBraunianMotionLoveHatePath = Globals.SGBraunianMotionLoveHateCheck,
                SGSanrioChanceEncounterGoldigPartyPath = Globals.SGSanrioChanceEncounterGoldigPartyCheck,
                SGTimeLongAgoPath = Globals.SGTimeLongAgoCheck,
                SGEpigraphShortcutPath = Globals.SGEpigraphShortcutCheck,
                SGOkabeBirthdaySpecialPath = Globals.SGOkabeBirthdaySpecialCheck
            };
            Globals.jsonSGPaths = JsonSerializer.Serialize(SGPaths);

            File.WriteAllText(Globals.SGconfigFilePath, Globals.jsonSGPaths);
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
            Console.WriteLine(Globals.ConsoleOutputPrefix + "SG Config Saved!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog SGMainGame = new FolderBrowserDialog();
            if (SGMainGame.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists($"{SGMainGame.SelectedPath}\\LauncherC0.exe"))
                {
                    textBox1.Text = SGMainGame.SelectedPath;
                    Globals.SGMainGameCheck = SGMainGame.SelectedPath;
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
                Filter = "PDF Files (*.pdf)|*.pdf",
                FilterIndex = 1,
                Multiselect = false
            };
            if (SGHolyDayCalamitousBirth.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = SGHolyDayCalamitousBirth.FileName;
                Globals.SGHolyDayCalamitousBirthCheck = SGHolyDayCalamitousBirth.FileName;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Egoistic Poriomania
            OpenFileDialog SGEgoisticPoriomania = new OpenFileDialog
            {
                Filter = "MP4 / MKV Files (*.mkv or *.mp4)|*.mkv;*.mp4",
                FilterIndex = 1,
                Multiselect = false
            };
            if (SGEgoisticPoriomania.ShowDialog() == DialogResult.OK)
            {
                textBox3.Text = SGEgoisticPoriomania.FileName;
                Globals.SGEgoisticPoriomaniaCheck = SGEgoisticPoriomania.FileName;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Load Region of Deja Vu
            OpenFileDialog SGLoadRegionDejaVu = new OpenFileDialog
            {
                Filter = "MP4 / MKV Files (*.mkv or *.mp4)|*.mkv;*.mp4",
                FilterIndex = 1,
                Multiselect = false
            };
            if (SGLoadRegionDejaVu.ShowDialog() == DialogResult.OK)
            {
                textBox4.Text = SGLoadRegionDejaVu.FileName;
                Globals.SGLoadRegionDejaVuCheck = SGLoadRegionDejaVu.FileName;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog PosterioriExistenceDramaCD = new OpenFileDialog
            {
                Filter = "MP4 / MKV Files (*.mkv or *.mp4)|*.mkv;*.mp4",
                FilterIndex = 1,
                Multiselect = true
            };
            if (PosterioriExistenceDramaCD.ShowDialog() == DialogResult.OK)
            {

                Globals.allPosterioriExistenceDramaCDFiles = PosterioriExistenceDramaCD.FileNames;
                Globals.SGPosterioriExistenceCheck = Path.GetDirectoryName(Globals.allPosterioriExistenceDramaCDFiles[0]);
                if (File.Exists($"{Globals.SGPosterioriExistenceCheck}\\main.m3u"))
                {
                    File.Delete($"{Globals.SGPosterioriExistenceCheck}\\main.m3u");
                    File.WriteAllLines($"{Globals.SGPosterioriExistenceCheck}\\main.m3u", Globals.allPosterioriExistenceDramaCDFiles);
                }
                else
                {
                    File.WriteAllLines($"{Globals.SGPosterioriExistenceCheck}\\main.m3u", Globals.allPosterioriExistenceDramaCDFiles);
                }
                textBox5.Text = Globals.SGPosterioriExistenceCheck;
            }
        }

        // Babel Drama CD Folder
        private void button9_Click(object sender, EventArgs e)
        {
            /*
            FolderBrowserDialog BabelGrievedMazeFolder = new FolderBrowserDialog();
            if (BabelGrievedMazeFolder.ShowDialog() == DialogResult.OK)
            {
                
            }
            */
            OpenFileDialog BabelGrievedMazeDramaCDFiles = new OpenFileDialog
            {
                Filter = "MP4 / MKV Files (*.mkv or *.mp4)|*.mkv;*.mp4",
                FilterIndex = 1,
                Multiselect = true
            };
            if (BabelGrievedMazeDramaCDFiles.ShowDialog() == DialogResult.OK)
            {
                
                Globals.allBabelGrievedMazeDramaCDFiles = BabelGrievedMazeDramaCDFiles.FileNames;
                Globals.SGBabelGrievedMazeDramaCDCheck = Path.GetDirectoryName(Globals.allBabelGrievedMazeDramaCDFiles[0]);
                if (File.Exists($"{Globals.SGBabelGrievedMazeDramaCDCheck}\\main.m3u"))
                {
                    File.Delete($"{Globals.SGBabelGrievedMazeDramaCDCheck}\\main.m3u");
                    File.WriteAllLines($"{Globals.SGBabelGrievedMazeDramaCDCheck}\\main.m3u", Globals.allBabelGrievedMazeDramaCDFiles);
                }
                else
                {
                    File.WriteAllLines($"{Globals.SGBabelGrievedMazeDramaCDCheck}\\main.m3u", Globals.allBabelGrievedMazeDramaCDFiles);
                }
                textBox8.Text = Globals.SGBabelGrievedMazeDramaCDCheck;
            }
            //textBox8.Text = SGLoadRegionDejaVu.FileName;
            //Globals.SGLoadRegionDejaVuCheck = SGLoadRegionDejaVu.FileName;
            //Console Output
            //Get Directory of the Files
            //Path.GetDirectoryName(Globals.allBabelGrievedMazeFiles[0]);
            //Console.WriteLine(Path.GetDirectoryName(Globals.allBabelGrievedMazeFiles[0]));
            //Globals.allBabelGrievedMazeFiles.ToList().ForEach(Console.WriteLine);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog BabelGrievedMazeMangaFiles = new FolderBrowserDialog();
            if (BabelGrievedMazeMangaFiles.ShowDialog() == DialogResult.OK)
            {
                Globals.SGBabelGrievedMazeMangaCheck = BabelGrievedMazeMangaFiles.SelectedPath;
                textBox8.Text = Globals.SGBabelGrievedMazeMangaCheck;

                if (File.Exists($"{Globals.SGBabelGrievedMazeMangaCheck}\\main.pdf"))
                {
                    File.Delete($"{Globals.SGBabelGrievedMazeMangaCheck}\\main.pdf");
                }

                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                using (PdfDocument BabelGrievedMazeMangaCompletePDF = new PdfDocument())
                {
                    string[] files = Directory.GetFiles(Globals.SGBabelGrievedMazeMangaCheck);
                    foreach (string file in files)
                    {
                        using (PdfDocument x = PdfReader.Open(file, PdfDocumentOpenMode.Import))
                        {
                            for (int i = 0; i < x.PageCount; i++)
                            {
                                BabelGrievedMazeMangaCompletePDF.AddPage(x.Pages[i]);
                            }
                        }
                    }
                    if (File.Exists($"{Globals.SGBabelGrievedMazeMangaCheck}\\main.pdf"))
                    {
                        File.Delete($"{Globals.SGBabelGrievedMazeMangaCheck}\\main.pdf");
                        BabelGrievedMazeMangaCompletePDF.Save($"{Globals.SGBabelGrievedMazeMangaCheck}\\main.pdf");
                    }
                    else
                    {
                        BabelGrievedMazeMangaCompletePDF.Save($"{Globals.SGBabelGrievedMazeMangaCheck}\\main.pdf");
                    }
                }

            }
        }
    }
}
