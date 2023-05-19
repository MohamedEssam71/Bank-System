using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystemGUI
{
    public partial class CustomerListControl : UserControl
    {
        public CustomerListControl()
        {
            InitializeComponent();
        }
        private string name;
        private string ssn;
        private string phone;
        private string address;
        private int branchNumber;
        private int bankCode;

        private void CustomerListControl_Load(object sender, EventArgs e)
        {

        }

        private void customerNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void separationPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        public new string Name
        {
            get { return name; }
            set { this.name = value; customerNameLabel.Text = value; }
        }
        public string SSN
        {
            get { return ssn; }
            set { this.ssn = value; customerDescriptionLabel.Text += ("ID: " + value); }
        }
        public string Phone
        {
            get { return phone; }
            set { this.phone = value; customerDescriptionLabel.Text += ("\nPhone: " + value); }
        }
        public string Address
        {
            get { return address; }
            set { this.address = value; customerDescriptionLabel.Text += ("\nAddress: " + value); }
        }

        public int BankCode
        {
            get { return bankCode; }
            set { this.bankCode = value; customerDescriptionLabel.Text += "\nBank Code: " + value; }
        }
        public int BranchNumber
        {
            get { return branchNumber; }
            set { this.branchNumber = value; customerDescriptionLabel.Text += ",   Branch Number: " + value; }
        }
    }
}
