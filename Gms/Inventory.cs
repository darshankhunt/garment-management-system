using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.OleDb;

namespace PlayerUI
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
            Fillgrid();


        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\My Drive\GMS.accdb;Persist Security Info = True;");
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void Fillgrid()
        {
            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("Select *from Inventory Order by INVENTORY_ID", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            inv_data_gridview.DataSource = dt;
            con.Close();
        }

        void cleartext()
        {
            proName.Text = "";
            partyName.Text = "";
            particularName.Text = "";
            colourName.Text = "";
            remarksText.Text = "";
            qtyText.Text = "";
            sizeText.Text = "";

        }

        private void save_btn_emp_Click(object sender, EventArgs e)
        {

            string productname = proName.Text;
            string partyname= partyName.Text;
            string particular = particularName.Text;
            string colour = colourName.Text;  
            string size = sizeText.Text;
            string quantity = qtyText.Text;
            string date_info = invDate.Value.ToShortDateString();
            string remarks = remarksText.Text;

            if (productname.Equals("") || partyname.Equals("") || particular.Equals("") || colour.Equals("") || size.Equals("") || quantity.Equals("") || date_info.Equals("") || remarks.Equals("")) {
                MessageBox.Show("You miss out some fields. You can edit later.","Message");

            }
            else
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("insert into Inventory (PRODUCT_NAME, PARTY_NAME, PARTICULAR, COLOUR, [SIZE], QUANTITY, DATE_INFO, REMARKS) values( @pron, @parn, @parti, @colour, @size, @qt, @dt, @rem);", con);
                cmd.Parameters.AddWithValue("@pron", productname);
                cmd.Parameters.AddWithValue("@parn", partyname);
                cmd.Parameters.AddWithValue("@parti", particular);
                cmd.Parameters.AddWithValue("@colour", colour);
                cmd.Parameters.AddWithValue("@size", size);
                cmd.Parameters.AddWithValue("@qt", quantity);
                cmd.Parameters.AddWithValue("@dt", date_info);
                cmd.Parameters.AddWithValue("@rem", remarks);
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
        }
    }
}