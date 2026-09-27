namespace _07_Project_Bank_System
{
    partial class frmTotalBalance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTotalBalance));
            this.btnBack = new System.Windows.Forms.Button();
            this.lsvClients = new System.Windows.Forms.ListView();
            this.lblTotalBalance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.LightGray;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            resources.ApplyResources(this.btnBack, "btnBack");
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Name = "btnBack";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lsvClients
            // 
            this.lsvClients.BackColor = System.Drawing.Color.LightGray;
            this.lsvClients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.lsvClients, "lsvClients");
            this.lsvClients.ForeColor = System.Drawing.Color.Black;
            this.lsvClients.FullRowSelect = true;
            this.lsvClients.GridLines = true;
            this.lsvClients.HideSelection = false;
            this.lsvClients.Name = "lsvClients";
            this.lsvClients.UseCompatibleStateImageBehavior = false;
            this.lsvClients.View = System.Windows.Forms.View.Details;
            // 
            // lblTotalBalance
            // 
            resources.ApplyResources(this.lblTotalBalance, "lblTotalBalance");
            this.lblTotalBalance.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalBalance.ForeColor = System.Drawing.Color.LightGray;
            this.lblTotalBalance.Name = "lblTotalBalance";
            // 
            // frmTotalBalance
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::_07_Project_Bank_System.Properties.Resources.logo;
            this.Controls.Add(this.lblTotalBalance);
            this.Controls.Add(this.lsvClients);
            this.Controls.Add(this.btnBack);
            this.DoubleBuffered = true;
            this.Name = "frmTotalBalance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListView lsvClients;
        private System.Windows.Forms.Label lblTotalBalance;
    }
}