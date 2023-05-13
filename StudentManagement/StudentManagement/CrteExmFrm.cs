using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace StudentManagement
{
    public partial class CrteExmFrm : Form
    {
        private string enme;
        public string[] subj = {}, date = {};
        //public decimal[] maxm;
        List<decimal> maxm = new List<decimal>();

        public CrteExmFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            crteSubFrm frm = new crteSubFrm();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String enme = exNameTxt.Text;
            String snme = subBox.GetItemText(subBox.SelectedItem);
            Decimal mxmarks = maxMarkNum.Value;
            DateTime dt = dateTimeBox.Value;
            String txt = "";
            string[] sbj = new string[] { snme };
            string[] dte = new string[] { dt.ToLongDateString() };
            decimal[] mx = new decimal[] { mxmarks };
            //MessageBox.Show(snme);
            subj = subj.Concat(sbj).ToArray();
            date = date.Concat(dte).ToArray();
            //maxm = maxm.Concat(mx).ToArray();
            maxm.Add(mxmarks);
            txt += dt.ToLongDateString() + ":" + snme + ":" + mxmarks.ToString();
            lstBox.Items.Add(txt);

        }

        private void CrteExmFrm_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@global.constr);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT SubCode,SubNme from SubjectTB", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                //MessageBox.Show(dr.ToString());
                string da = dr[0].ToString()+":"+dr[1].ToString();
                subBox.Items.Add(da); 
            }
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var exm = exNameTxt.Text;
            SqlConnection con = new SqlConnection(@global.constr);
            con.Open();
            for (int i = 0; i < subj.Length; i++)
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO ExamTB VALUES (@ex,@sub,@dt,@mx)", con);                
                cmd.Parameters.AddWithValue("@ex", exm);
                cmd.Parameters.AddWithValue("@sub", subj[i]);
                cmd.Parameters.AddWithValue("@dt", date[i]);
                cmd.Parameters.AddWithValue("@mx", maxm[i]);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Exam created successfully!!!");
        }
    }
}
