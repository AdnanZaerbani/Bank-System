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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _07_Project_Bank_System
{
    public partial class frmSystem : Form
    {
        enum enPermissions
        {
            Show_Client_List = 1, Add_New_Client = 2, Delete_Client = 4, Update_Client = 8, Find_Client = 16, Transactions = 32, Mange_Users = 64, Full_Access = 127
        }
        public frmSystem()
        {
            InitializeComponent();
            lblWelcome.Text = "Search by Account ID : ";
            btnFillClients.Enabled = true;
            lsvClients.View = View.Details;
            lsvClients.FullRowSelect = true;
            lsvClients.GridLines = true;
            lsvClients.Columns.Add("M/F", 60);
            lsvClients.Columns.Add("Account ID", 100);
            lsvClients.Columns.Add("Full Name", 300);
            lsvClients.Columns.Add("National ID", 110);
            lsvClients.Columns.Add("Phone", 115);
            lsvClients.Columns.Add("Email", 215);
            lsvClients.Columns.Add("City", 100);
            lsvClients.Columns.Add("Address", 120);
            lsvClients.Columns.Add("Balance", 200);
            lsvClients.Columns.Add("Currency", 85);
            lsvClients.Columns.Add("Status", 70);
            lsvClients.Columns.Add("Created Date", 120);
            lsvClients.Columns.Add("Security Code", 120);
            lsvClients.Columns.Add("Notice", 235);
            lsvUsers.Columns.Add("User ID", 100);
            lsvUsers.Columns.Add("Password", 100);
            lsvUsers.Columns.Add("Permissions", 770);
            
        }
        struct stUsersData
        {
            public string UsersName;
            public string Password;
            public int Permissions;
        };

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
        const string Users = @"C:\Users\Adnan\Desktop\#07 Project Bank System\#07 Project Bank System\Users.txt";
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

        List<stUsersData> LoadUsers()
        {
            List<stUsersData> User = new List<stUsersData>();

            if (!File.Exists(Users))
                return User;

            foreach (string line in File.ReadAllLines(Users))
            {
                string[] p = line.Split(new string[] { Seperator }, StringSplitOptions.None);
                if (p.Length < 3) continue;

                stUsersData c = new stUsersData();
                c.UsersName = p[0];
                c.Password = p[1];
                c.Permissions = int.Parse(p[2]);
                User.Add(c);
            }

            return User;
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

        void FillListView()
        {
            lsvClients.Items.Clear();

            var clients = LoadClients();

            foreach (var c in clients)
            {
                ListViewItem item = new ListViewItem();
                if (c.Gender == 0)
                {
                    item.ImageIndex = 0;
                }
                else
                {
                    item.ImageIndex = 1;
                }
                item.SubItems.Add(c.AccountID);
                item.SubItems.Add(c.FullName);
                item.SubItems.Add(c.NationalID);
                item.SubItems.Add(c.Phone);
                item.SubItems.Add(c.Email);
                item.SubItems.Add(c.City);
                item.SubItems.Add(c.Address);
                item.SubItems.Add(c.Balance.ToString());
                item.SubItems.Add(c.Currency);
                item.SubItems.Add(c.Status);
                item.SubItems.Add(c.CreatedDate);
                item.SubItems.Add(c.SecurityCode);
                item.SubItems.Add(c.Notice);
                lsvClients.Items.Add(item);
            }
        }

        private void btnFillClients_Click(object sender, EventArgs e)
        {
            if ((clsGlobal.Permissions & (int)enPermissions.Full_Access) == ((int)enPermissions.Full_Access) || (clsGlobal.Permissions & (int)enPermissions.Show_Client_List) == ((int)enPermissions.Show_Client_List))
            {
                lsvClients.Items.Clear();
                if (!File.Exists(ClientList))
                {
                    MessageBox.Show("File not found!");
                    return;
                }

                foreach (string line in File.ReadLines(ClientList))
                {
                    string[] p = line.Split(new string[] { "#//#" }, StringSplitOptions.None);
                    if (p.Length < 14) continue;

                    ListViewItem item = new ListViewItem();
                    if (Convert.ToInt32(p[1]) == 0)
                    {
                        item.ImageIndex = 0;
                    }
                    else
                    {
                        item.ImageIndex = 1;
                    }
                    item.SubItems.Add(p[0]);
                    item.SubItems.Add(p[2]);
                    item.SubItems.Add(p[3]);
                    item.SubItems.Add(p[4]);
                    item.SubItems.Add(p[5]);
                    item.SubItems.Add(p[6]);
                    item.SubItems.Add(p[7]);
                    item.SubItems.Add(p[8]);
                    item.SubItems.Add(p[9]);
                    item.SubItems.Add(p[10]);
                    item.SubItems.Add(p[11]);
                    item.SubItems.Add(p[12]);
                    item.SubItems.Add(p[13]);
                    lsvClients.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("Access Denied !\nContact the administrator", "Fill Client", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (lblWelcome.Text == "Search by Account ID : ")
            {
                if (!string.IsNullOrWhiteSpace(txtSearch.Text) && txtSearch.Text.Length == 4)
                {
                    string key = txtSearch.Text.Trim().ToLower();
                    var clients = LoadClients();

                    var result = clients.Where(c =>
                           c.AccountID.ToLower().Contains(key)

                    ).ToList();

                    lsvClients.Items.Clear();

                    foreach (var c in result)
                    {
                        ListViewItem item = new ListViewItem();
                        if (c.Gender == 0)
                        {
                            item.ImageIndex = 0;
                        }
                        else
                        {
                            item.ImageIndex = 1;
                        }
                        item.SubItems.Add(c.AccountID);
                        item.SubItems.Add(c.FullName);
                        item.SubItems.Add(c.NationalID);
                        item.SubItems.Add(c.Phone);
                        item.SubItems.Add(c.Email);
                        item.SubItems.Add(c.City);
                        item.SubItems.Add(c.Address);
                        item.SubItems.Add(c.Balance.ToString());
                        item.SubItems.Add(c.Currency);
                        item.SubItems.Add(c.Status);
                        item.SubItems.Add(c.CreatedDate);
                        item.SubItems.Add(c.SecurityCode);
                        item.SubItems.Add(c.Notice);
                        lsvClients.Items.Add(item);
                    }

                    if (result.Count == 0)
                        MessageBox.Show("No Client Found!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    MessageBox.Show("The Account ID must be four characters long.", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
            }
            else if (lblWelcome.Text == "Search by User ID : ")
            {
                if (!string.IsNullOrWhiteSpace(txtSearch.Text) && txtSearch.Text.Length == 5)
                {
                    string key = txtSearch.Text.Trim().ToLower();
                    var Users = LoadUsers();

                    var result = Users.Where(c =>
                           c.UsersName.ToLower().Contains(key)

                    ).ToList();

                    lsvUsers.Items.Clear();

                    foreach (var c in result)
                    {
                        ListViewItem item = new ListViewItem(c.UsersName);
                        item.SubItems.Add(c.Password);
                        item.SubItems.Add(c.Permissions.ToString());
                        lsvUsers.Items.Add(item);
                    }

                    if (result.Count == 0)
                        MessageBox.Show("No User Found!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    MessageBox.Show("The User ID must be five characters long.", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
            }

        }

        private void updateClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((clsGlobal.Permissions & (int)enPermissions.Full_Access) == ((int)enPermissions.Full_Access) || (clsGlobal.Permissions & (int)enPermissions.Update_Client) == ((int)enPermissions.Update_Client))
            {
                Form frm = new frmUpdateClient();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Access Denied !\nContact the administrator", "Update Client", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        private void updateClientToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if ((clsGlobal.Permissions & (int)enPermissions.Full_Access) == ((int)enPermissions.Full_Access) || (clsGlobal.Permissions & (int)enPermissions.Update_Client) == ((int)enPermissions.Update_Client))
            {
                Form frm = new frmUpdateClient();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Access Denied !\nContact the administrator", "Update Client", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }
        private void addNewClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((clsGlobal.Permissions & (int)enPermissions.Full_Access) == ((int)enPermissions.Full_Access) || (clsGlobal.Permissions & (int)enPermissions.Add_New_Client) == ((int)enPermissions.Add_New_Client))
            {
                Form form = new frmAddNewClient();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Access Denied !\nContact the administrator", "Add New Client", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        private void addNewClientToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if ((clsGlobal.Permissions & (int)enPermissions.Full_Access) == ((int)enPermissions.Full_Access) || (clsGlobal.Permissions & (int)enPermissions.Add_New_Client) == ((int)enPermissions.Add_New_Client))
            {
                Form form = new frmAddNewClient();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Access Denied !\nContact the administrator", "Add New Client", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        private void deleteClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((clsGlobal.Permissions & (int)enPermissions.Full_Access) == ((int)enPermissions.Full_Access) || (clsGlobal.Permissions & (int)enPermissions.Delete_Client) == ((int)enPermissions.Delete_Client))
            {
                Form form = new frmDeleteClient();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Access Denied !\nContact the administrator", "Delete Client", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        private void deleteClientToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if ((clsGlobal.Permissions & (int)enPermissions.Full_Access) == ((int)enPermissions.Full_Access) || (clsGlobal.Permissions & (int)enPermissions.Delete_Client) == ((int)enPermissions.Delete_Client))
            {
                Form form = new frmDeleteClient();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Access Denied !\nContact the administrator", "Delete Client", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        private void findClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((clsGlobal.Permissions & (int)enPermissions.Full_Access) == ((int)enPermissions.Full_Access) || (clsGlobal.Permissions & (int)enPermissions.Find_Client) == ((int)enPermissions.Find_Client))
            {
                Form form = new frmFindClient();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Access Denied !\nContact the administrator", "Find Client", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            
        }

        private void findClientToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if ((clsGlobal.Permissions & (int)enPermissions.Full_Access) == ((int)enPermissions.Full_Access) || (clsGlobal.Permissions & (int)enPermissions.Find_Client) == ((int)enPermissions.Find_Client))
            {
                Form form = new frmFindClient();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Access Denied !\nContact the administrator", "Find Client", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        private void depositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((clsGlobal.Permissions & (int)enPermissions.Full_Access) == ((int)enPermissions.Full_Access) || (clsGlobal.Permissions & (int)enPermissions.Transactions) == ((int)enPermissions.Transactions))
            {
                Form form = new frmDepWith();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Access Denied !\nContact the administrator", "Transaction Client", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        private void depositToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if ((clsGlobal.Permissions & (int)enPermissions.Full_Access) == ((int)enPermissions.Full_Access) || (clsGlobal.Permissions & (int)enPermissions.Transactions) == ((int)enPermissions.Transactions))
            {
                Form form = new frmDepWith();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Access Denied !\nContact the administrator", "Transaction Client", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        private void totalBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((clsGlobal.Permissions & (int)enPermissions.Full_Access) == ((int)enPermissions.Full_Access) || (clsGlobal.Permissions & (int)enPermissions.Transactions) == ((int)enPermissions.Transactions))
            {
                Form form = new frmTotalBalance();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Access Denied !\nContact the administrator", "Transaction Client", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            
        }

        private void totalBalanceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if ((clsGlobal.Permissions & (int)enPermissions.Full_Access) == ((int)enPermissions.Full_Access) || (clsGlobal.Permissions & (int)enPermissions.Transactions) == ((int)enPermissions.Transactions))
            {
                Form form = new frmTotalBalance();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Access Denied !\nContact the administrator", "Transaction Client", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnFillUsers_Click(object sender, EventArgs e)
        {
            if ((clsGlobal.Permissions & (int)enPermissions.Full_Access) == ((int)enPermissions.Full_Access) || (clsGlobal.Permissions & (int)enPermissions.Mange_Users) == ((int)enPermissions.Mange_Users))
            {
                lsvUsers.Items.Clear();
                if (!File.Exists(Users))
                {
                    MessageBox.Show("File not found!");
                    return;
                }

                foreach (string line in File.ReadLines(Users))
                {
                    string[] p = line.Split(new string[] { "#//#" }, StringSplitOptions.None);
                    if (p.Length < 3) continue;

                    ListViewItem item = new ListViewItem(p[0]);
                    item.SubItems.Add(p[1]);
                    item.SubItems.Add(p[2]);
                    lsvUsers.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("Access Denied !\nContact the administrator", "Fill User", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        private void tbcManagment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcManagment.SelectedIndex == 0)
            {
                lblWelcome.Text = "Search by Account ID : ";
                lsvUsers.Items.Clear();
                txtSearch.Clear();
            }
            else if (tbcManagment.SelectedIndex == 1)
            {
                lblWelcome.Text = "Search by User ID : ";
                lsvClients.Items.Clear();
                txtSearch.Clear();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form form = new frmLoginScreen();
            form.Show();
            this.Close();
            
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((clsGlobal.Permissions & (int)enPermissions.Full_Access) == ((int)enPermissions.Full_Access) || (clsGlobal.Permissions & (int)enPermissions.Mange_Users) == ((int)enPermissions.Mange_Users))
            {
                Form form = new frmAddNewUser();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Access Denied !\nContact the administrator", "Add New User", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if ((clsGlobal.Permissions & (int)enPermissions.Full_Access) == ((int)enPermissions.Full_Access) || (clsGlobal.Permissions & (int)enPermissions.Mange_Users) == ((int)enPermissions.Mange_Users))
            {
                Form form = new frmAddNewUser();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Access Denied !\nContact the administrator", "Add New User", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((clsGlobal.Permissions & (int)enPermissions.Full_Access) == ((int)enPermissions.Full_Access) || (clsGlobal.Permissions & (int)enPermissions.Mange_Users) == ((int)enPermissions.Mange_Users))
            {
                Form form = new frmDeleteUser();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Access Denied !\nContact the administrator", "Delete User", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if ((clsGlobal.Permissions & (int)enPermissions.Full_Access) == ((int)enPermissions.Full_Access) || (clsGlobal.Permissions & (int)enPermissions.Mange_Users) == ((int)enPermissions.Mange_Users))
            {
                Form form = new frmDeleteUser();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Access Denied !\nContact the administrator", "Delete User", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        private void findUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((clsGlobal.Permissions & (int)enPermissions.Full_Access) == ((int)enPermissions.Full_Access) || (clsGlobal.Permissions & (int)enPermissions.Mange_Users) == ((int)enPermissions.Mange_Users))
            {
                Form form = new frmUpdateUser();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Access Denied !\nContact the administrator", "Update User", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if ((clsGlobal.Permissions & (int)enPermissions.Full_Access) == ((int)enPermissions.Full_Access) || (clsGlobal.Permissions & (int)enPermissions.Mange_Users) == ((int)enPermissions.Mange_Users))
            {
                Form form = new frmUpdateUser();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Access Denied !\nContact the administrator", "Update User", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            if ((clsGlobal.Permissions & (int)enPermissions.Full_Access) == ((int)enPermissions.Full_Access) || (clsGlobal.Permissions & (int)enPermissions.Mange_Users) == ((int)enPermissions.Mange_Users))
            {
                Form form = new frmFindUser();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Access Denied !\nContact the administrator", "Find User", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        private void findUserToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if ((clsGlobal.Permissions & (int)enPermissions.Full_Access) == ((int)enPermissions.Full_Access) || (clsGlobal.Permissions & (int)enPermissions.Mange_Users) == ((int)enPermissions.Mange_Users))
            {
                Form form = new frmFindUser();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Access Denied !\nContact the administrator", "Find User", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
