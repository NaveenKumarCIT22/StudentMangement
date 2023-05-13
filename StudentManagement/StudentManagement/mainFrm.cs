using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class mainFrm : Form
    {
        public mainFrm()
        {
            InitializeComponent();
        }

        private void mainFrm_FormClosing(Object sender, FormClosingEventArgs e)
        {
            //In case windows is trying to shut down, don't hold the process up
            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            if (this.DialogResult == DialogResult.Cancel)
            {
                // Assume that X has been clicked and act accordingly.
                // Confirm user wants to close
                switch (MessageBox.Show(this, "Are you sure?", "Do you still want ... ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    //Stay on this form
                    case DialogResult.No:
                        e.Cancel = true;
                        break;
                    default:
                        break;
                }
            }
        }

        private void mainFrm_Load(object sender, EventArgs e)
        {
            //pictureBox1.Image = imageList1.Images[0];
        }

        private void infoBtn_Click(object sender, EventArgs e)
        {
            StdntPrsnlInfo frm = new StdntPrsnlInfo();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StdntAcdmcInfo frm = new StdntAcdmcInfo();
            frm.Show();
        }

        private void mainFrm_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            // picbox.Image = imagelst.Images[0];
        }
    }
}
