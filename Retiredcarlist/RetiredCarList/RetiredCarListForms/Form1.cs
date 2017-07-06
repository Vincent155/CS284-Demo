using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RAV4Forms;
using SIENTAForms;

namespace RetiredCarListForms
{
    public partial class RetiredCarListForm : Form
    {
        public RetiredCarListForm()
        {
            InitializeComponent();
        }

        private void sientapictureBox_Click(object sender, EventArgs e)
        {
            SientaForm sienta = new SientaForm();
            this.Visible = false;
            sienta.Visible = true;
        }

        private void RAV4pictureBox_Click(object sender, EventArgs e)
        {
            RAV4Form rav4 = new RAV4Form();
            this.Visible = false;
            rav4.Visible = true;
        }
    }
}