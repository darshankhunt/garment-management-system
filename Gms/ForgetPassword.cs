using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace PlayerUI
{
    public partial class ForgetPassword : Form
    {
        public ForgetPassword()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\My Drive\GMS.accdb;Persist Security Info = True;");
        private void btnconfirm_Click(object sender, EventArgs e)
        {
          
                string adminid = adId.Text;
                string adminkey = adkey.Text;
                string np = newPass.Text;
                string cp = conPass.Text;
                if (adminid.Equals("") || adminkey.Equals("") || np.Equals("") || cp.Equals(""))
                {
                    MessageBox.Show("Please Enter ALl Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    string getkey = "Select User_id , Admin_Key from Users where User_id = " + adminid;
                    OleDbDataAdapter adapter = new OleDbDataAdapter();
                    OleDbCommand checkkey = new OleDbCommand(getkey, con);
                    adapter.SelectCommand = checkkey;
                    DataTable ds = new DataTable();
                    adapter.Fill(ds);
                    List<string> keys = new List<string>();
                    List<string> ids = new List<string>();
                    foreach (DataRow row in ds.Rows)
                    {
                        ids.Add(Convert.ToString(row[0]));
                        keys.Add(Convert.ToString(row[1]));
                    }
                    if (keys.Contains(adminkey) && ids.Contains(adminid))
                    {
                        if (np.Equals(cp))
                        {
                            con.Open();
                            string upd = "Update Users SET [Password] = @newp where User_id = @uid";
                            OleDbCommand update = new OleDbCommand(upd, con);
                            update.Parameters.AddWithValue("@newp", np);
                            update.Parameters.AddWithValue("@uid", adminid);
                            int row = update.ExecuteNonQuery();
                            con.Close();
                            if (row > 0)
                            {
                                MessageBox.Show("Your Password Has Been Sucssfully Reset", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Some Error Occured , Please Try Again Sometimes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            }

                        }
                        else
                        {
                            MessageBox.Show("Password Does Not Match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wrong Admin Id or Key", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
            
            
            
        }
    }
}
