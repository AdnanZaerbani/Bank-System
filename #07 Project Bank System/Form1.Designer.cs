namespace _07_Project_Bank_System
{
    partial class frmLoginScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoginScreen));
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblAllRightsReserved = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblNumberOfAttempts = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.chkAcceptance = new System.Windows.Forms.CheckBox();
            this.trLoginSuccssfuly = new System.Windows.Forms.Timer(this.components);
            this.pbFlag = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.lnlWebsite = new System.Windows.Forms.LinkLabel();
            this.niInfo = new System.Windows.Forms.NotifyIcon(this.components);
            this.prb100 = new System.Windows.Forms.ProgressBar();
            this.lbl100 = new System.Windows.Forms.Label();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.LightGray;
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(304, 304);
            this.txtUserName.MaxLength = 10;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(152, 29);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.MouseEnter += new System.EventHandler(this.txtUserName_MouseEnter);
            this.txtUserName.MouseLeave += new System.EventHandler(this.txtUserName_MouseLeave);
            this.txtUserName.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserName_Validating);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.LightGray;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(304, 361);
            this.txtPassword.MaxLength = 10;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = 'X';
            this.txtPassword.Size = new System.Drawing.Size(152, 29);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.MouseEnter += new System.EventHandler(this.txtPassword_MouseEnter);
            this.txtPassword.MouseLeave += new System.EventHandler(this.txtPassword_MouseLeave);
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.LightGray;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Enabled = false;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Andalus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(139, 447);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(152, 48);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.MouseEnter += new System.EventHandler(this.btnLogin_MouseEnter);
            this.btnLogin.MouseLeave += new System.EventHandler(this.btnLogin_MouseLeave);
            // 
            // lblAllRightsReserved
            // 
            this.lblAllRightsReserved.AutoSize = true;
            this.lblAllRightsReserved.Font = new System.Drawing.Font("Andalus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblAllRightsReserved.ForeColor = System.Drawing.Color.LightGray;
            this.lblAllRightsReserved.Location = new System.Drawing.Point(301, 650);
            this.lblAllRightsReserved.Name = "lblAllRightsReserved";
            this.lblAllRightsReserved.Size = new System.Drawing.Size(169, 22);
            this.lblAllRightsReserved.TabIndex = 3;
            this.lblAllRightsReserved.Text = "All Rights Reserved 2025";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("Andalus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.LightGray;
            this.lblUserName.Location = new System.Drawing.Point(301, 279);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUserName.Size = new System.Drawing.Size(162, 22);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "User Name :                   ";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Andalus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.LightGray;
            this.lblPassword.Location = new System.Drawing.Point(300, 336);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(76, 22);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password :";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Andalus", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblWelcome.ForeColor = System.Drawing.Color.LightGray;
            this.lblWelcome.Location = new System.Drawing.Point(130, 134);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblWelcome.Size = new System.Drawing.Size(506, 108);
            this.lblWelcome.TabIndex = 6;
            this.lblWelcome.Text = "Welcome to Syria International \r\nIslamic Bank";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumberOfAttempts
            // 
            this.lblNumberOfAttempts.AutoSize = true;
            this.lblNumberOfAttempts.BackColor = System.Drawing.Color.Transparent;
            this.lblNumberOfAttempts.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblNumberOfAttempts.ForeColor = System.Drawing.Color.Black;
            this.lblNumberOfAttempts.Location = new System.Drawing.Point(300, 534);
            this.lblNumberOfAttempts.Name = "lblNumberOfAttempts";
            this.lblNumberOfAttempts.Size = new System.Drawing.Size(12, 26);
            this.lblNumberOfAttempts.TabIndex = 7;
            this.lblNumberOfAttempts.Text = "\r\n";
            this.lblNumberOfAttempts.Visible = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDate.Font = new System.Drawing.Font("Andalus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblDate.ForeColor = System.Drawing.Color.LightGray;
            this.lblDate.Location = new System.Drawing.Point(631, 650);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(10, 22);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "\r\n";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightGray;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Andalus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(484, 447);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(152, 48);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            this.btnExit.MouseEnter += new System.EventHandler(this.btnExit_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            // 
            // chkAcceptance
            // 
            this.chkAcceptance.AutoSize = true;
            this.chkAcceptance.BackColor = System.Drawing.Color.Transparent;
            this.chkAcceptance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkAcceptance.Font = new System.Drawing.Font("Andalus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chkAcceptance.ForeColor = System.Drawing.Color.LightGray;
            this.chkAcceptance.Location = new System.Drawing.Point(304, 396);
            this.chkAcceptance.Name = "chkAcceptance";
            this.chkAcceptance.Size = new System.Drawing.Size(253, 26);
            this.chkAcceptance.TabIndex = 3;
            this.chkAcceptance.Text = "Acceptance of terms and conditions";
            this.chkAcceptance.UseVisualStyleBackColor = false;
            this.chkAcceptance.CheckedChanged += new System.EventHandler(this.chkAcceptance_CheckedChanged);
            this.chkAcceptance.MouseEnter += new System.EventHandler(this.chkAcceptance_MouseEnter);
            this.chkAcceptance.MouseLeave += new System.EventHandler(this.chkAcceptance_MouseLeave);
            // 
            // trLoginSuccssfuly
            // 
            this.trLoginSuccssfuly.Interval = 3000;
            this.trLoginSuccssfuly.Tick += new System.EventHandler(this.trLoginSuccssfuly_Tick);
            // 
            // pbFlag
            // 
            this.pbFlag.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pbFlag.Image = global::_07_Project_Bank_System.Properties.Resources.English1;
            this.pbFlag.Location = new System.Drawing.Point(635, 28);
            this.pbFlag.Name = "pbFlag";
            this.pbFlag.Size = new System.Drawing.Size(40, 28);
            this.pbFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFlag.TabIndex = 10;
            this.pbFlag.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::_07_Project_Bank_System.Properties.Resources.freepik__background__71004;
            this.pictureBox1.Location = new System.Drawing.Point(324, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.BackColor = System.Drawing.Color.LightGray;
            this.cmbLanguage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbLanguage.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Items.AddRange(new object[] {
            "English",
            "Arabic"});
            this.cmbLanguage.Location = new System.Drawing.Point(681, 28);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(109, 28);
            this.cmbLanguage.TabIndex = 12;
            this.cmbLanguage.SelectedIndexChanged += new System.EventHandler(this.cmbLanguage_SelectedIndexChanged);
            // 
            // lnlWebsite
            // 
            this.lnlWebsite.AutoSize = true;
            this.lnlWebsite.BackColor = System.Drawing.Color.Transparent;
            this.lnlWebsite.Font = new System.Drawing.Font("Andalus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lnlWebsite.ForeColor = System.Drawing.Color.Transparent;
            this.lnlWebsite.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.lnlWebsite.LinkColor = System.Drawing.Color.MediumBlue;
            this.lnlWebsite.Location = new System.Drawing.Point(12, 650);
            this.lnlWebsite.Name = "lnlWebsite";
            this.lnlWebsite.Size = new System.Drawing.Size(118, 22);
            this.lnlWebsite.TabIndex = 13;
            this.lnlWebsite.TabStop = true;
            this.lnlWebsite.Text = "Visit our website\r\n";
            this.lnlWebsite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // niInfo
            // 
            this.niInfo.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.niInfo.Icon = ((System.Drawing.Icon)(resources.GetObject("niInfo.Icon")));
            this.niInfo.Text = "Informations Screen";
            this.niInfo.Visible = true;
            // 
            // prb100
            // 
            this.prb100.Location = new System.Drawing.Point(305, 624);
            this.prb100.Name = "prb100";
            this.prb100.Size = new System.Drawing.Size(158, 23);
            this.prb100.Step = 20;
            this.prb100.TabIndex = 14;
            this.prb100.Visible = false;
            // 
            // lbl100
            // 
            this.lbl100.AutoSize = true;
            this.lbl100.BackColor = System.Drawing.Color.Transparent;
            this.lbl100.Font = new System.Drawing.Font("Andalus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl100.ForeColor = System.Drawing.Color.LightGray;
            this.lbl100.Location = new System.Drawing.Point(376, 599);
            this.lbl100.Name = "lbl100";
            this.lbl100.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl100.Size = new System.Drawing.Size(0, 22);
            this.lbl100.TabIndex = 15;
            this.lbl100.Visible = false;
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // frmLoginScreen
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::_07_Project_Bank_System.Properties.Resources.logoeff;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(802, 681);
            this.Controls.Add(this.lbl100);
            this.Controls.Add(this.prb100);
            this.Controls.Add(this.lnlWebsite);
            this.Controls.Add(this.cmbLanguage);
            this.Controls.Add(this.pbFlag);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chkAcceptance);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblNumberOfAttempts);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblAllRightsReserved);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLoginScreen";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLoginScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblAllRightsReserved;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblNumberOfAttempts;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckBox chkAcceptance;
        private System.Windows.Forms.Timer trLoginSuccssfuly;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbFlag;
        private System.Windows.Forms.ComboBox cmbLanguage;
        private System.Windows.Forms.LinkLabel lnlWebsite;
        private System.Windows.Forms.NotifyIcon niInfo;
        private System.Windows.Forms.ProgressBar prb100;
        private System.Windows.Forms.Label lbl100;
        private System.Windows.Forms.ErrorProvider epError;
    }
}

