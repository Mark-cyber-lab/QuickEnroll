namespace QuickEnroll
{
    partial class Records
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
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label1 = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            StudentName = new DataGridViewTextBoxColumn();
            DegreeProgram = new DataGridViewTextBoxColumn();
            Year = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Paid = new DataGridViewTextBoxColumn();
            UpdateTime = new DataGridViewTextBoxColumn();
            CreationDate = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.BackColor = Color.FloralWhite;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1211, 739);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(1067, 678);
            button2.Name = "button2";
            button2.Size = new Size(112, 40);
            button2.TabIndex = 7;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(254, 678);
            button1.Name = "button1";
            button1.Size = new Size(108, 40);
            button1.TabIndex = 6;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(592, 119);
            label2.Name = "label2";
            label2.Size = new Size(271, 46);
            label2.TabIndex = 5;
            label2.Text = "Student Records";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(1092, 186);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(87, 24);
            radioButton2.TabIndex = 4;
            radioButton2.TabStop = true;
            radioButton2.Text = "Not Paid";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(1028, 186);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(58, 24);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "Paid";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(252, 189);
            label1.Name = "label1";
            label1.Size = new Size(136, 28);
            label1.TabIndex = 2;
            label1.Text = "Search Name: ";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(394, 189);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(293, 34);
            textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { StudentName, DegreeProgram, Year, Status, Paid, UpdateTime, CreationDate });
            dataGridView1.Location = new Point(254, 234);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(927, 424);
            dataGridView1.TabIndex = 0;
            // 
            // StudentName
            // 
            StudentName.HeaderText = "Student Name";
            StudentName.MinimumWidth = 6;
            StudentName.Name = "StudentName";
            StudentName.ReadOnly = true;
            StudentName.Width = 125;
            // 
            // DegreeProgram
            // 
            DegreeProgram.HeaderText = "Degree Program";
            DegreeProgram.MinimumWidth = 6;
            DegreeProgram.Name = "DegreeProgram";
            DegreeProgram.ReadOnly = true;
            DegreeProgram.Width = 125;
            // 
            // Year
            // 
            Year.HeaderText = "Year";
            Year.MinimumWidth = 6;
            Year.Name = "Year";
            Year.ReadOnly = true;
            Year.Width = 125;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Width = 125;
            // 
            // Paid
            // 
            Paid.HeaderText = "Paid";
            Paid.MinimumWidth = 6;
            Paid.Name = "Paid";
            Paid.ReadOnly = true;
            Paid.Width = 125;
            // 
            // UpdateTime
            // 
            UpdateTime.HeaderText = "Update Time";
            UpdateTime.MinimumWidth = 6;
            UpdateTime.Name = "UpdateTime";
            UpdateTime.ReadOnly = true;
            UpdateTime.Width = 125;
            // 
            // CreationDate
            // 
            CreationDate.HeaderText = "Creation Date";
            CreationDate.MinimumWidth = 6;
            CreationDate.Name = "CreationDate";
            CreationDate.ReadOnly = true;
            CreationDate.Width = 125;
            // 
            // Records
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1213, 742);
            Controls.Add(panel1);
            Name = "Records";
            Text = "Records";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn StudentName;
        private DataGridViewTextBoxColumn DegreeProgram;
        private DataGridViewTextBoxColumn Year;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Paid;
        private DataGridViewTextBoxColumn UpdateTime;
        private DataGridViewTextBoxColumn CreationDate;
        private Label label2;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button button2;
        private Button button1;
    }
}