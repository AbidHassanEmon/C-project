using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        public Dashboard(String X)
        {
            InitializeComponent();
            string role = X;
            if (role == "Employee")
            {
                btnAddItem.Hide();
                btnRemoveItem.Hide();
                btnUpdateItem.Hide();
                btnPlaceorder.Hide();
                btnmanageEmployee.Hide();

            }
            else if (role == "Admin")
            {
                btnAddItem.Show();
                btnRemoveItem.Show();
                btnUpdateItem.Show();
                btnPlaceorder.Show();
                btnmanageEmployee.Show();
            }

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login ab = new Login();
            this.Hide();
            ab.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            ucAddItem1.Hide();
            ucRemoveItem1.Hide();
            ucUpdateItem1.Hide();
            ucMangeEmployee1.Hide();
            ucPlaceOrder1.Show();
            ucPlaceOrder1.BringToFront();
        }

        private void btnPlaceorder_Click(object sender, EventArgs e)
        {
            ucAddItem1.Hide();
            ucRemoveItem1.Hide();
            ucUpdateItem1.Hide();
            ucMangeEmployee1.Hide();
            ucPlaceOrder1.Show();
            ucPlaceOrder1.BringToFront();
        }

        private void btnUpdateItem_Click(object sender, EventArgs e)
        {
            ucPlaceOrder1.Hide();
            ucAddItem1.Hide();
            ucRemoveItem1.Hide();
            ucMangeEmployee1.Hide();
            ucUpdateItem1.Show();
            ucUpdateItem1.BringToFront();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            ucRemoveItem1.Hide();
            ucUpdateItem1.Hide();
            ucPlaceOrder1.Hide();
            ucMangeEmployee1.Hide();
            ucAddItem1.Show();
            ucAddItem1.BringToFront();
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            ucPlaceOrder1.Hide();
            ucAddItem1.Hide();
            ucUpdateItem1.Hide();
            ucMangeEmployee1.Hide();
            ucRemoveItem1.Show();
            ucRemoveItem1.BringToFront();
        }

        private void btnmanageEmployee_Click(object sender, EventArgs e)
        {
            ucPlaceOrder1.Hide();
            ucAddItem1.Hide();
            ucUpdateItem1.Hide();
            ucRemoveItem1.Hide();
            ucMangeEmployee1.Show();
            ucMangeEmployee1.BringToFront();

        }
    }
}
