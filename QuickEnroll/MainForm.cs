using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickEnroll
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void loadform(object Form)
        {
            if (this.panel4.Controls.Count > 0)
                this.panel4.Controls.RemoveAt(0);
            Form fh = Form as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panel4.Controls.Add(fh);
            this.panel4.Tag = fh;
            fh.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadform(new Dashboard());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadform(new Records());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadform(new Personnel());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadform(new History());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            loadform(new Settings());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
