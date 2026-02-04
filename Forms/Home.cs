using GreenLifeStoreManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenLifeStoreManagementSystem.Forms
{
    public partial class Home : Form
    {
        private User currentUser;

        public Home(User user)
        {
            InitializeComponent();
            currentUser = user;
            UpdateWelcomeMessage();
        }

        private void UpdateWelcomeMessage()
        {
            if (currentUser != null)
            {
                labelWelcome.Text = $"Welcome, {currentUser.FullName}";
                labelRole.Text = $"Role: {currentUser.Role}";
            }
        }
    }
}
