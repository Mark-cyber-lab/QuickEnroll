namespace QuickEnroll
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            mainpanel = new Panel();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            button6 = new Button();
            panel4 = new Panel();
            label1 = new Label();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(40, 100);
            button1.Name = "button1";
            button1.Size = new Size(147, 50);
            button1.TabIndex = 2;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            button2.Location = new Point(40, 188);
            button2.Name = "button2";
            button2.Size = new Size(147, 44);
            button2.TabIndex = 3;
            button2.Text = "Records";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            button3.Location = new Point(40, 269);
            button3.Name = "button3";
            button3.Size = new Size(147, 45);
            button3.TabIndex = 4;
            button3.Text = "Personnel";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            button4.Location = new Point(40, 348);
            button4.Name = "button4";
            button4.Size = new Size(147, 43);
            button4.TabIndex = 5;
            button4.Text = "History";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            button5.Location = new Point(40, 539);
            button5.Name = "button5";
            button5.Size = new Size(147, 41);
            button5.TabIndex = 6;
            button5.Text = "Settings";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 92);
            panel2.Name = "panel2";
            panel2.Size = new Size(232, 629);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Honeydew;
            panel3.Controls.Add(mainpanel);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(0, -1);
            panel3.Name = "panel3";
            panel3.Size = new Size(232, 126);
            panel3.TabIndex = 2;
            // 
            // mainpanel
            // 
            mainpanel.Location = new Point(233, 93);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(992, 629);
            mainpanel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(232, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1228, 92);
            panel1.TabIndex = 0;
            // 
            // button6
            // 
            button6.BackColor = Color.Red;
            button6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = SystemColors.ButtonFace;
            button6.Location = new Point(1104, 27);
            button6.Name = "button6";
            button6.Size = new Size(98, 41);
            button6.TabIndex = 7;
            button6.Text = "Exit";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // panel4
            // 
            panel4.Location = new Point(233, 92);
            panel4.Name = "panel4";
            panel4.Size = new Size(995, 629);
            panel4.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(438, 9);
            label1.Name = "label1";
            label1.Size = new Size(555, 62);
            label1.TabIndex = 30;
            label1.Text = "Enrollment Management";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1228, 721);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load;
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Panel panel2;
        private Panel panel3;
        private Panel mainpanel;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button button6;
        private Panel panel4;
        private Label label1;
    }
}