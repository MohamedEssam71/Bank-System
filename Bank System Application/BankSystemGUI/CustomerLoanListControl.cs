using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BankSystemGUI
{
    public partial class CustomerLoanListControl : UserControl
    {
        public CustomerLoanListControl()
        {
            InitializeComponent();
        }

        private string type;
        private int number;
        private int amount;
        public string Type
        {
            get { return type; }
            set { this.type = value; loanTypeLabel.Text = value; }
        }
        public int Number
        {
            get { return number; }
            set { this.number = value; loanDescriptionLabel.Text += ("Code: " + value); }
        }
        public int Amount
        {
            get { return amount; }
            set { this.amount = value; loanDescriptionLabel.Text += ("\nAmount: " + value); }
        }

    }
}
