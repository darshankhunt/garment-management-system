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
    public partial class ListofReport : Form
    {
        public ListofReport()
        {
            InitializeComponent();
            labelAmt.Visible = false;
            salaryDisplay.Visible = false;
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\My Drive\GMS.accdb;Persist Security Info = True;");
        private void inv_cl_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void show_btn_rep_Click(object sender, EventArgs e)
        {
            string fdate = fromdate.Value.ToShortDateString();
            string tdate = todate.Value.ToShortDateString();
            string emp = EmpName.Text;
            getSalary(fdate, tdate, emp);
        }
        private void getSalary(string fromDate, string toDate, string emp)
        {
            
            if (allData.Checked)
            {
                if(withAmt.Checked)
                {
                    labelAmt.Visible = true;
                    salaryDisplay.Visible = true;
                    labelAmt.Text = "GRAND TOTAL";
                    string getsa = "select Employee_id,Employee_name , [QUANTITY], Date_of_Work, Amount from Work_of_Employee where date_of_work between '" + fromDate + "' and '" + toDate + "'";
                    OleDbDataAdapter adapter = new OleDbDataAdapter();
                    OleDbCommand getSaly = new OleDbCommand(getsa, con);
                    adapter.SelectCommand = getSaly;
                    DataTable ds = new DataTable();
                    adapter.Fill(ds);
                    List<int> li = new List<int>();
                    List<int> sumqty = new List<int>();
                    foreach (DataRow row in ds.Rows)
                    {
                        li.Add(Convert.ToInt32(row[4]));
                        sumqty.Add(Convert.ToInt32(row[2]));
                    }
                    string sum = "";
                    string sumofqty = "";
                    sumofqty = sumqty.Sum().ToString();
                    sum = li.Sum().ToString();
                    qty_rep.Text = sumofqty;
                    salaryDisplay.Text = sum;
                    listofreports_gridview.DataSource = ds;
                }
                else
                {
                    labelAmt.Text = "GRAND TOTAL";
                    string getsa = "select Employee_id,Employee_name , [QUANTITY], Date_of_Work from Work_of_Employee where date_of_work between '" + fromDate + "' and '" + toDate + "'";
                    OleDbDataAdapter adapter = new OleDbDataAdapter();
                    OleDbCommand getSaly = new OleDbCommand(getsa, con);
                    adapter.SelectCommand = getSaly;
                    DataTable ds = new DataTable();
                    adapter.Fill(ds);
                    List<int> sumqty = new List<int>();
                    foreach (DataRow row in ds.Rows)
                    {
                        sumqty.Add(Convert.ToInt32(row[2]));
                    }
                    string sumofqty = "";
                    sumofqty = sumqty.Sum().ToString();
                    qty_rep.Text = sumofqty;
                    salaryDisplay.Text = "";
                    listofreports_gridview.DataSource = ds;
                }
                
            }
            else
            {
                if (withAmt.Checked)
                {
                    labelAmt.Visible = true;
                    salaryDisplay.Visible = true;
                    labelAmt.Text = "TOTAL PAYOUT";
                    string getsa = "select Employee_id, Employee_name , QUANTITY,  Date_of_Work, Amount from Work_of_Employee where date_of_work between '" + fromDate + "' and '" + toDate + "' and Employee_Id = '" + emp + "' or Employee_name like '"+emp+"%'";
                    OleDbDataAdapter adapter = new OleDbDataAdapter();
                    OleDbCommand getSaly = new OleDbCommand(getsa, con);
                    adapter.SelectCommand = getSaly;
                    DataTable ds = new DataTable();
                    adapter.Fill(ds);
                    List<int> li = new List<int>();
                    List<int> sumqty = new List<int>();
                    foreach (DataRow row in ds.Rows)
                    {
                        li.Add(Convert.ToInt32(row[4]));
                        sumqty.Add(Convert.ToInt32(row[2]));
                    }
                    string sum = "";
                    sum = li.Sum().ToString();
                    salaryDisplay.Text = sum;
                    string sumofqty = "";
                    sumofqty = sumqty.Sum().ToString();
                    qty_rep.Text = sumofqty;
                    listofreports_gridview.DataSource = ds;
                }
                else
                {
                    labelAmt.Text = "TOTAL PAYOUT";
                    string getsa = "select Employee_id, Employee_name , QUANTITY,  Date_of_Work from Work_of_Employee where date_of_work between '" + fromDate + "' and '" + toDate + "' and Employee_Id = '" + emp + "' or Employee_name like '" + emp + "%'";
                    OleDbDataAdapter adapter = new OleDbDataAdapter();
                    OleDbCommand getSaly = new OleDbCommand(getsa, con);
                    adapter.SelectCommand = getSaly;
                    DataTable ds = new DataTable();
                    adapter.Fill(ds);
                    salaryDisplay.Text = "";
                    List<int> sumqty = new List<int>();
                    foreach (DataRow row in ds.Rows)
                    {
                        sumqty.Add(Convert.ToInt32(row[2]));
                    }
                    string sumofqty = "";
                    sumofqty = sumqty.Sum().ToString();
                    qty_rep.Text = sumofqty;
                    listofreports_gridview.DataSource = ds;
                }
            }   
        }

        private void ListofReport_Load(object sender, EventArgs e)
        {

        }
    }
}