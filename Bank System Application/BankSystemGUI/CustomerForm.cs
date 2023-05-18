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
    public partial class CustomerForm : Form
    {
        private Thread th;
        public CustomerForm()
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

        private void requestLoanButton_Click(object sender, EventArgs e)
        {
            th = new Thread(openRequestLoanForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }
        private void openRequestLoanForm()
        {
            Application.Run(new RequestLoan());
        }

        private void showLoanButton_Click(object sender, EventArgs e)
        {
            th = new Thread(openShowLoansForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }
        private void openShowLoansForm()
        {
            Application.Run(new ShowLoansCustomer());
        }
    }
}
