using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AltisForms;
using VIOSForms;

namespace CarListForms
{
    public partial class carListForm : Form
    {
        public carListForm()
        {
            InitializeComponent();
        }

        private void ViospictureBox_Click(object sender, EventArgs e)
        {
            VIOSForm VIOS = new VIOSForm();
            this.Visible = false;
            VIOS.Visible = true;
        }

        private void AltispictureBox_Click(object sender, EventArgs e)
        {
            AltisForm ALTIS = new AltisForm();
            this.Visible = false;
            ALTIS.Visible = true;
        }
    }
}