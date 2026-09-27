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
    public partial class frmDepWith : Form
    {
        public frmDepWith()
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
                    
                    mtxtBalance.Text = c.Balance.ToString();
                    txtCurrency.Text = c.Currency;
                    txtStatus.Text = c.Status;
                    
                    txtNotice.Text = c.Notice;
                    txtSearch.Enabled = false;
                    btnSearch.Enabled = false;
                    btnDone.Visible = true;
                    
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

        private void btnDepWith_Click(object sender, EventArgs e)
        {
            pControls.Visible = false;
            btnCancel.Visible = false;
            var clients = LoadClients();

            for (int i = 0; i < clients.Count; i++)
            {
                stClientData c = clients[i];
                if (c.AccountID == txtSearch.Text)
                {
                    c.FullName = txtFullName.Text;
                    c.NationalID = mtxtNationalID.Text;
                    c.Balance = float.Parse(mtxtNewBalance.Text);
                    c.Currency = txtCurrency.Text;
                    c.Status = txtStatus.Text;
                    c.Notice = txtNotice.Text;
                    if (rbDeposit.Checked)
                    {
                        c.Gender = 0;
                    }
                    else
                    {
                        c.Gender = 1;
                    }
                    clients[i] = c;
                    break;
                }
            }
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
            niInfo.BalloonTipText = "The transaction has been successfully";
            niInfo.ShowBalloonTip(1000);
            SaveClients(clients);
            MessageBox.Show("The transaction has been successfully.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            Form form = new frmSystem();
            form.Show();
            this.Close();
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            if (rbDeposit.Checked)
            {
                mtxtNewBalance.Text = Convert.ToString(float.Parse(mtxtBalance.Text) + float.Parse(mtxtTransaction.Text));
                if (MessageBox.Show("Are you sure about of transaction ?", "Noitce", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    btnDone.Enabled = true;
                    btnCancel.Enabled = false;
                    btnTransaction.Enabled = false;
                    mtxtTransaction.Enabled = false;
                    rbDeposit.Enabled = false;
                    rbWithdraw.Enabled = false;
                    txtNotice.Enabled = false;
                }
            }
            else
            {
                if (float.Parse(mtxtBalance.Text) >= float.Parse(mtxtTransaction.Text))
                {
                    mtxtNewBalance.Text = Convert.ToString(float.Parse(mtxtBalance.Text) - float.Parse(mtxtTransaction.Text));
                    if (MessageBox.Show("Are you sure about of transaction ?", "Noitce", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        btnDone.Enabled = true;
                        btnCancel.Enabled = false;
                        btnTransaction.Enabled = false;
                        mtxtTransaction.Enabled = false;
                        rbDeposit.Enabled = false;
                        rbWithdraw.Enabled = false;
                        txtNotice.Enabled = false;
                    }
                }
                else
                {
                    mtxtTransaction.Clear();
                    MessageBox.Show("You cann't withdraw this amount from the account !", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
            }

            
        }

        private void mtxtTransaction_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mtxtTransaction.Text))
            {
                e.Cancel = false;
                mtxtTransaction.Focus();
                epError.SetError(mtxtTransaction, "Balance should have a value");
            }
            else
            {
                epError.SetError(mtxtTransaction, "");
            }
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
    }
}
