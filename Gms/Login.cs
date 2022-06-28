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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\My Drive\GMS.accdb;Persist Security Info = True;");
        public static string loginas = "";
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string u = UserNameField.Text;
            string p = textpasswod.Text;
            if(u.Equals("")||p.Equals("")){
                MessageBox.Show("Please Fill Down Details","Error",MessageBoxButtons.OK,MessageBoxIcon.Hand);
            }
            else
            {
                if (u.Equals("Manager"))
                {
                    string lo = "Select Username , Password from Users Where User_id = 3";
                    OleDbDataAdapter adapter = new OleDbDataAdapter();
                    OleDbCommand login = new OleDbCommand(lo, con);
                    adapter.SelectCommand = login;
                    DataTable ds = new DataTable();
                    adapter.Fill(ds);
                    foreach (DataRow row in ds.Rows)
                    {
                        if (Convert.ToString(row[1]).Equals(p))
                        {
                            this.Hide();
                            var Login = new Login();
                            Login.Closed += (s, args) => this.Close();
                            loginas = "Manager";
                            DashBoard db = new DashBoard();
                            db.Show();
                        }
                        else
                        {
                            MessageBox.Show("Invaild Password For Manager", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                    }
                }
                else if (u.Equals("Admin"))
                {
                    string lo = "Select Username , Password from Users Where User_id = 2";
                    OleDbDataAdapter adapter = new OleDbDataAdapter();
                    OleDbCommand login = new OleDbCommand(lo, con);
                    adapter.SelectCommand = login;
                    DataTable ds = new DataTable();
                    adapter.Fill(ds);
                    foreach (DataRow row in ds.Rows)
                    {
                        if (Convert.ToString(row[1]).Equals(p))
                        {
                            this.Hide();
                            var Login = new Login();
                            Login.Closed += (s, args) => this.Close();
                            loginas = "Admin";
                            DashBoard db = new DashBoard();
                            db.Show();
                        }
                        else
                        {
                            MessageBox.Show("Invaild Password For Admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invaild Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                
                //List<string> username = new List<string>();
                //List<string> password = new List<string>();
                //foreach (DataRow row in ds.Rows)
                //{
                //    username.Add( Convert.ToString(row[0]));
                //    password.Add(Convert.ToString(row[1]));
                //}
                //if (username.Contains(u) && password.Contains(p))
                //{
                //    this.Hide();
                //    var Login = new Login();
                //    Login.Closed += (s, args) => this.Close();
                //    DashBoard db = new DashBoard();
                //    db.Show();
                //}
                //else
                //{
                //    MessageBox.Show("Invaild Username or Password","Error",MessageBoxButtons.OK, MessageBoxIcon.Hand);
                //}
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnforgetpass_Click(object sender, EventArgs e)
        {
            ForgetPassword fp = new ForgetPassword();
            fp.ShowDialog();
        }

        private void btnupdatePass_Click(object sender, EventArgs e)
        {
            UpdatePassword up = new UpdatePassword();
            up.ShowDialog();
        }
    }
}