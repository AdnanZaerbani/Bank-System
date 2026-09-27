namespace _07_Project_Bank_System
{
    partial class frmDeleteClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeleteClient));
            this.lblUpdated = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pbUpdated = new System.Windows.Forms.ProgressBar();
            this.pControls = new System.Windows.Forms.Panel();
            this.mtxtBalance = new System.Windows.Forms.MaskedTextBox();
            this.mtxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.mtxtNationalID = new System.Windows.Forms.MaskedTextBox();
            this.mtxtSecurityCode = new System.Windows.Forms.MaskedTextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtNotice = new System.Windows.Forms.TextBox();
            this.txtCurrency = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtCreatedDate = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAccountID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.niInfo = new System.Windows.Forms.NotifyIcon(this.components);
            this.pControls.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUpdated
            // 
            this.lblUpdated.AutoSize = true;
            this.lblUpdated.BackColor = System.Drawing.Color.Transparent;
            this.lblUpdated.Font = new System.Drawing.Font("Andalus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblUpdated.ForeColor = System.Drawing.Color.LightGray;
            this.lblUpdated.Location = new System.Drawing.Point(440, 565);
            this.lblUpdated.Name = "lblUpdated";
            this.lblUpdated.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUpdated.Size = new System.Drawing.Size(0, 30);
            this.lblUpdated.TabIndex = 54;
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
            this.btnCancel.Location = new System.Drawing.Point(263, 553);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(171, 42);
            this.btnCancel.TabIndex = 52;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pbUpdated
            // 
            this.pbUpdated.Location = new System.Drawing.Point(263, 553);
            this.pbUpdated.Name = "pbUpdated";
            this.pbUpdated.Size = new System.Drawing.Size(171, 42);
            this.pbUpdated.TabIndex = 53;
            this.pbUpdated.Visible = false;
            // 
            // pControls
            // 
            this.pControls.BackColor = System.Drawing.Color.Transparent;
            this.pControls.Controls.Add(this.mtxtBalance);
            this.pControls.Controls.Add(this.mtxtPhone);
            this.pControls.Controls.Add(this.mtxtNationalID);
            this.pControls.Controls.Add(this.mtxtSecurityCode);
            this.pControls.Controls.Add(this.btnDelete);
            this.pControls.Controls.Add(this.groupBox1);
            this.pControls.Controls.Add(this.txtCity);
            this.pControls.Controls.Add(this.txtAddress);
            this.pControls.Controls.Add(this.txtNotice);
            this.pControls.Controls.Add(this.txtCurrency);
            this.pControls.Controls.Add(this.txtStatus);
            this.pControls.Controls.Add(this.txtCreatedDate);
            this.pControls.Controls.Add(this.txtEmail);
            this.pControls.Controls.Add(this.label15);
            this.pControls.Controls.Add(this.label14);
            this.pControls.Controls.Add(this.label13);
            this.pControls.Controls.Add(this.label12);
            this.pControls.Controls.Add(this.label11);
            this.pControls.Controls.Add(this.label10);
            this.pControls.Controls.Add(this.label9);
            this.pControls.Controls.Add(this.label8);
            this.pControls.Controls.Add(this.label7);
            this.pControls.Controls.Add(this.label5);
            this.pControls.Controls.Add(this.label4);
            this.pControls.Controls.Add(this.label3);
            this.pControls.Controls.Add(this.txtFullName);
            this.pControls.Controls.Add(this.label2);
            this.pControls.Controls.Add(this.txtAccountID);
            this.pControls.Controls.Add(this.label1);
            this.pControls.Location = new System.Drawing.Point(-1, 139);
            this.pControls.Name = "pControls";
            this.pControls.Size = new System.Drawing.Size(739, 408);
            this.pControls.TabIndex = 51;
            this.pControls.Visible = false;
            // 
            // mtxtBalance
            // 
            this.mtxtBalance.BackColor = System.Drawing.Color.LightGray;
            this.mtxtBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxtBalance.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.mtxtBalance.Enabled = false;
            this.mtxtBalance.Font = new System.Drawing.Font("Andalus", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.mtxtBalance.Location = new System.Drawing.Point(572, 19);
            this.mtxtBalance.Mask = "000000000000000000";
            this.mtxtBalance.Name = "mtxtBalance";
            this.mtxtBalance.ReadOnly = true;
            this.mtxtBalance.Size = new System.Drawing.Size(136, 26);
            this.mtxtBalance.TabIndex = 38;
            this.mtxtBalance.ValidatingType = typeof(int);
            // 
            // mtxtPhone
            // 
            this.mtxtPhone.BackColor = System.Drawing.Color.LightGray;
            this.mtxtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxtPhone.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.mtxtPhone.Enabled = false;
            this.mtxtPhone.Font = new System.Drawing.Font("Andalus", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.mtxtPhone.Location = new System.Drawing.Point(113, 112);
            this.mtxtPhone.Mask = "0000000000";
            this.mtxtPhone.Name = "mtxtPhone";
            this.mtxtPhone.ReadOnly = true;
            this.mtxtPhone.Size = new System.Drawing.Size(136, 26);
            this.mtxtPhone.TabIndex = 46;
            this.mtxtPhone.ValidatingType = typeof(int);
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
            // mtxtSecurityCode
            // 
            this.mtxtSecurityCode.BackColor = System.Drawing.Color.LightGray;
            this.mtxtSecurityCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxtSecurityCode.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.mtxtSecurityCode.Enabled = false;
            this.mtxtSecurityCode.Font = new System.Drawing.Font("Andalus", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.mtxtSecurityCode.Location = new System.Drawing.Point(572, 144);
            this.mtxtSecurityCode.Mask = "0000";
            this.mtxtSecurityCode.Name = "mtxtSecurityCode";
            this.mtxtSecurityCode.ReadOnly = true;
            this.mtxtSecurityCode.Size = new System.Drawing.Size(136, 26);
            this.mtxtSecurityCode.TabIndex = 18;
            this.mtxtSecurityCode.ValidatingType = typeof(int);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightGray;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Andalus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(4, 358);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(152, 48);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbMale);
            this.groupBox1.Controls.Add(this.rbFemale);
            this.groupBox1.ForeColor = System.Drawing.Color.LightGray;
            this.groupBox1.Location = new System.Drawing.Point(264, 344);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 61);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Enabled = false;
            this.rbMale.Location = new System.Drawing.Point(6, 26);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(48, 17);
            this.rbMale.TabIndex = 45;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Enabled = false;
            this.rbFemale.Location = new System.Drawing.Point(90, 26);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(59, 17);
            this.rbFemale.TabIndex = 46;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.Color.LightGray;
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCity.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtCity.Enabled = false;
            this.txtCity.Font = new System.Drawing.Font("Andalus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtCity.Location = new System.Drawing.Point(572, 175);
            this.txtCity.MaxLength = 30;
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(136, 27);
            this.txtCity.TabIndex = 43;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.LightGray;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtAddress.Enabled = false;
            this.txtAddress.Font = new System.Drawing.Font("Andalus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtAddress.Location = new System.Drawing.Point(113, 175);
            this.txtAddress.MaxLength = 30;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(136, 27);
            this.txtAddress.TabIndex = 42;
            // 
            // txtNotice
            // 
            this.txtNotice.BackColor = System.Drawing.Color.LightGray;
            this.txtNotice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNotice.Enabled = false;
            this.txtNotice.Font = new System.Drawing.Font("Andalus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtNotice.Location = new System.Drawing.Point(505, 344);
            this.txtNotice.MaxLength = 100;
            this.txtNotice.Multiline = true;
            this.txtNotice.Name = "txtNotice";
            this.txtNotice.ReadOnly = true;
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
            this.txtCurrency.Location = new System.Drawing.Point(572, 51);
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
            this.txtStatus.Location = new System.Drawing.Point(572, 82);
            this.txtStatus.MaxLength = 30;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(136, 27);
            this.txtStatus.TabIndex = 39;
            // 
            // txtCreatedDate
            // 
            this.txtCreatedDate.BackColor = System.Drawing.Color.LightGray;
            this.txtCreatedDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCreatedDate.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtCreatedDate.Enabled = false;
            this.txtCreatedDate.Font = new System.Drawing.Font("Andalus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtCreatedDate.Location = new System.Drawing.Point(572, 113);
            this.txtCreatedDate.MaxLength = 30;
            this.txtCreatedDate.Name = "txtCreatedDate";
            this.txtCreatedDate.ReadOnly = true;
            this.txtCreatedDate.Size = new System.Drawing.Size(136, 27);
            this.txtCreatedDate.TabIndex = 38;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.LightGray;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Andalus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtEmail.Location = new System.Drawing.Point(113, 144);
            this.txtEmail.MaxLength = 30;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(136, 27);
            this.txtEmail.TabIndex = 35;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Andalus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label15.ForeColor = System.Drawing.Color.LightGray;
            this.label15.Location = new System.Drawing.Point(3, 84);
            this.label15.Name = "label15";
            this.label15.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label15.Size = new System.Drawing.Size(95, 22);
            this.label15.TabIndex = 32;
            this.label15.Text = "National ID : ";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Andalus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label14.ForeColor = System.Drawing.Color.LightGray;
            this.label14.Location = new System.Drawing.Point(3, 116);
            this.label14.Name = "label14";
            this.label14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label14.Size = new System.Drawing.Size(59, 22);
            this.label14.TabIndex = 31;
            this.label14.Text = "Phone : ";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Andalus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label13.ForeColor = System.Drawing.Color.LightGray;
            this.label13.Location = new System.Drawing.Point(0, 149);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label13.Size = new System.Drawing.Size(53, 22);
            this.label13.TabIndex = 30;
            this.label13.Text = "Email :";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.label11.Location = new System.Drawing.Point(448, 20);
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
            this.label10.Location = new System.Drawing.Point(448, 52);
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
            this.label9.Location = new System.Drawing.Point(448, 84);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(60, 22);
            this.label9.TabIndex = 26;
            this.label9.Text = "Status : ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Andalus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.ForeColor = System.Drawing.Color.LightGray;
            this.label8.Location = new System.Drawing.Point(448, 116);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(104, 22);
            this.label8.TabIndex = 25;
            this.label8.Text = "Created Date : ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Andalus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.ForeColor = System.Drawing.Color.LightGray;
            this.label7.Location = new System.Drawing.Point(448, 148);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(109, 22);
            this.label7.TabIndex = 24;
            this.label7.Text = "Security Code : ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Andalus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(0, 180);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(72, 22);
            this.label5.TabIndex = 22;
            this.label5.Text = "Address : ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Andalus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(448, 180);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(48, 22);
            this.label4.TabIndex = 21;
            this.label4.Text = "City : ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.label2.Location = new System.Drawing.Point(6, 53);
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
            this.label1.Location = new System.Drawing.Point(0, 22);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(88, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "AccountID : \r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Andalus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblWelcome.ForeColor = System.Drawing.Color.LightGray;
            this.lblWelcome.Location = new System.Drawing.Point(254, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblWelcome.Size = new System.Drawing.Size(183, 30);
            this.lblWelcome.TabIndex = 50;
            this.lblWelcome.Text = "Enter Account ID  :\r\n";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
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
            this.btnSearch.Location = new System.Drawing.Point(272, 85);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(152, 48);
            this.btnSearch.TabIndex = 49;
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
            this.txtSearch.Location = new System.Drawing.Point(272, 42);
            this.txtSearch.MaxLength = 4;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(152, 37);
            this.txtSearch.TabIndex = 48;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
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
            // frmDeleteClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::_07_Project_Bank_System.Properties.Resources.logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(735, 604);
            this.Controls.Add(this.lblUpdated);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pbUpdated);
            this.Controls.Add(this.pControls);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDeleteClient";
            this.Text = "Delete Client";
            this.pControls.ResumeLayout(false);
            this.pControls.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUpdated;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ProgressBar pbUpdated;
        private System.Windows.Forms.Panel pControls;
        private System.Windows.Forms.MaskedTextBox mtxtBalance;
        private System.Windows.Forms.MaskedTextBox mtxtPhone;
        private System.Windows.Forms.MaskedTextBox mtxtNationalID;
        private System.Windows.Forms.MaskedTextBox mtxtSecurityCode;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtNotice;
        private System.Windows.Forms.TextBox txtCurrency;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtCreatedDate;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAccountID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ErrorProvider epError;
        private System.Windows.Forms.NotifyIcon niInfo;
    }
}