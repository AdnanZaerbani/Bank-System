namespace _07_Project_Bank_System
{
    partial class frmUpdateUser
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Show Client List");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Add New Client");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Delete Client");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Update Client");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Find Client");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Transaction");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Mange Client", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Mange User");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Full Access", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateUser));
            this.lblUpdated = new System.Windows.Forms.Label();
            this.pbUpdated = new System.Windows.Forms.ProgressBar();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.mtxtPassword = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.gbPermissions = new System.Windows.Forms.GroupBox();
            this.tvPermissions = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.niInfo = new System.Windows.Forms.NotifyIcon(this.components);
            this.gbPermissions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUpdated
            // 
            this.lblUpdated.AutoSize = true;
            this.lblUpdated.BackColor = System.Drawing.Color.Transparent;
            this.lblUpdated.Font = new System.Drawing.Font("Andalus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblUpdated.ForeColor = System.Drawing.Color.LightGray;
            this.lblUpdated.Location = new System.Drawing.Point(426, 556);
            this.lblUpdated.Name = "lblUpdated";
            this.lblUpdated.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUpdated.Size = new System.Drawing.Size(0, 30);
            this.lblUpdated.TabIndex = 74;
            this.lblUpdated.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUpdated.Visible = false;
            // 
            // pbUpdated
            // 
            this.pbUpdated.Location = new System.Drawing.Point(249, 548);
            this.pbUpdated.Name = "pbUpdated";
            this.pbUpdated.Size = new System.Drawing.Size(171, 46);
            this.pbUpdated.TabIndex = 73;
            this.pbUpdated.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightGray;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Andalus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(554, 548);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(171, 46);
            this.btnCancel.TabIndex = 72;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightGray;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Andalus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(12, 546);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(152, 48);
            this.btnUpdate.TabIndex = 71;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // mtxtPassword
            // 
            this.mtxtPassword.BackColor = System.Drawing.Color.LightGray;
            this.mtxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxtPassword.Font = new System.Drawing.Font("Andalus", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.mtxtPassword.Location = new System.Drawing.Point(589, 167);
            this.mtxtPassword.Mask = "0000";
            this.mtxtPassword.Name = "mtxtPassword";
            this.mtxtPassword.Size = new System.Drawing.Size(136, 26);
            this.mtxtPassword.TabIndex = 69;
            this.mtxtPassword.ValidatingType = typeof(int);
            this.mtxtPassword.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Andalus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.ForeColor = System.Drawing.Color.LightGray;
            this.label7.Location = new System.Drawing.Point(503, 168);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(80, 22);
            this.label7.TabIndex = 70;
            this.label7.Text = "Password : ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Visible = false;
            // 
            // txtUserID
            // 
            this.txtUserID.BackColor = System.Drawing.Color.LightGray;
            this.txtUserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserID.Font = new System.Drawing.Font("Andalus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtUserID.Location = new System.Drawing.Point(86, 163);
            this.txtUserID.MaxLength = 30;
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(136, 27);
            this.txtUserID.TabIndex = 67;
            this.txtUserID.Visible = false;
            // 
            // gbPermissions
            // 
            this.gbPermissions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gbPermissions.Controls.Add(this.tvPermissions);
            this.gbPermissions.Font = new System.Drawing.Font("Andalus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gbPermissions.ForeColor = System.Drawing.Color.LightGray;
            this.gbPermissions.Location = new System.Drawing.Point(231, 196);
            this.gbPermissions.Name = "gbPermissions";
            this.gbPermissions.Size = new System.Drawing.Size(218, 249);
            this.gbPermissions.TabIndex = 68;
            this.gbPermissions.TabStop = false;
            this.gbPermissions.Text = "Permissions";
            this.gbPermissions.Visible = false;
            // 
            // tvPermissions
            // 
            this.tvPermissions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tvPermissions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tvPermissions.CheckBoxes = true;
            this.tvPermissions.ForeColor = System.Drawing.Color.LightGray;
            this.tvPermissions.Location = new System.Drawing.Point(6, 26);
            this.tvPermissions.Name = "tvPermissions";
            treeNode1.Name = "Show Client List";
            treeNode1.Tag = "1";
            treeNode1.Text = "Show Client List";
            treeNode2.Name = "Add New Client";
            treeNode2.Tag = "2";
            treeNode2.Text = "Add New Client";
            treeNode3.Name = "Delete Client";
            treeNode3.Tag = "4";
            treeNode3.Text = "Delete Client";
            treeNode4.Name = "Update Client";
            treeNode4.Tag = "8";
            treeNode4.Text = "Update Client";
            treeNode5.Name = "Find Client";
            treeNode5.Tag = "16";
            treeNode5.Text = "Find Client";
            treeNode6.Name = "Transaction";
            treeNode6.Tag = "32";
            treeNode6.Text = "Transaction";
            treeNode7.Name = "Mange Client";
            treeNode7.Tag = "63";
            treeNode7.Text = "Mange Client";
            treeNode8.Name = "Mange User";
            treeNode8.Tag = "64";
            treeNode8.Text = "Mange User";
            treeNode9.Name = "Full Access";
            treeNode9.Tag = "127";
            treeNode9.Text = "Full Access";
            this.tvPermissions.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode9});
            this.tvPermissions.Size = new System.Drawing.Size(206, 217);
            this.tvPermissions.TabIndex = 0;
            this.tvPermissions.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvPermissions_AfterCheck);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Andalus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(10, 168);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(70, 22);
            this.label1.TabIndex = 66;
            this.label1.Text = "User ID : \r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Andalus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblWelcome.ForeColor = System.Drawing.Color.LightGray;
            this.lblWelcome.Location = new System.Drawing.Point(269, 11);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblWelcome.Size = new System.Drawing.Size(150, 30);
            this.lblWelcome.TabIndex = 65;
            this.lblWelcome.Text = "Enter User ID  :\r\n";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightGray;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Andalus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(274, 87);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(152, 48);
            this.btnSearch.TabIndex = 64;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.Validating += new System.ComponentModel.CancelEventHandler(this.btnSearch_Validating);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.LightGray;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Andalus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtSearch.Location = new System.Drawing.Point(274, 44);
            this.txtSearch.MaxLength = 5;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(152, 37);
            this.txtSearch.TabIndex = 63;
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // niInfo
            // 
            this.niInfo.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.niInfo.Icon = ((System.Drawing.Icon)(resources.GetObject("niInfo.Icon")));
            this.niInfo.Text = "notifyIcon1";
            this.niInfo.Visible = true;
            // 
            // frmUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::_07_Project_Bank_System.Properties.Resources.logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(735, 604);
            this.Controls.Add(this.lblUpdated);
            this.Controls.Add(this.pbUpdated);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.mtxtPassword);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.gbPermissions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUpdateUser";
            this.Text = "Update User";
            this.gbPermissions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUpdated;
        private System.Windows.Forms.ProgressBar pbUpdated;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.MaskedTextBox mtxtPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.GroupBox gbPermissions;
        private System.Windows.Forms.TreeView tvPermissions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ErrorProvider epError;
        private System.Windows.Forms.NotifyIcon niInfo;
    }
}