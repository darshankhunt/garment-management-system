using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerUI
{
    public partial class Work_Employee : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\My Drive\GMS.accdb;Persist Security Info = True;");
        public Work_Employee()
        {
            InitializeComponent();
            Fillgrid();
            string ch = Login.loginas;
            if (Login.loginas.Equals("Manager"))
            {
                delete_btn_Work.Visible = false;
            }
            else
            {

            }
        }
        private void Work_cl_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void cleartext()
        {
            empIdWork.Text = "";
            PartyNameWork.Text = "";
            ProductWork.Text = "";
            ColorWork.Text = "";
            RNCodeWork.Text = "";
            RateWork.Text = "";
            QtyWork.Text = "";
            size_Work.Text = "";
        }
        void Fillgrid()
        {
            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("Select *from WORK_OF_EMPLOYEE Order by WORK_ID", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Work_emp_gridview.DataSource = dt;
            con.Close();
        }

        

        private void save_btn_work_Click(object sender, EventArgs e)
        {
            int Eid=0;
            int rate = 0;
            int qty = 0;
            try
            {
                Eid = Convert.ToInt32(empIdWork.Text);
                rate = Convert.ToInt32(RateWork.Text);
                qty = Convert.ToInt32(QtyWork.Text);
            }
            catch(FormatException)
            {
                MessageBox.Show("Please Enter Employee Id or Rate or QTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            
            string prana = PartyNameWork.Text;
            string pro = ProductWork.Text;
            string col = ColorWork.Text;
            string rncode = RNCodeWork.Text;
  
            string d = DateWork.Value.ToShortDateString();
            if (d.Equals(""))
            {
                MessageBox.Show("First Time You Must Select Value of Date","Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (prana.Equals("") || pro.Equals("") || col.Equals("") || rncode.Equals("")|| size_Work.Text.Equals(""))
            {
                MessageBox.Show("You Missed Out Some Fields.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bool i = checkid(Eid);
                if(i==true)
                {
                    string n = getName(Eid);
                    con.Open();
                    OleDbCommand cmd = new OleDbCommand("insert into WORK_OF_EMPLOYEE (EMPLOYEE_ID, EMPLOYEE_NAME , PARTY_NAME, PRODUCT, COLOR, [SIZE] , DATE_OF_WORK, RN_CODE ,RATE , QUANTITY) values(@eid,@en,@pn,@p,@c,@si,@dof,@rnc,@r,@qty);", con);
                    cmd.Parameters.AddWithValue("@eid", Eid);
                    cmd.Parameters.AddWithValue("@en", n);
                    cmd.Parameters.AddWithValue("@pn", prana);
                    cmd.Parameters.AddWithValue("@p", pro);
                    cmd.Parameters.AddWithValue("@c", col);
                    cmd.Parameters.AddWithValue("@si", size_Work.Text);
                    cmd.Parameters.AddWithValue("@dof", d);
                    cmd.Parameters.AddWithValue("@rnc", rncode);
                    cmd.Parameters.AddWithValue("@r", rate);
                    cmd.Parameters.AddWithValue("@qty", qty);
                    int row =cmd.ExecuteNonQuery();
                    con.Close();
                    if (row > 0)
                    {
                        MessageBox.Show("Record Sucessfully Saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed To Insert", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    cleartext();
                    Fillgrid();
                }
                else
                {
                    MessageBox.Show("Employee Id doesn't Exist, Please Enter Vaild Employee Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }
        private void delete_btn_Work_Click(object sender, EventArgs e)
        {
            if (Work_emp_gridview.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(Work_emp_gridview.Rows[Work_emp_gridview.CurrentRow.Index].Cells[0].Value);
                con.Open();
                OleDbCommand cmd = new OleDbCommand("Delete FROM WORK_OF_EMPLOYEE WHERE WORK_ID = @Wid", con);
                cmd.Parameters.AddWithValue("@Wid", id);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Sucessfully Deleted","Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Fillgrid();
            }
            else
            {
                MessageBox.Show("Please Select a Whole Row","Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void search_text_saldet_TextChanged(object sender, EventArgs e)
        {
            string sql = "SELECT *FROM Work_Of_Employee where Employee_name like '" + search_text_work.Text + "%' or Employee_id = '"+search_text_work.Text + "'";
            con.Open();
            OleDbCommand cmd = new OleDbCommand(sql, con);
            OleDbDataAdapter odb = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            odb.Fill(dt);
            Work_emp_gridview.DataSource = dt;
            con.Close();
        }

        private bool checkid(int chid)
        {
            string cid = "SELECT EMPLOYEE_ID FROM Employee_Details";
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            OleDbCommand cmd = new OleDbCommand(cid, con);
            adapter.SelectCommand = cmd;
            DataTable ds = new DataTable();
            adapter.Fill(ds);
            bool ids = false;
            foreach (DataRow row in ds.Rows)
            {
                if(row[0].Equals(chid))
                {
                    ids = true;
                }
            }
            return ids;
        }
        private string getName(int Emp_id)
        {
            string getn = "SELECT FIRST_NAME" + ' ' + ",MIDDLE_NAME" + ' ' + ",LAST_NAME FROM EMPLOYEE_DETAILS where Employee_ID = " + Emp_id;
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            OleDbCommand getname = new OleDbCommand(getn, con);
            adapter.SelectCommand = getname;
            DataTable ds = new DataTable();
            adapter.Fill(ds);
            string name = "";
            foreach (DataRow row in ds.Rows)
            {
                name = row[0] + " " + row[1] + " " + row[2];
            }
            return name;
        }
    }
}