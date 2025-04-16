namespace QuickEnroll
{
    partial class Assignation
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
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            comboBox2 = new ComboBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            comboBox3 = new ComboBox();
            label4 = new Label();
            button1 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            ProfessorName = new DataGridViewTextBoxColumn();
            RoomNo = new DataGridViewTextBoxColumn();
            CourseName = new DataGridViewTextBoxColumn();
            ScheduleDateTime = new DataGridViewTextBoxColumn();
            button2 = new Button();
            label1 = new Label();
            SettingsSubPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // SettingsSubPanel
            // 
            SettingsSubPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SettingsSubPanel.BackColor = Color.DarkSlateGray;
            SettingsSubPanel.Controls.Add(dateTimePicker1);
            SettingsSubPanel.Controls.Add(label5);
            SettingsSubPanel.Controls.Add(comboBox2);
            SettingsSubPanel.Controls.Add(label3);
            SettingsSubPanel.Controls.Add(comboBox1);
            SettingsSubPanel.Controls.Add(label2);
            SettingsSubPanel.Controls.Add(comboBox3);
            SettingsSubPanel.Controls.Add(label4);
            SettingsSubPanel.Controls.Add(button1);
            SettingsSubPanel.Controls.Add(button3);
            SettingsSubPanel.Controls.Add(dataGridView1);
            SettingsSubPanel.Controls.Add(button2);
            SettingsSubPanel.Controls.Add(label1);
            SettingsSubPanel.Location = new Point(2, 2);
            SettingsSubPanel.Name = "SettingsSubPanel";
            SettingsSubPanel.Size = new Size(696, 498);
            SettingsSubPanel.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(407, 150);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 67;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(301, 148);
            label5.Name = "label5";
            label5.Size = new Size(100, 28);
            label5.TabIndex = 66;
            label5.Text = "Schedule:";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Bachelor of Science Information Technology", "Bachelor of Science Computer Science", "Bachelor of Science Medicine", "Bachelor of Science Meteorology", "Bachelor of Science Chemistry" });
            comboBox2.Location = new Point(138, 145);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 36);
            comboBox2.TabIndex = 65;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(62, 145);
            label3.Name = "label3";
            label3.Size = new Size(70, 28);
            label3.TabIndex = 64;
            label3.Text = "Room:";
            label3.Click += label3_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Bachelor of Science Information Technology", "Bachelor of Science Computer Science", "Bachelor of Science Medicine", "Bachelor of Science Meteorology", "Bachelor of Science Chemistry" });
            comboBox1.Location = new Point(444, 94);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 36);
            comboBox1.TabIndex = 63;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(358, 97);
            label2.Name = "label2";
            label2.Size = new Size(80, 28);
            label2.TabIndex = 62;
            label2.Text = "Course:";
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Bachelor of Science Information Technology", "Bachelor of Science Computer Science", "Bachelor of Science Medicine", "Bachelor of Science Meteorology", "Bachelor of Science Chemistry" });
            comboBox3.Location = new Point(171, 94);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(151, 36);
            comboBox3.TabIndex = 61;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(61, 94);
            label4.Name = "label4";
            label4.Size = new Size(104, 28);
            label4.TabIndex = 60;
            label4.Text = "Professor:";
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(74, 444);
            button1.Name = "button1";
            button1.Size = new Size(108, 40);
            button1.TabIndex = 21;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(294, 444);
            button3.Name = "button3";
            button3.Size = new Size(112, 40);
            button3.TabIndex = 18;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ProfessorName, RoomNo, CourseName, ScheduleDateTime });
            dataGridView1.Location = new Point(74, 198);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(552, 225);
            dataGridView1.TabIndex = 2;
            // 
            // ProfessorName
            // 
            ProfessorName.HeaderText = "Professor Name";
            ProfessorName.MinimumWidth = 6;
            ProfessorName.Name = "ProfessorName";
            ProfessorName.ReadOnly = true;
            ProfessorName.Width = 125;
            // 
            // RoomNo
            // 
            RoomNo.HeaderText = "Room Number";
            RoomNo.MinimumWidth = 6;
            RoomNo.Name = "RoomNo";
            RoomNo.Width = 125;
            // 
            // CourseName
            // 
            CourseName.HeaderText = "Course Name";
            CourseName.MinimumWidth = 6;
            CourseName.Name = "CourseName";
            CourseName.ReadOnly = true;
            CourseName.Width = 125;
            // 
            // ScheduleDateTime
            // 
            ScheduleDateTime.HeaderText = "Schedule Date Time";
            ScheduleDateTime.MinimumWidth = 6;
            ScheduleDateTime.Name = "ScheduleDateTime";
            ScheduleDateTime.Width = 125;
            // 
            // button2
            // 
            button2.BackColor = Color.DodgerBlue;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(514, 444);
            button2.Name = "button2";
            button2.Size = new Size(112, 40);
            button2.TabIndex = 17;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(249, 16);
            label1.Name = "label1";
            label1.Size = new Size(201, 46);
            label1.TabIndex = 0;
            label1.Text = "Assignation";
            // 
            // Assignation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 503);
            Controls.Add(SettingsSubPanel);
            Name = "Assignation";
            Text = "Assignation";
            SettingsSubPanel.ResumeLayout(false);
            SettingsSubPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel SettingsSubPanel;
        private Button button1;
        private Button button3;
        private DataGridView dataGridView1;
        private Button button2;
        private Label label1;
        private DataGridViewTextBoxColumn ProfessorName;
        private DataGridViewTextBoxColumn RoomNo;
        private DataGridViewTextBoxColumn CourseName;
        private DataGridViewTextBoxColumn ScheduleDateTime;
        private Label label5;
        private ComboBox comboBox2;
        private Label label3;
        private ComboBox comboBox1;
        private Label label2;
        private ComboBox comboBox3;
        private Label label4;
        private DateTimePicker dateTimePicker1;
    }
}