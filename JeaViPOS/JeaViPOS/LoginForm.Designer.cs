namespace JeaViPOS
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.pnlCard = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.chkShow = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pnlCard.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlCard
            //
            this.pnlCard.BackColor = System.Drawing.Color.White;
            this.pnlCard.Controls.Add(this.lblStatus);
            this.pnlCard.Controls.Add(this.btnLogin);
            this.pnlCard.Controls.Add(this.chkShow);
            this.pnlCard.Controls.Add(this.txtPassword);
            this.pnlCard.Controls.Add(this.lblPassword);
            this.pnlCard.Controls.Add(this.txtUsername);
            this.pnlCard.Controls.Add(this.lblUsername);
            this.pnlCard.Controls.Add(this.lblSubtitle);
            this.pnlCard.Controls.Add(this.lblTitle);
            this.pnlCard.Location = new System.Drawing.Point(40, 40);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(380, 410);
            this.pnlCard.TabIndex = 0;
            //
            // lblTitle
            //
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.lblTitle.Location = new System.Drawing.Point(26, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "JeaViPOS";
            //
            // lblSubtitle
            //
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblSubtitle.Location = new System.Drawing.Point(30, 74);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Text = "Sign in to your account";
            //
            // lblUsername
            //
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(30, 118);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Text = "Username";
            //
            // txtUsername
            //
            this.txtUsername.Location = new System.Drawing.Point(30, 142);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(320, 30);
            this.txtUsername.TabIndex = 0;
            //
            // lblPassword
            //
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(30, 188);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Text = "Password";
            //
            // txtPassword
            //
            this.txtPassword.Location = new System.Drawing.Point(30, 212);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(320, 30);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            //
            // chkShow
            //
            this.chkShow.AutoSize = true;
            this.chkShow.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.chkShow.Location = new System.Drawing.Point(30, 254);
            this.chkShow.Name = "chkShow";
            this.chkShow.TabIndex = 2;
            this.chkShow.Text = "Show password";
            this.chkShow.UseVisualStyleBackColor = true;
            this.chkShow.CheckedChanged += new System.EventHandler(this.chkShow_CheckedChanged);
            //
            // btnLogin
            //
            this.btnLogin.Location = new System.Drawing.Point(30, 296);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(320, 44);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Sign in";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.LoginClicked);
            //
            // lblStatus
            //
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.lblStatus.Location = new System.Drawing.Point(30, 352);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(320, 44);
            this.lblStatus.TabIndex = 4;
            //
            // LoginForm
            //
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);
            this.ClientSize = new System.Drawing.Size(460, 490);
            this.Controls.Add(this.pnlCard);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JeaViPOS - Login";
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkShow;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblStatus;
    }
}