namespace PlayerUI
{
    partial class PettyCash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PettyCash));
            this.inv_cl = new System.Windows.Forms.Button();
            this.save_btn_emp = new System.Windows.Forms.Button();
            this.delete_btn_petty = new System.Windows.Forms.Button();
            this.petty_cash_datagridview = new System.Windows.Forms.DataGridView();
            this.DebitPetty = new System.Windows.Forms.TextBox();
            this.CreditPetty = new System.Windows.Forms.TextBox();
            this.PettyDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.RemarksText = new System.Windows.Forms.TextBox();
            this.PartyName = new System.Windows.Forms.TextBox();
            this.ParticularName = new System.Windows.Forms.TextBox();
            this.empType = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FHG = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AvaBalance = new System.Windows.Forms.TextBox();
            this.HeadName = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.petty_cash_datagridview)).BeginInit();
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
            this.inv_cl.Click += new System.EventHandler(this.inv_cl_Click);
            // 
            // save_btn_emp
            // 
            this.save_btn_emp.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.save_btn_emp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.save_btn_emp.FlatAppearance.BorderSize = 0;
            this.save_btn_emp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_btn_emp.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn_emp.ForeColor = System.Drawing.Color.White;
            this.save_btn_emp.Location = new System.Drawing.Point(249, 503);
            this.save_btn_emp.Name = "save_btn_emp";
            this.save_btn_emp.Size = new System.Drawing.Size(79, 33);
            this.save_btn_emp.TabIndex = 9;
            this.save_btn_emp.Text = "SAVE";
            this.save_btn_emp.UseVisualStyleBackColor = false;
            this.save_btn_emp.Click += new System.EventHandler(this.save_btn_emp_Click);
            // 
            // delete_btn_petty
            // 
            this.delete_btn_petty.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.delete_btn_petty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.delete_btn_petty.FlatAppearance.BorderSize = 0;
            this.delete_btn_petty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_btn_petty.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn_petty.ForeColor = System.Drawing.Color.White;
            this.delete_btn_petty.Location = new System.Drawing.Point(363, 503);
            this.delete_btn_petty.Name = "delete_btn_petty";
            this.delete_btn_petty.Size = new System.Drawing.Size(79, 33);
            this.delete_btn_petty.TabIndex = 10;
            this.delete_btn_petty.Text = "DELETE";
            this.delete_btn_petty.UseVisualStyleBackColor = false;
            this.delete_btn_petty.Click += new System.EventHandler(this.delete_btn_emp_Click);
            // 
            // petty_cash_datagridview
            // 
            this.petty_cash_datagridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.petty_cash_datagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.petty_cash_datagridview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.petty_cash_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.petty_cash_datagridview.Location = new System.Drawing.Point(12, 279);
            this.petty_cash_datagridview.Name = "petty_cash_datagridview";
            this.petty_cash_datagridview.Size = new System.Drawing.Size(660, 215);
            this.petty_cash_datagridview.TabIndex = 11;
            // 
            // DebitPetty
            // 
            this.DebitPetty.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DebitPetty.Location = new System.Drawing.Point(500, 101);
            this.DebitPetty.Name = "DebitPetty";
            this.DebitPetty.Size = new System.Drawing.Size(172, 20);
            this.DebitPetty.TabIndex = 6;
            // 
            // CreditPetty
            // 
            this.CreditPetty.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CreditPetty.Location = new System.Drawing.Point(499, 60);
            this.CreditPetty.Name = "CreditPetty";
            this.CreditPetty.Size = new System.Drawing.Size(172, 20);
            this.CreditPetty.TabIndex = 5;
            // 
            // PettyDate
            // 
            this.PettyDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PettyDate.Location = new System.Drawing.Point(142, 186);
            this.PettyDate.Name = "PettyDate";
            this.PettyDate.Size = new System.Drawing.Size(172, 20);
            this.PettyDate.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 94;
            this.label2.Text = "DATE:";
            // 
            // RemarksText
            // 
            this.RemarksText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RemarksText.Location = new System.Drawing.Point(500, 144);
            this.RemarksText.Multiline = true;
            this.RemarksText.Name = "RemarksText";
            this.RemarksText.Size = new System.Drawing.Size(172, 62);
            this.RemarksText.TabIndex = 7;
            // 
            // PartyName
            // 
            this.PartyName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PartyName.Location = new System.Drawing.Point(142, 142);
            this.PartyName.Name = "PartyName";
            this.PartyName.Size = new System.Drawing.Size(172, 20);
            this.PartyName.TabIndex = 3;
            // 
            // ParticularName
            // 
            this.ParticularName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ParticularName.Location = new System.Drawing.Point(142, 58);
            this.ParticularName.Name = "ParticularName";
            this.ParticularName.Size = new System.Drawing.Size(172, 20);
            this.ParticularName.TabIndex = 1;
            // 
            // empType
            // 
            this.empType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.empType.AutoSize = true;
            this.empType.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empType.Location = new System.Drawing.Point(390, 101);
            this.empType.Name = "empType";
            this.empType.Size = new System.Drawing.Size(49, 20);
            this.empType.TabIndex = 88;
            this.empType.Text = "DEBIT";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 87;
            this.label7.Text = "HEAD";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 86;
            this.label6.Text = "PARTY";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(390, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 84;
            this.label4.Text = "CREDIT";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(390, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 83;
            this.label3.Text = "REMARKS:";
            // 
            // FHG
            // 
            this.FHG.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FHG.AutoSize = true;
            this.FHG.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FHG.Location = new System.Drawing.Point(8, 58);
            this.FHG.Name = "FHG";
            this.FHG.Size = new System.Drawing.Size(94, 20);
            this.FHG.TabIndex = 82;
            this.FHG.Text = "PARTICULAR";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(343, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 98;
            this.label1.Text = "AVAILABLE BALANCE";
            // 
            // AvaBalance
            // 
            this.AvaBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AvaBalance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvaBalance.Location = new System.Drawing.Point(501, 240);
            this.AvaBalance.Multiline = true;
            this.AvaBalance.Name = "AvaBalance";
            this.AvaBalance.ReadOnly = true;
            this.AvaBalance.Size = new System.Drawing.Size(171, 23);
            this.AvaBalance.TabIndex = 8;
            // 
            // HeadName
            // 
            this.HeadName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HeadName.FormattingEnabled = true;
            this.HeadName.Location = new System.Drawing.Point(142, 100);
            this.HeadName.Name = "HeadName";
            this.HeadName.Size = new System.Drawing.Size(172, 21);
            this.HeadName.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(257, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 23);
            this.label8.TabIndex = 112;
            this.label8.Text = "PETTY CASH";
            // 
            // PettyCash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(209)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(684, 548);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.HeadName);
            this.Controls.Add(this.AvaBalance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DebitPetty);
            this.Controls.Add(this.CreditPetty);
            this.Controls.Add(this.PettyDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RemarksText);
            this.Controls.Add(this.PartyName);
            this.Controls.Add(this.ParticularName);
            this.Controls.Add(this.empType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FHG);
            this.Controls.Add(this.save_btn_emp);
            this.Controls.Add(this.delete_btn_petty);
            this.Controls.Add(this.inv_cl);
            this.Controls.Add(this.petty_cash_datagridview);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PettyCash";
            this.Text = "PettyCash";
            this.Load += new System.EventHandler(this.PettyCash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.petty_cash_datagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button inv_cl;
        private System.Windows.Forms.Button save_btn_emp;
        private System.Windows.Forms.DataGridView petty_cash_datagridview;
        private System.Windows.Forms.TextBox DebitPetty;
        private System.Windows.Forms.TextBox CreditPetty;
        private System.Windows.Forms.DateTimePicker PettyDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RemarksText;
        private System.Windows.Forms.TextBox PartyName;
        private System.Windows.Forms.TextBox ParticularName;
        private System.Windows.Forms.Label empType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label FHG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AvaBalance;
        private System.Windows.Forms.ComboBox HeadName;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Button delete_btn_petty;
    }
}