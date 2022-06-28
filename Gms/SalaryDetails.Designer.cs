namespace PlayerUI
{
    partial class SalaryDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalaryDetails));
            this.salary_details_gridview = new System.Windows.Forms.DataGridView();
            this.save_btn_saldet = new System.Windows.Forms.Button();
            this.delete_btn_saldet = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.search_text_saldet = new System.Windows.Forms.TextBox();
            this.payoutDate = new System.Windows.Forms.DateTimePicker();
            this.loan_salary = new System.Windows.Forms.TextBox();
            this.empidSal = new System.Windows.Forms.TextBox();
            this.salary_sal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.payout_date = new System.Windows.Forms.Label();
            this.emp_id_sal = new System.Windows.Forms.Label();
            this.inv_cl = new System.Windows.Forms.Button();
            this.salary = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.advance_salary = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ch_deduction = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.salary_details_gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // salary_details_gridview
            // 
            this.salary_details_gridview.AllowUserToDeleteRows = false;
            this.salary_details_gridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.salary_details_gridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.salary_details_gridview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.salary_details_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salary_details_gridview.Location = new System.Drawing.Point(12, 229);
            this.salary_details_gridview.Name = "salary_details_gridview";
            this.salary_details_gridview.ReadOnly = true;
            this.salary_details_gridview.Size = new System.Drawing.Size(660, 265);
            this.salary_details_gridview.TabIndex = 18;
            // 
            // save_btn_saldet
            // 
            this.save_btn_saldet.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.save_btn_saldet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.save_btn_saldet.FlatAppearance.BorderSize = 0;
            this.save_btn_saldet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_btn_saldet.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn_saldet.ForeColor = System.Drawing.Color.White;
            this.save_btn_saldet.Location = new System.Drawing.Point(270, 504);
            this.save_btn_saldet.Name = "save_btn_saldet";
            this.save_btn_saldet.Size = new System.Drawing.Size(79, 33);
            this.save_btn_saldet.TabIndex = 8;
            this.save_btn_saldet.Text = "SAVE";
            this.save_btn_saldet.UseVisualStyleBackColor = false;
            this.save_btn_saldet.Click += new System.EventHandler(this.save_btn_saldet_Click);
            // 
            // delete_btn_saldet
            // 
            this.delete_btn_saldet.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.delete_btn_saldet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.delete_btn_saldet.FlatAppearance.BorderSize = 0;
            this.delete_btn_saldet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_btn_saldet.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn_saldet.ForeColor = System.Drawing.Color.White;
            this.delete_btn_saldet.Location = new System.Drawing.Point(383, 504);
            this.delete_btn_saldet.Name = "delete_btn_saldet";
            this.delete_btn_saldet.Size = new System.Drawing.Size(79, 33);
            this.delete_btn_saldet.TabIndex = 9;
            this.delete_btn_saldet.Text = "DELETE";
            this.delete_btn_saldet.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(402, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 63;
            this.label3.Text = "SEARCH";
            // 
            // search_text_saldet
            // 
            this.search_text_saldet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_text_saldet.Location = new System.Drawing.Point(500, 203);
            this.search_text_saldet.Name = "search_text_saldet";
            this.search_text_saldet.Size = new System.Drawing.Size(172, 20);
            this.search_text_saldet.TabIndex = 7;
            // 
            // payoutDate
            // 
            this.payoutDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.payoutDate.Location = new System.Drawing.Point(132, 143);
            this.payoutDate.Name = "payoutDate";
            this.payoutDate.Size = new System.Drawing.Size(172, 20);
            this.payoutDate.TabIndex = 3;
            // 
            // loan_salary
            // 
            this.loan_salary.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.loan_salary.Location = new System.Drawing.Point(468, 57);
            this.loan_salary.Name = "loan_salary";
            this.loan_salary.Size = new System.Drawing.Size(172, 20);
            this.loan_salary.TabIndex = 4;
            // 
            // empidSal
            // 
            this.empidSal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.empidSal.Location = new System.Drawing.Point(132, 59);
            this.empidSal.Name = "empidSal";
            this.empidSal.Size = new System.Drawing.Size(172, 20);
            this.empidSal.TabIndex = 1;
            // 
            // salary_sal
            // 
            this.salary_sal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.salary_sal.AutoSize = true;
            this.salary_sal.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.salary_sal.Location = new System.Drawing.Point(33, 102);
            this.salary_sal.Name = "salary_sal";
            this.salary_sal.Size = new System.Drawing.Size(50, 15);
            this.salary_sal.TabIndex = 70;
            this.salary_sal.Text = "SALARY";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(337, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 69;
            this.label6.Text = "LOAN";
            // 
            // payout_date
            // 
            this.payout_date.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.payout_date.AutoSize = true;
            this.payout_date.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.payout_date.Location = new System.Drawing.Point(33, 146);
            this.payout_date.Name = "payout_date";
            this.payout_date.Size = new System.Drawing.Size(83, 15);
            this.payout_date.TabIndex = 66;
            this.payout_date.Text = "PAYOUT DATE";
            // 
            // emp_id_sal
            // 
            this.emp_id_sal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.emp_id_sal.AutoSize = true;
            this.emp_id_sal.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.emp_id_sal.Location = new System.Drawing.Point(33, 59);
            this.emp_id_sal.Name = "emp_id_sal";
            this.emp_id_sal.Size = new System.Drawing.Size(83, 15);
            this.emp_id_sal.TabIndex = 64;
            this.emp_id_sal.Text = "EMPLOYEE_ID";
            // 
            // inv_cl
            // 
            this.inv_cl.FlatAppearance.BorderSize = 0;
            this.inv_cl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.inv_cl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inv_cl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inv_cl.ForeColor = System.Drawing.Color.Black;
            this.inv_cl.Location = new System.Drawing.Point(0, 0);
            this.inv_cl.Name = "inv_cl";
            this.inv_cl.Size = new System.Drawing.Size(25, 25);
            this.inv_cl.TabIndex = 0;
            this.inv_cl.Text = "X";
            this.inv_cl.UseVisualStyleBackColor = true;
            this.inv_cl.Click += new System.EventHandler(this.inv_cl_Click);
            // 
            // salary
            // 
            this.salary.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.salary.Location = new System.Drawing.Point(132, 100);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(172, 20);
            this.salary.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(336, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 81;
            this.label1.Text = "ADVANCE ";
            // 
            // advance_salary
            // 
            this.advance_salary.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.advance_salary.Location = new System.Drawing.Point(468, 100);
            this.advance_salary.Name = "advance_salary";
            this.advance_salary.Size = new System.Drawing.Size(172, 20);
            this.advance_salary.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(337, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 15);
            this.label2.TabIndex = 83;
            this.label2.Text = "CHOOSE DEDUCTION";
            // 
            // ch_deduction
            // 
            this.ch_deduction.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ch_deduction.Location = new System.Drawing.Point(468, 141);
            this.ch_deduction.Name = "ch_deduction";
            this.ch_deduction.Size = new System.Drawing.Size(172, 20);
            this.ch_deduction.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(257, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 23);
            this.label8.TabIndex = 112;
            this.label8.Text = "SALARY DETAILS";
            // 
            // SalaryDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(209)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(684, 548);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ch_deduction);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.advance_salary);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inv_cl);
            this.Controls.Add(this.payoutDate);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.loan_salary);
            this.Controls.Add(this.empidSal);
            this.Controls.Add(this.salary_sal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.payout_date);
            this.Controls.Add(this.emp_id_sal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.search_text_saldet);
            this.Controls.Add(this.save_btn_saldet);
            this.Controls.Add(this.delete_btn_saldet);
            this.Controls.Add(this.salary_details_gridview);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SalaryDetails";
            this.Text = "Account";
            ((System.ComponentModel.ISupportInitialize)(this.salary_details_gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private AppData appData;
       // private AppDataTableAdapters.Salary_DetailsTableAdapter salary_DetailsTableAdapter;
        private System.Windows.Forms.DataGridView salary_details_gridview;
        private System.Windows.Forms.Button save_btn_saldet;
        private System.Windows.Forms.Button delete_btn_saldet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox search_text_saldet;
        private System.Windows.Forms.DateTimePicker payoutDate;
        private System.Windows.Forms.TextBox loan_salary;
        private System.Windows.Forms.TextBox empidSal;
        private System.Windows.Forms.Label salary_sal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label payout_date;
        private System.Windows.Forms.Label emp_id_sal;
        private System.Windows.Forms.Button inv_cl;
        private System.Windows.Forms.TextBox salary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox advance_salary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ch_deduction;
        private System.Windows.Forms.Label label8;
    }
}