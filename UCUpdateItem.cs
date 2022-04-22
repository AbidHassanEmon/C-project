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
    public partial class UCUpdateItem : UserControl
    {
        int id;
        string sql,qry;
        public UCUpdateItem()
        {
            InitializeComponent();
        }
        DataAccess ob = new DataAccess();
        private void UCUpdateItem_Load(object sender, EventArgs e)
        {
            loadDataGridView();
        }

        private void loadDataGridView()
        {
            sql = "select * from Item";
            DataSet da = ob.ExecuteQuery(sql);
            dataGridView1.DataSource = da.Tables[0];
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var ab = "select * from Item where Name like '%" + txtSearch.Text + "%';";
            DataSet da = ob.ExecuteQuery(ab);
            dataGridView1.DataSource = da.Tables[0];
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtItemName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboCatagory.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            int price= int.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            txtPrice.Text = price.ToString();
        }

        private void ClearContent()
        {
            comboCatagory.SelectedIndex = -1;
            this.txtItemName.Clear();
            this.txtPrice.Clear();
        }

        private void btnUpdateItem_Click(object sender, EventArgs e)
        {
            try
            {
                qry = "Update Item Set Name='" + txtItemName.Text + "',Category='" + comboCatagory.Text + "',Price=" + txtPrice.Text + " where Id='" + id + "' ";
                ob.ExecuteSetQuery(qry);
                this.ClearContent();
                loadDataGridView();
            }
            catch(Exception ec)
            {
                MessageBox.Show("An Error Occourd:" + ec.Message);
            }
            
        }
    }
}