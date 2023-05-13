using System;
using System.IO;
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
    public partial class StdntAcdmcInfo : Form
    {
        public StdntAcdmcInfo()
        {
            InitializeComponent();
        }

        DataTable dt;

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void crtExmBtn_Click(object sender, EventArgs e)
        {
            CrteExmFrm frm = new CrteExmFrm();
            frm.Show();
        }

        private void csvBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "csv files (*.csv)|*.csv";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            //String filename = saveFileDialog1.FileName;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                    dt.ToCSV(saveFileDialog1.FileName);
            }
        }

        private void allBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@global.constr);
            var stra = "";
            //RollNo
            //Asc Name
            //Dsc Name
            //Incr Marks
            //Dcr Marks
            if (sortBox.GetItemText(sortBox.SelectedItem) == "Dcr Marks")
            {
                stra = " ORDER BY Sub1 DESC, Sub2 DESC, Sub3 DESC, Sub4 DESC, Sub5 DESC, Sub6 DESC, Sub7 DESC, Sub8 DESC, Sub9 DESC";
            } else if (sortBox.GetItemText(sortBox.SelectedItem) == "Incr Marks"){
                stra = " ORDER BY Sub1, Sub2, Sub3, Sub4, Sub5, Sub6, Sub7, Sub8, Sub9";
            }
            else if (sortBox.GetItemText(sortBox.SelectedItem) == "RollNo")
            {
                stra = " ORDER BY RollNo";
            }
            //else if (sortBox.Text == "Asc Name")
            //{
            //    stra = " ORDER BY ";
            //}
            //else if (sortBox.Text == "Incr Marks")
            //{
            //    stra = " ORDER BY Sub1, Sub2, Sub3, Sub4, Sub5, Sub6, Sub7, Sub8, Sub9";
            //}
            //global.constr 
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM StdntAcdmcInfoTB"+stra, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var roll = addRollTxt.Text;
            //var dept = addDeptTxt.Text;
            var dept = addDeptTxt.GetItemText(addDeptTxt.SelectedItem);
            var sem = addsemBox.GetItemText(addsemBox.SelectedItem);
            var exam = addExmTxt.Text;
            var sub1 = s1Num.Value;
            var sub2 = s2Num.Value;
            var sub3 = s3Num.Value;
            var sub4 = s4Num.Value;
            var sub5 = s5Num.Value;
            var sub6 = s6Num.Value;
            var sub7 = s7Num.Value;
            var sub8 = s8Num.Value;
            var sub9 = s9Num.Value;
            SqlConnection con = new SqlConnection(@global.constr);
            con.Open();
            //SqlCommand pre = new SqlCommand("SELECT SubNme FROM SubjectTB WHERE Sem='"+sem+"' AND Dept='"+dept+"'");
            //SqlDataAdapter ds = new SqlDataAdapter(pre);
            //dt = new DataTable();
            //ds.Fill(dt);
            //foreach (DataRow dr in dt.Rows)
            //{
     
            //}

            /*
            if (dtRpt.Rows.Count == 0)
                return;

            if (dtRpt.Rows.Count > 0)
            {
                int i = 0;
                for (i = 0; i <= dtRpt.Rows.Count - 1; i++)
                {
                    mTotValCash = mTotValCash + Convert.ToDecimal(dtRpt.Rows[i]["CASH"]);
                    mTotValCredit = mTotValCredit + Convert.ToDecimal(dtRpt.Rows[i]["CREDIT"]);
                    mTotValCard = mTotValCard + Convert.ToDecimal(dtRpt.Rows[i]["CARD"]);
                    mDisVal = mDisVal + Convert.ToDecimal(dtRpt.Rows[i]["DISCAMT"]);
                }
            }
              
             */
            //if (dt.Rows.Count == 6)
            //{
            //    s7Num.Enabled = false;
            //    s8Num.Enabled = false;
            //    s9Num.Enabled = false;
            //}
            //else if (dt.Rows.Count == 8)
            //{
            //    s9Num.Enabled = false;
            //}
            SqlCommand cmd = new SqlCommand("INSERT INTO StdntAcdmcInfoTB VALUES (@roll,@dpt,@sem,@exam,@sub1,@sub2,@sub3,@sub4,@sub5,@sub6,@sub7,@sub8,@sub9)", con);
            cmd.Parameters.AddWithValue("@roll", roll);
            cmd.Parameters.AddWithValue("@dpt", dept);
            cmd.Parameters.AddWithValue("@sem", sem);
            cmd.Parameters.AddWithValue("@exam", exam);
            cmd.Parameters.AddWithValue("@sub1", sub1);
            cmd.Parameters.AddWithValue("@sub2", sub2);
            cmd.Parameters.AddWithValue("@sub3", sub3);
            cmd.Parameters.AddWithValue("@sub4", sub4);
            cmd.Parameters.AddWithValue("@sub5", sub5);
            cmd.Parameters.AddWithValue("@sub6", sub6);
            cmd.Parameters.AddWithValue("@sub7", sub7);
            cmd.Parameters.AddWithValue("@sub8", sub8);
            cmd.Parameters.AddWithValue("@sub9", sub9);
            cmd.ExecuteNonQuery();
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM StdntAcdmcInfoTB WHERE RollNo=@roll", con);
            cmd1.Parameters.AddWithValue("@roll", roll);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView3.DataSource = dt;
            con.Close();
            addRollTxt.Clear();
            //addExmTxt.Clear();
            addDeptTxt.Text = "";
            s1Num.Value = 0;
            s2Num.Value = 0;
            s3Num.Value = 0;
            s4Num.Value = 0;
            s5Num.Value = 0;
            s6Num.Value = 0;
            s7Num.Value = 0;
            s8Num.Value = 0;
            s9Num.Value = 0;
        }

        private void addDeptTxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dept = addDeptTxt.GetItemText(addDeptTxt.SelectedItem);
            var sem = addsemBox.GetItemText(addsemBox.SelectedItem);
            SqlConnection con = new SqlConnection(@global.constr);
            con.Open();
            SqlCommand pre = new SqlCommand("SELECT SubNme FROM SubjectTB WHERE Sem='" + sem + "' AND Dept='" + dept + "' ORDER BY CCode",con);
            SqlDataAdapter ds = new SqlDataAdapter(pre);
            dt = new DataTable();
            ds.Fill(dt);
            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {

                if (i == 0)
                {
                    s1Num.Enabled = true;
                    string ele = dt.Rows[i][0].ToString();
                    if (ele.Length > 8)
                    {
                        var lst = ele.Split(' ');
                        ele = "";
                        if (lst.Length > 1)
                        {
                            foreach (var l in lst)
                            {
                                ele += l[0].ToString().ToUpper();
                            }
                        }
                        else
                        {
                            ele = lst[0].ToString().Substring(0, 5);
                        }
                    }
                    l1.Text = ele;
                }
                else if (i == 1)
                {
                    s2Num.Enabled = true;
                    string ele = dt.Rows[i][0].ToString();
                    if (ele.Length > 8)
                    {
                        var lst = ele.Split(' ');
                        ele = "";
                        if (lst.Length > 1)
                        {
                            foreach (var l in lst)
                            {
                                ele += l[0].ToString().ToUpper();
                            }
                        }
                        else
                        {
                            ele = lst[0].ToString().Substring(0, 5);
                        }
                    }
                    l2.Text = ele;
                }
                else if (i == 2)
                {
                    s3Num.Enabled = true;
                    string ele = dt.Rows[i][0].ToString();
                    if (ele.Length > 8)
                    {
                        var lst = ele.Split(' ');
                        ele = "";
                        if (lst.Length > 1)
                        {
                            foreach (var l in lst)
                            {
                                ele += l[0].ToString().ToUpper();
                            }
                        }
                        else
                        {
                            ele = lst[0].ToString().Substring(0, 5);
                        }
                    }
                    l3.Text = ele;
                }
                else if (i == 3)
                {
                    s4Num.Enabled = true;
                    string ele = dt.Rows[i][0].ToString();
                    if (ele.Length > 8)
                    {
                        var lst = ele.Split(' ');
                        ele = "";
                        if (lst.Length > 1)
                        {
                            foreach (var l in lst)
                            {
                                ele += l[0].ToString().ToUpper();
                            }
                        }
                        else
                        {
                            ele = lst[0].ToString().Substring(0, 5);
                        }
                    }
                    l4.Text = ele;
                }
                else if (i == 4)
                {
                    s5Num.Enabled = true;
                    string ele = dt.Rows[i][0].ToString();
                    if (ele.Length > 8)
                    {
                        var lst = ele.Split(' ');
                        ele = "";
                        if (lst.Length > 1)
                        {
                            foreach (var l in lst)
                            {
                                ele += l[0].ToString().ToUpper();
                            }
                        }
                        else
                        {
                            ele = lst[0].ToString().Substring(0, 5);
                        }
                    }
                    l5.Text = ele;
                }
                else if (i == 5)
                {
                    s6Num.Enabled = true;
                    string ele = dt.Rows[i][0].ToString();
                    if (ele.Length > 8)
                    {
                        var lst = ele.Split(' ');
                        ele = "";
                        if (lst.Length > 1)
                        {
                            foreach (var l in lst)
                            {
                                ele += l[0].ToString().ToUpper();
                            }
                        }
                        else
                        {
                            ele = lst[0].ToString().Substring(0, 5);
                        }
                    }
                    l6.Text = ele;
                }
                else if (i == 6)
                {
                    s7Num.Enabled = true;
                    string ele = dt.Rows[i][0].ToString();
                    if (ele.Length > 8)
                    {
                        var lst = ele.Split(' ');
                        ele = "";
                        if (lst.Length > 1)
                        {
                            foreach (var l in lst)
                            {
                                ele += l[0].ToString().ToUpper();
                            }
                        }
                        else
                        {
                            ele = lst[0].ToString().Substring(0, 5);
                        }
                    }
                    l7.Text = ele;
                }
                else if (i == 7)
                {
                    s8Num.Enabled = true;
                    string ele = dt.Rows[i][0].ToString();
                    if (ele.Length > 8)
                    {
                        var lst = ele.Split(' ');
                        ele = "";
                        if (lst.Length > 1)
                        {
                            foreach (var l in lst)
                            {
                                ele += l[0].ToString().ToUpper();
                            }
                        }
                        else
                        {
                            ele = lst[0].ToString().Substring(0, 5);
                        }
                    }
                    l8.Text = ele;
                }
                else if (i == 8)
                {
                    s9Num.Enabled = true;
                    string ele = dt.Rows[i][0].ToString();
                    if (ele.Length > 8)
                    {
                        var lst = ele.Split(' ');
                        ele = "";
                        if (lst.Length > 1)
                        {
                            foreach (var l in lst)
                            {
                                ele += l[0].ToString().ToUpper();
                            }
                        }
                        else
                        {
                            ele = lst[0].ToString().Substring(0, 5);
                        }
                    }
                    l9.Text = ele;
                }
            }
            con.Close();
        }

        private void addTab_Click(object sender, EventArgs e)
        {
            
        }

        private void StdntAcdmcInfo_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@global.constr);
            con.Open();
            SqlCommand pre = new SqlCommand("SELECT Dept FROM DeptTB",con);
            SqlDataReader dr = pre.ExecuteReader();
            AutoCompleteStringCollection acs = new AutoCompleteStringCollection();
            while (dr.Read())
            {
                string da = dr[0].ToString();
                addDeptTxt.Items.Add(da);
                DeptTxt.Items.Add(da);
                fdeptTxt.Items.Add(da);
                ddeptTxt.Items.Add(da);
                //acs.Add(da);
            }
            dr.Close();
            //DeptTxt.AutoCompleteCustomSource = acs;
            //fdeptTxt.AutoCompleteCustomSource = acs;
            //ddeptTxt.AutoCompleteCustomSource = acs;

            SqlCommand cmd = new SqlCommand("SELECT DISTINCT Exam FROM ExamTB", con);
            dr = cmd.ExecuteReader();
            acs = new AutoCompleteStringCollection();
            while (dr.Read())
            {
                addExmTxt.Items.Add(dr[0].ToString());
                dExmTxt.Items.Add(dr[0].ToString());
                fexamTxt.Items.Add(dr[0].ToString());
                examTxt.Items.Add(dr[0].ToString());
                //acs.Add(dr[0].ToString());
            }
            //addExmTxt.AutoCompleteCustomSource = acs;
            //dExmTxt.AutoCompleteCustomSource = acs;
            //fexamTxt.AutoCompleteCustomSource = acs;
            //examTxt.AutoCompleteCustomSource = acs;
            dr.Close();
            //SqlCommand cmd1 = new SqlCommand("SELECT DISTINCT SubNme FROM SubjectTB",con);
            //dr = cmd1.ExecuteReader();
            //acs = new AutoCompleteStringCollection();
            //////SqlCommand cmd1 = new SqlCommand("SELECT DISTINCT SubCode,SubNme,CCode from SubjectTB WHERE Dept='" + dpt + "' ORDER BY CCode", con);
            //////dr = cmd1.ExecuteReader();
            //////while (dr.Read())
            //////{
            //////    //MessageBox.Show(dr.ToString());
            //////    string da = dr[0].ToString() + ":" + dr[1].ToString();
            //////    subTxt.Items.Add(da);
            //////    fsubTxt.Items.Add(da);
            //////}
            //while (dr.Read())
            //{
            //    subTxt.Items.Add(dr[0].ToString());
            //    fsubTxt.Items.Add(dr[0].ToString());
            //    //acs.Add(dr[0].ToString());
            //}
            //subTxt.AutoCompleteCustomSource = acs;
            //fsubTxt.AutoCompleteCustomSource = acs;
            //////dr.Close();
            con.Close();
        }

        private void fltrBtn_Click(object sender, EventArgs e)
        {
            String str = "";
            String wstr = "";
            if (frollTxt.Text != "")
            {
                str += " RollNo='" + frollTxt.Text + "' AND";
            }
            //if (fsubTxt.Text != "")
            //{
            //    str += " PhoneNo=" + fsubTxt.Text + " AND";
            //}
            if (fdeptTxt.Text != "")
            {
                str += " Dept='" + fdeptTxt.Text + "' AND";
            }
            if (fnmeTxt.Text != "")
            {
                str += " SName='" + fnmeTxt.Text + "' AND";
            }
            if (msemBox.Text != "")
            {
                str += " Sem='" + msemBox.Text + "' AND";
            }
            if (fexamTxt.Text != "")
            {
                str += " Exam='" + fexamTxt.Text + "'";
            }

            if (str.Substring(str.Length - 3, 3) == "AND")
                wstr = str.Substring(0, str.Length - 3);
            SqlConnection con = new SqlConnection(@global.constr);
            con.Open();
            SqlCommand cmd1;
            if (subTxt.GetItemText(subTxt.SelectedItem) != "")
            {
                str += "Sub" + (subTxt.SelectedIndex + 1).ToString();
                cmd1 = new SqlCommand("SELECT RollNo, Dept, Sem, Exam, Sub" + (subTxt.SelectedIndex + 1).ToString() + " FROM StdntAcdmcInfoTB WHERE " + wstr, con);
            }
            else
            {
                cmd1 = new SqlCommand("SELECT * FROM StdntAcdmcInfoTB WHERE " + wstr, con);
            }
            //SqlCommand cmd1 = new SqlCommand("SELECT * FROM StdntAcdmcInfoTB WHERE " + wstr, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String str = "";
            String wstr = "";
            if (rollTxt.Text != "")
            {
                str += " RollNo='" + rollTxt.Text + "' AND";
            }
            //if (subTxt.GetItemText(subTxt.SelectedItem) != "")
            //{
            //    str += "Sub" + (subTxt.SelectedIndex+1).ToString();
            //    str += " =" + subTxt.Text + " and";
            //}
            if (DeptTxt.Text != "")
            {
                str += " Dept='" + DeptTxt.Text + "' AND";
            }
            //if (nmeTxt.Text != "")
            //{
            //    str += " SName='" + nmeTxt.Text + "' AND";
            //}
            if (semBox.Text != "")
            {
                str += " Sem='" + semBox.Text + "' AND";
            }
            if (examTxt.Text != "")
            {
                str += " Exam='" + examTxt.Text + "'";
            }

            if (str.Substring(str.Length - 3, 3) == "AND")
                wstr = str.Substring(0, str.Length - 3);
            
            //if (sortBox.Text != "")
            //{
            //    str += " SName='" + sortBox.Text + "'";
            //}
            MessageBox.Show(wstr);
            SqlConnection con = new SqlConnection(@global.constr);
            con.Open();
            SqlCommand cmd1;
            if (subTxt.GetItemText(subTxt.SelectedItem) != "")
            {
                str += "Sub" + (subTxt.SelectedIndex + 1).ToString();
                cmd1 = new SqlCommand("SELECT RollNo, Dept, Sem, Exam, Sub" + (subTxt.SelectedIndex + 1).ToString() + " FROM StdntAcdmcInfoTB WHERE " + wstr, con);
            }
            else
            {
                cmd1 = new SqlCommand("SELECT * FROM StdntAcdmcInfoTB WHERE " + wstr, con);
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String str = "";
            if (drollTxt.Text != "")
            {
                str += " RollNo='" + drollTxt.Text + "' AND";
            }
            if (dsemBox.Text != "")
            {
                str += " Sem=" + dsemBox.Text + " AND";
            }
            if (ddeptTxt.Text != "")
            {
                str += " Dept='" + ddeptTxt.Text + "' AND";
            }
            if (dExmTxt.Text != "")
            {
                str += " Exam='" + dExmTxt.Text + "'";
            }

            if (str.Substring(str.Length - 3, 3) == "AND")
                str = str.Substring(0, str.Length - 3);

            SqlConnection con = new SqlConnection(@global.constr);
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM StdntAcdmcInfoTB WHERE " + str, con);
            cmd.ExecuteNonQuery();
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM StdntAcdmcInfoTB WHERE Dept=@dept", con);
            cmd1.Parameters.AddWithValue("@dept", ddeptTxt.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView4.DataSource = dt;
            con.Close();
            MessageBox.Show("Deleted successfully!!!");
        }

        private void DeptTxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dpt = DeptTxt.GetItemText(DeptTxt.SelectedItem);
            SqlConnection con = new SqlConnection(@global.constr);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT SubCode,SubNme,CCode from SubjectTB WHERE Dept='"+dpt+"' ORDER BY CCode", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                //MessageBox.Show(dr.ToString());
                string da = dr[0].ToString() + ":" + dr[1].ToString();
                subTxt.Items.Add(da);
            }
            con.Close();
        }

        private void fdeptTxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dpt = fdeptTxt.GetItemText(fdeptTxt.SelectedItem);
            SqlConnection con = new SqlConnection(@global.constr);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT SubCode,SubNme,CCode from SubjectTB WHERE Dept='" + dpt + "' ORDER BY CCode", con);
            SqlDataReader dr = cmd.ExecuteReader();
            fsubTxt.Items.Clear();
            while (dr.Read())
            {
                //MessageBox.Show(dr.ToString());
                string da = dr[0].ToString() + ":" + dr[1].ToString();
                fsubTxt.Items.Add(da);
            }
            con.Close();
        }

        private void mdfyBtn_Click(object sender, EventArgs e)
        {
            var mBy = numScrollBy.Value;
            var mInto = numScrollInto.Value;
            String str = "";
            String wstr = "";
            if (frollTxt.Text != "")
            {
                str += " RollNo='" + frollTxt.Text + "' AND";
            }
            //if (fsubTxt.Text != "")
            //{
            //    str += " PhoneNo=" + fsubTxt.Text + " AND";
            //}
            if (fdeptTxt.Text != "")
            {
                str += " Dept='" + fdeptTxt.Text + "' AND";
            }
            //if (fnmeTxt.Text != "")
            //{
            //    str += " SName='" + fnmeTxt.Text + "' AND";
            //}
            if (msemBox.Text != "")
            {
                str += " Sem='" + msemBox.Text + "' AND";
            }
            if (fexamTxt.Text != "")
            {
                str += " Exam='" + fexamTxt.Text + "'";
            }

            if (str.Substring(str.Length - 3, 3) == "AND")
                wstr = str.Substring(0, str.Length - 3);
            SqlConnection con = new SqlConnection(@global.constr);
            con.Open();
            SqlCommand cmd1;
            if (fsubTxt.GetItemText(fsubTxt.SelectedItem) != "")
            {
                str = "Sub" + (fsubTxt.SelectedIndex + 1).ToString();
                try
                {
                    if (mBy != 0)
                    {
                        cmd1 = new SqlCommand("UPDATE StdntAcdmcInfoTB SET " + str + " = " + str + "+" + mBy.ToString() + " WHERE " + wstr, con);
                        cmd1.ExecuteNonQuery();
                    }
                    else if (mInto != 0)
                    {
                        cmd1 = new SqlCommand("UPDATE StdntAcdmcInfoTB SET " + str + "=" + mInto.ToString() + " WHERE " + wstr, con);
                        cmd1.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Please enter a search criteria to modify records...");
                    }
                }
                catch
                {
                    MessageBox.Show("Error in Modifying data please mouse select the subject.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a subject search criteria to modify records...");

            }
            cmd1 = new SqlCommand("SELECT * FROM StdntAcdmcInfoTB WHERE "+wstr,con);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }
    }
}

public static class CSVUtlity
{
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