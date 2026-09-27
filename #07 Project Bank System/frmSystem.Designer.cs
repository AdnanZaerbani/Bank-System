namespace _07_Project_Bank_System
{
    partial class frmSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSystem));
            this.lsvClients = new System.Windows.Forms.ListView();
            this.cmmClients = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showClientsListToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewClientToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteClientToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateClientToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.findClientToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.totalBalanceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnFillClients = new System.Windows.Forms.Button();
            this.tbcManagment = new System.Windows.Forms.TabControl();
            this.tcClient = new System.Windows.Forms.TabPage();
            this.tcUser = new System.Windows.Forms.TabPage();
            this.lsvUsers = new System.Windows.Forms.ListView();
            this.cmmUsers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.msManagment = new System.Windows.Forms.MenuStrip();
            this.showClientListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showClientsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalBalanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findUserToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnFillUsers = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cmmClients.SuspendLayout();
            this.tbcManagment.SuspendLayout();
            this.tcClient.SuspendLayout();
            this.tcUser.SuspendLayout();
            this.cmmUsers.SuspendLayout();
            this.msManagment.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsvClients
            // 
            this.lsvClients.BackColor = System.Drawing.Color.LightGray;
            this.lsvClients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsvClients.ContextMenuStrip = this.cmmClients;
            this.lsvClients.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lsvClients.ForeColor = System.Drawing.Color.Black;
            this.lsvClients.FullRowSelect = true;
            this.lsvClients.GridLines = true;
            this.lsvClients.HideSelection = false;
            this.lsvClients.LargeImageList = this.imageList2;
            this.lsvClients.Location = new System.Drawing.Point(6, 6);
            this.lsvClients.Name = "lsvClients";
            this.lsvClients.Size = new System.Drawing.Size(1949, 339);
            this.lsvClients.SmallImageList = this.imageList1;
            this.lsvClients.TabIndex = 0;
            this.lsvClients.UseCompatibleStateImageBehavior = false;
            this.lsvClients.View = System.Windows.Forms.View.Details;
            // 
            // cmmClients
            // 
            this.cmmClients.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showClientsListToolStripMenuItem1,
            this.addNewClientToolStripMenuItem1,
            this.deleteClientToolStripMenuItem1,
            this.updateClientToolStripMenuItem1,
            this.findClientToolStripMenuItem1,
            this.toolStripSeparator1,
            this.transactionToolStripMenuItem});
            this.cmmClients.Name = "contextMenuStrip1";
            this.cmmClients.Size = new System.Drawing.Size(187, 166);
            // 
            // showClientsListToolStripMenuItem1
            // 
            this.showClientsListToolStripMenuItem1.Font = new System.Drawing.Font("Andalus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.showClientsListToolStripMenuItem1.Name = "showClientsListToolStripMenuItem1";
            this.showClientsListToolStripMenuItem1.Size = new System.Drawing.Size(186, 26);
            this.showClientsListToolStripMenuItem1.Text = "Show Clients List";
            this.showClientsListToolStripMenuItem1.Click += new System.EventHandler(this.btnFillClients_Click);
            // 
            // addNewClientToolStripMenuItem1
            // 
            this.addNewClientToolStripMenuItem1.Font = new System.Drawing.Font("Andalus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.addNewClientToolStripMenuItem1.Name = "addNewClientToolStripMenuItem1";
            this.addNewClientToolStripMenuItem1.Size = new System.Drawing.Size(186, 26);
            this.addNewClientToolStripMenuItem1.Text = "Add New Client";
            this.addNewClientToolStripMenuItem1.Click += new System.EventHandler(this.addNewClientToolStripMenuItem1_Click);
            // 
            // deleteClientToolStripMenuItem1
            // 
            this.deleteClientToolStripMenuItem1.Font = new System.Drawing.Font("Andalus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.deleteClientToolStripMenuItem1.Name = "deleteClientToolStripMenuItem1";
            this.deleteClientToolStripMenuItem1.Size = new System.Drawing.Size(186, 26);
            this.deleteClientToolStripMenuItem1.Text = "Delete Client";
            this.deleteClientToolStripMenuItem1.Click += new System.EventHandler(this.deleteClientToolStripMenuItem1_Click);
            // 
            // updateClientToolStripMenuItem1
            // 
            this.updateClientToolStripMenuItem1.Font = new System.Drawing.Font("Andalus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.updateClientToolStripMenuItem1.Name = "updateClientToolStripMenuItem1";
            this.updateClientToolStripMenuItem1.Size = new System.Drawing.Size(186, 26);
            this.updateClientToolStripMenuItem1.Text = "Update Client";
            this.updateClientToolStripMenuItem1.Click += new System.EventHandler(this.updateClientToolStripMenuItem1_Click);
            // 
            // findClientToolStripMenuItem1
            // 
            this.findClientToolStripMenuItem1.Font = new System.Drawing.Font("Andalus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.findClientToolStripMenuItem1.Name = "findClientToolStripMenuItem1";
            this.findClientToolStripMenuItem1.Size = new System.Drawing.Size(186, 26);
            this.findClientToolStripMenuItem1.Text = "Find Client";
            this.findClientToolStripMenuItem1.Click += new System.EventHandler(this.findClientToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(183, 6);
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.depositToolStripMenuItem1,
            this.totalBalanceToolStripMenuItem1});
            this.transactionToolStripMenuItem.Font = new System.Drawing.Font("Andalus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.transactionToolStripMenuItem.Text = "Transaction";
            // 
            // depositToolStripMenuItem1
            // 
            this.depositToolStripMenuItem1.Name = "depositToolStripMenuItem1";
            this.depositToolStripMenuItem1.Size = new System.Drawing.Size(205, 26);
            this.depositToolStripMenuItem1.Text = "Deposit / Withdraw";
            this.depositToolStripMenuItem1.Click += new System.EventHandler(this.depositToolStripMenuItem1_Click);
            // 
            // totalBalanceToolStripMenuItem1
            // 
            this.totalBalanceToolStripMenuItem1.Name = "totalBalanceToolStripMenuItem1";
            this.totalBalanceToolStripMenuItem1.Size = new System.Drawing.Size(205, 26);
            this.totalBalanceToolStripMenuItem1.Text = "Total Balance";
            this.totalBalanceToolStripMenuItem1.Click += new System.EventHandler(this.totalBalanceToolStripMenuItem1_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "Male6.png");
            this.imageList2.Images.SetKeyName(1, "Female6.png");
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Male6.png");
            this.imageList1.Images.SetKeyName(1, "Female6.png");
            // 
            // btnFillClients
            // 
            this.btnFillClients.BackColor = System.Drawing.Color.LightGray;
            this.btnFillClients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFillClients.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFillClients.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFillClients.FlatAppearance.BorderSize = 0;
            this.btnFillClients.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.btnFillClients.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnFillClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFillClients.Font = new System.Drawing.Font("Andalus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnFillClients.ForeColor = System.Drawing.Color.Black;
            this.btnFillClients.Location = new System.Drawing.Point(22, 550);
            this.btnFillClients.Name = "btnFillClients";
            this.btnFillClients.Size = new System.Drawing.Size(152, 48);
            this.btnFillClients.TabIndex = 6;
            this.btnFillClients.Text = "Fill Clients";
            this.btnFillClients.UseVisualStyleBackColor = false;
            this.btnFillClients.Click += new System.EventHandler(this.btnFillClients_Click);
            // 
            // tbcManagment
            // 
            this.tbcManagment.Controls.Add(this.tcClient);
            this.tbcManagment.Controls.Add(this.tcUser);
            this.tbcManagment.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbcManagment.Location = new System.Drawing.Point(12, 604);
            this.tbcManagment.Multiline = true;
            this.tbcManagment.Name = "tbcManagment";
            this.tbcManagment.SelectedIndex = 0;
            this.tbcManagment.Size = new System.Drawing.Size(1969, 387);
            this.tbcManagment.TabIndex = 8;
            this.tbcManagment.SelectedIndexChanged += new System.EventHandler(this.tbcManagment_SelectedIndexChanged);
            // 
            // tcClient
            // 
            this.tcClient.BackColor = System.Drawing.Color.Transparent;
            this.tcClient.Controls.Add(this.lsvClients);
            this.tcClient.Location = new System.Drawing.Point(4, 35);
            this.tcClient.Name = "tcClient";
            this.tcClient.Padding = new System.Windows.Forms.Padding(3);
            this.tcClient.Size = new System.Drawing.Size(1961, 348);
            this.tcClient.TabIndex = 0;
            this.tcClient.Text = "Clients Management";
            // 
            // tcUser
            // 
            this.tcUser.Controls.Add(this.lsvUsers);
            this.tcUser.Location = new System.Drawing.Point(4, 35);
            this.tcUser.Name = "tcUser";
            this.tcUser.Padding = new System.Windows.Forms.Padding(3);
            this.tcUser.Size = new System.Drawing.Size(1961, 348);
            this.tcUser.TabIndex = 1;
            this.tcUser.Text = "User Management";
            this.tcUser.UseVisualStyleBackColor = true;
            // 
            // lsvUsers
            // 
            this.lsvUsers.BackColor = System.Drawing.Color.LightGray;
            this.lsvUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsvUsers.ContextMenuStrip = this.cmmUsers;
            this.lsvUsers.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lsvUsers.ForeColor = System.Drawing.Color.Black;
            this.lsvUsers.FullRowSelect = true;
            this.lsvUsers.GridLines = true;
            this.lsvUsers.HideSelection = false;
            this.lsvUsers.LargeImageList = this.imageList2;
            this.lsvUsers.Location = new System.Drawing.Point(6, 6);
            this.lsvUsers.Name = "lsvUsers";
            this.lsvUsers.Size = new System.Drawing.Size(965, 336);
            this.lsvUsers.TabIndex = 9;
            this.lsvUsers.UseCompatibleStateImageBehavior = false;
            this.lsvUsers.View = System.Windows.Forms.View.Details;
            // 
            // cmmUsers
            // 
            this.cmmUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.cmmUsers.Name = "contextMenuStrip1";
            this.cmmUsers.Size = new System.Drawing.Size(168, 134);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Andalus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(167, 26);
            this.toolStripMenuItem1.Text = "List Users";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.btnFillUsers_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Font = new System.Drawing.Font("Andalus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(167, 26);
            this.toolStripMenuItem3.Text = "Add New User";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Font = new System.Drawing.Font("Andalus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(167, 26);
            this.toolStripMenuItem4.Text = "Delete User";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Font = new System.Drawing.Font("Andalus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(167, 26);
            this.toolStripMenuItem5.Text = "Update User";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Font = new System.Drawing.Font("Andalus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(167, 26);
            this.toolStripMenuItem6.Text = "Find User";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.LightGray;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Andalus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtSearch.Location = new System.Drawing.Point(847, 501);
            this.txtSearch.MaxLength = 10;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(292, 37);
            this.txtSearch.TabIndex = 9;
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
            this.btnSearch.Location = new System.Drawing.Point(917, 544);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(152, 48);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // msManagment
            // 
            this.msManagment.BackColor = System.Drawing.Color.LightGray;
            this.msManagment.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showClientListToolStripMenuItem,
            this.usersToolStripMenuItem});
            this.msManagment.Location = new System.Drawing.Point(0, 0);
            this.msManagment.Name = "msManagment";
            this.msManagment.Size = new System.Drawing.Size(1994, 30);
            this.msManagment.TabIndex = 11;
            this.msManagment.Text = "menuStrip1";
            // 
            // showClientListToolStripMenuItem
            // 
            this.showClientListToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showClientsListToolStripMenuItem,
            this.addNewClientToolStripMenuItem,
            this.deleteClientToolStripMenuItem,
            this.updateClientToolStripMenuItem,
            this.findClientToolStripMenuItem,
            this.toolStripMenuItem2,
            this.transactionsToolStripMenuItem});
            this.showClientListToolStripMenuItem.Font = new System.Drawing.Font("Andalus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.showClientListToolStripMenuItem.Name = "showClientListToolStripMenuItem";
            this.showClientListToolStripMenuItem.Size = new System.Drawing.Size(67, 26);
            this.showClientListToolStripMenuItem.Text = "Clients";
            // 
            // showClientsListToolStripMenuItem
            // 
            this.showClientsListToolStripMenuItem.Name = "showClientsListToolStripMenuItem";
            this.showClientsListToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.showClientsListToolStripMenuItem.Text = "Show Clients List";
            this.showClientsListToolStripMenuItem.Click += new System.EventHandler(this.btnFillClients_Click);
            // 
            // addNewClientToolStripMenuItem
            // 
            this.addNewClientToolStripMenuItem.Name = "addNewClientToolStripMenuItem";
            this.addNewClientToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.addNewClientToolStripMenuItem.Text = "Add New Client";
            this.addNewClientToolStripMenuItem.Click += new System.EventHandler(this.addNewClientToolStripMenuItem_Click);
            // 
            // deleteClientToolStripMenuItem
            // 
            this.deleteClientToolStripMenuItem.Name = "deleteClientToolStripMenuItem";
            this.deleteClientToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.deleteClientToolStripMenuItem.Text = "Delete Client";
            this.deleteClientToolStripMenuItem.Click += new System.EventHandler(this.deleteClientToolStripMenuItem_Click);
            // 
            // updateClientToolStripMenuItem
            // 
            this.updateClientToolStripMenuItem.Name = "updateClientToolStripMenuItem";
            this.updateClientToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.updateClientToolStripMenuItem.Text = "Update Client";
            this.updateClientToolStripMenuItem.Click += new System.EventHandler(this.updateClientToolStripMenuItem_Click);
            // 
            // findClientToolStripMenuItem
            // 
            this.findClientToolStripMenuItem.Name = "findClientToolStripMenuItem";
            this.findClientToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.findClientToolStripMenuItem.Text = "Find Client";
            this.findClientToolStripMenuItem.Click += new System.EventHandler(this.findClientToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(186, 6);
            // 
            // transactionsToolStripMenuItem
            // 
            this.transactionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.depositToolStripMenuItem,
            this.totalBalanceToolStripMenuItem});
            this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.transactionsToolStripMenuItem.Text = "Transactions";
            // 
            // depositToolStripMenuItem
            // 
            this.depositToolStripMenuItem.Name = "depositToolStripMenuItem";
            this.depositToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.depositToolStripMenuItem.Text = "Deposit / Withdraw";
            this.depositToolStripMenuItem.Click += new System.EventHandler(this.depositToolStripMenuItem_Click);
            // 
            // totalBalanceToolStripMenuItem
            // 
            this.totalBalanceToolStripMenuItem.Name = "totalBalanceToolStripMenuItem";
            this.totalBalanceToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.totalBalanceToolStripMenuItem.Text = "Total Balance";
            this.totalBalanceToolStripMenuItem.Click += new System.EventHandler(this.totalBalanceToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shToolStripMenuItem,
            this.addNewUserToolStripMenuItem,
            this.deleteUserToolStripMenuItem,
            this.findUserToolStripMenuItem,
            this.findUserToolStripMenuItem1});
            this.usersToolStripMenuItem.Font = new System.Drawing.Font("Andalus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(57, 26);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // shToolStripMenuItem
            // 
            this.shToolStripMenuItem.Name = "shToolStripMenuItem";
            this.shToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.shToolStripMenuItem.Text = "List Users";
            this.shToolStripMenuItem.Click += new System.EventHandler(this.btnFillUsers_Click);
            // 
            // addNewUserToolStripMenuItem
            // 
            this.addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            this.addNewUserToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.addNewUserToolStripMenuItem.Text = "Add New User";
            this.addNewUserToolStripMenuItem.Click += new System.EventHandler(this.addNewUserToolStripMenuItem_Click);
            // 
            // deleteUserToolStripMenuItem
            // 
            this.deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            this.deleteUserToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.deleteUserToolStripMenuItem.Text = "Delete User";
            this.deleteUserToolStripMenuItem.Click += new System.EventHandler(this.deleteUserToolStripMenuItem_Click);
            // 
            // findUserToolStripMenuItem
            // 
            this.findUserToolStripMenuItem.Name = "findUserToolStripMenuItem";
            this.findUserToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.findUserToolStripMenuItem.Text = "Update User";
            this.findUserToolStripMenuItem.Click += new System.EventHandler(this.findUserToolStripMenuItem_Click);
            // 
            // findUserToolStripMenuItem1
            // 
            this.findUserToolStripMenuItem1.Name = "findUserToolStripMenuItem1";
            this.findUserToolStripMenuItem1.Size = new System.Drawing.Size(180, 26);
            this.findUserToolStripMenuItem1.Text = "Find User";
            this.findUserToolStripMenuItem1.Click += new System.EventHandler(this.findUserToolStripMenuItem1_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Andalus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblWelcome.ForeColor = System.Drawing.Color.LightGray;
            this.lblWelcome.Location = new System.Drawing.Point(842, 472);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblWelcome.Size = new System.Drawing.Size(217, 30);
            this.lblWelcome.TabIndex = 12;
            this.lblWelcome.Text = "Search by Account ID :\r\n";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFillUsers
            // 
            this.btnFillUsers.BackColor = System.Drawing.Color.LightGray;
            this.btnFillUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFillUsers.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFillUsers.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFillUsers.FlatAppearance.BorderSize = 0;
            this.btnFillUsers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.btnFillUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnFillUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFillUsers.Font = new System.Drawing.Font("Andalus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnFillUsers.ForeColor = System.Drawing.Color.Black;
            this.btnFillUsers.Location = new System.Drawing.Point(180, 550);
            this.btnFillUsers.Name = "btnFillUsers";
            this.btnFillUsers.Size = new System.Drawing.Size(152, 48);
            this.btnFillUsers.TabIndex = 13;
            this.btnFillUsers.Text = "Fill Users";
            this.btnFillUsers.UseVisualStyleBackColor = false;
            this.btnFillUsers.Click += new System.EventHandler(this.btnFillUsers_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightGray;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Andalus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(1819, 544);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(152, 48);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::_07_Project_Bank_System.Properties.Resources.logo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1994, 1003);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnFillUsers);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.tbcManagment);
            this.Controls.Add(this.btnFillClients);
            this.Controls.Add(this.msManagment);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msManagment;
            this.Name = "frmSystem";
            this.Text = "The System of Bank";
            this.cmmClients.ResumeLayout(false);
            this.tbcManagment.ResumeLayout(false);
            this.tcClient.ResumeLayout(false);
            this.tcUser.ResumeLayout(false);
            this.cmmUsers.ResumeLayout(false);
            this.msManagment.ResumeLayout(false);
            this.msManagment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvClients;
        private System.Windows.Forms.Button btnFillClients;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.TabControl tbcManagment;
        private System.Windows.Forms.TabPage tcClient;
        private System.Windows.Forms.TabPage tcUser;
        private System.Windows.Forms.ListView lsvUsers;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.MenuStrip msManagment;
        private System.Windows.Forms.ToolStripMenuItem showClientListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showClientsListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depositToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalBalanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findUserToolStripMenuItem1;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.ContextMenuStrip cmmClients;
        private System.Windows.Forms.ToolStripMenuItem showClientsListToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addNewClientToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteClientToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem updateClientToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem findClientToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depositToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem totalBalanceToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ContextMenuStrip cmmUsers;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.Button btnFillUsers;
        private System.Windows.Forms.Button btnExit;
    }
}