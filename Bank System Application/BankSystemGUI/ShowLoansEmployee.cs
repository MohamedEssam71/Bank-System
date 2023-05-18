﻿using System;
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
    public partial class ShowLoansEmployee : Form
    {
        private Thread th;

        private List<CustomerLoanListControl> loans = new List<CustomerLoanListControl>();
        public ShowLoansEmployee()
        {
            InitializeComponent();
        }

        private void backToEmployeeLabel_Click(object sender, EventArgs e)
        {
            th = new Thread(openEmployeePanelForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }
        private void openEmployeePanelForm()
        {
            Application.Run(new EmployeeForm());
        }

        private void confirmStateLoanButton_Click(object sender, EventArgs e)
        {
            if (!checkIfFill())
            {
                MessageBox.Show("Fill all the empty places !", "Error");
            }
            else
            {
                //Code to change database loan attribute to accept, reject, pending
                MessageBox.Show("Loan Action confirmed Successfully", "Well Done");
                employeeStateLoanComboBox.Text = string.Empty;
                emplyeeNumberLoanTextBox.Clear();
            }

        }
        private bool checkIfFill()
        {
            if (emplyeeNumberLoanTextBox.Text.Length == 0 || employeeStateLoanComboBox.Text.Length == 0)
            {
                return false;
            }
            return true;
        }

        private void employeeLoansFlowControl_Paint(object sender, PaintEventArgs e)
        {

        }
        private void populateLoans()
        {
            // load loans that from the same branch and is pending to make employee choose from them.
            for (int i = 0; i < 5; i++)
            {
                CustomerLoanListControl loansControl = new CustomerLoanListControl();
                loansControl.Type = "Industrial Loan";
                loansControl.Number = 3333;
                loansControl.Amount = 1234;
                loans.Add(loansControl);
                employeeLoansFlowControl.Controls.Add(loansControl);

            }
        }

        private void ShowLoansEmployee_Load(object sender, EventArgs e)
        {
            populateLoans();
        }
    }
}