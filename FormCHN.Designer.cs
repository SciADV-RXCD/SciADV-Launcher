namespace SciADV_Launcher
{
    partial class FormCHN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCHN));
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.CHNLogo;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(571, 187);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label1.Location = new Point(12, 202);
            label1.Name = "label1";
            label1.Size = new Size(776, 55);
            label1.TabIndex = 1;
            label1.Text = "----------     SIDE CONTENT     ----------";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            button2.Location = new Point(12, 260);
            button2.Name = "button2";
            button2.Size = new Size(255, 178);
            button2.TabIndex = 2;
            button2.Text = "CHAOS;GATE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            button3.Location = new Point(273, 260);
            button3.Name = "button3";
            button3.Size = new Size(255, 178);
            button3.TabIndex = 3;
            button3.Text = "CHAOS;HEAD\r\nLove Chu☆Chu!";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            button4.Location = new Point(533, 260);
            button4.Name = "button4";
            button4.Size = new Size(255, 178);
            button4.TabIndex = 4;
            button4.Text = "CHAOS;CHAT";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackgroundImage = Properties.Resources.ConfigIcon;
            button5.BackgroundImageLayout = ImageLayout.Zoom;
            button5.Location = new Point(589, 12);
            button5.Name = "button5";
            button5.Size = new Size(199, 158);
            button5.TabIndex = 5;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(589, 176);
            button6.Name = "button6";
            button6.Size = new Size(199, 23);
            button6.TabIndex = 6;
            button6.Text = "RELOAD CONFIG";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // FormCHN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormCHN";
            Text = "CHAOS;HEAD NoAH Launcher";
            Load += FormCHN_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}