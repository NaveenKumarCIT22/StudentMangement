using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudentManagement
{
    public partial class crteSubFrm : Form
    {
        public crteSubFrm()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                practicalNum.Enabled = true;
            }
            else 
            {
                practicalNum.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var snme = subTxt.Text;
            var scde = codeTxt.Text;
            var crdt = creditNum.Value;
            var sem = semBox.GetItemText(semBox.SelectedItem);
            var tw = theoryNum.Value;
            var pw = practicalNum.Value;
            var dpt = deptLst.CheckedItems;
            var ptxt = priotityTxt.Text;
            SqlConnection con = new SqlConnection(@global.constr);
            con.Open();
            foreach (object dt in dpt)
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO SubjectTB VALUES (@scde,@snme,@crdt,@sem,@tw,@pw,@dt,@pt)",con);
                cmd.Parameters.AddWithValue("@scde", scde);
                cmd.Parameters.AddWithValue("@snme", snme);
                cmd.Parameters.AddWithValue("@crdt", crdt);
                cmd.Parameters.AddWithValue("@sem", sem);
                cmd.Parameters.AddWithValue("@tw", tw);
                cmd.Parameters.AddWithValue("@pw", pw);
                cmd.Parameters.AddWithValue("@dt", dt);
                cmd.Parameters.AddWithValue("@pt", ptxt);
                cmd.ExecuteNonQuery();
            }
            con.Close();
            MessageBox.Show(snme+" Subject created...");
        }

        private void crteSubFrm_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@global.constr);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Dept from DeptTB",con);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                string da = dr[0].ToString();
                deptLst.Items.Add(da);
            }
            con.Close();
        }
    }
}
