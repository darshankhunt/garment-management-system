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
    public partial class PettyCash : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\My Drive\GMS.accdb;Persist Security Info = True;");
        List<String> headsname = new List<String> { "SNACKS & REFRESHMENT", "RAW MATERIALS", "MEDICINE", "LOAN", "STATIONARY", "WAGES", "TRANSPORTATION", "OTHERS" };
        public PettyCash()
        {
            InitializeComponent();
            Fillgrid();
            finalCal();
            string ch = Login.loginas;
            if (Login.loginas.Equals("Manager"))
            {
                delete_btn_petty.Visible = false;
            }
            else
            {
                
            }
        }
        
        private void inv_cl_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void refreshList(List<String> list)
        {
            HeadName.Items.Clear();
            HeadName.DataSource = list;

        }
        private void save_btn_emp_Click(object sender, EventArgs e)
        {
            
            string pa = ParticularName.Text;
            string hn = "";
            try
            {
                hn = HeadName.SelectedItem.ToString();
            }
            catch (NullReferenceException)
            {
                hn = HeadName.Text;
                headsname.Add(hn);    
                refreshList(headsname);
            }
            string par = PartyName.Text;
            int cre = 0;
            int debit = 0;
            try
            {
                cre = Convert.ToInt32(CreditPetty.Text);
            }
            catch(FormatException)
            {
                cre = 0;
            }
            try
            {
                debit = Convert.ToInt32(DebitPetty.Text);
            }
            catch (FormatException)
            {
                debit = 0;
            }
            string rem = RemarksText.Text;
            string date = PettyDate.Value.ToShortDateString();
            if(pa.Equals("")||par.Equals("")||rem.Equals("")||date.Equals("")){
                MessageBox.Show("You Miss out Some Fields.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Open();
            OleDbCommand cmd = new OleDbCommand("insert into Petty_Cash (PARTICULAR, HEAD, PARTY, DATE_INFO, CREDIT, DEBIT, REMARKS) values(@p,@h,@pa,@dt,@c,@d,@rem);", con);
            cmd.Parameters.AddWithValue("@p", pa);
            cmd.Parameters.AddWithValue("@h", hn);
            cmd.Parameters.AddWithValue("@pa", par);
            cmd.Parameters.AddWithValue("@dt", date);
            cmd.Parameters.AddWithValue("@c", cre);
            cmd.Parameters.AddWithValue("@d", debit);
            cmd.Parameters.AddWithValue("@rem", rem);
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
            finalCal();
        }
        void finalCal()
        {
            int sumofcredit = 0;
            for (int i = 0; i < petty_cash_datagridview.Rows.Count; ++i)
            {
                sumofcredit += Convert.ToInt32(petty_cash_datagridview.Rows[i].Cells[5].Value);
            }
            int sumofdebit = 0;
            for (int i = 0; i < petty_cash_datagridview.Rows.Count; ++i)
            {
                sumofdebit += Convert.ToInt32(petty_cash_datagridview.Rows[i].Cells[6].Value);
            }
            int Abalance = sumofcredit - sumofdebit;
            string Aba = Convert.ToString(Abalance);
            AvaBalance.Text = Aba;
        }
        void Fillgrid()
        {
            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("Select *from Petty_Cash Order by SR", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            petty_cash_datagridview.DataSource = dt;
            con.Close();
        }
        void cleartext()
        {
            ParticularName.Text = "";
            HeadName.SelectedItem = "";
            HeadName.Text = "";
            PartyName.Text = "";
            CreditPetty.Text = "";
            DebitPetty.Text = "";
            RemarksText.Text = "";
        }

        private void delete_btn_emp_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(petty_cash_datagridview.Rows[petty_cash_datagridview.CurrentRow.Index].Cells[0].Value);
            con.Open();
            OleDbCommand cmd = new OleDbCommand("Delete FROM PETTY_CASH WHERE SR = @eid", con);
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
            finalCal();
        }

        private void PettyCash_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < headsname.Count; i++)
            {
                HeadName.Items.Add(headsname[i]);
            }
        }
    }
}
