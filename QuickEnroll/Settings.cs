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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void loadform(object Form)
        {
            if (this.SettingsSubPanel.Controls.Count > 0)
                this.SettingsSubPanel.Controls.RemoveAt(0);
            Form fh = Form as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.SettingsSubPanel.Controls.Add(fh);
            this.SettingsSubPanel.Tag = fh;
            fh.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.loadform(new SchoolYearEditor());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.loadform(new Course());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.loadform(new CourseProgram());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.loadform(new Professor());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.loadform(new Room());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.loadform(new Assignation());
        }
    }
}
