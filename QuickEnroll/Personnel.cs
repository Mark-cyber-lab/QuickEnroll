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
    public partial class Personnel : Form
    {
        public Personnel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new PersonnelApplicatoni().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new PersonnelApplicatoni().Show();
        }
    }
}
