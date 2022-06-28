namespace PlayerUI
{
    partial class Inventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
            this.inv_cl = new System.Windows.Forms.Button();
            this.inv_data_gridview = new System.Windows.Forms.DataGridView();
            this.emp_view = new System.Windows.Forms.Button();
            this.save_btn_emp = new System.Windows.Forms.Button();
            this.delete_btn_emp = new System.Windows.Forms.Button();
            this.edit_btn_emp = new System.Windows.Forms.Button();
            this.remarksText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.search_text_inv = new System.Windows.Forms.TextBox();
            this.partyName = new System.Windows.Forms.TextBox();
            this.particularName = new System.Windows.Forms.TextBox();
            this.colourName = new System.Windows.Forms.TextBox();
            this.proName = new System.Windows.Forms.TextBox();
            this.empType = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.name_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.invDate = new System.Windows.Forms.DateTimePicker();
            this.qtyText = new System.Windows.Forms.TextBox();
            this.sizeText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inv_data_gridview)).BeginInit();
            this.SuspendLayout();
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
            this.inv_cl.Click += new System.EventHandler(this.button5_Click);
            // 
            // inv_data_gridview
            // 
            this.inv_data_gridview.AllowUserToDeleteRows = false;
            this.inv_data_gridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inv_data_gridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.inv_data_gridview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.inv_data_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inv_data_gridview.Location = new System.Drawing.Point(12, 295);
            this.inv_data_gridview.Name = "inv_data_gridview";
            this.inv_data_gridview.ReadOnly = true;
            this.inv_data_gridview.Size = new System.Drawing.Size(660, 199);
            this.inv_data_gridview.TabIndex = 17;
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
            // 
            // remarksText
            // 
            this.remarksText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.remarksText.Location = new System.Drawing.Point(499, 185);
            this.remarksText.Multiline = true;
            this.remarksText.Name = "remarksText";
            this.remarksText.Size = new System.Drawing.Size(172, 44);
            this.remarksText.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(390, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 76;
            this.label1.Text = "SEARCH";
            // 
            // search_text_inv
            // 
            this.search_text_inv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_text_inv.Location = new System.Drawing.Point(499, 267);
            this.search_text_inv.Name = "search_text_inv";
            this.search_text_inv.Size = new System.Drawing.Size(172, 20);
            this.search_text_inv.TabIndex = 9;
            // 
            // partyName
            // 
            this.partyName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.partyName.Location = new System.Drawing.Point(142, 100);
            this.partyName.Name = "partyName";
            this.partyName.Size = new System.Drawing.Size(172, 20);
            this.partyName.TabIndex = 2;
            // 
            // particularName
            // 
            this.particularName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.particularName.Location = new System.Drawing.Point(142, 141);
            this.particularName.Name = "particularName";
            this.particularName.Size = new System.Drawing.Size(172, 20);
            this.particularName.TabIndex = 3;
            // 
            // colourName
            // 
            this.colourName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.colourName.Location = new System.Drawing.Point(142, 185);
            this.colourName.Name = "colourName";
            this.colourName.Size = new System.Drawing.Size(172, 20);
            this.colourName.TabIndex = 4;
            // 
            // proName
            // 
            this.proName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.proName.Location = new System.Drawing.Point(142, 57);
            this.proName.Name = "proName";
            this.proName.Size = new System.Drawing.Size(172, 20);
            this.proName.TabIndex = 1;
            // 
            // empType
            // 
            this.empType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.empType.AutoSize = true;
            this.empType.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empType.Location = new System.Drawing.Point(390, 100);
            this.empType.Name = "empType";
            this.empType.Size = new System.Drawing.Size(86, 20);
            this.empType.TabIndex = 68;
            this.empType.Text = "QUANTITY:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 20);
            this.label7.TabIndex = 67;
            this.label7.Text = "PARTY NAME:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 66;
            this.label6.Text = "PARTICULAR:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 65;
            this.label5.Text = "COLOUR:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(390, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 64;
            this.label4.Text = "SIZE:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(390, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 63;
            this.label3.Text = "REMARKS:";
            // 
            // name_lbl
            // 
            this.name_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.name_lbl.AutoSize = true;
            this.name_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_lbl.Location = new System.Drawing.Point(8, 57);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(129, 20);
            this.name_lbl.TabIndex = 62;
            this.name_lbl.Text = "PRODUCT NAME:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(390, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 78;
            this.label2.Text = "DATE:";
            // 
            // invDate
            // 
            this.invDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.invDate.Location = new System.Drawing.Point(500, 141);
            this.invDate.Name = "invDate";
            this.invDate.Size = new System.Drawing.Size(172, 20);
            this.invDate.TabIndex = 7;
            // 
            // qtyText
            // 
            this.qtyText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.qtyText.Location = new System.Drawing.Point(500, 100);
            this.qtyText.Name = "qtyText";
            this.qtyText.Size = new System.Drawing.Size(172, 20);
            this.qtyText.TabIndex = 6;
            // 
            // sizeText
            // 
            this.sizeText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sizeText.Location = new System.Drawing.Point(499, 59);
            this.sizeText.Name = "sizeText";
            this.sizeText.Size = new System.Drawing.Size(172, 20);
            this.sizeText.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(257, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 23);
            this.label8.TabIndex = 112;
            this.label8.Text = "INVENTORY";
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(209)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(684, 548);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.qtyText);
            this.Controls.Add(this.sizeText);
            this.Controls.Add(this.invDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.remarksText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search_text_inv);
            this.Controls.Add(this.partyName);
            this.Controls.Add(this.particularName);
            this.Controls.Add(this.colourName);
            this.Controls.Add(this.proName);
            this.Controls.Add(this.empType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.name_lbl);
            this.Controls.Add(this.emp_view);
            this.Controls.Add(this.save_btn_emp);
            this.Controls.Add(this.delete_btn_emp);
            this.Controls.Add(this.edit_btn_emp);
            this.Controls.Add(this.inv_data_gridview);
            this.Controls.Add(this.inv_cl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inventory";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.inv_data_gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button inv_cl;
        private System.Windows.Forms.DataGridView inv_data_gridview;
        private System.Windows.Forms.Button emp_view;
        private System.Windows.Forms.Button save_btn_emp;
        private System.Windows.Forms.Button delete_btn_emp;
        private System.Windows.Forms.Button edit_btn_emp;
        private System.Windows.Forms.TextBox remarksText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox search_text_inv;
        private System.Windows.Forms.TextBox partyName;
        private System.Windows.Forms.TextBox particularName;
        private System.Windows.Forms.TextBox colourName;
        private System.Windows.Forms.TextBox proName;
        private System.Windows.Forms.Label empType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker invDate;
        private System.Windows.Forms.TextBox qtyText;
        private System.Windows.Forms.TextBox sizeText;
        private System.Windows.Forms.Label label8;
    }
}