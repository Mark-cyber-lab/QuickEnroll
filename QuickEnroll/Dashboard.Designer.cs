namespace QuickEnroll
{
    partial class Dashboard
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
            textBox6 = new TextBox();
            textBox2 = new TextBox();
            textBox5 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1210, 724);
            panel1.TabIndex = 0;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI Semibold", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(800, 306);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(264, 114);
            textBox6.TabIndex = 37;
            textBox6.Text = "12,000";
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI Semibold", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(800, 516);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(264, 114);
            textBox2.TabIndex = 36;
            textBox2.Text = "12,000";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI Semibold", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(439, 516);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(277, 114);
            textBox5.TabIndex = 35;
            textBox5.Text = "12,000";
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semibold", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(439, 306);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(277, 114);
            textBox1.TabIndex = 34;
            textBox1.Text = "12,000";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 23F);
            label5.Location = new Point(800, 461);
            label5.Name = "label5";
            label5.Size = new Size(103, 52);
            label5.TabIndex = 33;
            label5.Text = "Total";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 23F);
            label4.Location = new Point(800, 251);
            label4.Name = "label4";
            label4.Size = new Size(170, 52);
            label4.TabIndex = 32;
            label4.Text = "Declined";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 23F);
            label3.Location = new Point(439, 461);
            label3.Name = "label3";
            label3.Size = new Size(162, 52);
            label3.TabIndex = 31;
            label3.Text = "Enrolled";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 23F);
            label2.Location = new Point(439, 251);
            label2.Name = "label2";
            label2.Size = new Size(162, 52);
            label2.TabIndex = 30;
            label2.Text = "Pending";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(481, 125);
            label1.Name = "label1";
            label1.Size = new Size(534, 62);
            label1.TabIndex = 29;
            label1.Text = "Enrollment Applications";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(1210, 726);
            Controls.Add(panel1);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox6;
        private TextBox textBox2;
        private TextBox textBox5;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}