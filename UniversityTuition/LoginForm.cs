using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UniversityTuition
{
    public partial class LoginForm : Form
    {
        string User = "admin";
        string Pass = "admin";
        MainForm mf = new MainForm();
        public LoginForm()
        {
            InitializeComponent();
            mf.lf = this;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string inpUser = inputUsername.Text;
            string inpPass = inputPassword.Text;
            if (inpUser == User && inpPass == Pass)
            {
                mf.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("نام کابری یا رمزعبور اشتباه است!");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            inputPassword.PasswordChar = '*';
        }
    }
}
