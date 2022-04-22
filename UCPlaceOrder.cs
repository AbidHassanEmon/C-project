using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGV2Printer;

namespace RestaurantManagementSystem
{
    public partial class UCPlaceOrder : UserControl
    {
        public UCPlaceOrder()
        {
            InitializeComponent();
        }

        DataAccess ob = new DataAccess();
        protected int n, total = 0;
         int amount;
        private void UCPlaceOrder_Load(object sender, EventArgs e)
        {
            this.loadDataGridView();
        }

        private void loadDataGridView()
        {
            String sql = "select * from Item";
            DataSet da = ob.ExecuteQuery(sql);
            dGridPlaceOrder.DataSource = da.Tables[0];
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var ab = "select * from Item where Name like '%" + txtSearch.Text + "%';";
            DataSet da = ob.ExecuteQuery(ab);
            dGridPlaceOrder.DataSource = da.Tables[0];
        }

        private void dGridPlaceOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                txtItemName.Text = dGridPlaceOrder.Rows[e.RowIndex].Cells[1].Value.ToString();
                int price = int.Parse(dGridPlaceOrder.Rows[e.RowIndex].Cells[3].Value.ToString());
                txtPrice.Text = price.ToString();
            }
            catch (Exception Exc)
            {
                MessageBox.Show("An Error Occourd:" + Exc.Message);
            }

        }

        private void nUDQuantity_ValueChanged(object sender, EventArgs e)
        {
            int Quantity = int.Parse(nUDQuantity.Value.ToString());
            int price = int.Parse(txtPrice.Text);
            txtTotal.Text = (Quantity * price).ToString();
        }

        private void dGridViewCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                amount = int.Parse(dGridViewCart.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch (Exception Exc)
            {
                MessageBox.Show("An Error Occourd:" + Exc.Message);
            }
        }

        private void clear()
        {
            nUDQuantity.Value = 0;
            txtTotal.Clear();
            txtItemName.Clear();
            txtPrice.Clear();
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            
                if (txtTotal.Text == "0" || txtTotal.Text == "")
                {
                    MessageBox.Show("An Error Occourd \n ONE MUST BE ORDER");
                    return;
                }
                else
                {
                    n = dGridViewCart.Rows.Add();
                    dGridViewCart.Rows[n].Cells[0].Value = txtItemName.Text;
                    dGridViewCart.Rows[n].Cells[1].Value = txtPrice.Text;
                    dGridViewCart.Rows[n].Cells[2].Value = nUDQuantity.Value;
                    dGridViewCart.Rows[n].Cells[3].Value = txtTotal.Text;

                    total = total + int.Parse(txtTotal.Text);
                    lblGrandTotal.Text = total.ToString();

                }

            this.clear();

        }

       
        private void btnRemoveCart_Click(object sender, EventArgs e)
        {
            try
            {
                dGridViewCart.Rows.RemoveAt(this.dGridViewCart.SelectedRows[0].Index);
                
            }

            catch (Exception Exc)
            {
                MessageBox.Show("An Error Occourd:" + Exc.Message);
            }
            total -= amount;
            lblGrandTotal.Text = total.ToString();

        }

        private void clearCart()
        {
            total = 00;
            lblGrandTotal.Text = total.ToString();
            dGridViewCart.Rows.Clear();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
           PrintDataGridView ob = new PrintDataGridView(dGridViewCart);

            ob.ReportHeader = "XYZ Restaurant Bill";
            ob.ReportFooter = "                                                                                                                                                                 " +
                "   Grand Total =                    "+ total +" TK.";
            ob.Print();

            this.clearCart();
        }


    }
}
