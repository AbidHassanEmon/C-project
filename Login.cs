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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string Sql = "select * from UserInfo where Name = '" + this.txtUsername.Text + "' and pass = '" + this.txtPassword.Text + "';";
                DataAccess ds = new DataAccess();
                DataSet da = ds.ExecuteQuery(Sql);
                String Role = da.Tables[0].Rows[0][3].ToString();

                if (da.Tables[0].Rows.Count == 1)
                {
                    this.ClearContent();

                    MessageBox.Show("Login Valid");
                    Dashboard form = new Dashboard(Role);
                    this.Hide();
                    form.Show();

                }

                else
                {
                    MessageBox.Show("Login Invalid");
                    this.ClearContent();
                }

            }
            catch (Exception Exc)
            {
                MessageBox.Show("An Error Occourd:" + Exc.Message);
            }

        }

        private void ClearContent()
        {
            this.txtUsername.Clear();
            this.txtPassword.Clear();
        }

       

        private void chbtnPasswoard_CheckedChanged_1(object sender, EventArgs e)
        {
            if (this.chbtnPasswoard.Checked)
            {
                this.txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                this.txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            this.ClearContent();
        }
    }
}
