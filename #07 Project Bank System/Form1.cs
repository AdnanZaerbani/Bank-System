using _07_Project_Bank_System.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace _07_Project_Bank_System
{
    public partial class frmLoginScreen : Form
    {
        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.LightSteelBlue;
        }
        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.LightGray;
        }
        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.LightSteelBlue;
        }
        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.LightGray;
        }
        private void txtUserName_MouseEnter(object sender, EventArgs e)
        {
            txtUserName.BackColor = Color.LightSteelBlue;
        }
        private void txtUserName_MouseLeave(object sender, EventArgs e)
        {
            txtUserName.BackColor = Color.LightGray;
        }
        private void txtPassword_MouseEnter(object sender, EventArgs e)
        {
            txtPassword.BackColor = Color.LightSteelBlue;
        }
        private void txtPassword_MouseLeave(object sender, EventArgs e)
        {
            txtPassword.BackColor = Color.LightGray;
        }
        private void chkAcceptance_MouseEnter(object sender, EventArgs e)
        {
            chkAcceptance.ForeColor = Color.LightSteelBlue;
        }
        private void chkAcceptance_MouseLeave(object sender, EventArgs e)
        {
            chkAcceptance.ForeColor = Color.LightGray;
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lnlWebsite.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.siib.sy/en/");
        }
        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = false;
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                switch (cmbLanguage.SelectedItem.ToString())
                {
                    case "English":
                        epError.SetError(txtUserName, "User Name should have a value!");
                        break;
                    case "Arabic":
                        epError.SetError(txtUserName, "يجب ان يحوي اسم المستخدم على قيمة");
                        break;
                }
            }
            else
            {
                epError.SetError(txtUserName, "");
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = false;
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                switch (cmbLanguage.SelectedItem.ToString())
                {
                    case "English":
                        epError.SetError(txtPassword, "Password should have a value!");
                        break;
                    case "Arabic":
                        epError.SetError(txtPassword, "يجب ان تحوي كلمة السر على قيمة");
                        break;
                }
            }
            else
            {
                epError.SetError(txtPassword, "");
            }
        }
        public frmLoginScreen()
        {
            InitializeComponent();
            lblDate.Text = DateTime.Now.ToString();
            lblDate.BackColor = Color.Transparent;
            lblDate.ForeColor = Color.LightGray;
        }

        private void frmLoginScreen_Load(object sender, EventArgs e)
        {
            cmbLanguage.SelectedIndex = 0;
        }

        private void cmbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbLanguage.SelectedItem.ToString())
            {
                case "English":
                    pbFlag.Image = Resources.English;
                    lblWelcome.Text = "Welcome to Syria International \r\nIslamic Bank\r\n";
                    lblUserName.Text = "User Name : ";
                    lblUserName.RightToLeft = RightToLeft.No;
                    lblPassword.Text = "Password : ";
                    lblPassword.RightToLeft = RightToLeft.No;
                    chkAcceptance.Text = "Acceptance of terms and conditions";
                    chkAcceptance.RightToLeft = RightToLeft.No;
                    btnLogin.Text = "Login";
                    btnExit.Text = "Exit";
                    lblAllRightsReserved.Text = "All Rights Reserved 2025";
                    lnlWebsite.Text = "Visit our Website";
                    break;
                case "Arabic":
                    pbFlag.Image = Resources.Arabic;
                    lblWelcome.Text = "\nاهلا و سهلا بكم في بنك سورية الدولي الاسلامي";
                    lblUserName.Text = "اسم المستخدم :                   ";
                    lblUserName.RightToLeft = RightToLeft.Yes;
                    lblPassword.Text = "كلمة السر :                      ";
                    lblPassword.RightToLeft = RightToLeft.Yes;
                    chkAcceptance.Text = "اوافق على الشروط و الاحكام";
                    chkAcceptance.RightToLeft = RightToLeft.Yes;
                    btnLogin.Text = "تسجيل دخول";
                    btnExit.Text = "خروج";
                    lblAllRightsReserved.Text = "    جميع الحقوق محفوظة 2025";
                    lnlWebsite.Text = "زوروا موقعنا الالكتروني";
                    break;
            }
        }

        const string Users = @"C:\Users\Adnan\Desktop\#07 Project Bank System\#07 Project Bank System\Users.txt";
        string Seperator = "#//#";
        sbyte NumberOfAttempts = 3;

        struct stUsersData
        {
          public string UsersName;
          public string Password;
        };

        private void UnLoggedIn()
        {
            txtUserName.Clear();
            txtPassword.Clear();
            lblNumberOfAttempts.Visible = true;
            NumberOfAttempts--;
            lblNumberOfAttempts.BackColor = Color.IndianRed;
            lblNumberOfAttempts.ForeColor = Color.White;
            switch (cmbLanguage.SelectedItem.ToString())
            {
                case "English":
                    lblNumberOfAttempts.Text = "Incorrect username or password.\nYou have " + NumberOfAttempts.ToString() + " of attempts remaining.";
                    lblNumberOfAttempts.RightToLeft = RightToLeft.No;
                    niInfo.BalloonTipTitle = "Input Error";
                    niInfo.BalloonTipText = "Incorrect username or password.\nYou have " + NumberOfAttempts.ToString() + " of attempts remaining.";
                    break;
                case "Arabic":
                    lblNumberOfAttempts.Text = " خطأ في اسم المستخدم او كلمة السر. تبقى \nلديك" + NumberOfAttempts.ToString() + "من المحاولات";
                    lblNumberOfAttempts.RightToLeft = RightToLeft.Yes;
                    niInfo.BalloonTipTitle = "خطأ في الادخال";
                    niInfo.BalloonTipText = " خطأ في اسم المستخدم او كلمة السر. تبقى \nلديك " + NumberOfAttempts.ToString() + " من المحاولات";
                    break;
            }
            niInfo.BalloonTipIcon = ToolTipIcon.Warning;
            niInfo.ShowBalloonTip(100);
        }
        private void LoggedIn()
        {
            cmbLanguage.Visible = false;
            lnlWebsite.Visible = false;
            txtUserName.Enabled = false;
            txtPassword.Enabled = false;
            chkAcceptance.Enabled = false;
            btnLogin.Enabled = false;
            lblNumberOfAttempts.Visible = true;
            lblNumberOfAttempts.BackColor = Color.Green;
            lblNumberOfAttempts.ForeColor = Color.White;
            lbl100.Visible = true;
            prb100.Visible = true;
            switch (cmbLanguage.SelectedItem.ToString())
            {
                case "English":
                    lblNumberOfAttempts.Text = "Login successful.\nPlease wait a moment.";
                    lblNumberOfAttempts.RightToLeft= RightToLeft.No;
                    niInfo.BalloonTipTitle = "Login successful. Please wait a moment.";
                    niInfo.BalloonTipText = "User Name : " + txtUserName.Text;
                    break; 
                case "Arabic":
                    lblNumberOfAttempts.Text = "تم تسجيل الدخول بنجاح. انتظر لحظة";
                    lblNumberOfAttempts.TextAlign = ContentAlignment.MiddleRight;
                    lblNumberOfAttempts.RightToLeft = RightToLeft.Yes;
                    niInfo.BalloonTipTitle = "تم تسجيل الدخول بنجاح. انتظر لحظة";
                    niInfo.BalloonTipText = "اسم المستخدم : " + txtUserName.Text;
                    break;
            }
            niInfo.BalloonTipIcon = ToolTipIcon.Info;
            niInfo.ShowBalloonTip(3000);
            for (int i = 0; i <= 3; i++)
            {
                Thread.Sleep(500);
                prb100.Value += 25;
                lbl100.Text = (((float)prb100.Value / prb100.Maximum) * 100) + "%";
                prb100.Refresh();
                lbl100.Refresh();
            }
        }
        private void SystemLock()
        {
            txtUserName.Clear();
            txtPassword.Clear();
            lblNumberOfAttempts.Visible = true;
            lblNumberOfAttempts.BackColor = Color.IndianRed;
            lblNumberOfAttempts.ForeColor = Color.White;
            switch (cmbLanguage.SelectedItem.ToString())
            {
                case "English":
                    lblNumberOfAttempts.Text = "You have used up your number of attempts.\nThe system is locked.";
                    lblNumberOfAttempts.RightToLeft = RightToLeft.No;
                    niInfo.BalloonTipTitle = "The system is locked";
                    niInfo.BalloonTipText = "You have used up your number of attempts";
                    break;
                case "Arabic":
                    lblNumberOfAttempts.Text = "تم استخدام جميع المحاولات. النظام مقفل";
                    lblNumberOfAttempts.RightToLeft = RightToLeft.Yes;
                    niInfo.BalloonTipTitle = "النظام مقفل";
                    niInfo.BalloonTipText = "تم استخدام جميع المحاولات";
                    break;
            }
            niInfo.BalloonTipIcon = ToolTipIcon.Error;
            niInfo.ShowBalloonTip(3000);
            btnLogin.Enabled = false;
            txtPassword.Enabled = false;
            txtUserName.Enabled = false;
            chkAcceptance.Enabled = false;
            cmbLanguage.Enabled = false;
            lnlWebsite.Enabled = false;
        }
        private void chkAcceptance_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAcceptance.Checked)
            {
                btnLogin.Enabled = true;
            }

            if (chkAcceptance.Checked == false)
            {
                btnLogin.Enabled = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            stUsersData data = new stUsersData();
            data.UsersName = txtUserName.Text.Trim();
            data.Password = txtPassword.Text.Trim();
            string[] lines = File.ReadAllLines(Users);

            bool isValid = lines.Any(line =>
            {
                var parts = line.Split(new string[] { Seperator }, StringSplitOptions.None);

                return parts.Length >= 3 &&
                       parts[0].Trim() == data.UsersName &&
                       parts[1].Trim() == data.Password;
            });

            if (NumberOfAttempts == 1)
            {
                SystemLock();
            }
            else if (isValid)
            {
                foreach (string line in File.ReadAllLines(Users))
                {
                    string[] p = line.Split(new string[] { Seperator }, StringSplitOptions.None);
                    if (p.Length < 3) continue;

                    if (p[0] == txtUserName.Text && p[1] == txtPassword.Text)
                    {
                        clsGlobal.Permissions = Convert.ToInt32(p[2]);
                    }
                }
                LoggedIn();
                trLoginSuccssfuly.Enabled = true;
            }
            else
            {
                UnLoggedIn();
            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void trLoginSuccssfuly_Tick(object sender, EventArgs e)
        {
            NumberOfAttempts = 0;
            while (NumberOfAttempts == 3)
            {
                NumberOfAttempts++;
            }
            trLoginSuccssfuly.Enabled = false;
            Form form = new frmSystem();
            form.Show();
            this.Hide();
        }
    }

    
}
