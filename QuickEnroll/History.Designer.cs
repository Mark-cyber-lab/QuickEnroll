namespace QuickEnroll
{
    partial class History
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
            label1 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            Action = new DataGridViewTextBoxColumn();
            DateTime = new DataGridViewTextBoxColumn();
            Initiator = new DataGridViewTextBoxColumn();
            Details = new DataGridViewTextBoxColumn();
            Result = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1213, 708);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(764, 164);
            label1.Name = "label1";
            label1.Size = new Size(49, 28);
            label1.TabIndex = 20;
            label1.Text = "End:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(819, 164);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(387, 162);
            label5.Name = "label5";
            label5.Size = new Size(57, 28);
            label5.TabIndex = 18;
            label5.Text = "Start:";
            label5.Click += label5_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(450, 164);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 17;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(633, 88);
            label2.Name = "label2";
            label2.Size = new Size(213, 46);
            label2.TabIndex = 16;
            label2.Text = "History Logs";
            label2.Click += label2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Action, DateTime, Initiator, Details, Result });
            dataGridView1.Location = new Point(391, 209);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(678, 467);
            dataGridView1.TabIndex = 13;
            // 
            // Action
            // 
            Action.HeaderText = "Action";
            Action.MinimumWidth = 6;
            Action.Name = "Action";
            Action.ReadOnly = true;
            Action.Width = 125;
            // 
            // DateTime
            // 
            DateTime.HeaderText = "Date Time";
            DateTime.MinimumWidth = 6;
            DateTime.Name = "DateTime";
            DateTime.ReadOnly = true;
            DateTime.Width = 125;
            // 
            // Initiator
            // 
            Initiator.HeaderText = "Initiator";
            Initiator.MinimumWidth = 6;
            Initiator.Name = "Initiator";
            Initiator.ReadOnly = true;
            Initiator.Width = 125;
            // 
            // Details
            // 
            Details.HeaderText = "Details";
            Details.MinimumWidth = 6;
            Details.Name = "Details";
            Details.ReadOnly = true;
            Details.Width = 125;
            // 
            // Result
            // 
            Result.HeaderText = "Result";
            Result.MinimumWidth = 6;
            Result.Name = "Result";
            Result.ReadOnly = true;
            Result.Width = 125;
            // 
            // History
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1212, 709);
            Controls.Add(panel1);
            Name = "History";
            Text = "History";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private Label label1;
        private DateTimePicker dateTimePicker2;
        private DataGridViewTextBoxColumn Action;
        private DataGridViewTextBoxColumn DateTime;
        private DataGridViewTextBoxColumn Initiator;
        private DataGridViewTextBoxColumn Details;
        private DataGridViewTextBoxColumn Result;
    }
}