using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystemGUI
{
    public partial class CustomerAccountListControl : UserControl
    {
        public CustomerAccountListControl()
        {
            InitializeComponent();
        }
        private int accNumber;
        private string type;
        private decimal balance;
        public string Type
        {
            get { return type; }
            set { this.type = value; accountTypeLabel.Text = value; }
        }
        public int AccNumber
        {
            get { return accNumber; }
            set { this.accNumber = value; accountDetailLabel.Text += "Account Number -> " + value; }
        }
        public decimal Balance
        {
            get { return balance; }
            set { this.balance = value; accountDetailLabel.Text += ("\nBalance: " + value); }
        }
        
    }
}
