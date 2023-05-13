using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudentManagement
{
    public partial class StdntPrsnlInfo : Form
    {
        public StdntPrsnlInfo()
        {
            InitializeComponent();
        }

        DataTable dt;

        private void button2_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-V8DITO49\NKSQL;Initial Catalog=CollegeDB;Integrated Security=True");
            //SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-V8DITO49\NKSQL;Initial Catalog=CollegeDB;user id = nk; password=nk");
            SqlConnection con = new SqlConnection(@global.constr);
            //global.constr 
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM StdntPrsnlInfoTB", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String str = "";
            if (rollTxt.Text != "")
            {
                str += " RollNo='" + rollTxt.Text + "' AND";
            }
            if (phnTxt.Text != "")
            {
                str += " PhoneNo=" + phnTxt.Text + " AND";
            }
            if (DeptTxt.Text != "")
            {
                str += " Dept='" + DeptTxt.Text + "' AND";
            }
            if (nmeTxt.Text != "")
            { 
                str += " SName='" + nmeTxt.Text + "'";
            }

            if (str.Substring(str.Length - 3, 3) == "AND")
                str = str.Substring(0, str.Length - 3);

            //MessageBox.Show(str);

            SqlConnection con = new SqlConnection(@global.constr);
            con.Open();
            //SqlCommand cmd = new SqlCommand("SELECT * FROM StdntPrsnlInfoTB WHERE (@str)", con);
            SqlCommand cmd = new SqlCommand("SELECT * FROM StdntPrsnlInfoTB WHERE "+str, con);
            //cmd.Parameters.AddWithValue("@str", str);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 0)
            { 
                 MessageBox.Show(dt.Rows.Count.ToString() + " records found!!!");
            }


            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@global.constr);
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO StdntPrsnlInfoTB VALUES (@roll,@nme,@dpt,@adhr,@phn,@mail)", con);
            cmd.Parameters.AddWithValue("@roll", addRollTxt.Text);
            cmd.Parameters.AddWithValue("@nme", addNmeTxt.Text);
            cmd.Parameters.AddWithValue("@dpt", addDeptTxt.Text);
            cmd.Parameters.AddWithValue("@adhr", Int64.Parse(addAdhrTxt.Text));
            cmd.Parameters.AddWithValue("@phn", Int64.Parse(addPhnTxt.Text));
            cmd.Parameters.AddWithValue("@mail", addMailTxt.Text);
            cmd.ExecuteNonQuery();
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM StdntPrsnlInfoTB WHERE RollNo=@roll", con);
            cmd1.Parameters.AddWithValue("@roll", addRollTxt.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView3.DataSource = dt;
            con.Close();
            addRollTxt.Clear();
            addNmeTxt.Clear();
            addMailTxt.Clear();
            addDeptTxt.Clear();
            addAdhrTxt.Clear();
            addPhnTxt.Clear();
        }

        private void tabGrp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            String str = "";
            String wstr = "";
            String ustr = "";
            if (frollTxt.Text != "")
            {
                str += " RollNo='" + frollTxt.Text + "' AND";
            }
            if (fphnTxt.Text != "")
            {
                str += " PhoneNo=" + fphnTxt.Text + " AND";
            }
            if (fdeptTxt.Text != "")
            {
                str += " Dept='" + fdeptTxt.Text + "' AND";
            }
            if (fnmeTxt.Text != "")
            {
                str += " SName='" + fnmeTxt.Text + "'";
            }

            if (str.Substring(str.Length - 3, 3) == "AND")
                wstr = str.Substring(0, str.Length - 3);

            str = "";
            if (mmailTxt.Text != "")
            {
                str += " Email='" + mmailTxt.Text + "' AND";
            }
            if (mphnTxt.Text != "")
            {
                str += " PhoneNo=" + mphnTxt.Text + " AND";
            }
            if (mdeptTxt.Text != "")
            {
                str += " Dept='" + mdeptTxt.Text + "' AND";
            }
            if (mnmeTxt.Text != "")
            {
                str += " SName='" + mnmeTxt.Text + "' AND";
            }

            if (str.Substring(str.Length - 3, 3) == "AND")
                ustr = str.Substring(0, str.Length - 3);


            SqlConnection con = new SqlConnection(@global.constr);
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE StdntPrsnlInfoTB SET "+ustr+" WHERE "+wstr, con);
            cmd.ExecuteNonQuery();
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM StdntPrsnlInfoTB WHERE RollNo=@roll", con);
            cmd1.Parameters.AddWithValue("@roll", frollTxt.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
            //frollTxt.Clear();
            //fnmeTxt.Clear();
            //fdeptTxt.Clear();
            //fphnTxt.Clear();
            //mnmeTxt.Clear();
            //mmailTxt.Clear();
            //mdeptTxt.Clear();
            //mphnTxt.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String str = "";
            if (drollTxt.Text != "")
            {
                str += " RollNo='" + drollTxt.Text + "' AND";
            }
            if (dphnTxt.Text != "")
            {
                str += " PhoneNo=" + dphnTxt.Text + " AND";
            }
            if (ddeptTxt.Text != "")
            {
                str += " Dept='" + ddeptTxt.Text + "' AND";
            }
            if (dnmeTxt.Text != "")
            {
                str += " SName='" + dnmeTxt.Text + "'";
            }

            if (str.Substring(str.Length - 3, 3) == "AND")
                str = str.Substring(0, str.Length - 3);

            SqlConnection con = new SqlConnection(@global.constr);
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM StdntPrsnlInfoTB WHERE " + str, con);
            cmd.ExecuteNonQuery();
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM StdntPrsnlInfoTB WHERE Dept=@dept", con);
            cmd1.Parameters.AddWithValue("@dept", ddeptTxt.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView4.DataSource = dt;
            con.Close();
            MessageBox.Show("Deleted successfully!!!");

        }

        private void fltrBtn_Click(object sender, EventArgs e)
        {
            String str = "";
            String wstr = "";
            if (frollTxt.Text != "")
            {
                str += " RollNo='" + frollTxt.Text + "' AND";
            }
            if (fphnTxt.Text != "")
            {
                str += " PhoneNo=" + fphnTxt.Text + " AND";
            }
            if (fdeptTxt.Text != "")
            {
                str += " Dept='" + fdeptTxt.Text + "' AND";
            }
            if (fnmeTxt.Text != "")
            {
                str += " SName='" + fnmeTxt.Text + "'";
            }

            if (str.Substring(str.Length - 3, 3) == "AND")
                wstr = str.Substring(0, str.Length - 3);
            SqlConnection con = new SqlConnection(@global.constr);
            con.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM StdntPrsnlInfoTB WHERE "+wstr, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            frollTxt.Clear();
            fnmeTxt.Clear();
            fdeptTxt.Clear();
            fphnTxt.Clear();
            mnmeTxt.Clear();
            mmailTxt.Clear();
            mdeptTxt.Clear();
            mphnTxt.Clear();
        }

        private void csvBtn_Click(object sender, EventArgs e)
        {
            //String str = "";
            //if (rollTxt.Text != "")
            //{
            //    str += " RollNo='" + rollTxt.Text + "' AND";
            //}
            //if (phnTxt.Text != "")
            //{
            //    str += " PhoneNo=" + phnTxt.Text + " AND";
            //}
            //if (DeptTxt.Text != "")
            //{
            //    str += " Dept='" + DeptTxt.Text + "' AND";
            //}
            //if (nmeTxt.Text != "")
            //{
            //    str += " SName='" + nmeTxt.Text + "'";
            //}

            //if (str.Substring(str.Length - 3, 3) == "AND")
            //    str = str.Substring(0, str.Length - 3);

            ////MessageBox.Show(str);

            //SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-V8DITO49\NKSQL;Initial Catalog=CollegeDB;Integrated Security=True");
            //con.Open();
            ////SqlCommand cmd = new SqlCommand("SELECT * FROM StdntPrsnlInfoTB WHERE (@str)", con);
            //SqlCommand cmd = new SqlCommand("SELECT * FROM StdntPrsnlInfoTB WHERE " + str, con);
            ////cmd.Parameters.AddWithValue("@str", str);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //dt = new DataTable();
            //da.Fill(dt);
            //string filename = SavefileDialog();
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "csv files (*.csv)|*.csv";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            //String filename = saveFileDialog1.FileName;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //if ((myStream = saveFileDialog1.OpenFile()) != null)
                //{
                    //string mFolderName = "D:\\abcd.csv";

                    // Code to write the stream goes here.
                    //dt.ToCSV(mFolderName);

                    dt.ToCSV(saveFileDialog1.FileName);

                    //myStream.Close();
                //}
            }
            //dt.ToCSV(filename);
        }

        private void StdntPrsnlInfo_Load(object sender, EventArgs e)
        {

        }
    }
    public static class CSVUtlity {
        public static void ToCSV(this DataTable dtDataTable, string strFilePath)
        {
            StreamWriter sw = new StreamWriter(strFilePath, false);
            //headers    
            for (int i = 0; i < dtDataTable.Columns.Count; i++)
            {
                sw.Write(dtDataTable.Columns[i]);
                if (i < dtDataTable.Columns.Count - 1)
                {
                    sw.Write(",");
                }
            }
            sw.Write(sw.NewLine);
            foreach (DataRow dr in dtDataTable.Rows)
            {
                for (int i = 0; i < dtDataTable.Columns.Count; i++)
                {
                    if (!Convert.IsDBNull(dr[i]))
                    {
                        string value = dr[i].ToString();
                        if (value.Contains(','))
                        {
                            value = String.Format("\"{0}\"", value);
                            sw.Write(value);
                        }
                        else
                        {
                            sw.Write(dr[i].ToString());
                        }
                    }
                    if (i < dtDataTable.Columns.Count - 1)
                    {
                        sw.Write(",");
                    }
                }
                sw.Write(sw.NewLine);
            }
            sw.Close();
        }
    }
}
