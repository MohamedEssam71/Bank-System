using BankSystem;
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
            SqlConnection con = new SqlConnection(Program.ConString);
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                string query = "SELECT Type FROM Loan " +
                    "WHERE BranchBranchNumber = " + Program.branchNumberGlobal +
                    "and BranchBankCode = " + Program.bankCodeGlobal;
                SqlCommand cmd = new SqlCommand(query, con);
                using (SqlDataReader sqlDataReader = cmd.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        typeLoanComboBox.Items.Add((string)sqlDataReader["Type"]);
                    }
                }
            }
            con.Close();


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
                SqlConnection con = new SqlConnection(Program.ConString);
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    string InitialQuery = "SELECT LoanNumber FROM Loan WHERE Type = '" + typeLoanComboBox.Text.ToString() + "'" +
                        " and BranchBankCode = " + Program.bankCodeGlobal + " and " +
                        "BranchBranchNumber = " + Program.branchNumberGlobal; ;
                    SqlCommand tmpCmd = new SqlCommand(InitialQuery, con);
                    int LoanNumber = 0;
                    using (SqlDataReader sqlDataReader = tmpCmd.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            LoanNumber = (int)sqlDataReader["LoanNumber"];
                        }
                    }

                    string query = "Insert into Loan_Person(amount, status, PersonSSN, LoanLoanNumber) " +
                        "Values('" + amountLoanTextBox.Text.ToString() + "', " +
                        "'" + "pending" + "', '" + Program.ssnGlobal + "', " + LoanNumber + ")";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Request Sent Successfully", "Well Done");
                    amountLoanTextBox.Clear();
                    typeLoanComboBox.Text = "";
                }
                con.Close();

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
