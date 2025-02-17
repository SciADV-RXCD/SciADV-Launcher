namespace SciADV_Launcher
{
    partial class FormCHNConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCHNConfig));
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            button3 = new Button();
            button2 = new Button();
            label2 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            button4 = new Button();
            label5 = new Label();
            textBox4 = new TextBox();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(374, 33);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 33);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(356, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(162, 21);
            label1.TabIndex = 2;
            label1.Text = "CHAOS;HEAD NoAH";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(12, 68);
            label3.Name = "label3";
            label3.Size = new Size(107, 21);
            label3.TabIndex = 5;
            label3.Text = "CHAOS;GATE";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 92);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(356, 23);
            textBox2.TabIndex = 6;
            // 
            // button3
            // 
            button3.Location = new Point(374, 92);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 7;
            button3.Text = "...";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(340, 415);
            button2.Name = "button2";
            button2.Size = new Size(109, 23);
            button2.TabIndex = 8;
            button2.Text = "Save Settings";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.Location = new Point(340, 389);
            label2.Name = "label2";
            label2.Size = new Size(109, 23);
            label2.TabIndex = 9;
            label2.Text = "Config Saved!";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(12, 127);
            label4.Name = "label4";
            label4.Size = new Size(235, 21);
            label4.TabIndex = 10;
            label4.Text = "CHAOS;HEAD Love Chu☆Chu!";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 151);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(356, 23);
            textBox3.TabIndex = 11;
            // 
            // button4
            // 
            button4.Location = new Point(374, 151);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 12;
            button4.Text = "...";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(12, 186);
            label5.Name = "label5";
            label5.Size = new Size(109, 21);
            label5.TabIndex = 13;
            label5.Text = "CHAOS;CHAT";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 210);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(356, 23);
            textBox4.TabIndex = 14;
            // 
            // button5
            // 
            button5.Location = new Point(374, 210);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 15;
            button5.Text = "...";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // FormCHNConfig
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 450);
            Controls.Add(button5);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(button4);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormCHNConfig";
            Text = "C;HN Configurator";
            Load += FormCHNConfig_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Label label3;
        private TextBox textBox2;
        private Button button3;
        private Button button2;
        private Label label2;
        private Label label4;
        private TextBox textBox3;
        private Button button4;
        private Label label5;
        private TextBox textBox4;
        private Button button5;
    }
}