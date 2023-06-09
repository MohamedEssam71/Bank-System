using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            SqlConnection con = new SqlConnection(Program.ConString);
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                string query = "SELECT LP.LoanPersonID, L.Type, LP.Amount,LP.Status" +
                    " FROM Loan L INNER JOIN Loan_Person LP ON " +
                    "L.LoanNumber = LP.LoanLoanNumber AND LP.PersonSSN = " + Program.ssnGlobal;
                /*string query = "SELECT L.LoanNumber, L.Type, LP.Amount FROM Loan L, Loan_Person LP where " +
                    "L.LoanNumber = LP.LoanLoanNumber and LP.PersonSSN = " + Program.ssnGlobal;*/
                SqlCommand cmd = new SqlCommand(query, con);

                using (SqlDataReader sqlDataReader = cmd.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        CustomerLoanListControl loansControl = new CustomerLoanListControl();
                        loansControl.Type = (string)sqlDataReader["Type"];
                        loansControl.LoanPersonID = (int)sqlDataReader["LoanPersonID"];
                        loansControl.State = (string)sqlDataReader["Status"];
                        loansControl.Amount = (decimal)sqlDataReader["Amount"];
                        loansControl.BankCode = Program.bankCodeGlobal;
                        loansControl.BranchNumber = Program.branchNumberGlobal;
                        loans.Add(loansControl);
                        customerLoanFlowControl.Controls.Add(loansControl);

                    }
                }
            }
            con.Close();
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
