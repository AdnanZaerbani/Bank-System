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
    public partial class frmUpdateUser : Form
    {
        public frmUpdateUser()
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
                    btnUpdate.Enabled = true;
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
                epError.SetError(txtSearch, "The User ID must be five characters long");
            }
            else
            {
                epError.SetError(txtSearch, "");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure about update this user ? ", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                btnCancel.Visible = false;
                var Users = LoadUsers();

                for (int i = 0; i < Users.Count; i++)
                {
                    stUserData c = Users[i];
                    if (c.UserID == txtSearch.Text)
                    {
                        c.UserID = txtUserID.Text;
                        c.Password = mtxtPassword.Text;
                        c.Permissions = Permission;
                        Users[i] = c;
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
                niInfo.BalloonTipText = "The information has been updated successfully";
                niInfo.ShowBalloonTip(1000);
                SaveUsers(Users);
                MessageBox.Show("The information has been updated successfully.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                Form form = new frmSystem();
                form.Show();
                this.Close();
            }
        }

        private void tvPermissions_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Action == TreeViewAction.Unknown)
                return;

            CheckUncheckChildren(e.Node, e.Node.Checked);

            UpdatePermissions(e.Node);

            UpdateParents(e.Node);
        }

        void CheckUncheckChildren(TreeNode node, bool check)
        {
            foreach (TreeNode child in node.Nodes)
            {
                child.Checked = check;
                CheckUncheckChildren(child, check);
            }
        }

        void UpdatePermissions(TreeNode node)
        {
            if (node.Tag != null)
            {
                int perm = Convert.ToInt32((string)node.Tag);

                if (node.Checked)
                    Permission |= perm;
                else
                    Permission &= ~perm;
            }

            foreach (TreeNode child in node.Nodes)
                UpdatePermissions(child);

        }

        void UpdateParents(TreeNode node)
        {
            if (node.Parent == null)
                return;

            bool allChecked = true;

            foreach (TreeNode sibling in node.Parent.Nodes)
            {
                if (!sibling.Checked)
                {
                    allChecked = false;
                    break;
                }
            }

            node.Parent.Checked = allChecked;
            UpdateParents(node.Parent);
        }
    }
}
