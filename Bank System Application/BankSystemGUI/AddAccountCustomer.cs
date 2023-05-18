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
    public partial class AddAccountCustomer : Form
    {
        private Thread th;
        public AddAccountCustomer()
        {

            InitializeComponent();
            populateDropDownLoanList();

        }

        private void typeLoanComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void populateDropDownLoanList()
        {
            // need to get type of account from the DataBase


            for (int i = 0; i < 5; ++i)
            {
                typeAccountComboBox.Items.Add("Mohamed");
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
                //Code to Add new Account with new primary key
                MessageBox.Show("Account Added Successfully", "Well Done");
                amountAccountTextBox.Clear();
                typeAccountComboBox.Text = "";

            }

        }
        private bool checkIfLoanFill()
        {
            if (amountAccountTextBox.TextLength == 0 || typeAccountComboBox.Text.Length == 0)
            {
                return false;
            }
            return true;
        }
    }
}
