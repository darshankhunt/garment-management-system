namespace PlayerUI
{
    partial class ListofReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListofReport));
            this.label8 = new System.Windows.Forms.Label();
            this.inv_cl = new System.Windows.Forms.Button();
            this.payout_date = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fromdate = new System.Windows.Forms.DateTimePicker();
            this.todate = new System.Windows.Forms.DateTimePicker();
            this.EmpName = new System.Windows.Forms.TextBox();
            this.listofreports_gridview = new System.Windows.Forms.DataGridView();
            this.show_btn_rep = new System.Windows.Forms.Button();
            this.labelAmt = new System.Windows.Forms.Label();
            this.salaryDisplay = new System.Windows.Forms.TextBox();
            this.allData = new System.Windows.Forms.CheckBox();
            this.qty_rep = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.withAmt = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.listofreports_gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(284, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 23);
            this.label8.TabIndex = 113;
            this.label8.Text = "REPORTS";
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
            // payout_date
            // 
            this.payout_date.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.payout_date.AutoSize = true;
            this.payout_date.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.payout_date.Location = new System.Drawing.Point(12, 59);
            this.payout_date.Name = "payout_date";
            this.payout_date.Size = new System.Drawing.Size(72, 15);
            this.payout_date.TabIndex = 115;
            this.payout_date.Text = "FROM DATE";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(234, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 116;
            this.label1.Text = "TO DATE";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(459, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 117;
            this.label2.Text = "SEARCH";
            // 
            // fromdate
            // 
            this.fromdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fromdate.Location = new System.Drawing.Point(92, 57);
            this.fromdate.Name = "fromdate";
            this.fromdate.Size = new System.Drawing.Size(137, 20);
            this.fromdate.TabIndex = 1;
            // 
            // todate
            // 
            this.todate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.todate.Location = new System.Drawing.Point(295, 57);
            this.todate.Name = "todate";
            this.todate.Size = new System.Drawing.Size(137, 20);
            this.todate.TabIndex = 2;
            // 
            // EmpName
            // 
            this.EmpName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EmpName.Location = new System.Drawing.Point(546, 57);
            this.EmpName.Name = "EmpName";
            this.EmpName.Size = new System.Drawing.Size(136, 20);
            this.EmpName.TabIndex = 3;
            // 
            // listofreports_gridview
            // 
            this.listofreports_gridview.AllowUserToDeleteRows = false;
            this.listofreports_gridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listofreports_gridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listofreports_gridview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.listofreports_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listofreports_gridview.Location = new System.Drawing.Point(12, 156);
            this.listofreports_gridview.Name = "listofreports_gridview";
            this.listofreports_gridview.ReadOnly = true;
            this.listofreports_gridview.Size = new System.Drawing.Size(660, 344);
            this.listofreports_gridview.TabIndex = 121;
            // 
            // show_btn_rep
            // 
            this.show_btn_rep.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.show_btn_rep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.show_btn_rep.FlatAppearance.BorderSize = 0;
            this.show_btn_rep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.show_btn_rep.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_btn_rep.ForeColor = System.Drawing.Color.White;
            this.show_btn_rep.Location = new System.Drawing.Point(307, 508);
            this.show_btn_rep.Name = "show_btn_rep";
            this.show_btn_rep.Size = new System.Drawing.Size(79, 33);
            this.show_btn_rep.TabIndex = 10;
            this.show_btn_rep.Text = "SHOW";
            this.show_btn_rep.UseVisualStyleBackColor = false;
            this.show_btn_rep.Click += new System.EventHandler(this.show_btn_rep_Click);
            // 
            // labelAmt
            // 
            this.labelAmt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAmt.AutoSize = true;
            this.labelAmt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmt.Location = new System.Drawing.Point(483, 113);
            this.labelAmt.Name = "labelAmt";
            this.labelAmt.Size = new System.Drawing.Size(0, 20);
            this.labelAmt.TabIndex = 8;
            // 
            // salaryDisplay
            // 
            this.salaryDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.salaryDisplay.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryDisplay.Location = new System.Drawing.Point(572, 110);
            this.salaryDisplay.Multiline = true;
            this.salaryDisplay.Name = "salaryDisplay";
            this.salaryDisplay.ReadOnly = true;
            this.salaryDisplay.Size = new System.Drawing.Size(100, 25);
            this.salaryDisplay.TabIndex = 9;
            // 
            // allData
            // 
            this.allData.AutoSize = true;
            this.allData.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allData.Location = new System.Drawing.Point(15, 114);
            this.allData.Name = "allData";
            this.allData.Size = new System.Drawing.Size(144, 22);
            this.allData.TabIndex = 4;
            this.allData.Text = "SHOW ALL DATA";
            this.allData.UseVisualStyleBackColor = true;
            // 
            // qty_rep
            // 
            this.qty_rep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.qty_rep.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qty_rep.Location = new System.Drawing.Point(374, 111);
            this.qty_rep.Multiline = true;
            this.qty_rep.Name = "qty_rep";
            this.qty_rep.ReadOnly = true;
            this.qty_rep.Size = new System.Drawing.Size(100, 25);
            this.qty_rep.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(284, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "TOTAL QTY";
            // 
            // withAmt
            // 
            this.withAmt.AutoSize = true;
            this.withAmt.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withAmt.Location = new System.Drawing.Point(159, 114);
            this.withAmt.Name = "withAmt";
            this.withAmt.Size = new System.Drawing.Size(130, 22);
            this.withAmt.TabIndex = 5;
            this.withAmt.Text = "WITH AMOUNT";
            this.withAmt.UseVisualStyleBackColor = true;
            // 
            // ListofReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(209)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(684, 548);
            this.Controls.Add(this.withAmt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.qty_rep);
            this.Controls.Add(this.allData);
            this.Controls.Add(this.salaryDisplay);
            this.Controls.Add(this.labelAmt);
            this.Controls.Add(this.show_btn_rep);
            this.Controls.Add(this.listofreports_gridview);
            this.Controls.Add(this.EmpName);
            this.Controls.Add(this.todate);
            this.Controls.Add(this.fromdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.payout_date);
            this.Controls.Add(this.inv_cl);
            this.Controls.Add(this.label8);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListofReport";
            this.Text = "ListofReport";
            this.Load += new System.EventHandler(this.ListofReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listofreports_gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button inv_cl;
        private System.Windows.Forms.Label payout_date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker fromdate;
        private System.Windows.Forms.DateTimePicker todate;
        private System.Windows.Forms.TextBox EmpName;
        private System.Windows.Forms.DataGridView listofreports_gridview;
        private System.Windows.Forms.Button show_btn_rep;
        private System.Windows.Forms.Label labelAmt;
        private System.Windows.Forms.TextBox salaryDisplay;
        private System.Windows.Forms.CheckBox allData;
        private System.Windows.Forms.TextBox qty_rep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox withAmt;
    }
}