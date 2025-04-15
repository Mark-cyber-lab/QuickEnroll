
namespace QuickEnroll
{
    partial class EnrollmentApplication
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            comboBox3 = new ComboBox();
            label13 = new Label();
            comboBox4 = new ComboBox();
            label14 = new Label();
            button1 = new Button();
            button2 = new Button();
            comboBox5 = new ComboBox();
            label15 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(297, 101);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(175, 34);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(678, 107);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(175, 34);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F);
            textBox3.Location = new Point(297, 167);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(175, 34);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 12F);
            textBox4.Location = new Point(678, 164);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(175, 34);
            textBox4.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(173, 107);
            label1.Name = "label1";
            label1.Size = new Size(115, 28);
            label1.TabIndex = 4;
            label1.Text = "First Name: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(532, 107);
            label2.Name = "label2";
            label2.Size = new Size(140, 28);
            label2.TabIndex = 5;
            label2.Text = "Middle Name: ";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(176, 170);
            label3.Name = "label3";
            label3.Size = new Size(112, 28);
            label3.TabIndex = 6;
            label3.Text = "Last Name: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(603, 170);
            label4.Name = "label4";
            label4.Size = new Size(69, 28);
            label4.TabIndex = 7;
            label4.Text = "Suffix: ";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(446, 233);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(343, 231);
            label5.Name = "label5";
            label5.Size = new Size(94, 28);
            label5.TabIndex = 9;
            label5.Text = "Birthday: ";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(173, 32);
            label6.Name = "label6";
            label6.Size = new Size(199, 38);
            label6.TabIndex = 10;
            label6.Text = "Personnal Info";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(181, 398);
            label7.Name = "label7";
            label7.Size = new Size(91, 28);
            label7.TabIndex = 12;
            label7.Text = "Province:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Masbate", "Legazpi", "Daraga", "Camarines Norte", "Camarines Sur", "Catanduanes" });
            comboBox1.Location = new Point(278, 398);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 13;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "San Jacinto", "Washington", "Camalig" });
            comboBox2.Location = new Point(702, 398);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 15;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(572, 398);
            label8.Name = "label8";
            label8.Size = new Size(124, 28);
            label8.TabIndex = 14;
            label8.Text = "Municipality:";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(173, 330);
            label9.Name = "label9";
            label9.Size = new Size(174, 38);
            label9.TabIndex = 16;
            label9.Text = "Contact Info";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(124, 463);
            label10.Name = "label10";
            label10.Size = new Size(148, 28);
            label10.TabIndex = 17;
            label10.Text = "Phone Number:";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(633, 467);
            label11.Name = "label11";
            label11.Size = new Size(63, 28);
            label11.TabIndex = 19;
            label11.Text = "Email:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(173, 534);
            label12.Name = "label12";
            label12.Size = new Size(108, 38);
            label12.TabIndex = 21;
            label12.Text = "Studies";
            label12.Click += label12_Click;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 12F);
            textBox5.Location = new Point(278, 467);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(151, 34);
            textBox5.TabIndex = 22;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 12F);
            textBox6.Location = new Point(702, 467);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(151, 34);
            textBox6.TabIndex = 23;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Bachelor of Science Information Technology", "Bachelor of Science Computer Science", "Bachelor of Science Medicine", "Bachelor of Science Meteorology", "Bachelor of Science Chemistry" });
            comboBox3.Location = new Point(278, 597);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(151, 28);
            comboBox3.TabIndex = 25;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F);
            label13.Location = new Point(196, 597);
            label13.Name = "label13";
            label13.Size = new Size(76, 28);
            label13.TabIndex = 24;
            label13.Text = "Course:";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "1st Year", "2nd Year", "3rd Year", "4th Year", "5th Year" });
            comboBox4.Location = new Point(702, 597);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(151, 28);
            comboBox4.TabIndex = 27;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F);
            label14.Location = new Point(595, 593);
            label14.Name = "label14";
            label14.Size = new Size(101, 28);
            label14.TabIndex = 26;
            label14.Text = "Year Level:";
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(387, 669);
            button1.Name = "button1";
            button1.Size = new Size(108, 40);
            button1.TabIndex = 28;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(532, 669);
            button2.Name = "button2";
            button2.Size = new Size(112, 40);
            button2.TabIndex = 29;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "Male", "Female" });
            comboBox5.Location = new Point(446, 276);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(151, 28);
            comboBox5.TabIndex = 60;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F);
            label15.Location = new Point(357, 276);
            label15.Name = "label15";
            label15.Size = new Size(80, 28);
            label15.TabIndex = 59;
            label15.Text = "Gender:";
            // 
            // EnrollmentApplication
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 737);
            Controls.Add(comboBox5);
            Controls.Add(label15);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox4);
            Controls.Add(label14);
            Controls.Add(comboBox3);
            Controls.Add(label13);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(comboBox2);
            Controls.Add(label8);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "EnrollmentApplication";
            Text = "Application";
            Load += EnrollmentApplication_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox textBox5;
        private TextBox textBox6;
        private ComboBox comboBox3;
        private Label label13;
        private ComboBox comboBox4;
        private Label label14;
        private Button button1;
        private Button button2;
        private ComboBox comboBox5;
        private Label label15;
    }
}