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
            this.btnLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHelpDesk
            // 
            this.lblHelpDesk.AutoSize = true;
            this.lblHelpDesk.BackColor = System.Drawing.Color.SeaGreen;
            this.lblHelpDesk.Font = new System.Drawing.Font("Candara", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelpDesk.ForeColor = System.Drawing.Color.White;
            this.lblHelpDesk.Location = new System.Drawing.Point(309, 159);
            this.lblHelpDesk.Name = "lblHelpDesk";
            this.lblHelpDesk.Size = new System.Drawing.Size(213, 68);
            this.lblHelpDesk.TabIndex = 0;
            this.lblHelpDesk.Text = "NoDesk";
            // 
            // lblLoginInstruction
            // 
            this.lblLoginInstruction.AutoSize = true;
            this.lblLoginInstruction.BackColor = System.Drawing.Color.SeaGreen;
            this.lblLoginInstruction.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginInstruction.ForeColor = System.Drawing.Color.White;
            this.lblLoginInstruction.Location = new System.Drawing.Point(817, 127);
            this.lblLoginInstruction.MaximumSize = new System.Drawing.Size(600, 100);
            this.lblLoginInstruction.MinimumSize = new System.Drawing.Size(600, 100);
            this.lblLoginInstruction.Name = "lblLoginInstruction";
            this.lblLoginInstruction.Size = new System.Drawing.Size(600, 100);
            this.lblLoginInstruction.TabIndex = 1;
            this.lblLoginInstruction.Text = "Please provide login credentials to login to NoDesk for the Garden Group";
            this.lblLoginInstruction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.SeaGreen;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(973, 314);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(124, 29);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(977, 352);
            this.txtUsername.MaximumSize = new System.Drawing.Size(317, 31);
            this.txtUsername.MinimumSize = new System.Drawing.Size(350, 36);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(350, 36);
            this.txtUsername.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.SeaGreen;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(979, 435);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(120, 29);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.CausesValidation = false;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(1083, 571);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(148, 46);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(55, 280);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(712, 398);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.SeaGreen;
            this.pnlLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLogin.Controls.Add(this.pictureBox1);
            this.pnlLogin.Controls.Add(this.txtPassword);
            this.pnlLogin.Controls.Add(this.lblLoginInstruction);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.txtUsername);
            this.pnlLogin.Controls.Add(this.lblHelpDesk);
            this.pnlLogin.Controls.Add(this.lblUsername);
            this.pnlLogin.Controls.Add(this.lblPassword);
            this.pnlLogin.Location = new System.Drawing.Point(31, 41);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(1511, 885);
            this.pnlLogin.TabIndex = 11;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(978, 469);
            this.txtPassword.MaximumSize = new System.Drawing.Size(317, 31);
            this.txtPassword.MinimumSize = new System.Drawing.Size(350, 36);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(350, 36);
            this.txtPassword.TabIndex = 9;
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1568, 958);
            this.Controls.Add(this.pnlLogin);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginScreen";
            this.Load += new System.EventHandler(this.LoginScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHelpDesk;
        private System.Windows.Forms.Label lblLoginInstruction;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.TextBox txtPassword;
    }
}