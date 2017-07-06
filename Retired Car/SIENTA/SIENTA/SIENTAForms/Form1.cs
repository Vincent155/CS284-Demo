using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SIENTAForms
{
    public partial class SientaForm : Form
    {
        public SientaForm()
        {
            InitializeComponent();
        }

        private void LISTbutton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\wei\Desktop\Demo\Retired Car\SIENTA\特色外型.pdf");
        }

        private void salebutton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\wei\Desktop\Demo\Retired Car\SIENTA\售價規配.pdf");
        }
    }
}