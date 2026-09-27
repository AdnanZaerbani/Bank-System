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

namespace _07_Project_Bank_System
{
    public partial class frmFindClient : Form
    {
        public frmFindClient()
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
        private void btnBack_Click(object sender, EventArgs e)
        {
            Form form = new frmSystem();
            form.Show();
            this.Close();
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
    }
}
