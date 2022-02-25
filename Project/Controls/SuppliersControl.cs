using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Controls
{
    public partial class SuppliersControl : UserControl
    {
        public SuppliersControl()
        {
            InitializeComponent();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            //Fill supplier data in the form
            //change [Add] button text to [Update]

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            //rest form
            //change [update] button text to [Add]
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            //save changes 
            //return button text to Add
        }
    }
}
