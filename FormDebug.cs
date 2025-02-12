using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SciADV_Launcher
{
    public partial class FormDebug : Form
    {
        public FormDebug()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //THIS IS ONLY A TEST - REMOVE WHEN NOT NEEDED ANYMORE
            string GamePath = "\"H:\\Game Library\\_Science Adventure Series Complete\\Games\\STEINS;GATE Variant Space Octet\\sg8bit.exe\"";
            
            

            Process sgVariantSpaceOctet = new Process
            {
                StartInfo =
                {
                    FileName = Globals.LocaleEmulatorTool,
                    Arguments = Globals.JapaneseLocaleGUID + GamePath,
                    UseShellExecute = true
                }
            };
            sgVariantSpaceOctet.Start();
        }
    }
}
