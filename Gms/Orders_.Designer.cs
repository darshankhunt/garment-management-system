namespace PlayerUI
{
    partial class Orders_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orders_));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sr_no_i = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.party_i = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.particular_i = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JOB_NO_i = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color_i = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty_i = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size_i = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remark_i = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inv_btn_del = new System.Windows.Forms.Button();
            this.inv_btn_save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.inv_cl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sr_no_i,
            this.chno,
            this.party_i,
            this.particular_i,
            this.JOB_NO_i,
            this.color_i,
            this.qty_i,
            this.size_i,
            this.remark_i});
            this.dataGridView1.Location = new System.Drawing.Point(54, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(433, 274);
            this.dataGridView1.TabIndex = 10;
            // 
            // sr_no_i
            // 
            this.sr_no_i.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sr_no_i.HeaderText = "SR";
            this.sr_no_i.Name = "sr_no_i";
            this.sr_no_i.ReadOnly = true;
            // 
            // chno
            // 
            this.chno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chno.HeaderText = "CHALAN NO.";
            this.chno.Name = "chno";
            // 
            // party_i
            // 
            this.party_i.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.party_i.HeaderText = "PARTY";
            this.party_i.Name = "party_i";
            // 
            // particular_i
            // 
            this.particular_i.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.particular_i.HeaderText = "PARTICULAR";
            this.particular_i.Name = "particular_i";
            // 
            // JOB_NO_i
            // 
            this.JOB_NO_i.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.JOB_NO_i.HeaderText = "J.NO";
            this.JOB_NO_i.Name = "JOB_NO_i";
            // 
            // color_i
            // 
            this.color_i.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.color_i.HeaderText = "COLOR";
            this.color_i.Name = "color_i";
            // 
            // qty_i
            // 
            this.qty_i.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.qty_i.HeaderText = "QTY";
            this.qty_i.Name = "qty_i";
            // 
            // size_i
            // 
            this.size_i.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.size_i.HeaderText = "SIZE";
            this.size_i.Name = "size_i";
            // 
            // remark_i
            // 
            this.remark_i.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.remark_i.HeaderText = "REMARK";
            this.remark_i.Name = "remark_i";
            // 
            // inv_btn_del
            // 
            this.inv_btn_del.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inv_btn_del.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.inv_btn_del.FlatAppearance.BorderSize = 0;
            this.inv_btn_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inv_btn_del.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inv_btn_del.ForeColor = System.Drawing.Color.White;
            this.inv_btn_del.Location = new System.Drawing.Point(508, 166);
            this.inv_btn_del.Name = "inv_btn_del";
            this.inv_btn_del.Size = new System.Drawing.Size(150, 40);
            this.inv_btn_del.TabIndex = 12;
            this.inv_btn_del.Text = "DELETE";
            this.inv_btn_del.UseVisualStyleBackColor = false;
            // 
            // inv_btn_save
            // 
            this.inv_btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inv_btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.inv_btn_save.FlatAppearance.BorderSize = 0;
            this.inv_btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inv_btn_save.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inv_btn_save.ForeColor = System.Drawing.Color.White;
            this.inv_btn_save.Location = new System.Drawing.Point(508, 99);
            this.inv_btn_save.Name = "inv_btn_save";
            this.inv_btn_save.Size = new System.Drawing.Size(150, 40);
            this.inv_btn_save.TabIndex = 11;
            this.inv_btn_save.Text = "SAVE";
            this.inv_btn_save.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.label2.Location = new System.Drawing.Point(205, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 32);
            this.label2.TabIndex = 17;
            this.label2.Text = "ORDERS INWARD";
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
            this.inv_cl.TabIndex = 18;
            this.inv_cl.Text = "X";
            this.inv_cl.UseVisualStyleBackColor = true;
            this.inv_cl.Click += new System.EventHandler(this.inv_cl_Click);
            // 
            // Orders_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(209)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(684, 431);
            this.Controls.Add(this.inv_cl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inv_btn_del);
            this.Controls.Add(this.inv_btn_save);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Orders_";
            this.Text = "ORDERS INWARD";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button inv_btn_del;
        private System.Windows.Forms.Button inv_btn_save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn sr_no_i;
        private System.Windows.Forms.DataGridViewTextBoxColumn chno;
        private System.Windows.Forms.DataGridViewTextBoxColumn party_i;
        private System.Windows.Forms.DataGridViewTextBoxColumn particular_i;
        private System.Windows.Forms.DataGridViewTextBoxColumn JOB_NO_i;
        private System.Windows.Forms.DataGridViewTextBoxColumn color_i;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty_i;
        private System.Windows.Forms.DataGridViewTextBoxColumn size_i;
        private System.Windows.Forms.DataGridViewTextBoxColumn remark_i;
        private System.Windows.Forms.Button inv_cl;
    }
}