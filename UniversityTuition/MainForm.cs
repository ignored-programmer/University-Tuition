using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityTuition
{
    public partial class MainForm : Form
    {
        PayForm pf = new PayForm();
        SearchForm sf = new SearchForm();
        public LoginForm lf;
        public MainForm()
        {
            InitializeComponent();
            pf.mf = this;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            pf.Show();
        }

        private void btnSearchID_Click(object sender, EventArgs e)
        {
            sf.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            lf.Close();
        }
    }
}
