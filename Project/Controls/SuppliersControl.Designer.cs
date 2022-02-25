namespace Project.Controls
{
    partial class SuppliersControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddBtn = new System.Windows.Forms.Button();
            this.IDLbl = new System.Windows.Forms.Label();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.NameLbl = new System.Windows.Forms.Label();
            this.EmailLbl = new System.Windows.Forms.Label();
            this.PhoneLbl = new System.Windows.Forms.Label();
            this.AddressLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.NewSupplierGroup = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.NewSupplierGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(25, 307);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(105, 32);
            this.AddBtn.TabIndex = 0;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // IDLbl
            // 
            this.IDLbl.AutoSize = true;
            this.IDLbl.Location = new System.Drawing.Point(21, 46);
            this.IDLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IDLbl.Name = "IDLbl";
            this.IDLbl.Size = new System.Drawing.Size(26, 20);
            this.IDLbl.TabIndex = 1;
            this.IDLbl.Text = "ID";
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(110, 46);
            this.IDBox.Margin = new System.Windows.Forms.Padding(2);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(170, 26);
            this.IDBox.TabIndex = 2;
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(21, 90);
            this.NameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(51, 20);
            this.NameLbl.TabIndex = 1;
            this.NameLbl.Text = "Name";
            // 
            // EmailLbl
            // 
            this.EmailLbl.AutoSize = true;
            this.EmailLbl.Location = new System.Drawing.Point(21, 133);
            this.EmailLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmailLbl.Name = "EmailLbl";
            this.EmailLbl.Size = new System.Drawing.Size(48, 20);
            this.EmailLbl.TabIndex = 1;
            this.EmailLbl.Text = "Email";
            // 
            // PhoneLbl
            // 
            this.PhoneLbl.AutoSize = true;
            this.PhoneLbl.Location = new System.Drawing.Point(21, 176);
            this.PhoneLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PhoneLbl.Name = "PhoneLbl";
            this.PhoneLbl.Size = new System.Drawing.Size(55, 20);
            this.PhoneLbl.TabIndex = 1;
            this.PhoneLbl.Text = "Phone";
            // 
            // AddressLbl
            // 
            this.AddressLbl.AutoSize = true;
            this.AddressLbl.Location = new System.Drawing.Point(21, 224);
            this.AddressLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AddressLbl.Name = "AddressLbl";
            this.AddressLbl.Size = new System.Drawing.Size(68, 20);
            this.AddressLbl.TabIndex = 1;
            this.AddressLbl.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(328, 17);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 37);
            this.label6.TabIndex = 1;
            this.label6.Text = "Supplier";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(110, 90);
            this.NameBox.Margin = new System.Windows.Forms.Padding(2);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(170, 26);
            this.NameBox.TabIndex = 2;
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(110, 133);
            this.EmailBox.Margin = new System.Windows.Forms.Padding(2);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(170, 26);
            this.EmailBox.TabIndex = 2;
            // 
            // PhoneBox
            // 
            this.PhoneBox.Location = new System.Drawing.Point(110, 176);
            this.PhoneBox.Margin = new System.Windows.Forms.Padding(2);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(170, 26);
            this.PhoneBox.TabIndex = 2;
            // 
            // AddressBox
            // 
            this.AddressBox.Location = new System.Drawing.Point(110, 224);
            this.AddressBox.Margin = new System.Windows.Forms.Padding(2);
            this.AddressBox.Multiline = true;
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(170, 58);
            this.AddressBox.TabIndex = 2;
            // 
            // NewSupplierGroup
            // 
            this.NewSupplierGroup.Controls.Add(this.IDLbl);
            this.NewSupplierGroup.Controls.Add(this.AddressBox);
            this.NewSupplierGroup.Controls.Add(this.CancelBtn);
            this.NewSupplierGroup.Controls.Add(this.AddBtn);
            this.NewSupplierGroup.Controls.Add(this.PhoneBox);
            this.NewSupplierGroup.Controls.Add(this.NameLbl);
            this.NewSupplierGroup.Controls.Add(this.EmailBox);
            this.NewSupplierGroup.Controls.Add(this.EmailLbl);
            this.NewSupplierGroup.Controls.Add(this.NameBox);
            this.NewSupplierGroup.Controls.Add(this.PhoneLbl);
            this.NewSupplierGroup.Controls.Add(this.IDBox);
            this.NewSupplierGroup.Controls.Add(this.AddressLbl);
            this.NewSupplierGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewSupplierGroup.Location = new System.Drawing.Point(22, 114);
            this.NewSupplierGroup.Margin = new System.Windows.Forms.Padding(2);
            this.NewSupplierGroup.Name = "NewSupplierGroup";
            this.NewSupplierGroup.Padding = new System.Windows.Forms.Padding(2);
            this.NewSupplierGroup.Size = new System.Drawing.Size(309, 353);
            this.NewSupplierGroup.TabIndex = 3;
            this.NewSupplierGroup.TabStop = false;
            this.NewSupplierGroup.Text = "New Supplier";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(335, 114);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(550, 360);
            this.dataGridView1.TabIndex = 4;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(780, 78);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(105, 32);
            this.DeleteBtn.TabIndex = 0;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(671, 78);
            this.UpdateBtn.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(105, 32);
            this.UpdateBtn.TabIndex = 0;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(175, 307);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(105, 32);
            this.CancelBtn.TabIndex = 0;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SuppliersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.NewSupplierGroup);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.label6);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SuppliersControl";
            this.Size = new System.Drawing.Size(930, 580);
            this.NewSupplierGroup.ResumeLayout(false);
            this.NewSupplierGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label IDLbl;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label EmailLbl;
        private System.Windows.Forms.Label PhoneLbl;
        private System.Windows.Forms.Label AddressLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.TextBox PhoneBox;
        private System.Windows.Forms.TextBox AddressBox;
        private System.Windows.Forms.GroupBox NewSupplierGroup;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button CancelBtn;
    }
}
