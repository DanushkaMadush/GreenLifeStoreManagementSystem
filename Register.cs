using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenLifeStoreManagementSystem
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void buttonBackToLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxFullName.Text = string.Empty;
            textBoxUsername.Text = string.Empty;
            textBoxEmail.Text = string.Empty;
            textBoxPhone.Text = string.Empty;
            textBoxAddress.Text = string.Empty;
            textBoxPassword.Text = string.Empty;
            textBoxConfirmPassword.Text = string.Empty;
            labelValidation.Text = string.Empty;
            textBoxFullName.Focus();
        }
    }
}
