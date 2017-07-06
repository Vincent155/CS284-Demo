using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RAV4Forms
{
    public partial class RAV4Form : Form
    {
        public RAV4Form()
        {
            InitializeComponent();
        }

        private void listbutton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\wei\Desktop\Demo\Retired Car\RAV4\特色外型.pdf");
        }

        private void salebutton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\wei\Desktop\Demo\Retired Car\RAV4\售價規配.pdf");
        }
    }
}