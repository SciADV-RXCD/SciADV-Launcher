namespace SciADV_Launcher
{
    partial class FormMainConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainConfig));
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            label4 = new Label();
            label5 = new Label();
            button3 = new Button();
            label6 = new Label();
            progressBar1 = new ProgressBar();
            progressBar2 = new ProgressBar();
            progressBar3 = new ProgressBar();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(206, 46);
            label1.TabIndex = 0;
            label1.Text = "Text Reader";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(12, 58);
            button1.Name = "button1";
            button1.Size = new Size(206, 36);
            button1.TabIndex = 1;
            button1.Text = "Download Tool";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 97);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(206, 59);
            label2.TabIndex = 2;
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label3.Location = new Point(254, 9);
            label3.Name = "label3";
            label3.Size = new Size(221, 46);
            label3.TabIndex = 3;
            label3.Text = "Video Player";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(254, 58);
            button2.Name = "button2";
            button2.Size = new Size(221, 36);
            button2.TabIndex = 4;
            button2.Text = "Download Tool";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(254, 97);
            label4.Name = "label4";
            label4.Size = new Size(221, 59);
            label4.TabIndex = 5;
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label5.Location = new Point(513, 9);
            label5.Name = "label5";
            label5.Size = new Size(275, 46);
            label5.TabIndex = 6;
            label5.Text = "Locale Emulator";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F);
            button3.Location = new Point(513, 58);
            button3.Name = "button3";
            button3.Size = new Size(275, 36);
            button3.TabIndex = 7;
            button3.Text = "Download Tool";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(513, 97);
            label6.Name = "label6";
            label6.Size = new Size(275, 59);
            label6.TabIndex = 8;
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 156);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(206, 23);
            progressBar1.TabIndex = 9;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(254, 156);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(221, 23);
            progressBar2.TabIndex = 10;
            // 
            // progressBar3
            // 
            progressBar3.Location = new Point(513, 156);
            progressBar3.Name = "progressBar3";
            progressBar3.Size = new Size(275, 23);
            progressBar3.TabIndex = 11;
            // 
            // FormMainConfig
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 189);
            Controls.Add(progressBar3);
            Controls.Add(progressBar2);
            Controls.Add(progressBar1);
            Controls.Add(label6);
            Controls.Add(button3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormMainConfig";
            Text = "SciADV Launcher Configurator";
            Load += FormMainConfig_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label2;
        private Label label3;
        private Button button2;
        private Label label4;
        private Label label5;
        private Button button3;
        private Label label6;
        private ProgressBar progressBar1;
        private ProgressBar progressBar2;
        private ProgressBar progressBar3;
    }
}