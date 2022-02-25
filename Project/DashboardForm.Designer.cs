namespace Project
{
    partial class DashboardForm
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
            this.SideBar = new System.Windows.Forms.Panel();
            this.PurchBtn = new System.Windows.Forms.Button();
            this.SalesBtn = new System.Windows.Forms.Button();
            this.SuppliersBtn = new System.Windows.Forms.Button();
            this.ProductBtn = new System.Windows.Forms.Button();
            this.SideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.Gray;
            this.SideBar.Controls.Add(this.ProductBtn);
            this.SideBar.Controls.Add(this.PurchBtn);
            this.SideBar.Controls.Add(this.SalesBtn);
            this.SideBar.Controls.Add(this.SuppliersBtn);
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.Location = new System.Drawing.Point(0, 0);
            this.SideBar.Margin = new System.Windows.Forms.Padding(2);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(200, 630);
            this.SideBar.TabIndex = 0;
            // 
            // PurchBtn
            // 
            this.PurchBtn.BackColor = System.Drawing.Color.DimGray;
            this.PurchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PurchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchBtn.ForeColor = System.Drawing.Color.White;
            this.PurchBtn.Location = new System.Drawing.Point(-1, 149);
            this.PurchBtn.Margin = new System.Windows.Forms.Padding(2);
            this.PurchBtn.Name = "PurchBtn";
            this.PurchBtn.Size = new System.Drawing.Size(204, 51);
            this.PurchBtn.TabIndex = 1;
            this.PurchBtn.Text = "Purchases";
            this.PurchBtn.UseVisualStyleBackColor = false;
            this.PurchBtn.Click += new System.EventHandler(this.PurchBtn_Click);
            // 
            // SalesBtn
            // 
            this.SalesBtn.BackColor = System.Drawing.Color.DimGray;
            this.SalesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesBtn.ForeColor = System.Drawing.Color.White;
            this.SalesBtn.Location = new System.Drawing.Point(-1, 99);
            this.SalesBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SalesBtn.Name = "SalesBtn";
            this.SalesBtn.Size = new System.Drawing.Size(204, 51);
            this.SalesBtn.TabIndex = 1;
            this.SalesBtn.Text = "Sales";
            this.SalesBtn.UseVisualStyleBackColor = false;
            this.SalesBtn.Click += new System.EventHandler(this.SalesBtn_Click);
            // 
            // SuppliersBtn
            // 
            this.SuppliersBtn.BackColor = System.Drawing.Color.DimGray;
            this.SuppliersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SuppliersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuppliersBtn.ForeColor = System.Drawing.Color.White;
            this.SuppliersBtn.Location = new System.Drawing.Point(-1, 49);
            this.SuppliersBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SuppliersBtn.Name = "SuppliersBtn";
            this.SuppliersBtn.Size = new System.Drawing.Size(204, 51);
            this.SuppliersBtn.TabIndex = 1;
            this.SuppliersBtn.Text = "Suppliers";
            this.SuppliersBtn.UseVisualStyleBackColor = false;
            this.SuppliersBtn.Click += new System.EventHandler(this.SuppliersBtn_Click);
            // 
            // ProductBtn
            // 
            this.ProductBtn.BackColor = System.Drawing.Color.White;
            this.ProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductBtn.ForeColor = System.Drawing.Color.DimGray;
            this.ProductBtn.Location = new System.Drawing.Point(-1, -1);
            this.ProductBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ProductBtn.Name = "ProductBtn";
            this.ProductBtn.Size = new System.Drawing.Size(204, 51);
            this.ProductBtn.TabIndex = 1;
            this.ProductBtn.Text = "Products";
            this.ProductBtn.UseVisualStyleBackColor = false;
            this.ProductBtn.Click += new System.EventHandler(this.ProductBtn_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(802, 630);
            this.Controls.Add(this.SideBar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DashboardForm";
            this.Text = "Dashboard";
            this.SideBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel SideBar;
        private System.Windows.Forms.Button ProductBtn;
        private System.Windows.Forms.Button PurchBtn;
        private System.Windows.Forms.Button SalesBtn;
        private System.Windows.Forms.Button SuppliersBtn;
    }
}

