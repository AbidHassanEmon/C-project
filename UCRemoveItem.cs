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
    public partial class UCRemoveItem : UserControl
    {
        public UCRemoveItem()
        {
            InitializeComponent();
        }

        DataAccess ob = new DataAccess();
        String sql,name;
        int id;
       

        private void UCRemoveItem_Load(object sender, EventArgs e)
        {
            this.loadDataGridView();
        }

        private void loadDataGridView()
        {
            sql = "select * from Item";
            DataSet da = ob.ExecuteQuery(sql);
            dGridRemoveItem.DataSource = da.Tables[0];
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var ab = "select * from Item where Name like '%" + txtSearch.Text + "%';";
            DataSet da = ob.ExecuteQuery(ab);
            dGridRemoveItem.DataSource = da.Tables[0];
        }

        private void dGridRemoveItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id= int.Parse(dGridRemoveItem.Rows[e.RowIndex].Cells[0].Value.ToString());
            name = dGridRemoveItem.Rows[e.RowIndex].Cells[1].Value.ToString(); ;
        }

        private void btnDeletItem_Click(object sender, EventArgs e)
        {
            try
            {
                var sql = "Delete from Item Where Id= " + id + ";";
                int Count = this.ob.ExecuteDMLQuery(sql);
                if (Count == 1)
                {
                    this.loadDataGridView();
                    MessageBox.Show(name +"  Delete Successfull");
                }
                else
                {
                    MessageBox.Show("Data Delete Failed");
                }

            }
            catch (Exception Exc)
            {
                MessageBox.Show("An Error Occourd:" + Exc.Message);
            }
            
        }
    }
}
