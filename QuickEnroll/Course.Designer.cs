namespace QuickEnroll
{
    partial class Course
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
            SettingsSubPanel = new Panel();
            comboBox3 = new ComboBox();
            label4 = new Label();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            CourseName = new DataGridViewTextBoxColumn();
            Unit = new DataGridViewTextBoxColumn();
            Program = new DataGridViewTextBoxColumn();
            CreationDate = new DataGridViewTextBoxColumn();
            UpdateDate = new DataGridViewTextBoxColumn();
            button2 = new Button();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            SettingsSubPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // SettingsSubPanel
            // 
            SettingsSubPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SettingsSubPanel.BackColor = Color.DarkSlateGray;
            SettingsSubPanel.Controls.Add(comboBox3);
            SettingsSubPanel.Controls.Add(label4);
            SettingsSubPanel.Controls.Add(button3);
            SettingsSubPanel.Controls.Add(dataGridView1);
            SettingsSubPanel.Controls.Add(button2);
            SettingsSubPanel.Controls.Add(button1);
            SettingsSubPanel.Controls.Add(label3);
            SettingsSubPanel.Controls.Add(label2);
            SettingsSubPanel.Controls.Add(textBox2);
            SettingsSubPanel.Controls.Add(textBox1);
            SettingsSubPanel.Controls.Add(label1);
            SettingsSubPanel.Location = new Point(0, 1);
            SettingsSubPanel.Name = "SettingsSubPanel";
            SettingsSubPanel.Size = new Size(696, 498);
            SettingsSubPanel.TabIndex = 2;
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Bachelor of Science Information Technology", "Bachelor of Science Computer Science", "Bachelor of Science Medicine", "Bachelor of Science Meteorology", "Bachelor of Science Chemistry" });
            comboBox3.Location = new Point(221, 161);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(151, 36);
            comboBox3.TabIndex = 59;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(119, 161);
            label4.Name = "label4";
            label4.Size = new Size(95, 28);
            label4.TabIndex = 20;
            label4.Text = "Program:";
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(77, 444);
            button3.Name = "button3";
            button3.Size = new Size(112, 40);
            button3.TabIndex = 18;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CourseName, Unit, Program, CreationDate, UpdateDate });
            dataGridView1.Location = new Point(12, 203);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(673, 232);
            dataGridView1.TabIndex = 2;
            // 
            // CourseName
            // 
            CourseName.HeaderText = "Course Name";
            CourseName.MinimumWidth = 6;
            CourseName.Name = "CourseName";
            CourseName.ReadOnly = true;
            CourseName.Width = 125;
            // 
            // Unit
            // 
            Unit.HeaderText = "Unit";
            Unit.MinimumWidth = 6;
            Unit.Name = "Unit";
            Unit.ReadOnly = true;
            Unit.Width = 125;
            // 
            // Program
            // 
            Program.HeaderText = "Program";
            Program.MinimumWidth = 6;
            Program.Name = "Program";
            Program.ReadOnly = true;
            Program.Width = 125;
            // 
            // CreationDate
            // 
            CreationDate.HeaderText = "Creation Date";
            CreationDate.MinimumWidth = 6;
            CreationDate.Name = "CreationDate";
            CreationDate.ReadOnly = true;
            CreationDate.Width = 125;
            // 
            // UpdateDate
            // 
            UpdateDate.HeaderText = "Update Date";
            UpdateDate.MinimumWidth = 6;
            UpdateDate.Name = "UpdateDate";
            UpdateDate.ReadOnly = true;
            UpdateDate.Width = 125;
            // 
            // button2
            // 
            button2.BackColor = Color.DodgerBlue;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(517, 444);
            button2.Name = "button2";
            button2.Size = new Size(112, 40);
            button2.TabIndex = 17;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(291, 444);
            button1.Name = "button1";
            button1.Size = new Size(108, 43);
            button1.TabIndex = 12;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(394, 101);
            label3.Name = "label3";
            label3.Size = new Size(55, 28);
            label3.TabIndex = 4;
            label3.Text = "Unit:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(75, 98);
            label2.Name = "label2";
            label2.Size = new Size(140, 28);
            label2.TabIndex = 3;
            label2.Text = "Course Name:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(448, 91);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 43);
            textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(221, 91);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 43);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(291, 21);
            label1.Name = "label1";
            label1.Size = new Size(127, 46);
            label1.TabIndex = 0;
            label1.Text = "Course";
            // 
            // Course
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 499);
            Controls.Add(SettingsSubPanel);
            Name = "Course";
            Text = "Course";
            SettingsSubPanel.ResumeLayout(false);
            SettingsSubPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel SettingsSubPanel;
        private Button button3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn CourseName;
        private DataGridViewTextBoxColumn Unit;
        private DataGridViewTextBoxColumn Program;
        private DataGridViewTextBoxColumn CreationDate;
        private DataGridViewTextBoxColumn UpdateDate;
        private Button button2;
        private Button button1;
        private Label label3;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label1;
        private Label label4;
        private ComboBox comboBox3;
    }
}