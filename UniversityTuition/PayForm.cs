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
    public partial class PayForm : Form
    {
        public MainForm mf;
        SearchForm sf = new SearchForm();
        public PayForm()
        {
            InitializeComponent();
            sf.pf = this;
        }

        private void btnPayForm_Click(object sender, EventArgs e)
        {
            int amount = int.Parse(inputAmountForm.Text);
            string stID = inputStudentID.Text;

                this.Hide();
                mf.listRecentPayments.Items.Add(" مبلغ : " + amount + " توسط دانشجو ، با کد دانشجویی : " + stID + " پرداخت شد ");

        }

        private void PayForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            sf.inputSearch.Text = "";
            sf.Show();
        }
    }
}
