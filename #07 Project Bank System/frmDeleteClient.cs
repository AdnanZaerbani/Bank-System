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
using System.Security.Principal;

namespace _07_Project_Bank_System
{
    public partial class frmDeleteClient : Form
    {
        public frmDeleteClient()
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSearch.Text) && txtSearch.Text.Length == 4)
            {
                pControls.Visible = true;
                string key = txtSearch.Text.Trim().ToLower();
                var clients = LoadClients();
                var result = clients.Where(c =>
                       c.AccountID.ToLower().Contains(key)
                ).ToList();

                foreach (var c in result)
                {
                    txtAccountID.Text = c.AccountID;
                    txtFullName.Text = c.FullName;
                    mtxtNationalID.Text = c.NationalID;
                    mtxtPhone.Text = c.Phone;
                    txtEmail.Text = c.Email;
                    txtCity.Text = c.City;
                    txtAddress.Text = c.Address;
                    mtxtBalance.Text = c.Balance.ToString();
                    txtCurrency.Text = c.Currency;
                    txtStatus.Text = c.Status;
                    txtCreatedDate.Text = c.CreatedDate;
                    mtxtSecurityCode.Text = c.SecurityCode;
                    txtNotice.Text = c.Notice;
                    if (c.Gender.ToString() == "0")
                    {
                        rbMale.Checked = true;
                    }
                    else
                    {
                        rbFemale.Checked = true;
                    }
                    btnDelete.Enabled = true;
                    txtSearch.Enabled = false;
                    btnSearch.Enabled = false;
                }
                if (result.Count == 0)
                    MessageBox.Show("No Client Found!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                niInfo.BalloonTipIcon = ToolTipIcon.Warning;
                niInfo.BalloonTipTitle = "Wrong";
                niInfo.BalloonTipText = "The Account ID must be four characters long";
                niInfo.ShowBalloonTip(1000);
                MessageBox.Show("The Account ID must be four characters long.", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                txtSearch.Clear();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure about delete this client ? ", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                pControls.Visible = false;
                btnCancel.Visible = false;
                var clients = LoadClients();
                clients = clients.Where(c => c.AccountID != txtAccountID.Text).ToList();
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
                niInfo.BalloonTipText = "The information has been deleted successfully";
                niInfo.ShowBalloonTip(1000);
                SaveClients(clients);
                MessageBox.Show("The information has been deleted successfully.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                Form form = new frmSystem();
                form.Show();
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form form = new frmSystem();
            form.Show();
            this.Close();
        }

        private void btnSearch_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                e.Cancel = false;
                txtSearch.Focus();
                epError.SetError(txtSearch, "The Account ID must be four characters long");
            }
            else
            {
                epError.SetError(txtSearch, "");
            }
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
