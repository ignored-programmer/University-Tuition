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
    public partial class SearchForm : Form
    {
        public PayForm pf;
        string StID = "14001037";
        public SearchForm()
        {
            InitializeComponent();
        }

        private void btnSearchForm_Click(object sender, EventArgs e)
        {
            if (inputSearch.Text.Contains("دانیال"))
            {
                if (pf != null && pf.Visible == true)
                {
                    btnCopy.Visible = true;
                }
                lblStudentID.Text = "کد دانشجویی فرد مورد نظر : " + StID;
                
            }
            else
            {
                MessageBox.Show("کاربر مورد نظر یافت نشد");
            }

        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            btnCopy.Visible = false;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            pf.inputStudentID.Text = StID;
            this.Hide();
        }

        private void SearchForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
