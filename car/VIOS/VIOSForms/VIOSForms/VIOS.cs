using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VIOSForms
{
    public partial class VIOSForm : Form
    {
        public VIOSForm()
        {
            InitializeComponent();
        }

        private void listbutton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\wei\Desktop\Demo\car\VIOS\特色外型.pdf");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\wei\Desktop\Demo\car\VIOS\差異表.pdf");
        }
    }
}