namespace BillingSystem
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblUsername = new Label();
            txtUsername = new MaskedTextBox();
            lblPassword = new Label();
            txtPassword = new MaskedTextBox();
            btnLogin = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AccessibleName = "lblTitle";
            lblTitle.AutoSize = true;
            lblTitle.FlatStyle = FlatStyle.System;
            lblTitle.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(83, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(223, 29);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "BILLING SYSTEM";
            lblTitle.Click += label1_Click_1;
            // 
            // lblUsername
            // 
            lblUsername.AccessibleName = "lblUsername";
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUsername.Location = new Point(43, 62);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(94, 23);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username:";
            lblUsername.Click += label2_Click;
            // 
            // txtUsername
            // 
            txtUsername.AccessibleName = "txtUsername";
            txtUsername.Location = new Point(170, 59);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(189, 27);
            txtUsername.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.AccessibleName = "lblPassword";
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPassword.Location = new Point(43, 109);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(90, 23);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password:";
            lblPassword.Click += label3_Click;
            // 
            // txtPassword
            // 
            txtPassword.AccessibleName = "txtPassword";
            txtPassword.Location = new Point(170, 109);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(189, 27);
            txtPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.AccessibleName = "btnLogin";
            btnLogin.BackColor = Color.CornflowerBlue;
            btnLogin.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            btnLogin.Location = new Point(83, 171);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(77, 41);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.AccessibleName = "btnCancel";
            btnCancel.BackColor = Color.Crimson;
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancel.Location = new Point(223, 169);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(72, 43);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 253);
            Controls.Add(btnCancel);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Billing System - Login ";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblUsername;
        private MaskedTextBox txtUsername;
        private Label lblPassword;
        private MaskedTextBox txtPassword;
        private Button btnLogin;
        private Button btnCancel;
    }
}
