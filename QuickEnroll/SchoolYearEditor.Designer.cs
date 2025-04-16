namespace QuickEnroll
{
    partial class SchoolYearEditor
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
            Startting = new DataGridViewTextBoxColumn();
            End = new DataGridViewTextBoxColumn();
            CreationDate = new DataGridViewTextBoxColumn();
            UpdateDate = new DataGridViewTextBoxColumn();
            button2 = new Button();
            label4 = new Label();
            label5 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
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
            SettingsSubPanel.Controls.Add(label4);
            SettingsSubPanel.Controls.Add(label5);
            SettingsSubPanel.Controls.Add(textBox3);
            SettingsSubPanel.Controls.Add(textBox4);
            SettingsSubPanel.Controls.Add(button1);
            SettingsSubPanel.Controls.Add(label3);
            SettingsSubPanel.Controls.Add(label2);
            SettingsSubPanel.Controls.Add(textBox2);
            SettingsSubPanel.Controls.Add(textBox1);
            SettingsSubPanel.Controls.Add(label1);
            SettingsSubPanel.Location = new Point(0, 2);
            SettingsSubPanel.Name = "SettingsSubPanel";
            SettingsSubPanel.Size = new Size(696, 498);
            SettingsSubPanel.TabIndex = 1;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(299, 440);
            button3.Name = "button3";
            button3.Size = new Size(112, 40);
            button3.TabIndex = 18;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Startting, End, CreationDate, UpdateDate });
            dataGridView1.Location = new Point(77, 239);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(552, 188);
            dataGridView1.TabIndex = 2;
            // 
            // Startting
            // 
            Startting.HeaderText = "Start";
            Startting.MinimumWidth = 6;
            Startting.Name = "Startting";
            Startting.ReadOnly = true;
            Startting.Width = 125;
            // 
            // End
            // 
            End.HeaderText = "End";
            End.MinimumWidth = 6;
            End.Name = "End";
            End.ReadOnly = true;
            End.Width = 125;
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
            button2.Location = new Point(532, 166);
            button2.Name = "button2";
            button2.Size = new Size(112, 40);
            button2.TabIndex = 17;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(310, 176);
            label4.Name = "label4";
            label4.Size = new Size(31, 28);
            label4.TabIndex = 16;
            label4.Text = "to";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(77, 175);
            label5.Name = "label5";
            label5.Size = new Size(85, 28);
            label5.TabIndex = 15;
            label5.Text = "Current:";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(345, 165);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 43);
            textBox3.TabIndex = 14;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(179, 166);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 43);
            textBox4.TabIndex = 13;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(536, 96);
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
            label3.Location = new Point(310, 106);
            label3.Name = "label3";
            label3.Size = new Size(31, 28);
            label3.TabIndex = 4;
            label3.Text = "to";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(104, 105);
            label2.Name = "label2";
            label2.Size = new Size(58, 28);
            label2.TabIndex = 3;
            label2.Text = "New:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(345, 95);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 43);
            textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(179, 96);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 43);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(255, 21);
            label1.Name = "label1";
            label1.Size = new Size(199, 46);
            label1.TabIndex = 0;
            label1.Text = "School Year";
            // 
            // SchoolYearEditor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 505);
            Controls.Add(SettingsSubPanel);
            Name = "SchoolYearEditor";
            Text = "replica";
            Load += SchoolYearEditor_Load;
            SettingsSubPanel.ResumeLayout(false);
            SettingsSubPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel SettingsSubPanel;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label5;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Startting;
        private DataGridViewTextBoxColumn End;
        private DataGridViewTextBoxColumn CreationDate;
        private DataGridViewTextBoxColumn UpdateDate;
        private Button button2;
        private Button button3;
    }
}