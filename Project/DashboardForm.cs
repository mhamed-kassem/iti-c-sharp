using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.Controls;
namespace Project
{
    public partial class DashboardForm : Form
    {
        SuppliersControl supplierControl;
        ProductsControl productControl;
        SalesControl salesControl;
        PurchasesControl purchasesControl;
        UserControl currentControl;

        Button selectedBtn;
        public DashboardForm()
        {
            InitializeComponent();
            Width = 1220;
            Height = 740;

            supplierControl = new SuppliersControl();
            productControl = new ProductsControl();
            salesControl = new SalesControl();
            purchasesControl = new PurchasesControl();

            supplierControl.Location = new Point(200, 0);
            productControl.Location = new Point(200, 0);
            salesControl.Location = new Point(200,0);
            purchasesControl.Location = new Point(200,0);

            //add controls
            Controls.Add(productControl);
            Controls.Add(supplierControl);
            Controls.Add(salesControl);
            Controls.Add(purchasesControl);

            selectedBtn = ProductBtn; 
            currentControl = productControl;
            currentControl.BringToFront();
        }

        private void ProductBtn_Click(object sender, EventArgs e)
        {
            productControl.BringToFront();
            SelectBtn(sender as Button);
        }

        private void SelectBtn(Button b)
        {
            selectedBtn.BackColor = Color.DimGray;
            selectedBtn.ForeColor = Color.White;
            b.BackColor = Color.White;
            b.ForeColor = Color.DimGray;
            selectedBtn = b;
        }

        private void SuppliersBtn_Click(object sender, EventArgs e)
        {
            supplierControl.BringToFront();
            SelectBtn(sender as Button);
        }

        private void SalesBtn_Click(object sender, EventArgs e)
        {
            salesControl.BringToFront();
            SelectBtn(sender as Button);
        }

        private void PurchBtn_Click(object sender, EventArgs e)
        {
            purchasesControl.BringToFront();
            SelectBtn(sender as Button);
        }
    }
}
