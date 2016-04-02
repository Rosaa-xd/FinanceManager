using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceManager
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void llbl_ForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PasswordForgottenForm pff = new PasswordForgottenForm();
            pff.Show();
        }

        private void llbl_Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm rf = new RegisterForm();
            rf.Show();
        }
    }
}
