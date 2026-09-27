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
    public partial class frmFindUser : Form
    {
        public frmFindUser()
        {
            InitializeComponent();
        }
        int Permission = 0;
        struct stUserData
        {
            public string UserID;
            public string Password;
            public int Permissions;

        };
        const string ListUsers = @"C:\Users\Adnan\Desktop\#07 Project Bank System\#07 Project Bank System\Users.txt";
        string Seperator = "#//#";
        List<stUserData> LoadUsers()
        {
            List<stUserData> Users = new List<stUserData>();

            if (!File.Exists(ListUsers))
                return Users;

            foreach (string line in File.ReadAllLines(ListUsers))
            {
                string[] p = line.Split(new string[] { Seperator }, StringSplitOptions.None);
                if (p.Length < 3) continue;

                stUserData c = new stUserData();
                c.UserID = p[0];
                c.Password = p[1];
                c.Permissions = int.Parse(p[2]);
                Users.Add(c);
            }

            return Users;
        }
        void SaveUsers(List<stUserData> Users)
        {
            List<string> lines = new List<string>();

            foreach (var c in Users)
            {
                lines.Add(c.UserID + Seperator + c.Password + Seperator + c.Permissions);
            }

            File.WriteAllLines(ListUsers, lines);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form form = new frmSystem();
            form.Show();
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSearch.Text) && txtSearch.Text.Length == 5)
            {
                txtUserID.Visible = true;
                mtxtPassword.Visible = true;
                gbPermissions.Visible = true;
                tvPermissions.Visible = true;
                label1.Visible = true;
                label7.Visible = true;
                string key = txtSearch.Text.Trim().ToLower();
                var clients = LoadUsers();
                var result = clients.Where(c =>
                       c.UserID.ToLower().Contains(key)
                ).ToList();

                foreach (var c in result)
                {
                    txtUserID.Text = c.UserID;
                    mtxtPassword.Text = c.Password;
                    Permission = c.Permissions;
                    LoadPermissionsToTree(tvPermissions.Nodes, Permission);
                    txtSearch.Enabled = false;
                    btnSearch.Enabled = false;
                }
                if (result.Count == 0)
                    MessageBox.Show("No User Found!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                niInfo.BalloonTipIcon = ToolTipIcon.Warning;
                niInfo.BalloonTipTitle = "Wrong";
                niInfo.BalloonTipText = "The User ID must be five characters long";
                niInfo.ShowBalloonTip(1000);
                MessageBox.Show("The User ID must be five characters long.", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                txtSearch.Clear();
            }

        }
        void LoadPermissionsToTree(TreeNodeCollection nodes, int permissions)
        {
            foreach (TreeNode node in nodes)
            {
                // إذا العقدة فيها Tag (يعني صلاحية)
                if (node.Tag != null)
                {
                    int perm = int.Parse(node.Tag.ToString());

                    node.Checked = (permissions & perm) == perm;
                }

                // تابع للأبناء
                if (node.Nodes.Count > 0)
                    LoadPermissionsToTree(node.Nodes, permissions);
            }
        }

        private void btnSearch_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                e.Cancel = false;
                txtSearch.Focus();
                epError.SetError(txtSearch, "The User ID must be five characters long");
            }
            else
            {
                epError.SetError(txtSearch, "");
            }
        }

        private void tvPermissions_BeforeCheck(object sender, TreeViewCancelEventArgs e)
        {
            e.Cancel = false;
        }
    }
}
