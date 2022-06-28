using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;
namespace PlayerUI
{
    public partial class SalaryDetails : Form
    {
        public SalaryDetails()
        {
            InitializeComponent();
            Fillgrid();

        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\My Drive\GMS.accdb;Persist Security Info = True;");
        private void inv_cl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_btn_saldet_Click(object sender, EventArgs e)
        {
            int Eid = 0;
            try
            {
                Eid = Convert.ToInt32(empidSal.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please Enter Employee Id", "Error");
            }
            string date = payoutDate.Value.ToShortDateString();
            int salay = 0;
            try
            {
                salay = Convert.ToInt32(salary.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please Enter Salary","Error");
                salary.Focus();
            }
            int loans = 0;
            int advce = 0;
            int ucdedu = 0;
            try
            {
                loans = Convert.ToInt32(loan_salary.Text);
            }
            catch (FormatException)
            {
                loans = 0;
            }
            try
            {
                loans = Convert.ToInt32(advance_salary.Text);
            }
            catch (FormatException)
            {
                advce = 0;
            }
            try
            {
                loans = Convert.ToInt32(ch_deduction.Text);
            }
            catch (FormatException)
            {
                ucdedu = 0;
            }
            bool i = checkid(Eid);
             if (i == true)
             {
                 string n = getName(Eid);
                 con.Open();
                 OleDbCommand cmd = new OleDbCommand("insert into Salary_Details (EMPLOYEE_ID,EMPLOYEE_NAME,SALARY,DATE_OF_PAYOUT,LOAN,ADVANCE,USER_CHOICE_DEDUCTION) values(@eid,@empname,@sal,@dop,@loan,@advance,@ucd);", con);
                 cmd.Parameters.AddWithValue("@eid",Eid);
                 cmd.Parameters.AddWithValue("@empname", n);
                 cmd.Parameters.AddWithValue("@sal", salay);
                 cmd.Parameters.AddWithValue("@dop", date);
                 cmd.Parameters.AddWithValue("@loan", loans);
                 cmd.Parameters.AddWithValue("@advance",advce );
                 cmd.Parameters.AddWithValue("@ucd", ucdedu);
                 int row = cmd.ExecuteNonQuery();
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
        void Fillgrid()
        {
            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("Select *from Salary_Details Order by SALARY_ID", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            salary_details_gridview.DataSource = dt;
            con.Close();
        }
        void cleartext()
        {
            empidSal.Text = "";
            salary.Text = "";
            loan_salary.Text = "";
            advance_salary.Text = "";
            ch_deduction.Text = "";
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
                if (row[0].Equals(chid))
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
                name = row[0]+" "+row[1]+" " +row[2];
            }
            return name;
        }
       
    }
}
