using GreenLifeStoreManagementSystem.Forms;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void LoadForm(Form form)
        {
            panelMain.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelMain.Controls.Add(form);
            form.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            LoadForm(new Home());
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            LoadForm(new Profile());
        }

        private void btnReviews_Click(object sender, EventArgs e)
        {
            LoadForm(new ReviewAndRatings());
        }

        private void btnManageProducts_Click(object sender, EventArgs e)
        {
            LoadForm(new ManageProducts());
        }

        private void btnMyOrders_Click(object sender, EventArgs e)
        {
            LoadForm(new MyOrders());
        }

        private void btnManageCustomers_Click(object sender, EventArgs e)
        {
            LoadForm(new ManageCustomers());
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            LoadForm(new Cart());
        }

        private void btnManageOrders_Click(object sender, EventArgs e)
        {
            LoadForm(new ManageOrders());
        }

        private void btnBrowseProducts_Click(object sender, EventArgs e)
        {
            LoadForm(new BrowseProducts());
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            LoadForm(new Reports());
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadForm(new Dashboard());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoadForm(new Home()); // Redirect to login form
        }
    }
}
