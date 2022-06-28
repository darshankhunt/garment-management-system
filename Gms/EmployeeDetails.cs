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

namespace PlayerUI
{
    public partial class EmployeeDetails : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\My Drive\GMS.accdb;Persist Security Info = True;");
        public EmployeeDetails()
        {
            InitializeComponent();
            Fillgrid();
            string ch = Login.loginas;
            if (Login.loginas.Equals("Manager"))
            {
                delete_btn_emp.Visible = false;
            }
            else
            {

            }
        }

        private void inv_cl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_btn_emp_Click(object sender, EventArgs e)
        {
            string mo = monumber.Text;
            string gen = "";
            string etype = "";
            try
            {
                gen = gendertype.SelectedItem.ToString();
                etype = emp_Type.SelectedItem.ToString();
            }
            catch(Exception)
            {
                MessageBox.Show("You didn't select the Gender or Employee Type","Note",MessageBoxButtons.OK,MessageBoxIcon.Information);
                gen = "None";
                etype = "None";
            }
            string aadharcardno = aadharnum.Text;
            string addr = empAddress.Text;
            if (mo.Equals("0"))
            {
                mo = "None";
            }
            con.Open();
            OleDbCommand cmd = new OleDbCommand("insert into Employee_Details (FIRST_NAME, MIDDLE_NAME, LAST_NAME, MOBILE_NO, GENDER, EMPLOYEE_TYPE, AADHAR_CARD_NO, ADDRESS) values(@f,@m,@l,@mo,@g,@et,@acn,@add);", con);
            cmd.Parameters.AddWithValue("@f", fnameText.Text);
            cmd.Parameters.AddWithValue("@m", mnameText.Text);
            cmd.Parameters.AddWithValue("@l", lnameText.Text);
            cmd.Parameters.AddWithValue("@mo",mo);
            cmd.Parameters.AddWithValue("@g", gen);
            cmd.Parameters.AddWithValue("@et", etype);
            cmd.Parameters.AddWithValue("@acn", aadharnum.Text);
            cmd.Parameters.AddWithValue("@add", empAddress.Text);
            int row = cmd.ExecuteNonQuery();
            con.Close();    
            if(row>0)
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
        void Fillgrid()
        {
            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("Select *from Employee_Details Order by EMPLOYEE_ID",con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            emp_data_gridview.DataSource = dt;
            con.Close();
        }
        private void edit_btn_emp_Click(object sender, EventArgs e)
        {
            string mo = monumber.Text;
            string gen = "";
            string etype = "";
            try
            {
                gen = gendertype.SelectedItem.ToString();
                etype = emp_Type.SelectedItem.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("You didn't select the Gender or Employee Type","Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gen = "None";
                etype = "None";
            }
            string aadharcardno = aadharnum.Text;
            string addr = empAddress.Text;
            if (mo.Equals("0"))
            {
                mo = "None";
            }
            int id = Convert.ToInt32(emp_data_gridview.Rows[emp_data_gridview.CurrentRow.Index].Cells[0].Value);
            con.Open();
            OleDbCommand cmd = new OleDbCommand("Update Employee_Details SET FIRST_NAME = @f , MIDDLE_NAME = @m , LAST_NAME = @l , MOBILE_NO = @mo, GENDER = @g , EMPLOYEE_TYPE = @et , AADHAR_CARD_NO = @acn , ADDRESS = @add  WHERE EMPLOYEE_ID = @eid", con);
            cmd.Parameters.AddWithValue("@f", fnameText.Text);
            cmd.Parameters.AddWithValue("@m", mnameText.Text);
            cmd.Parameters.AddWithValue("@l", lnameText.Text);
            cmd.Parameters.AddWithValue("@mo", mo);
            cmd.Parameters.AddWithValue("@g", gen);
            cmd.Parameters.AddWithValue("@et", etype);
            cmd.Parameters.AddWithValue("@acn", aadharnum.Text);
            cmd.Parameters.AddWithValue("@add", empAddress.Text);
            cmd.Parameters.AddWithValue("@eid", id);
            int row = cmd.ExecuteNonQuery();
            con.Close();
            if (row > 0)
            {
                MessageBox.Show("Record Sucessfully Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed To Update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            cleartext();
            Fillgrid();
        }

        private void delete_btn_emp_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(emp_data_gridview.Rows[emp_data_gridview.CurrentRow.Index].Cells[0].Value);
            con.Open();
            OleDbCommand cmd = new OleDbCommand("Delete FROM Employee_Details WHERE EMPLOYEE_ID = @eid", con);
            cmd.Parameters.AddWithValue("@eid", id);
            int row = cmd.ExecuteNonQuery();
            con.Close();
            if (row > 0)
            {
                MessageBox.Show("Record Sucessfully Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed To Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
           
            Fillgrid();
        }
        void cleartext()
        {
            fnameText.Text = "";
            mnameText.Text = "";
            lnameText.Text = "";
            emp_Type.SelectedItem = null;
            gendertype.SelectedItem = null;
            monumber.Text = "";
            aadharnum.Text = "";
            empAddress.Text = "";
            
        }

        private void emp_view_Click(object sender, EventArgs e)
        {
            if (emp_data_gridview.SelectedRows.Count > 0)
            {
                //Fill the Text Fild
                fnameText.Text = (string)emp_data_gridview.Rows[emp_data_gridview.CurrentRow.Index].Cells[1].Value;
                mnameText.Text = (string)emp_data_gridview.Rows[emp_data_gridview.CurrentRow.Index].Cells[2].Value;
                lnameText.Text = (string)emp_data_gridview.Rows[emp_data_gridview.CurrentRow.Index].Cells[3].Value;
                monumber.Text = emp_data_gridview.Rows[emp_data_gridview.CurrentRow.Index].Cells[4].Value.ToString();
                gendertype.SelectedItem = (string)emp_data_gridview.Rows[emp_data_gridview.CurrentRow.Index].Cells[5].Value;
                emp_Type.SelectedItem = (string)emp_data_gridview.Rows[emp_data_gridview.CurrentRow.Index].Cells[6].Value;
                aadharnum.Text = (string)emp_data_gridview.Rows[emp_data_gridview.CurrentRow.Index].Cells[7].Value;
                empAddress.Text = (string)emp_data_gridview.Rows[emp_data_gridview.CurrentRow.Index].Cells[8].Value;
            }
            else
            {
                MessageBox.Show("Please Select a Whole Row","Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void search_text_emp_TextChanged(object sender, EventArgs e)
        {
            string sql = "SELECT *FROM Employee_Details where FIRST_NAME like '" + search_text_emp.Text + "%' or Employee_id like '" + search_text_emp.Text+"%'";
            con.Open();
            OleDbCommand cmd = new OleDbCommand(sql, con);
            OleDbDataAdapter odb = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            odb.Fill(dt);
            emp_data_gridview.DataSource = dt;
            con.Close();
        }
      
    }
}
