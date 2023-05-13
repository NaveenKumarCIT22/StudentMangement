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
    public partial class loginFrm : Form
    {
        public loginFrm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (usrBox.Text == "Admin" && pswdBox.Text == "admin")
            {
                MessageBox.Show("Login Successful!", "Gateway Msg");
                mainFrm frm = new mainFrm();
                this.Hide();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Please enter valid credentials provided by admin", "Gateway Msg");
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void loginFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
