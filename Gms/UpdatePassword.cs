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
    public partial class UpdatePassword : Form
    {
        public UpdatePassword()
        {
            InitializeComponent();
            idPass.Focus();
        }

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\My Drive\GMS.accdb;Persist Security Info = True;");
        private void btnupdatepass_Click(object sender, EventArgs e)
        {
            string id = idPass.Text;
            string o = oldPass.Text;
            string np = conPass.Text;
            string cp = newPass.Text;
            if (np.Equals("") || cp.Equals("") || o.Equals("") || id.Equals(""))
            {
                MessageBox.Show("Please Fill Down Details","Note",MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                string lo = "Select User_id , Password from Users where User_id = "+id;
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                OleDbCommand login = new OleDbCommand(lo, con);
                adapter.SelectCommand = login;
                DataTable ds = new DataTable();
                adapter.Fill(ds);
                List<string> password = new List<string>();
                List<string> ids = new List<string>();
                foreach (DataRow row in ds.Rows)
                {
                    ids.Add(Convert.ToString(row[0]));
                    password.Add(Convert.ToString(row[1]));
                }
                if (password.Contains(o) && ids.Contains(id))
                {
                    if (np.Equals(cp))
                    {
                        con.Open();
                        string upd = "Update Users SET [Password] = @newp where User_id = @uid";
                        OleDbCommand update = new OleDbCommand(upd, con);
                        update.Parameters.AddWithValue("@newp", np);
                        update.Parameters.AddWithValue("@uid", id);
                        int row = update.ExecuteNonQuery();
                        con.Close();
                        if (row > 0)
                        {
                            MessageBox.Show("Your Password Has Been Sucssfully Reset", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Failed To Update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Password Does Not Match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Invaild Admin Id or Old Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }
    }
}
