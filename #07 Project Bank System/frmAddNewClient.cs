using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace _07_Project_Bank_System
{
    public partial class frmAddNewClient : Form
    {
        public frmAddNewClient()
        {
            InitializeComponent();
        }

        struct stClientData
        {
            public int Gender;
            public string AccountID;
            public string FullName;
            public string NationalID;
            public string Phone;
            public string Email;
            public string City;
            public string Address;
            public float Balance;
            public string Currency;
            public string Status;
            public string CreatedDate;
            public string SecurityCode;
            public string Notice;
        };
        const string ClientList = @"C:\Users\Adnan\Desktop\#07 Project Bank System\#07 Project Bank System\ClientList.txt";
        string Seperator = "#//#";
        List<stClientData> LoadClients()
        {
            List<stClientData> clients = new List<stClientData>();

            if (!File.Exists(ClientList))
                return clients;

            foreach (string line in File.ReadAllLines(ClientList))
            {
                string[] p = line.Split(new string[] { Seperator }, StringSplitOptions.None);
                if (p.Length < 14) continue;

                stClientData c = new stClientData();
                c.AccountID = p[0];
                c.Gender = int.Parse(p[1]);
                c.FullName = p[2];
                c.NationalID = p[3];
                c.Phone = p[4];
                c.Email = p[5];
                c.City = p[6];
                c.Address = p[7];
                c.Balance = float.Parse(p[8]);
                c.Currency = p[9];
                c.Status = p[10];
                c.CreatedDate = p[11];
                c.SecurityCode = p[12];
                c.Notice = p[13];
                clients.Add(c);
            }

            return clients;
        }

        void SaveClients(List<stClientData> clients)
        {
            List<string> lines = new List<string>();

            foreach (var c in clients)
            {
                lines.Add(
                    c.AccountID + Seperator +
                    c.Gender + Seperator +
                    c.FullName + Seperator +
                    c.NationalID + Seperator +
                    c.Phone + Seperator +
                    c.Email + Seperator +
                    c.City + Seperator +
                    c.Address + Seperator +
                    c.Balance + Seperator +
                    c.Currency + Seperator +
                    c.Status + Seperator +
                    c.CreatedDate + Seperator +
                    c.SecurityCode + Seperator +
                    c.Notice);
            }

            File.WriteAllLines(ClientList, lines);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form form = new frmSystem();
            form.Show();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure about add this client ? ","Notice",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                pControls.Visible = false;
                btnCancel.Visible = false;
                var clients = LoadClients();
                stClientData c = new stClientData();
                c.AccountID = txtAccountID.Text;
                c.FullName = txtFullName.Text;
                c.NationalID = mtxtNationalID.Text;
                c.Phone = mtxtPhone.Text;
                c.Email = txtEmail.Text;
                c.City = txtCity.Text;
                c.Address = txtAddress.Text;
                c.Balance = float.Parse(mtxtBalance.Text);
                c.Currency = txtCurrency.Text;
                c.Status = txtStatus.Text;
                c.CreatedDate = DateTime.Now.ToShortDateString();
                c.SecurityCode = mtxtSecurityCode.Text;
                c.Notice = txtNotice.Text;
                if (rbMale.Checked)
                {
                    c.Gender = 0;
                }
                else
                {
                    c.Gender = 1;
                }
                clients.Add(c);
                SaveClients(clients);
                pbUpdated.Visible = true;
                lblUpdated.Visible = true;
                for (int i = 0; i <= 3; i++)
                {
                    Thread.Sleep(500);
                    pbUpdated.Value += 25;
                    lblUpdated.Text = (((float)pbUpdated.Value / pbUpdated.Maximum) * 100) + "%";
                    pbUpdated.Refresh();
                    lblUpdated.Refresh();
                }
                niInfo.BalloonTipIcon = ToolTipIcon.Info;
                niInfo.BalloonTipTitle = "Done";
                niInfo.BalloonTipText = "The information has been Added successfully";
                niInfo.ShowBalloonTip(1000);
                MessageBox.Show("The information has been Added successfully.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                Form form = new frmSystem();
                form.Show();
                this.Close();
            }
        }

        private void mtxtNationalID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mtxtNationalID.Text) || mtxtNationalID.Text.Length != 9)
            {
                e.Cancel = false;
                mtxtNationalID.Focus();
                epError.SetError(mtxtNationalID, "The National ID must be Nine Number long");
            }
            else
            {
                epError.SetError(mtxtNationalID, "");
            }
        }

        private void mtxtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mtxtPhone.Text) || mtxtPhone.Text.Length != 10)
            {
                e.Cancel = false;
                mtxtPhone.Focus();
                epError.SetError(mtxtPhone, "The Phone number must be Ten number long");
            }
            else
            {
                epError.SetError(mtxtPhone, "");
            }
        }

        private void mtxtBalance_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mtxtBalance.Text))
            {
                e.Cancel = false;
                mtxtBalance.Focus();
                epError.SetError(mtxtBalance, "Balance should have a value");
            }
            else
            {
                epError.SetError(mtxtBalance, "");
            }
        }

        private void mtxtSecurityCode_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mtxtSecurityCode.Text) || mtxtSecurityCode.Text.Length != 4)
            {
                e.Cancel = false;
                mtxtSecurityCode.Focus();
                epError.SetError(mtxtSecurityCode, "The Security Code must be four number long");
            }
            else
            {
                epError.SetError(mtxtSecurityCode, "");
            }
        }

        private void txtAccountID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAccountID.Text) || txtAccountID.Text.Length != 4)
            {
                e.Cancel = false;
                txtAccountID.Focus();
                epError.SetError(txtAccountID, "The Account ID has been used");
            }
            else
            {
                epError.SetError(txtAccountID, "");
                if (CheckAccountID())
                {
                    btnAdd.Enabled = true;
                }
                else
                {
                    e.Cancel = false;
                    txtAccountID.Focus();
                    epError.SetError(txtAccountID, "The Account ID has been used");
                }
            }
        }

        private bool CheckAccountID()
        {
            btnAdd.Enabled = false;
            stClientData data = new stClientData();
            data.AccountID = txtAccountID.Text.Trim();

            string[] lines = File.ReadAllLines(ClientList);

            bool isValid = lines.Any(line =>
            {
                var parts = line.Split(new string[] { Seperator }, StringSplitOptions.None);

                return parts.Length >= 2 &&
                       parts[0].Trim() == data.AccountID;
            });
            if (isValid)
            {
                return false;
            }
            return true;
        }
    }
}
