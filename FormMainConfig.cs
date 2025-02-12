using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SciADV_Launcher
{
    public partial class FormMainConfig : Form
    {
        public FormMainConfig()
        {
            InitializeComponent();
        }

        private void FormMainConfig_Load(object sender, EventArgs e)
        {
            progressBar1.Hide();
            progressBar2.Hide();
            progressBar3.Hide();

            if (File.Exists(Globals.TextReaderTool))
            {
                label2.Text = "Text Reader Tool Found!";
                button1.Enabled = false;
                progressBar1.Hide();
            }
            if (File.Exists(Globals.VideoPlayerTool))
            {
                label4.Text = "Video Player Tool Found!";
                button2.Enabled = false;
                progressBar2.Hide();
            }
            if (File.Exists(Globals.LocaleEmulatorTool))
            {
                label6.Text = "Locale Emulator Tool Found!";
                button3.Enabled = false;
                progressBar3.Hide();
            }
        }

        public static void DownloadFile(string url, string path, ProgressBar progressBar)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadProgressChanged += (s, e) =>
            {
                progressBar.Value = e.ProgressPercentage;
            };
            webClient.DownloadFile(new Uri(url), path);
        }

        //Download Video Tool
        private async void button1_Click(object sender, EventArgs e)
        {
            string sourceTextReaderPath = "Tools\\TextReader\\nwjs-sdk-v0.95.0-win-x64\\";
            string destinationTextReaderPath = "Tools\\TextReader\\";
            label2.Text = "Downloading\nText Reader...";
            await Task.Delay(300);
            DownloadFile("https://dl.nwjs.io/v0.95.0/nwjs-sdk-v0.95.0-win-x64.zip", "TextReader.zip", progressBar1);
            if (File.Exists("TextReader.zip"))
            {
                ZipFile.ExtractToDirectory("TextReader.zip", destinationTextReaderPath);
                File.Delete("TextReader.zip");

                var allFiles = Directory.GetFiles(sourceTextReaderPath);
                foreach (var file in allFiles)
                {
                    var destinationFileName = destinationTextReaderPath + Path.GetFileNameWithoutExtension(file) + Path.GetExtension(file);
                    File.Move(file, destinationFileName);
                }
                Directory.Move($"{sourceTextReaderPath}\\locales", $"{destinationTextReaderPath}\\locales");
                Directory.Move($"{sourceTextReaderPath}\\swiftshader", $"{destinationTextReaderPath}\\swiftshader");
                Directory.Delete(sourceTextReaderPath, true);

                File.WriteAllBytes("Tools\\TextReader\\package.json", Properties.Resources.packageJson);

                label2.Text = "Text Reader Found!";
                button1.Enabled = false;
                progressBar1.Hide();
            }
        }

        //Download Video Player Tool
        private async void button2_Click(object sender, EventArgs e)
        {
            label4.Text = "Downloading\nVideo Player...";
            await Task.Delay(300);
            DownloadFile("https://nightly.link/mpv-player/mpv/workflows/build/master/mpv-x86_64-windows-msvc.zip", "mpv.zip", progressBar2);
            if (File.Exists("mpv.zip"))
            {
                ZipFile.ExtractToDirectory("mpv.zip", "Tools\\VideoPlayer");
                File.Delete("mpv.zip");
                File.Delete("Tools\\VideoPlayer\\mpv.pdb");
                File.Delete("Tools\\VideoPlayer\\mpv.com");
                label4.Text = "Video Player Found!";
                button2.Enabled = false;
                progressBar2.Hide();
            }
        }

        //Download Locale Emulator Tool
        private async void button3_Click(object sender, EventArgs e)
        {
            label6.Text = "Downloading\nLocale Emulator...";
            await Task.Delay(300);
            DownloadFile("https://github.com/xupefei/Locale-Emulator/releases/download/v2.5.0.1/Locale.Emulator.2.5.0.1.zip", "LocaleEmulator.zip", progressBar3);
            if (File.Exists("LocaleEmulator.zip"))
            {
                ZipFile.ExtractToDirectory("LocaleEmulator.zip", "Tools\\LocaleEmulator");
                File.Delete("LocaleEmulator.zip");
                File.WriteAllBytes("Tools\\LocaleEmulator\\LECommonLibrary.dll", Properties.Resources.LECommonLibrary);
                File.WriteAllBytes("Tools\\LocaleEmulator\\LEConfig.xml", Properties.Resources.LEConfig);

                label6.Text = "Locale Emulator Found!";
                button3.Enabled = false;
                progressBar3.Hide();
            }
        }
    }
}
