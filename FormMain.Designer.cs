namespace SciADV_Launcher
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            menuStrip1 = new MenuStrip();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { aboutToolStripMenuItem, settingsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            aboutToolStripMenuItem.Margin = new Padding(0, 0, 15, 0);
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Padding = new Padding(4, 0, 30, 0);
            aboutToolStripMenuItem.Size = new Size(78, 20);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.sciadv_upscaled;
            pictureBox1.Location = new Point(12, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(380, 398);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            button1.Location = new Point(293, 28);
            button1.Name = "button1";
            button1.Size = new Size(98, 73);
            button1.TabIndex = 2;
            button1.Text = "DEBUG / UNUSED";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.CHNLogo;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Location = new Point(398, 27);
            button2.Name = "button2";
            button2.Size = new Size(185, 95);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.SGLogo;
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.Location = new Point(603, 27);
            button3.Name = "button3";
            button3.Size = new Size(185, 95);
            button3.TabIndex = 4;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackgroundImage = Properties.Resources.RNELogo;
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.Location = new Point(398, 128);
            button4.Name = "button4";
            button4.Size = new Size(185, 95);
            button4.TabIndex = 5;
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.BackgroundImage = Properties.Resources.CCLogo;
            button5.BackgroundImageLayout = ImageLayout.Zoom;
            button5.Location = new Point(603, 128);
            button5.Name = "button5";
            button5.Size = new Size(185, 95);
            button5.TabIndex = 6;
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.BackgroundImage = Properties.Resources.SG0Logo;
            button6.BackgroundImageLayout = ImageLayout.Zoom;
            button6.Location = new Point(398, 229);
            button6.Name = "button6";
            button6.Size = new Size(185, 95);
            button6.TabIndex = 7;
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.BackgroundImage = Properties.Resources.RNDLogo;
            button7.BackgroundImageLayout = ImageLayout.Zoom;
            button7.Location = new Point(603, 229);
            button7.Name = "button7";
            button7.Size = new Size(185, 95);
            button7.TabIndex = 8;
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.BackgroundImage = Properties.Resources.ACLogo;
            button8.BackgroundImageLayout = ImageLayout.Zoom;
            button8.Location = new Point(398, 330);
            button8.Name = "button8";
            button8.Size = new Size(185, 95);
            button8.TabIndex = 9;
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.BackgroundImageLayout = ImageLayout.Zoom;
            button9.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            button9.Location = new Point(603, 330);
            button9.Name = "button9";
            button9.Size = new Size(185, 95);
            button9.TabIndex = 10;
            button9.Text = "OTHERS";
            button9.UseVisualStyleBackColor = true;
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            settingsToolStripMenuItem.Margin = new Padding(0, 0, 15, 0);
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Padding = new Padding(4, 0, 30, 0);
            settingsToolStripMenuItem.Size = new Size(87, 20);
            settingsToolStripMenuItem.Text = "Settings";
            settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 437);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "FormMain";
            Text = "SciADV Launcher";
            Load += FormMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private ToolStripMenuItem settingsToolStripMenuItem;
    }
}
