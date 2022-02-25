namespace Project
{
    partial class SupplierControl
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
            this.NewSupplierGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(129, 373);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 0;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            // 
            // IDLbl
            // 
            this.IDLbl.AutoSize = true;
            this.IDLbl.Location = new System.Drawing.Point(28, 54);
            this.IDLbl.Name = "IDLbl";
            this.IDLbl.Size = new System.Drawing.Size(20, 16);
            this.IDLbl.TabIndex = 1;
            this.IDLbl.Text = "ID";
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(108, 54);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(176, 22);
            this.IDBox.TabIndex = 2;
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(28, 98);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(44, 16);
            this.NameLbl.TabIndex = 1;
            this.NameLbl.Text = "Name";
            // 
            // EmailLbl
            // 
            this.EmailLbl.AutoSize = true;
            this.EmailLbl.Location = new System.Drawing.Point(28, 145);
            this.EmailLbl.Name = "EmailLbl";
            this.EmailLbl.Size = new System.Drawing.Size(41, 16);
            this.EmailLbl.TabIndex = 1;
            this.EmailLbl.Text = "Email";
            // 
            // PhoneLbl
            // 
            this.PhoneLbl.AutoSize = true;
            this.PhoneLbl.Location = new System.Drawing.Point(28, 193);
            this.PhoneLbl.Name = "PhoneLbl";
            this.PhoneLbl.Size = new System.Drawing.Size(46, 16);
            this.PhoneLbl.TabIndex = 1;
            this.PhoneLbl.Text = "Phone";
            // 
            // AddressLbl
            // 
            this.AddressLbl.AutoSize = true;
            this.AddressLbl.Location = new System.Drawing.Point(28, 232);
            this.AddressLbl.Name = "AddressLbl";
            this.AddressLbl.Size = new System.Drawing.Size(58, 16);
            this.AddressLbl.TabIndex = 1;
            this.AddressLbl.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(405, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 46);
            this.label6.TabIndex = 1;
            this.label6.Text = "Supplier";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(108, 95);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(176, 22);
            this.NameBox.TabIndex = 2;
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(108, 142);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(176, 22);
            this.EmailBox.TabIndex = 2;
            // 
            // PhoneBox
            // 
            this.PhoneBox.Location = new System.Drawing.Point(108, 187);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(176, 22);
            this.PhoneBox.TabIndex = 2;
            // 
            // AddressBox
            // 
            this.AddressBox.Location = new System.Drawing.Point(108, 229);
            this.AddressBox.Multiline = true;
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(176, 71);
            this.AddressBox.TabIndex = 2;
            // 
            // NewSupplierGroup
            // 
            this.NewSupplierGroup.Controls.Add(this.IDLbl);
            this.NewSupplierGroup.Controls.Add(this.AddressBox);
            this.NewSupplierGroup.Controls.Add(this.AddBtn);
            this.NewSupplierGroup.Controls.Add(this.PhoneBox);
            this.NewSupplierGroup.Controls.Add(this.NameLbl);
            this.NewSupplierGroup.Controls.Add(this.EmailBox);
            this.NewSupplierGroup.Controls.Add(this.EmailLbl);
            this.NewSupplierGroup.Controls.Add(this.NameBox);
            this.NewSupplierGroup.Controls.Add(this.PhoneLbl);
            this.NewSupplierGroup.Controls.Add(this.IDBox);
            this.NewSupplierGroup.Controls.Add(this.AddressLbl);
            this.NewSupplierGroup.Location = new System.Drawing.Point(29, 140);
            this.NewSupplierGroup.Name = "NewSupplierGroup";
            this.NewSupplierGroup.Size = new System.Drawing.Size(328, 434);
            this.NewSupplierGroup.TabIndex = 3;
            this.NewSupplierGroup.TabStop = false;
            this.NewSupplierGroup.Text = "New Supplier";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(413, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(578, 443);
            this.dataGridView1.TabIndex = 4;
            // 
            // SupplierControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.NewSupplierGroup);
            this.Controls.Add(this.label6);
            this.Name = "SupplierControl";
            this.Size = new System.Drawing.Size(1234, 714);
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
    }
}
