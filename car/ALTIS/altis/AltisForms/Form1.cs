using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AltisForms
{
    public partial class AltisForm : Form
    {
        public AltisForm()
        {
            InitializeComponent();
        }

        private void listbutton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\wei\Desktop\Demo\car\ALTIS\特色外型.pdf");
        }

        private void salebutton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\wei\Desktop\Demo\car\ALTIS\差異表.pdf");
        }
    }
}