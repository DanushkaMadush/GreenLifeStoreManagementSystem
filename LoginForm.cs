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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxUsername.Text = string.Empty;
            textBoxPassword.Text = string.Empty;
            textBoxUsername.Focus();
        }

        private void linkLabelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register registerForm = new Register();
            registerForm.Show();
            this.Hide();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
    }
}
