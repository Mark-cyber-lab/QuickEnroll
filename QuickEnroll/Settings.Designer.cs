namespace QuickEnroll
{
    partial class Settings
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
            panel1 = new Panel();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            SettingsSubPanel = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.BackColor = Color.FloralWhite;
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(SettingsSubPanel);
            panel1.Location = new Point(-3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1226, 749);
            panel1.TabIndex = 0;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(288, 634);
            button6.Name = "button6";
            button6.Size = new Size(147, 50);
            button6.TabIndex = 8;
            button6.Text = "Room";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(288, 549);
            button5.Name = "button5";
            button5.Size = new Size(147, 50);
            button5.TabIndex = 7;
            button5.Text = "Assignation";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(288, 458);
            button4.Name = "button4";
            button4.Size = new Size(147, 50);
            button4.TabIndex = 6;
            button4.Text = "Professor";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(288, 366);
            button3.Name = "button3";
            button3.Size = new Size(147, 50);
            button3.TabIndex = 5;
            button3.Text = "Program";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(288, 276);
            button2.Name = "button2";
            button2.Size = new Size(147, 50);
            button2.TabIndex = 4;
            button2.Text = "Course";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(288, 186);
            button1.Name = "button1";
            button1.Size = new Size(147, 50);
            button1.TabIndex = 3;
            button1.Text = "School Year";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SettingsSubPanel
            // 
            SettingsSubPanel.BackColor = Color.DarkSlateGray;
            SettingsSubPanel.Location = new Point(486, 186);
            SettingsSubPanel.Name = "SettingsSubPanel";
            SettingsSubPanel.Size = new Size(696, 498);
            SettingsSubPanel.TabIndex = 0;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1222, 746);
            Controls.Add(panel1);
            Name = "Settings";
            Text = "Settings";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel SettingsSubPanel;
        private Button button1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button6;
    }
}