namespace QuickEnroll
{
    partial class Personnel
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

        private void label2_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }

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
            label1 = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            EmployeeName = new DataGridViewTextBoxColumn();
            Username = new DataGridViewTextBoxColumn();
            Birthday = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            ContactNumber = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1212, 733);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(1021, 657);
            button2.Name = "button2";
            button2.Size = new Size(112, 40);
            button2.TabIndex = 12;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(333, 657);
            button1.Name = "button1";
            button1.Size = new Size(108, 40);
            button1.TabIndex = 11;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(602, 118);
            label2.Name = "label2";
            label2.Size = new Size(303, 46);
            label2.TabIndex = 10;
            label2.Text = "Personnel Records";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(332, 197);
            label1.Name = "label1";
            label1.Size = new Size(136, 28);
            label1.TabIndex = 9;
            label1.Text = "Search Name: ";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(474, 197);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(293, 34);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { EmployeeName, Username, Birthday, Gender, Address, ContactNumber });
            dataGridView1.Location = new Point(333, 251);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(800, 378);
            dataGridView1.TabIndex = 0;
            // 
            // EmployeeName
            // 
            EmployeeName.HeaderText = "Employee Name";
            EmployeeName.MinimumWidth = 6;
            EmployeeName.Name = "EmployeeName";
            EmployeeName.ReadOnly = true;
            EmployeeName.Width = 125;
            // 
            // Username
            // 
            Username.HeaderText = "Username";
            Username.MinimumWidth = 6;
            Username.Name = "Username";
            Username.ReadOnly = true;
            Username.Width = 125;
            // 
            // Birthday
            // 
            Birthday.HeaderText = "Birthday";
            Birthday.MinimumWidth = 6;
            Birthday.Name = "Birthday";
            Birthday.ReadOnly = true;
            Birthday.Width = 125;
            // 
            // Gender
            // 
            Gender.HeaderText = "Gender";
            Gender.MinimumWidth = 6;
            Gender.Name = "Gender";
            Gender.ReadOnly = true;
            Gender.Width = 125;
            // 
            // Address
            // 
            Address.HeaderText = "Address";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            Address.ReadOnly = true;
            Address.Width = 125;
            // 
            // ContactNumber
            // 
            ContactNumber.HeaderText = "Contact Number";
            ContactNumber.MinimumWidth = 6;
            ContactNumber.Name = "ContactNumber";
            ContactNumber.ReadOnly = true;
            ContactNumber.Width = 125;
            // 
            // Personnel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1210, 729);
            Controls.Add(panel1);
            Name = "Personnel";
            Text = "Personnel";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn EmployeeName;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn Birthday;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn ContactNumber;
        private Button button2;
        private Button button1;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
    }
}