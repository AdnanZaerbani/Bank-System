namespace _07_Project_Bank_System
{
    partial class frmDepWith
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepWith));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pControls = new System.Windows.Forms.Panel();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.mtxtTransaction = new System.Windows.Forms.MaskedTextBox();
            this.mtxtNewBalance = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mtxtBalance = new System.Windows.Forms.MaskedTextBox();
            this.mtxtNationalID = new System.Windows.Forms.MaskedTextBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDeposit = new System.Windows.Forms.RadioButton();
            this.rbWithdraw = new System.Windows.Forms.RadioButton();
            this.txtNotice = new System.Windows.Forms.TextBox();
            this.txtCurrency = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAccountID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUpdated = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pbUpdated = new System.Windows.Forms.ProgressBar();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.niInfo = new System.Windows.Forms.NotifyIcon(this.components);
            this.pControls.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Andalus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblWelcome.ForeColor = System.Drawing.Color.LightGray;
            this.lblWelcome.Location = new System.Drawing.Point(276, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblWelcome.Size = new System.Drawing.Size(183, 30);
            this.lblWelcome.TabIndex = 53;
            this.lblWelcome.Text = "Enter Account ID  :\r\n";
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
            this.btnSearch.Location = new System.Drawing.Point(294, 85);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(152, 48);
            this.btnSearch.TabIndex = 52;
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
            this.txtSearch.Location = new System.Drawing.Point(294, 42);
            this.txtSearch.MaxLength = 4;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(152, 37);
            this.txtSearch.TabIndex = 51;
            // 
            // pControls
            // 
            this.pControls.BackColor = System.Drawing.Color.Transparent;
            this.pControls.Controls.Add(this.btnTransaction);
            this.pControls.Controls.Add(this.mtxtTransaction);
            this.pControls.Controls.Add(this.mtxtNewBalance);
            this.pControls.Controls.Add(this.label4);
            this.pControls.Controls.Add(this.mtxtBalance);
            this.pControls.Controls.Add(this.mtxtNationalID);
            this.pControls.Controls.Add(this.btnDone);
            this.pControls.Controls.Add(this.groupBox1);
            this.pControls.Controls.Add(this.txtNotice);
            this.pControls.Controls.Add(this.txtCurrency);
            this.pControls.Controls.Add(this.txtStatus);
            this.pControls.Controls.Add(this.label15);
            this.pControls.Controls.Add(this.label12);
            this.pControls.Controls.Add(this.label11);
            this.pControls.Controls.Add(this.label10);
            this.pControls.Controls.Add(this.label9);
            this.pControls.Controls.Add(this.label3);
            this.pControls.Controls.Add(this.txtFullName);
            this.pControls.Controls.Add(this.label2);
            this.pControls.Controls.Add(this.txtAccountID);
            this.pControls.Controls.Add(this.label1);
            this.pControls.Location = new System.Drawing.Point(0, 139);
            this.pControls.Name = "pControls";
            this.pControls.Size = new System.Drawing.Size(739, 408);
            this.pControls.TabIndex = 54;
            this.pControls.Visible = false;
            // 
            // btnTransaction
            // 
            this.btnTransaction.BackColor = System.Drawing.Color.LightGray;
            this.btnTransaction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransaction.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnTransaction.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTransaction.FlatAppearance.BorderSize = 0;
            this.btnTransaction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.btnTransaction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransaction.Font = new System.Drawing.Font("Andalus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnTransaction.ForeColor = System.Drawing.Color.Black;
            this.btnTransaction.Location = new System.Drawing.Point(323, 244);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(136, 28);
            this.btnTransaction.TabIndex = 50;
            this.btnTransaction.Text = "Transaction";
            this.btnTransaction.UseVisualStyleBackColor = false;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // mtxtTransaction
            // 
            this.mtxtTransaction.BackColor = System.Drawing.Color.LightGray;
            this.mtxtTransaction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxtTransaction.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mtxtTransaction.Font = new System.Drawing.Font("Andalus", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.mtxtTransaction.Location = new System.Drawing.Point(323, 212);
            this.mtxtTransaction.Mask = "000000000000000000";
            this.mtxtTransaction.Name = "mtxtTransaction";
            this.mtxtTransaction.Size = new System.Drawing.Size(136, 26);
            this.mtxtTransaction.TabIndex = 49;
            this.mtxtTransaction.ValidatingType = typeof(int);
            this.mtxtTransaction.Validating += new System.ComponentModel.CancelEventHandler(this.mtxtTransaction_Validating);
            // 
            // mtxtNewBalance
            // 
            this.mtxtNewBalance.BackColor = System.Drawing.Color.LightGray;
            this.mtxtNewBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxtNewBalance.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.mtxtNewBalance.Enabled = false;
            this.mtxtNewBalance.Font = new System.Drawing.Font("Andalus", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.mtxtNewBalance.Location = new System.Drawing.Point(587, 212);
            this.mtxtNewBalance.Mask = "000000000000000000";
            this.mtxtNewBalance.Name = "mtxtNewBalance";
            this.mtxtNewBalance.ReadOnly = true;
            this.mtxtNewBalance.Size = new System.Drawing.Size(136, 26);
            this.mtxtNewBalance.TabIndex = 47;
            this.mtxtNewBalance.ValidatingType = typeof(int);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Andalus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(490, 220);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(103, 22);
            this.label4.TabIndex = 46;
            this.label4.Text = "New Balance : ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mtxtBalance
            // 
            this.mtxtBalance.BackColor = System.Drawing.Color.LightGray;
            this.mtxtBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxtBalance.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.mtxtBalance.Enabled = false;
            this.mtxtBalance.Font = new System.Drawing.Font("Andalus", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.mtxtBalance.Location = new System.Drawing.Point(110, 212);
            this.mtxtBalance.Mask = "000000000000000000";
            this.mtxtBalance.Name = "mtxtBalance";
            this.mtxtBalance.ReadOnly = true;
            this.mtxtBalance.Size = new System.Drawing.Size(136, 26);
            this.mtxtBalance.TabIndex = 38;
            this.mtxtBalance.ValidatingType = typeof(int);
            // 
            // mtxtNationalID
            // 
            this.mtxtNationalID.BackColor = System.Drawing.Color.LightGray;
            this.mtxtNationalID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxtNationalID.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.mtxtNationalID.Enabled = false;
            this.mtxtNationalID.Font = new System.Drawing.Font("Andalus", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.mtxtNationalID.Location = new System.Drawing.Point(113, 82);
            this.mtxtNationalID.Mask = "000000000";
            this.mtxtNationalID.Name = "mtxtNationalID";
            this.mtxtNationalID.ReadOnly = true;
            this.mtxtNationalID.Size = new System.Drawing.Size(136, 26);
            this.mtxtNationalID.TabIndex = 45;
            this.mtxtNationalID.ValidatingType = typeof(int);
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.LightGray;
            this.btnDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDone.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDone.Enabled = false;
            this.btnDone.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDone.FlatAppearance.BorderSize = 0;
            this.btnDone.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.btnDone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.Font = new System.Drawing.Font("Andalus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnDone.ForeColor = System.Drawing.Color.Black;
            this.btnDone.Location = new System.Drawing.Point(4, 358);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(152, 48);
            this.btnDone.TabIndex = 17;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Visible = false;
            this.btnDone.Click += new System.EventHandler(this.btnDepWith_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDeposit);
            this.groupBox1.Controls.Add(this.rbWithdraw);
            this.groupBox1.Font = new System.Drawing.Font("Andalus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.ForeColor = System.Drawing.Color.LightGray;
            this.groupBox1.Location = new System.Drawing.Point(288, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 61);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transaction";
            // 
            // rbDeposit
            // 
            this.rbDeposit.AutoSize = true;
            this.rbDeposit.Location = new System.Drawing.Point(6, 26);
            this.rbDeposit.Name = "rbDeposit";
            this.rbDeposit.Size = new System.Drawing.Size(76, 26);
            this.rbDeposit.TabIndex = 45;
            this.rbDeposit.TabStop = true;
            this.rbDeposit.Text = "Deposit";
            this.rbDeposit.UseVisualStyleBackColor = true;
            // 
            // rbWithdraw
            // 
            this.rbWithdraw.AutoSize = true;
            this.rbWithdraw.Location = new System.Drawing.Point(90, 26);
            this.rbWithdraw.Name = "rbWithdraw";
            this.rbWithdraw.Size = new System.Drawing.Size(92, 26);
            this.rbWithdraw.TabIndex = 46;
            this.rbWithdraw.TabStop = true;
            this.rbWithdraw.Text = "Withdraw";
            this.rbWithdraw.UseVisualStyleBackColor = true;
            // 
            // txtNotice
            // 
            this.txtNotice.BackColor = System.Drawing.Color.LightGray;
            this.txtNotice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNotice.Font = new System.Drawing.Font("Andalus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtNotice.Location = new System.Drawing.Point(505, 344);
            this.txtNotice.MaxLength = 100;
            this.txtNotice.Multiline = true;
            this.txtNotice.Name = "txtNotice";
            this.txtNotice.Size = new System.Drawing.Size(206, 61);
            this.txtNotice.TabIndex = 41;
            // 
            // txtCurrency
            // 
            this.txtCurrency.BackColor = System.Drawing.Color.LightGray;
            this.txtCurrency.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCurrency.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtCurrency.Enabled = false;
            this.txtCurrency.Font = new System.Drawing.Font("Andalus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtCurrency.Location = new System.Drawing.Point(113, 113);
            this.txtCurrency.MaxLength = 30;
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.ReadOnly = true;
            this.txtCurrency.Size = new System.Drawing.Size(136, 27);
            this.txtCurrency.TabIndex = 40;
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.Color.LightGray;
            this.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStatus.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtStatus.Enabled = false;
            this.txtStatus.Font = new System.Drawing.Font("Andalus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtStatus.Location = new System.Drawing.Point(113, 144);
            this.txtStatus.MaxLength = 30;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(136, 27);
            this.txtStatus.TabIndex = 39;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Andalus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label15.ForeColor = System.Drawing.Color.LightGray;
            this.label15.Location = new System.Drawing.Point(3, 86);
            this.label15.Name = "label15";
            this.label15.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label15.Size = new System.Drawing.Size(95, 22);
            this.label15.TabIndex = 32;
            this.label15.Text = "National ID : ";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Andalus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label12.ForeColor = System.Drawing.Color.LightGray;
            this.label12.Location = new System.Drawing.Point(3, 181);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label12.Size = new System.Drawing.Size(0, 22);
            this.label12.TabIndex = 29;
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Andalus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.ForeColor = System.Drawing.Color.LightGray;
            this.label11.Location = new System.Drawing.Point(0, 218);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label11.Size = new System.Drawing.Size(71, 22);
            this.label11.TabIndex = 28;
            this.label11.Text = "Balance : ";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Andalus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.ForeColor = System.Drawing.Color.LightGray;
            this.label10.Location = new System.Drawing.Point(3, 121);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(80, 22);
            this.label10.TabIndex = 27;
            this.label10.Text = "Currency : ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Andalus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.ForeColor = System.Drawing.Color.LightGray;
            this.label9.Location = new System.Drawing.Point(3, 153);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(60, 22);
            this.label9.TabIndex = 26;
            this.label9.Text = "Status : ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Andalus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(441, 346);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(63, 22);
            this.label3.TabIndex = 20;
            this.label3.Text = "Notice : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFullName
            // 
            this.txtFullName.BackColor = System.Drawing.Color.LightGray;
            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFullName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtFullName.Enabled = false;
            this.txtFullName.Font = new System.Drawing.Font("Andalus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtFullName.Location = new System.Drawing.Point(113, 51);
            this.txtFullName.MaxLength = 30;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.ReadOnly = true;
            this.txtFullName.Size = new System.Drawing.Size(136, 27);
            this.txtFullName.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Andalus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(3, 54);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(82, 22);
            this.label2.TabIndex = 18;
            this.label2.Text = "Full Name :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAccountID
            // 
            this.txtAccountID.BackColor = System.Drawing.Color.LightGray;
            this.txtAccountID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccountID.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtAccountID.Enabled = false;
            this.txtAccountID.Font = new System.Drawing.Font("Andalus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtAccountID.Location = new System.Drawing.Point(113, 20);
            this.txtAccountID.MaxLength = 30;
            this.txtAccountID.Name = "txtAccountID";
            this.txtAccountID.ReadOnly = true;
            this.txtAccountID.Size = new System.Drawing.Size(136, 27);
            this.txtAccountID.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Andalus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(3, 22);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(88, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "AccountID : \r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUpdated
            // 
            this.lblUpdated.AutoSize = true;
            this.lblUpdated.BackColor = System.Drawing.Color.Transparent;
            this.lblUpdated.Font = new System.Drawing.Font("Andalus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblUpdated.ForeColor = System.Drawing.Color.LightGray;
            this.lblUpdated.Location = new System.Drawing.Point(471, 565);
            this.lblUpdated.Name = "lblUpdated";
            this.lblUpdated.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUpdated.Size = new System.Drawing.Size(0, 30);
            this.lblUpdated.TabIndex = 57;
            this.lblUpdated.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUpdated.Visible = false;
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
            this.btnCancel.Location = new System.Drawing.Point(294, 553);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(171, 42);
            this.btnCancel.TabIndex = 55;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pbUpdated
            // 
            this.pbUpdated.Location = new System.Drawing.Point(294, 553);
            this.pbUpdated.Name = "pbUpdated";
            this.pbUpdated.Size = new System.Drawing.Size(171, 42);
            this.pbUpdated.TabIndex = 56;
            this.pbUpdated.Visible = false;
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
            // frmDepWith
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::_07_Project_Bank_System.Properties.Resources.logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(735, 604);
            this.Controls.Add(this.lblUpdated);
            this.Controls.Add(this.pControls);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pbUpdated);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDepWith";
            this.Text = "Deposit / Withdraw";
            this.pControls.ResumeLayout(false);
            this.pControls.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel pControls;
        private System.Windows.Forms.MaskedTextBox mtxtBalance;
        private System.Windows.Forms.MaskedTextBox mtxtNationalID;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDeposit;
        private System.Windows.Forms.RadioButton rbWithdraw;
        private System.Windows.Forms.TextBox txtNotice;
        private System.Windows.Forms.TextBox txtCurrency;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAccountID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUpdated;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ProgressBar pbUpdated;
        private System.Windows.Forms.MaskedTextBox mtxtTransaction;
        private System.Windows.Forms.MaskedTextBox mtxtNewBalance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider epError;
        private System.Windows.Forms.NotifyIcon niInfo;
        private System.Windows.Forms.Button btnTransaction;
    }
}