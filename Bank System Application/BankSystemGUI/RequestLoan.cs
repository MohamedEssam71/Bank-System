using BankSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystemGUI
{
    public partial class RequestLoan : Form
    {
        private Thread th;
        public RequestLoan()
        {

            InitializeComponent();
            populateDropDownLoanList();

        }

        private void typeLoanComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void populateDropDownLoanList()
        {
            // need to get type from the DataBase


            for (int i = 0; i < 5; ++i)
            {
                typeLoanComboBox.Items.Add("Mohamed");
            }

        }

        private void backToCustomerPanelLabel_Click(object sender, EventArgs e)
        {
            th = new Thread(openCustomerPanelForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }
        private void openCustomerPanelForm()
        {
            Application.Run(new CustomerForm());
        }

        private void requestConfirmButton_Click(object sender, EventArgs e)
        {
            if (!checkIfLoanFill())
            {
                MessageBox.Show("Fill all the empty places !", "Error");
            }
            else
            {
                //Code to send Request
                MessageBox.Show("Request Send Successfully", "Well Done");
                amountLoanTextBox.Clear();
                typeLoanComboBox.Text = "";

            }

        }
        private bool checkIfLoanFill()
        {
            if (amountLoanTextBox.TextLength == 0 || typeLoanComboBox.Text.Length == 0)
            {
                return false;
            }
            return true;
        }
    }
}
