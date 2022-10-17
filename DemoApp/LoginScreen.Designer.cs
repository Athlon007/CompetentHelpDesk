namespace DemoApp
{
    partial class LoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            this.lblHelpDesk = new System.Windows.Forms.Label();
            this.lblLoginInstruction = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblResetPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pnlPasswordReset = new System.Windows.Forms.Panel();
            this.lblLinkSent = new System.Windows.Forms.Label();
            this.btnSendResetLink = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtUsernameResetPasswordPnl = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblUsernamePasswordResetPnl = new System.Windows.Forms.Label();
            this.lblTitleResetPassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlPasswordReset.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHelpDesk
            // 
            this.lblHelpDesk.AutoSize = true;
            this.lblHelpDesk.BackColor = System.Drawing.Color.SeaGreen;
            this.lblHelpDesk.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelpDesk.ForeColor = System.Drawing.Color.White;
            this.lblHelpDesk.Location = new System.Drawing.Point(209, 128);
            this.lblHelpDesk.Name = "lblHelpDesk";
            this.lblHelpDesk.Size = new System.Drawing.Size(183, 59);
            this.lblHelpDesk.TabIndex = 0;
            this.lblHelpDesk.Text = "NoDesk";
            // 
            // lblLoginInstruction
            // 
            this.lblLoginInstruction.AutoSize = true;
            this.lblLoginInstruction.BackColor = System.Drawing.Color.SeaGreen;
            this.lblLoginInstruction.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginInstruction.ForeColor = System.Drawing.Color.White;
            this.lblLoginInstruction.Location = new System.Drawing.Point(589, 113);
            this.lblLoginInstruction.MaximumSize = new System.Drawing.Size(600, 100);
            this.lblLoginInstruction.MinimumSize = new System.Drawing.Size(600, 100);
            this.lblLoginInstruction.Name = "lblLoginInstruction";
            this.lblLoginInstruction.Size = new System.Drawing.Size(600, 100);
            this.lblLoginInstruction.TabIndex = 1;
            this.lblLoginInstruction.Text = "Please provide login credentials to login to NoDesk for the garden Group";
            this.lblLoginInstruction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.SeaGreen;
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(732, 241);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(83, 20);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Location = new System.Drawing.Point(736, 279);
            this.txtUsername.MaximumSize = new System.Drawing.Size(317, 31);
            this.txtUsername.MinimumSize = new System.Drawing.Size(317, 36);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(317, 26);
            this.txtUsername.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.SeaGreen;
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(737, 352);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(78, 20);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            // 
            // lblResetPassword
            // 
            this.lblResetPassword.AutoSize = true;
            this.lblResetPassword.BackColor = System.Drawing.Color.SeaGreen;
            this.lblResetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResetPassword.ForeColor = System.Drawing.Color.LightCyan;
            this.lblResetPassword.Location = new System.Drawing.Point(735, 450);
            this.lblResetPassword.Name = "lblResetPassword";
            this.lblResetPassword.Size = new System.Drawing.Size(124, 20);
            this.lblResetPassword.TabIndex = 7;
            this.lblResetPassword.Text = "Reset password";
            this.lblResetPassword.Click += new System.EventHandler(this.lblResetPassword_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.CausesValidation = false;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(838, 503);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(129, 43);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(69, 261);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(570, 320);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pnlPasswordReset);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.lblLoginInstruction);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.lblResetPassword);
            this.panel1.Controls.Add(this.lblHelpDesk);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Location = new System.Drawing.Point(31, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1194, 665);
            this.panel1.TabIndex = 11;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Location = new System.Drawing.Point(736, 386);
            this.txtPassword.MaximumSize = new System.Drawing.Size(317, 31);
            this.txtPassword.MinimumSize = new System.Drawing.Size(317, 36);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(317, 26);
            this.txtPassword.TabIndex = 9;
            // 
            // pnlPasswordReset
            // 
            this.pnlPasswordReset.Controls.Add(this.lblLinkSent);
            this.pnlPasswordReset.Controls.Add(this.btnSendResetLink);
            this.pnlPasswordReset.Controls.Add(this.txtEmail);
            this.pnlPasswordReset.Controls.Add(this.txtUsernameResetPasswordPnl);
            this.pnlPasswordReset.Controls.Add(this.lblEmail);
            this.pnlPasswordReset.Controls.Add(this.lblUsernamePasswordResetPnl);
            this.pnlPasswordReset.Controls.Add(this.lblTitleResetPassword);
            this.pnlPasswordReset.Location = new System.Drawing.Point(615, -1);
            this.pnlPasswordReset.Name = "pnlPasswordReset";
            this.pnlPasswordReset.Size = new System.Drawing.Size(578, 665);
            this.pnlPasswordReset.TabIndex = 11;
            // 
            // lblLinkSent
            // 
            this.lblLinkSent.AutoSize = true;
            this.lblLinkSent.ForeColor = System.Drawing.Color.White;
            this.lblLinkSent.Location = new System.Drawing.Point(112, 543);
            this.lblLinkSent.MinimumSize = new System.Drawing.Size(360, 50);
            this.lblLinkSent.Name = "lblLinkSent";
            this.lblLinkSent.Size = new System.Drawing.Size(360, 50);
            this.lblLinkSent.TabIndex = 11;
            // 
            // btnSendResetLink
            // 
            this.btnSendResetLink.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSendResetLink.ForeColor = System.Drawing.Color.White;
            this.btnSendResetLink.Location = new System.Drawing.Point(135, 440);
            this.btnSendResetLink.Name = "btnSendResetLink";
            this.btnSendResetLink.Size = new System.Drawing.Size(95, 39);
            this.btnSendResetLink.TabIndex = 7;
            this.btnSendResetLink.Text = "Reset";
            this.btnSendResetLink.UseVisualStyleBackColor = false;
            this.btnSendResetLink.Click += new System.EventHandler(this.btnSendResetLink_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(135, 381);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(317, 26);
            this.txtEmail.TabIndex = 6;
            // 
            // txtUsernameResetPasswordPnl
            // 
            this.txtUsernameResetPasswordPnl.Location = new System.Drawing.Point(135, 296);
            this.txtUsernameResetPasswordPnl.Name = "txtUsernameResetPasswordPnl";
            this.txtUsernameResetPasswordPnl.Size = new System.Drawing.Size(317, 26);
            this.txtUsernameResetPasswordPnl.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(131, 343);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email";
            // 
            // lblUsernamePasswordResetPnl
            // 
            this.lblUsernamePasswordResetPnl.AutoSize = true;
            this.lblUsernamePasswordResetPnl.ForeColor = System.Drawing.Color.White;
            this.lblUsernamePasswordResetPnl.Location = new System.Drawing.Point(131, 259);
            this.lblUsernamePasswordResetPnl.Name = "lblUsernamePasswordResetPnl";
            this.lblUsernamePasswordResetPnl.Size = new System.Drawing.Size(83, 20);
            this.lblUsernamePasswordResetPnl.TabIndex = 3;
            this.lblUsernamePasswordResetPnl.Text = "Username";
            // 
            // lblTitleResetPassword
            // 
            this.lblTitleResetPassword.AutoSize = true;
            this.lblTitleResetPassword.BackColor = System.Drawing.Color.SeaGreen;
            this.lblTitleResetPassword.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleResetPassword.ForeColor = System.Drawing.Color.White;
            this.lblTitleResetPassword.Location = new System.Drawing.Point(33, 113);
            this.lblTitleResetPassword.MaximumSize = new System.Drawing.Size(600, 100);
            this.lblTitleResetPassword.MinimumSize = new System.Drawing.Size(500, 100);
            this.lblTitleResetPassword.Name = "lblTitleResetPassword";
            this.lblTitleResetPassword.Size = new System.Drawing.Size(500, 100);
            this.lblTitleResetPassword.TabIndex = 2;
            this.lblTitleResetPassword.Text = "Set a new password";
            this.lblTitleResetPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1258, 744);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "LoginScreen";
            this.Text = "LoginScreen";
            this.Load += new System.EventHandler(this.LoginScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlPasswordReset.ResumeLayout(false);
            this.pnlPasswordReset.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHelpDesk;
        private System.Windows.Forms.Label lblLoginInstruction;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblResetPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel pnlPasswordReset;
        private System.Windows.Forms.Label lblLinkSent;
        private System.Windows.Forms.Button btnSendResetLink;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtUsernameResetPasswordPnl;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblUsernamePasswordResetPnl;
        private System.Windows.Forms.Label lblTitleResetPassword;
    }
}