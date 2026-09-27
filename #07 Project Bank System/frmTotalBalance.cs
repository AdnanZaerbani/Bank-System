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
    public partial class frmTotalBalance : Form
    {
        sbyte CounterAccount = 0;
        double TotalBalance = 0;

        const string ClientList = @"C:\Users\Adnan\Desktop\#07 Project Bank System\#07 Project Bank System\ClientList.txt";
        string Seperator = "#//#";
        public frmTotalBalance()
        {
            InitializeComponent();
            lsvClients.View = View.Details;
            lsvClients.FullRowSelect = true;
            lsvClients.GridLines = true;
            lsvClients.Columns.Add("Account ID", 100);
            lsvClients.Columns.Add("Full Name", 300);
            lsvClients.Columns.Add("National ID", 110);
            lsvClients.Columns.Add("Balance", 200);
            lsvClients.Items.Clear();
            if (!File.Exists(ClientList))
            {
                MessageBox.Show("File not found!");
                return;
            }

            foreach (string line in File.ReadLines(ClientList))
            {
                string[] p = line.Split(new string[] { Seperator }, StringSplitOptions.None);
                if (p.Length < 14) continue;

                ListViewItem item = new ListViewItem(p[0]);
                item.SubItems.Add(p[2]);
                item.SubItems.Add(p[3]);
                item.SubItems.Add(p[8]);
                lsvClients.Items.Add(item);
                CounterAccount++;
                TotalBalance += double.Parse(p[8]);
            }

            lblTotalBalance.Text = "The total balance held by the bank is " + TotalBalance + " \ndistributed across " + CounterAccount + " accounts";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form form = new frmSystem();
            form.Show();
            this.Close();
        }
    }
}
