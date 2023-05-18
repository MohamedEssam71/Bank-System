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
    public partial class ShowLoansCustomer : Form
    {
        private Thread th;

        private List<CustomerLoanListControl> loans = new List<CustomerLoanListControl>();
        public ShowLoansCustomer()
        {
            InitializeComponent();
        }

        private void customerLoanListControl1_Load(object sender, EventArgs e)
        {

        }

        private void ShowLoansCustomer_Load(object sender, EventArgs e)
        {
            populateLoans();
        }

        private void populateLoans()
        {
            // get loans from dataBase and change fix size
            for (int i = 0; i < 5; i++)
            {
                CustomerLoanListControl loansControl = new CustomerLoanListControl();
                loansControl.Type = "Industrial Loan";
                loansControl.Number = 3333;
                loansControl.Amount = 1234;
                loans.Add(loansControl);
                customerLoanFlowControl.Controls.Add(loansControl);

            }
        }

        private void backToCustomerPanel_Click(object sender, EventArgs e)
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

        private void customerLoanFlowControl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
