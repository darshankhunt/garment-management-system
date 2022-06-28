namespace PlayerUI
{
    partial class EmployeeDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeDetails));
            this.emp_data_gridview = new System.Windows.Forms.DataGridView();
            this.inv_cl = new System.Windows.Forms.Button();
            this.edit_btn_emp = new System.Windows.Forms.Button();
            this.delete_btn_emp = new System.Windows.Forms.Button();
            this.save_btn_emp = new System.Windows.Forms.Button();
            this.empType = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.name_lbl = new System.Windows.Forms.Label();
            this.mnameText = new System.Windows.Forms.TextBox();
            this.lnameText = new System.Windows.Forms.TextBox();
            this.monumber = new System.Windows.Forms.TextBox();
            this.fnameText = new System.Windows.Forms.TextBox();
            this.gendertype = new System.Windows.Forms.ComboBox();
            this.search_text_emp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.emp_view = new System.Windows.Forms.Button();
            this.emp_Type = new System.Windows.Forms.ComboBox();
            this.aadharnum = new System.Windows.Forms.TextBox();
            this.empAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.emp_data_gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // emp_data_gridview
            // 
            this.emp_data_gridview.AllowUserToDeleteRows = false;
            this.emp_data_gridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emp_data_gridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.emp_data_gridview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.emp_data_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.emp_data_gridview.Location = new System.Drawing.Point(12, 292);
            this.emp_data_gridview.Name = "emp_data_gridview";
            this.emp_data_gridview.ReadOnly = true;
            this.emp_data_gridview.Size = new System.Drawing.Size(660, 202);
            this.emp_data_gridview.TabIndex = 16;
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
            // edit_btn_emp
            // 
            this.edit_btn_emp.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.edit_btn_emp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.edit_btn_emp.FlatAppearance.BorderSize = 0;
            this.edit_btn_emp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_btn_emp.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_btn_emp.ForeColor = System.Drawing.Color.White;
            this.edit_btn_emp.Location = new System.Drawing.Point(304, 504);
            this.edit_btn_emp.Name = "edit_btn_emp";
            this.edit_btn_emp.Size = new System.Drawing.Size(79, 33);
            this.edit_btn_emp.TabIndex = 12;
            this.edit_btn_emp.Text = "EDIT";
            this.edit_btn_emp.UseVisualStyleBackColor = false;
            this.edit_btn_emp.Click += new System.EventHandler(this.edit_btn_emp_Click);
            // 
            // delete_btn_emp
            // 
            this.delete_btn_emp.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.delete_btn_emp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.delete_btn_emp.FlatAppearance.BorderSize = 0;
            this.delete_btn_emp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_btn_emp.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn_emp.ForeColor = System.Drawing.Color.White;
            this.delete_btn_emp.Location = new System.Drawing.Point(406, 504);
            this.delete_btn_emp.Name = "delete_btn_emp";
            this.delete_btn_emp.Size = new System.Drawing.Size(79, 33);
            this.delete_btn_emp.TabIndex = 13;
            this.delete_btn_emp.Text = "DELETE";
            this.delete_btn_emp.UseVisualStyleBackColor = false;
            this.delete_btn_emp.Click += new System.EventHandler(this.delete_btn_emp_Click);
            // 
            // save_btn_emp
            // 
            this.save_btn_emp.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.save_btn_emp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.save_btn_emp.FlatAppearance.BorderSize = 0;
            this.save_btn_emp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_btn_emp.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn_emp.ForeColor = System.Drawing.Color.White;
            this.save_btn_emp.Location = new System.Drawing.Point(201, 504);
            this.save_btn_emp.Name = "save_btn_emp";
            this.save_btn_emp.Size = new System.Drawing.Size(79, 33);
            this.save_btn_emp.TabIndex = 11;
            this.save_btn_emp.Text = "SAVE";
            this.save_btn_emp.UseVisualStyleBackColor = false;
            this.save_btn_emp.Click += new System.EventHandler(this.save_btn_emp_Click);
            // 
            // empType
            // 
            this.empType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.empType.AutoSize = true;
            this.empType.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empType.Location = new System.Drawing.Point(343, 96);
            this.empType.Name = "empType";
            this.empType.Size = new System.Drawing.Size(121, 20);
            this.empType.TabIndex = 44;
            this.empType.Text = "EMPLOYEE TYPE";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 20);
            this.label7.TabIndex = 43;
            this.label7.Text = "MIDDLE NAME:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 42;
            this.label6.Text = "LAST NAME:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 41;
            this.label5.Text = "MOBILE NO.";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(343, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "GENDER";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(343, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "Aadhar Card No.";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(343, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "ADDRESS";
            // 
            // name_lbl
            // 
            this.name_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.name_lbl.AutoSize = true;
            this.name_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_lbl.Location = new System.Drawing.Point(24, 55);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(98, 20);
            this.name_lbl.TabIndex = 37;
            this.name_lbl.Text = "FIRST NAME:";
            // 
            // mnameText
            // 
            this.mnameText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mnameText.Location = new System.Drawing.Point(143, 98);
            this.mnameText.Name = "mnameText";
            this.mnameText.Size = new System.Drawing.Size(172, 20);
            this.mnameText.TabIndex = 2;
            // 
            // lnameText
            // 
            this.lnameText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lnameText.Location = new System.Drawing.Point(143, 140);
            this.lnameText.Name = "lnameText";
            this.lnameText.Size = new System.Drawing.Size(172, 20);
            this.lnameText.TabIndex = 3;
            // 
            // monumber
            // 
            this.monumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.monumber.Location = new System.Drawing.Point(143, 184);
            this.monumber.Name = "monumber";
            this.monumber.Size = new System.Drawing.Size(172, 20);
            this.monumber.TabIndex = 4;
            // 
            // fnameText
            // 
            this.fnameText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fnameText.Location = new System.Drawing.Point(143, 55);
            this.fnameText.Name = "fnameText";
            this.fnameText.Size = new System.Drawing.Size(172, 20);
            this.fnameText.TabIndex = 1;
            // 
            // gendertype
            // 
            this.gendertype.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gendertype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gendertype.FormattingEnabled = true;
            this.gendertype.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.gendertype.Location = new System.Drawing.Point(500, 54);
            this.gendertype.Name = "gendertype";
            this.gendertype.Size = new System.Drawing.Size(172, 21);
            this.gendertype.TabIndex = 5;
            // 
            // search_text_emp
            // 
            this.search_text_emp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_text_emp.Location = new System.Drawing.Point(500, 261);
            this.search_text_emp.Name = "search_text_emp";
            this.search_text_emp.Size = new System.Drawing.Size(172, 20);
            this.search_text_emp.TabIndex = 9;
            this.search_text_emp.TextChanged += new System.EventHandler(this.search_text_emp_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(402, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 56;
            this.label1.Text = "SEARCH:";
            // 
            // emp_view
            // 
            this.emp_view.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.emp_view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.emp_view.FlatAppearance.BorderSize = 0;
            this.emp_view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emp_view.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_view.ForeColor = System.Drawing.Color.White;
            this.emp_view.Location = new System.Drawing.Point(101, 504);
            this.emp_view.Name = "emp_view";
            this.emp_view.Size = new System.Drawing.Size(79, 33);
            this.emp_view.TabIndex = 10;
            this.emp_view.Text = "SELECT";
            this.emp_view.UseVisualStyleBackColor = false;
            this.emp_view.Click += new System.EventHandler(this.emp_view_Click);
            // 
            // emp_Type
            // 
            this.emp_Type.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.emp_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.emp_Type.FormattingEnabled = true;
            this.emp_Type.Items.AddRange(new object[] {
            "REGULAR",
            "VISITER"});
            this.emp_Type.Location = new System.Drawing.Point(500, 95);
            this.emp_Type.Name = "emp_Type";
            this.emp_Type.Size = new System.Drawing.Size(172, 21);
            this.emp_Type.TabIndex = 6;
            // 
            // aadharnum
            // 
            this.aadharnum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.aadharnum.Location = new System.Drawing.Point(500, 138);
            this.aadharnum.Name = "aadharnum";
            this.aadharnum.Size = new System.Drawing.Size(172, 20);
            this.aadharnum.TabIndex = 7;
            // 
            // empAddress
            // 
            this.empAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.empAddress.Location = new System.Drawing.Point(500, 184);
            this.empAddress.Multiline = true;
            this.empAddress.Name = "empAddress";
            this.empAddress.Size = new System.Drawing.Size(172, 43);
            this.empAddress.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(257, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 23);
            this.label8.TabIndex = 113;
            this.label8.Text = "EMPLOYEE DETAILS";
            // 
            // EmployeeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(209)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(684, 548);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.empAddress);
            this.Controls.Add(this.aadharnum);
            this.Controls.Add(this.emp_view);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search_text_emp);
            this.Controls.Add(this.emp_Type);
            this.Controls.Add(this.gendertype);
            this.Controls.Add(this.mnameText);
            this.Controls.Add(this.lnameText);
            this.Controls.Add(this.monumber);
            this.Controls.Add(this.fnameText);
            this.Controls.Add(this.empType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name_lbl);
            this.Controls.Add(this.save_btn_emp);
            this.Controls.Add(this.delete_btn_emp);
            this.Controls.Add(this.edit_btn_emp);
            this.Controls.Add(this.inv_cl);
            this.Controls.Add(this.emp_data_gridview);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeeDetails";
            this.Text = "EmployeeDetails";
            ((System.ComponentModel.ISupportInitialize)(this.emp_data_gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView emp_data_gridview;
        private System.Windows.Forms.Button inv_cl;
        //private AppData appData;
        //private AppDataTableAdapters.Employee_DetailsTableAdapter employee_DetailsTableAdapter;
        private System.Windows.Forms.Button edit_btn_emp;
        private System.Windows.Forms.Button save_btn_emp;
        private System.Windows.Forms.Label empType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.ComboBox gendertype;
        private System.Windows.Forms.TextBox search_text_emp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mnameText;
        private System.Windows.Forms.TextBox lnameText;
        private System.Windows.Forms.TextBox monumber;
        private System.Windows.Forms.TextBox fnameText;
        private System.Windows.Forms.Button emp_view;
        private System.Windows.Forms.ComboBox emp_Type;
        private System.Windows.Forms.TextBox aadharnum;
        private System.Windows.Forms.TextBox empAddress;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Button delete_btn_emp;
        //private AppDataTableAdapters.Salary_DetailsTableAdapter salary_DetailsTableAdapter;

    }
}