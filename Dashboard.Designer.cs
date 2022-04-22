
namespace RestaurantManagementSystem
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnUpdateItem = new System.Windows.Forms.Button();
            this.btnPlaceorder = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ucUpdateItem1 = new RestaurantManagementSystem.UCUpdateItem();
            this.ucRemoveItem1 = new RestaurantManagementSystem.UCRemoveItem();
            this.ucPlaceOrder1 = new RestaurantManagementSystem.UCPlaceOrder();
            this.ucAddItem1 = new RestaurantManagementSystem.UCAddItem();
            this.ucMangeEmployee1 = new RestaurantManagementSystem.UCMangeEmployee();
            this.btnmanageEmployee = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnmanageEmployee);
            this.panel1.Controls.Add(this.btnRemoveItem);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnAddItem);
            this.panel1.Controls.Add(this.btnUpdateItem);
            this.panel1.Controls.Add(this.btnPlaceorder);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 57);
            this.panel1.TabIndex = 2;
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveItem.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveItem.Location = new System.Drawing.Point(333, 14);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(101, 23);
            this.btnRemoveItem.TabIndex = 4;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Red;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(707, 12);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(67, 23);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.ForeColor = System.Drawing.Color.Black;
            this.btnAddItem.Location = new System.Drawing.Point(112, 13);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(87, 23);
            this.btnAddItem.TabIndex = 2;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnUpdateItem
            // 
            this.btnUpdateItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateItem.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateItem.Location = new System.Drawing.Point(217, 14);
            this.btnUpdateItem.Name = "btnUpdateItem";
            this.btnUpdateItem.Size = new System.Drawing.Size(87, 23);
            this.btnUpdateItem.TabIndex = 1;
            this.btnUpdateItem.Text = "Update Item";
            this.btnUpdateItem.UseVisualStyleBackColor = true;
            this.btnUpdateItem.Click += new System.EventHandler(this.btnUpdateItem_Click);
            // 
            // btnPlaceorder
            // 
            this.btnPlaceorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceorder.ForeColor = System.Drawing.Color.Black;
            this.btnPlaceorder.Location = new System.Drawing.Point(13, 13);
            this.btnPlaceorder.Name = "btnPlaceorder";
            this.btnPlaceorder.Size = new System.Drawing.Size(84, 23);
            this.btnPlaceorder.TabIndex = 0;
            this.btnPlaceorder.Text = "Place Order";
            this.btnPlaceorder.UseVisualStyleBackColor = true;
            this.btnPlaceorder.Click += new System.EventHandler(this.btnPlaceorder_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.ucMangeEmployee1);
            this.panel2.Controls.Add(this.ucUpdateItem1);
            this.panel2.Controls.Add(this.ucRemoveItem1);
            this.panel2.Controls.Add(this.ucPlaceOrder1);
            this.panel2.Controls.Add(this.ucAddItem1);
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Location = new System.Drawing.Point(-1, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(787, 394);
            this.panel2.TabIndex = 3;
            // 
            // ucUpdateItem1
            // 
            this.ucUpdateItem1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ucUpdateItem1.Location = new System.Drawing.Point(0, 3);
            this.ucUpdateItem1.Name = "ucUpdateItem1";
            this.ucUpdateItem1.Size = new System.Drawing.Size(787, 394);
            this.ucUpdateItem1.TabIndex = 3;
            // 
            // ucRemoveItem1
            // 
            this.ucRemoveItem1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ucRemoveItem1.Location = new System.Drawing.Point(0, 3);
            this.ucRemoveItem1.Name = "ucRemoveItem1";
            this.ucRemoveItem1.Size = new System.Drawing.Size(787, 394);
            this.ucRemoveItem1.TabIndex = 2;
            // 
            // ucPlaceOrder1
            // 
            this.ucPlaceOrder1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ucPlaceOrder1.Location = new System.Drawing.Point(0, 0);
            this.ucPlaceOrder1.Name = "ucPlaceOrder1";
            this.ucPlaceOrder1.Size = new System.Drawing.Size(787, 394);
            this.ucPlaceOrder1.TabIndex = 1;
            // 
            // ucAddItem1
            // 
            this.ucAddItem1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ucAddItem1.Location = new System.Drawing.Point(0, 3);
            this.ucAddItem1.Name = "ucAddItem1";
            this.ucAddItem1.Size = new System.Drawing.Size(787, 394);
            this.ucAddItem1.TabIndex = 0;
            // 
            // ucMangeEmployee1
            // 
            this.ucMangeEmployee1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ucMangeEmployee1.Location = new System.Drawing.Point(0, 3);
            this.ucMangeEmployee1.Name = "ucMangeEmployee1";
            this.ucMangeEmployee1.Size = new System.Drawing.Size(787, 394);
            this.ucMangeEmployee1.TabIndex = 4;
            // 
            // btnmanageEmployee
            // 
            this.btnmanageEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmanageEmployee.ForeColor = System.Drawing.Color.Black;
            this.btnmanageEmployee.Location = new System.Drawing.Point(471, 14);
            this.btnmanageEmployee.Name = "btnmanageEmployee";
            this.btnmanageEmployee.Size = new System.Drawing.Size(135, 23);
            this.btnmanageEmployee.TabIndex = 5;
            this.btnmanageEmployee.Text = "Manage Employee";
            this.btnmanageEmployee.UseVisualStyleBackColor = true;
            this.btnmanageEmployee.Click += new System.EventHandler(this.btnmanageEmployee_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 447);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnUpdateItem;
        private System.Windows.Forms.Button btnPlaceorder;
        private System.Windows.Forms.Panel panel2;
        private UCUpdateItem ucUpdateItem1;
        private UCRemoveItem ucRemoveItem1;
        private UCPlaceOrder ucPlaceOrder1;
        private UCAddItem ucAddItem1;
        private System.Windows.Forms.Button btnmanageEmployee;
        private UCMangeEmployee ucMangeEmployee1;
    }
}