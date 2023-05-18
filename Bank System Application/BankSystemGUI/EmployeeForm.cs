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
    public partial class EmployeeForm : Form
    {
        private Thread th;
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void backToMainLabel_Click(object sender, EventArgs e)
        {
            th = new Thread(openMainForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }
        private void openMainForm()
        {
            Application.Run(new MainPage());
        }

        private void showLoansEmployeeButton_Click(object sender, EventArgs e)
        {
            th = new Thread(openEmployeeLoansForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }
        private void openEmployeeLoansForm()
        {
            Application.Run(new ShowLoansEmployee());
        }

        private void showCustomerListButton_Click(object sender, EventArgs e)
        {
            th = new Thread(openCustomerListEmployeeForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }
        private void openCustomerListEmployeeForm()
        {
            Application.Run(new CustomerListEmployee());
        }
    }
}
