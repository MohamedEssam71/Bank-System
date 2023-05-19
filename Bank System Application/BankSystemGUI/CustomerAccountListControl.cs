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

        private string type;
        private decimal balance;
        public string Type
        {
            get { return type; }
            set { this.type = value; accountTypeLabel.Text = value; }
        }
        public decimal Balance
        {
            get { return balance; }
            set { this.balance = value; accountDetailLabel.Text += ("Balance: " + value); }
        }
        
    }
}
