namespace QuickEnroll
{
    partial class Professor
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
            button1 = new Button();
            dataGridView3 = new DataGridView();
            CourseName = new DataGridViewTextBoxColumn();
            dataGridView2 = new DataGridView();
            ProgramName = new DataGridViewTextBoxColumn();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            ProfessorName = new DataGridViewTextBoxColumn();
            CreationDate = new DataGridViewTextBoxColumn();
            UpdateDate = new DataGridViewTextBoxColumn();
            button2 = new Button();
            label1 = new Label();
            SettingsSubPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // SettingsSubPanel
            // 
            SettingsSubPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SettingsSubPanel.BackColor = Color.DarkSlateGray;
            SettingsSubPanel.Controls.Add(button1);
            SettingsSubPanel.Controls.Add(dataGridView3);
            SettingsSubPanel.Controls.Add(dataGridView2);
            SettingsSubPanel.Controls.Add(button3);
            SettingsSubPanel.Controls.Add(dataGridView1);
            SettingsSubPanel.Controls.Add(button2);
            SettingsSubPanel.Controls.Add(label1);
            SettingsSubPanel.Location = new Point(0, 2);
            SettingsSubPanel.Name = "SettingsSubPanel";
            SettingsSubPanel.Size = new Size(696, 498);
            SettingsSubPanel.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(42, 441);
            button1.Name = "button1";
            button1.Size = new Size(108, 40);
            button1.TabIndex = 21;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { CourseName });
            dataGridView3.Location = new Point(477, 261);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(177, 174);
            dataGridView3.TabIndex = 20;
            // 
            // CourseName
            // 
            CourseName.HeaderText = "Course Name";
            CourseName.MinimumWidth = 6;
            CourseName.Name = "CourseName";
            CourseName.Width = 125;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { ProgramName });
            dataGridView2.Location = new Point(477, 79);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(177, 176);
            dataGridView2.TabIndex = 19;
            // 
            // ProgramName
            // 
            ProgramName.HeaderText = "Program Name";
            ProgramName.MinimumWidth = 6;
            ProgramName.Name = "ProgramName";
            ProgramName.Width = 125;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ProfessorName, CreationDate, UpdateDate });
            dataGridView1.Location = new Point(42, 79);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(427, 356);
            dataGridView1.TabIndex = 2;
            // 
            // ProfessorName
            // 
            ProfessorName.HeaderText = "Professor Name";
            ProfessorName.MinimumWidth = 6;
            ProfessorName.Name = "ProfessorName";
            ProfessorName.Width = 125;
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
            UpdateDate.Width = 125;
            // 
            // button2
            // 
            button2.BackColor = Color.DodgerBlue;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(542, 444);
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
            label1.Location = new Point(263, 18);
            label1.Name = "label1";
            label1.Size = new Size(165, 46);
            label1.TabIndex = 0;
            label1.Text = "Professor";
            // 
            // Professor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 503);
            Controls.Add(SettingsSubPanel);
            Name = "Professor";
            Text = "Professor";
            SettingsSubPanel.ResumeLayout(false);
            SettingsSubPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel SettingsSubPanel;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn ProgramName;
        private Button button3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ProfessorName;
        private DataGridViewTextBoxColumn CreationDate;
        private DataGridViewTextBoxColumn UpdateDate;
        private Button button2;
        private Label label1;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn CourseName;
        private Button button1;
    }
}