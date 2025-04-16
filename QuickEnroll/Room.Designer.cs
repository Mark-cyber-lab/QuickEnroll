namespace QuickEnroll
{
    partial class Room
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
            dataGridView2 = new DataGridView();
            BuildingName = new DataGridViewTextBoxColumn();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            RoomName = new DataGridViewTextBoxColumn();
            Building = new DataGridViewTextBoxColumn();
            button2 = new Button();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            SettingsSubPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // SettingsSubPanel
            // 
            SettingsSubPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SettingsSubPanel.BackColor = Color.DarkSlateGray;
            SettingsSubPanel.Controls.Add(comboBox3);
            SettingsSubPanel.Controls.Add(label4);
            SettingsSubPanel.Controls.Add(dataGridView2);
            SettingsSubPanel.Controls.Add(button3);
            SettingsSubPanel.Controls.Add(dataGridView1);
            SettingsSubPanel.Controls.Add(button2);
            SettingsSubPanel.Controls.Add(button1);
            SettingsSubPanel.Controls.Add(label3);
            SettingsSubPanel.Controls.Add(label2);
            SettingsSubPanel.Controls.Add(textBox2);
            SettingsSubPanel.Controls.Add(textBox1);
            SettingsSubPanel.Controls.Add(label1);
            SettingsSubPanel.Location = new Point(1, 0);
            SettingsSubPanel.Name = "SettingsSubPanel";
            SettingsSubPanel.Size = new Size(696, 498);
            SettingsSubPanel.TabIndex = 3;
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Bachelor of Science Information Technology", "Bachelor of Science Computer Science", "Bachelor of Science Medicine", "Bachelor of Science Meteorology", "Bachelor of Science Chemistry" });
            comboBox3.Location = new Point(209, 147);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(190, 36);
            comboBox3.TabIndex = 63;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(57, 147);
            label4.Name = "label4";
            label4.Size = new Size(152, 28);
            label4.TabIndex = 62;
            label4.Text = "Building Name:";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { BuildingName });
            dataGridView2.Location = new Point(452, 206);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(177, 232);
            dataGridView2.TabIndex = 60;
            // 
            // BuildingName
            // 
            BuildingName.HeaderText = "Building Name";
            BuildingName.MinimumWidth = 6;
            BuildingName.Name = "BuildingName";
            BuildingName.Width = 125;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(300, 444);
            button3.Name = "button3";
            button3.Size = new Size(112, 40);
            button3.TabIndex = 18;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { RoomName, Building });
            dataGridView1.Location = new Point(77, 206);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(300, 232);
            dataGridView1.TabIndex = 2;
            // 
            // RoomName
            // 
            RoomName.HeaderText = "Room Name";
            RoomName.MinimumWidth = 6;
            RoomName.Name = "RoomName";
            RoomName.Width = 125;
            // 
            // Building
            // 
            Building.HeaderText = "Building";
            Building.MinimumWidth = 6;
            Building.Name = "Building";
            Building.Width = 125;
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
            button1.Location = new Point(77, 444);
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
            label3.Location = new Point(452, 116);
            label3.Name = "label3";
            label3.Size = new Size(147, 28);
            label3.TabIndex = 4;
            label3.Text = "Building Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(73, 98);
            label2.Name = "label2";
            label2.Size = new Size(130, 28);
            label2.TabIndex = 3;
            label2.Text = "Room Name:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(452, 147);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(177, 43);
            textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(209, 91);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(190, 43);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(291, 21);
            label1.Name = "label1";
            label1.Size = new Size(110, 46);
            label1.TabIndex = 0;
            label1.Text = "Room";
            // 
            // Room
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 494);
            Controls.Add(SettingsSubPanel);
            Name = "Room";
            Text = "Room";
            SettingsSubPanel.ResumeLayout(false);
            SettingsSubPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel SettingsSubPanel;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn BuildingName;
        private Button button3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn RoomName;
        private DataGridViewTextBoxColumn Building;
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