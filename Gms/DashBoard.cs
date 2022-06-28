using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerUI
{
    public partial class DashBoard : Form
    {
        
        public DashBoard()
        {
            InitializeComponent();
          
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void inv_cl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Work_Employee());
        }
        private void btn_inv_pettycash_Click(object sender, EventArgs e)
        {
            openChildForm(new PettyCash());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new ListofReport());
        }

        private void btn_inv_employees_Click(object sender, EventArgs e)
        {
            openChildForm(new EmployeeDetails());
        }

        
    }
}