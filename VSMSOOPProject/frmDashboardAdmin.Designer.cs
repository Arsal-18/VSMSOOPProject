namespace VSMSOOPProject
{
    partial class frmDashboardAdmin
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
            this.MenuStripAdmin = new System.Windows.Forms.MenuStrip();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesmanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSalesmanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateSalesmanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSalesmanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSupplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateSupplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSupplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addVehilceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStripAdmin
            // 
            this.MenuStripAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.salesmanToolStripMenuItem,
            this.supplierToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.vehiclesToolStripMenuItem,
            this.orderDetailsToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.MenuStripAdmin.Location = new System.Drawing.Point(0, 0);
            this.MenuStripAdmin.Name = "MenuStripAdmin";
            this.MenuStripAdmin.Size = new System.Drawing.Size(800, 24);
            this.MenuStripAdmin.TabIndex = 0;
            this.MenuStripAdmin.Text = "menuStrip1";
            this.MenuStripAdmin.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStripAdmin_ItemClicked);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCustomerToolStripMenuItem,
            this.removeCustomerToolStripMenuItem,
            this.deleteCustomerToolStripMenuItem});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // salesmanToolStripMenuItem
            // 
            this.salesmanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSalesmanToolStripMenuItem,
            this.updateSalesmanToolStripMenuItem,
            this.deleteSalesmanToolStripMenuItem});
            this.salesmanToolStripMenuItem.Name = "salesmanToolStripMenuItem";
            this.salesmanToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.salesmanToolStripMenuItem.Text = "Salesman ";
            // 
            // supplierToolStripMenuItem
            // 
            this.supplierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSupplierToolStripMenuItem,
            this.updateSupplierToolStripMenuItem,
            this.deleteSupplierToolStripMenuItem});
            this.supplierToolStripMenuItem.Name = "supplierToolStripMenuItem";
            this.supplierToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.supplierToolStripMenuItem.Text = "Supplier";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAdminToolStripMenuItem,
            this.updateAdminToolStripMenuItem,
            this.deleteAdminToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // vehiclesToolStripMenuItem
            // 
            this.vehiclesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addVehilceToolStripMenuItem,
            this.updateVehicleToolStripMenuItem,
            this.deleteVehicleToolStripMenuItem});
            this.vehiclesToolStripMenuItem.Name = "vehiclesToolStripMenuItem";
            this.vehiclesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.vehiclesToolStripMenuItem.Text = "Vehicles";
            // 
            // orderDetailsToolStripMenuItem
            // 
            this.orderDetailsToolStripMenuItem.Name = "orderDetailsToolStripMenuItem";
            this.orderDetailsToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.orderDetailsToolStripMenuItem.Text = "Order Details";
            // 
            // addCustomerToolStripMenuItem
            // 
            this.addCustomerToolStripMenuItem.Name = "addCustomerToolStripMenuItem";
            this.addCustomerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addCustomerToolStripMenuItem.Text = "Add Customer";
            this.addCustomerToolStripMenuItem.Click += new System.EventHandler(this.addCustomerToolStripMenuItem_Click);
            // 
            // removeCustomerToolStripMenuItem
            // 
            this.removeCustomerToolStripMenuItem.Name = "removeCustomerToolStripMenuItem";
            this.removeCustomerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeCustomerToolStripMenuItem.Text = "Remove Customer";
            // 
            // deleteCustomerToolStripMenuItem
            // 
            this.deleteCustomerToolStripMenuItem.Name = "deleteCustomerToolStripMenuItem";
            this.deleteCustomerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteCustomerToolStripMenuItem.Text = "Delete Customer";
            // 
            // addSalesmanToolStripMenuItem
            // 
            this.addSalesmanToolStripMenuItem.Name = "addSalesmanToolStripMenuItem";
            this.addSalesmanToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addSalesmanToolStripMenuItem.Text = "Add Salesman";
            // 
            // updateSalesmanToolStripMenuItem
            // 
            this.updateSalesmanToolStripMenuItem.Name = "updateSalesmanToolStripMenuItem";
            this.updateSalesmanToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateSalesmanToolStripMenuItem.Text = "Update Salesman";
            // 
            // deleteSalesmanToolStripMenuItem
            // 
            this.deleteSalesmanToolStripMenuItem.Name = "deleteSalesmanToolStripMenuItem";
            this.deleteSalesmanToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteSalesmanToolStripMenuItem.Text = "Delete Salesman";
            // 
            // addSupplierToolStripMenuItem
            // 
            this.addSupplierToolStripMenuItem.Name = "addSupplierToolStripMenuItem";
            this.addSupplierToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addSupplierToolStripMenuItem.Text = "Add Supplier";
            // 
            // updateSupplierToolStripMenuItem
            // 
            this.updateSupplierToolStripMenuItem.Name = "updateSupplierToolStripMenuItem";
            this.updateSupplierToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateSupplierToolStripMenuItem.Text = "Update Supplier";
            // 
            // deleteSupplierToolStripMenuItem
            // 
            this.deleteSupplierToolStripMenuItem.Name = "deleteSupplierToolStripMenuItem";
            this.deleteSupplierToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteSupplierToolStripMenuItem.Text = "Delete Supplier";
            // 
            // addAdminToolStripMenuItem
            // 
            this.addAdminToolStripMenuItem.Name = "addAdminToolStripMenuItem";
            this.addAdminToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addAdminToolStripMenuItem.Text = "Add Admin";
            // 
            // updateAdminToolStripMenuItem
            // 
            this.updateAdminToolStripMenuItem.Name = "updateAdminToolStripMenuItem";
            this.updateAdminToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateAdminToolStripMenuItem.Text = "Update Admin";
            // 
            // deleteAdminToolStripMenuItem
            // 
            this.deleteAdminToolStripMenuItem.Name = "deleteAdminToolStripMenuItem";
            this.deleteAdminToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteAdminToolStripMenuItem.Text = "Delete Admin";
            // 
            // addVehilceToolStripMenuItem
            // 
            this.addVehilceToolStripMenuItem.Name = "addVehilceToolStripMenuItem";
            this.addVehilceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addVehilceToolStripMenuItem.Text = "Add Vehilce ";
            // 
            // updateVehicleToolStripMenuItem
            // 
            this.updateVehicleToolStripMenuItem.Name = "updateVehicleToolStripMenuItem";
            this.updateVehicleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateVehicleToolStripMenuItem.Text = "UpdateVehicle";
            // 
            // deleteVehicleToolStripMenuItem
            // 
            this.deleteVehicleToolStripMenuItem.Name = "deleteVehicleToolStripMenuItem";
            this.deleteVehicleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteVehicleToolStripMenuItem.Text = "Delete Vehicle";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.logOutToolStripMenuItem.Text = "Log out";
            // 
            // frmDashboardAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MenuStripAdmin);
            this.MainMenuStrip = this.MenuStripAdmin;
            this.Name = "frmDashboardAdmin";
            this.Text = "frmDashboardAdmin";
            this.MenuStripAdmin.ResumeLayout(false);
            this.MenuStripAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStripAdmin;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesmanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSalesmanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehiclesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateSalesmanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSalesmanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSupplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateSupplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSupplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addVehilceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateVehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteVehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
    }
}