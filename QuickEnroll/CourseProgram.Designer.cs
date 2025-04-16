namespace QuickEnroll
{
    partial class CourseProgram
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
            button3 = new Button();
            dataGridView1 = new DataGridView();
            ProgramName = new DataGridViewTextBoxColumn();
            Department = new DataGridViewTextBoxColumn();
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
            SettingsSubPanel.Controls.Add(button3);
            SettingsSubPanel.Controls.Add(dataGridView1);
            SettingsSubPanel.Controls.Add(button2);
            SettingsSubPanel.Controls.Add(button1);
            SettingsSubPanel.Controls.Add(label3);
            SettingsSubPanel.Controls.Add(label2);
            SettingsSubPanel.Controls.Add(textBox2);
            SettingsSubPanel.Controls.Add(textBox1);
            SettingsSubPanel.Controls.Add(label1);
            SettingsSubPanel.Location = new Point(-3, 0);
            SettingsSubPanel.Name = "SettingsSubPanel";
            SettingsSubPanel.Size = new Size(696, 498);
            SettingsSubPanel.TabIndex = 3;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ProgramName, Department, CreationDate, UpdateDate });
            dataGridView1.Location = new Point(77, 198);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(552, 232);
            dataGridView1.TabIndex = 2;
            // 
            // ProgramName
            // 
            ProgramName.HeaderText = "Program Name";
            ProgramName.MinimumWidth = 6;
            ProgramName.Name = "ProgramName";
            ProgramName.ReadOnly = true;
            ProgramName.Width = 125;
            // 
            // Department
            // 
            Department.HeaderText = "Department";
            Department.MinimumWidth = 6;
            Department.Name = "Department";
            Department.ReadOnly = true;
            Department.Width = 125;
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
            button1.Location = new Point(304, 147);
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
            label3.Location = new Point(354, 104);
            label3.Name = "label3";
            label3.Size = new Size(127, 28);
            label3.TabIndex = 4;
            label3.Text = "Department:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(53, 99);
            label2.Name = "label2";
            label2.Size = new Size(155, 28);
            label2.TabIndex = 3;
            label2.Text = "Program Name:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(487, 89);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 43);
            textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(214, 89);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 43);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(278, 20);
            label1.Name = "label1";
            label1.Size = new Size(154, 46);
            label1.TabIndex = 0;
            label1.Text = "Program";
            // 
            // CourseProgram
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 501);
            Controls.Add(SettingsSubPanel);
            Name = "CourseProgram";
            Text = "CourseProgram";
            SettingsSubPanel.ResumeLayout(false);
            SettingsSubPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel SettingsSubPanel;
        private Button button3;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button1;
        private Label label3;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label1;
        private DataGridViewTextBoxColumn ProgramName;
        private DataGridViewTextBoxColumn Department;
        private DataGridViewTextBoxColumn CreationDate;
        private DataGridViewTextBoxColumn UpdateDate;
    }
}