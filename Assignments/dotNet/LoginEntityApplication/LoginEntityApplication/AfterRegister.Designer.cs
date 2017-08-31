namespace LoginEntityApplication
{
    partial class AfterRegister
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
            this.txtaccNo = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtbal = new System.Windows.Forms.TextBox();
            this.txtPasswd = new System.Windows.Forms.TextBox();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.lbluserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblInitialBalance = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtaccNo
            // 
            this.txtaccNo.Location = new System.Drawing.Point(343, 62);
            this.txtaccNo.Name = "txtaccNo";
            this.txtaccNo.Size = new System.Drawing.Size(120, 20);
            this.txtaccNo.TabIndex = 0;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(343, 108);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(120, 20);
            this.txtUsername.TabIndex = 1;
            // 
            // txtbal
            // 
            this.txtbal.Location = new System.Drawing.Point(343, 197);
            this.txtbal.Name = "txtbal";
            this.txtbal.Size = new System.Drawing.Size(120, 20);
            this.txtbal.TabIndex = 2;
            // 
            // txtPasswd
            // 
            this.txtPasswd.Location = new System.Drawing.Point(343, 153);
            this.txtPasswd.Name = "txtPasswd";
            this.txtPasswd.Size = new System.Drawing.Size(120, 20);
            this.txtPasswd.TabIndex = 3;
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Location = new System.Drawing.Point(216, 62);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(87, 13);
            this.lblAccountNumber.TabIndex = 4;
            this.lblAccountNumber.Text = "Account Number";
            // 
            // lbluserName
            // 
            this.lbluserName.AutoSize = true;
            this.lbluserName.Location = new System.Drawing.Point(216, 108);
            this.lbluserName.Name = "lbluserName";
            this.lbluserName.Size = new System.Drawing.Size(57, 13);
            this.lbluserName.TabIndex = 5;
            this.lbluserName.Text = "UserName";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(216, 153);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password";
            // 
            // lblInitialBalance
            // 
            this.lblInitialBalance.AutoSize = true;
            this.lblInitialBalance.Location = new System.Drawing.Point(216, 197);
            this.lblInitialBalance.Name = "lblInitialBalance";
            this.lblInitialBalance.Size = new System.Drawing.Size(73, 13);
            this.lblInitialBalance.TabIndex = 7;
            this.lblInitialBalance.Text = "Initial Balance";
            this.lblInitialBalance.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(219, 262);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(244, 61);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // AfterRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 433);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblInitialBalance);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lbluserName);
            this.Controls.Add(this.lblAccountNumber);
            this.Controls.Add(this.txtPasswd);
            this.Controls.Add(this.txtbal);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtaccNo);
            this.Name = "AfterRegister";
            this.Text = "AfterRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtaccNo;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtbal;
        private System.Windows.Forms.TextBox txtPasswd;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.Label lbluserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblInitialBalance;
        private System.Windows.Forms.Button btnRegister;
    }
}