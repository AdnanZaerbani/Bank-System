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
    public partial class frmAddNewUser : Form
    {
        public frmAddNewUser()
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
        const string ListUsers= @"C:\Users\Adnan\Desktop\#07 Project Bank System\#07 Project Bank System\Users.txt";
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


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure about add this user ? ", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                btnCancel.Visible = false;
                gbPermissions.Visible = false;
                var Users = LoadUsers();
                stUserData c = new stUserData();
                c.UserID = txtUserID.Text;
                c.Password = mtxtPassword.Text;
                c.Permissions = Permission;
                Users.Add(c);
                SaveUsers(Users);
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

        private bool CheckAccountID()
        {
            btnAdd.Enabled = false;
            stUserData data = new stUserData();
            data.UserID = txtUserID.Text.Trim();

            string[] lines = File.ReadAllLines(ListUsers);

            bool isValid = lines.Any(line =>
            {
                var parts = line.Split(new string[] { Seperator }, StringSplitOptions.None);

                return parts.Length >= 2 &&
                       parts[0].Trim() == data.UserID;
            });
            if (isValid)
            {
                return false;
            }
            return true;
        }

        private void txtUserID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserID.Text) || txtUserID.Text.Length != 5)
            {
                e.Cancel = false;
                txtUserID.Focus();
                epError.SetError(txtUserID, "The User ID has been used");
            }
            else
            {
                epError.SetError(txtUserID, "");
                if (CheckAccountID())
                {
                    btnAdd.Enabled = true;
                }
                else
                {
                    e.Cancel = false;
                    txtUserID.Focus();
                    epError.SetError(txtUserID, "The User ID has been used");
                }
            }
        }

        private void mtxtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mtxtPassword.Text) || mtxtPassword.Text.Length != 4)
            {
                e.Cancel = false;
                mtxtPassword.Focus();
                epError.SetError(mtxtPassword, "The Password must be four number long");
            }
            else
            {
                epError.SetError(mtxtPassword, "");
            }
        }
    }
}
