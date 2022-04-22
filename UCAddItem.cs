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
    public partial class UCAddItem : UserControl
    {
        DataAccess Ob = new DataAccess();
        public UCAddItem()
        {
            InitializeComponent();
        }
        private void ClearContent()
        {
            comboCatagory.SelectedIndex = -1;
            this.txtItemName.Clear();
            this.txtPrice.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ClearContent();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(this.txtItemName.Text) || String.IsNullOrEmpty(this.txtPrice.Text) || String.IsNullOrEmpty(this.comboCatagory.Text))
                {
                    MessageBox.Show("please Insert All  Data");
                    return;
                }
                String query = "insert into Item(Name,Category,Price)values('" + txtItemName.Text + "','" + comboCatagory.Text + "'," + txtPrice.Text + ")";
                int Count = this.Ob.ExecuteDMLQuery(query);
                if (Count == 1)
                {
                    this.ClearContent();
                    MessageBox.Show("Data Isertation Successfull");
                }
                else
                {
                    MessageBox.Show("Data Isertation Failed");
                }

            }
            catch (Exception Exc)
            {
                MessageBox.Show("An Error Occourd:" + Exc.Message);
            }
        }



    }
}
