namespace PlayerUI
{
    partial class UpdatePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdatePassword));
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.conPass = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.oldPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.newPass = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnupdatepass = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.idPass = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(32)))), ((int)(((byte)(49)))));
            this.label5.Location = new System.Drawing.Point(30, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Update Your Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Old Password";
            // 
            // conPass
            // 
            this.conPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.conPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conPass.Location = new System.Drawing.Point(31, 9);
            this.conPass.Multiline = true;
            this.conPass.Name = "conPass";
            this.conPass.PasswordChar = '*';
            this.conPass.Size = new System.Drawing.Size(339, 23);
            this.conPass.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.oldPass);
            this.panel1.Location = new System.Drawing.Point(37, 147);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 41);
            this.panel1.TabIndex = 2;
            // 
            // oldPass
            // 
            this.oldPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.oldPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldPass.Location = new System.Drawing.Point(28, 8);
            this.oldPass.Multiline = true;
            this.oldPass.Name = "oldPass";
            this.oldPass.PasswordChar = '*';
            this.oldPass.Size = new System.Drawing.Size(339, 23);
            this.oldPass.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "New Password";
            // 
            // newPass
            // 
            this.newPass.BackColor = System.Drawing.Color.White;
            this.newPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPass.Location = new System.Drawing.Point(28, 9);
            this.newPass.Multiline = true;
            this.newPass.Name = "newPass";
            this.newPass.PasswordChar = '*';
            this.newPass.Size = new System.Drawing.Size(339, 23);
            this.newPass.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.newPass);
            this.panel2.Location = new System.Drawing.Point(37, 223);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(394, 41);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "Confirm Password";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.conPass);
            this.panel3.Location = new System.Drawing.Point(34, 300);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(394, 41);
            this.panel3.TabIndex = 4;
            // 
            // btnupdatepass
            // 
            this.btnupdatepass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(32)))), ((int)(((byte)(49)))));
            this.btnupdatepass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdatepass.ForeColor = System.Drawing.Color.White;
            this.btnupdatepass.Location = new System.Drawing.Point(161, 372);
            this.btnupdatepass.Name = "btnupdatepass";
            this.btnupdatepass.Size = new System.Drawing.Size(145, 35);
            this.btnupdatepass.TabIndex = 5;
            this.btnupdatepass.Text = "Update";
            this.btnupdatepass.UseVisualStyleBackColor = false;
            this.btnupdatepass.Click += new System.EventHandler(this.btnupdatepass_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "Admin Id";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.idPass);
            this.panel4.Location = new System.Drawing.Point(37, 76);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(394, 41);
            this.panel4.TabIndex = 1;
            // 
            // idPass
            // 
            this.idPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idPass.Location = new System.Drawing.Point(28, 9);
            this.idPass.Multiline = true;
            this.idPass.Name = "idPass";
            this.idPass.Size = new System.Drawing.Size(339, 23);
            this.idPass.TabIndex = 0;
            // 
            // UpdatePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(209)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(466, 419);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnupdatepass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdatePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdatePassword";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox conPass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox newPass;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox oldPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnupdatepass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox idPass;

    }
}