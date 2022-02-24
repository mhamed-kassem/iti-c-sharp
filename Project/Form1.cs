using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoginControl loginControl = new LoginControl();
            this.Size = new Size(loginControl.Width, loginControl.Height);
            Controls.Add(loginControl);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
