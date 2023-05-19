using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
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
                if (!isValidLoanNumber())
                {
                    MessageBox.Show("Loan Number isn't Found !", "Error");
                }
                else
                {
                    //Code to change database loan attribute to accept, reject, pending
                    if (!isPendingLoan())
                    {
                        MessageBox.Show("This Loan is not in pending state !", "Error");
                    }
                    else
                    {
                        SqlConnection con = new SqlConnection(Program.ConString);
                        con.Open();
                        if (con.State == ConnectionState.Open)
                        {
                            string query = "UPDATE Loan Set status = '" +
                                employeeStateLoanComboBox.Text.ToString() + "' " +
                                "WHERE LoanNumber = " + int.Parse(emplyeeNumberLoanTextBox.Text);
                            SqlCommand cmd = new SqlCommand(query, con);
                            cmd.ExecuteNonQuery();
                        }
                        con.Close();

                        MessageBox.Show("Loan Action confirmed Successfully", "Well Done");
                        employeeStateLoanComboBox.Text = string.Empty;
                        emplyeeNumberLoanTextBox.Clear();
                    }
                }
            }

        }
        private bool isValidLoanNumber()
        {
            SqlConnection con = new SqlConnection(Program.ConString);
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                string query = "SELECT LoanNumber FROM Loan where " +
                    "BranchBranchNumber = " + Program.branchNumberGlobal + " " +
                    "and BranchBankCode = " + Program.bankCodeGlobal;
                SqlCommand cmd = new SqlCommand(query, con);

                using (SqlDataReader sqlDataReader = cmd.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        int result = sqlDataReader.GetInt32(0);
                        if (result == int.Parse(emplyeeNumberLoanTextBox.Text))
                        {
                            con.Close();
                            return true;
                        }
                    }
                }
            }
            con.Close();
            return false;
        }
        private bool isPendingLoan()
        {
            SqlConnection con = new SqlConnection(Program.ConString);
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                string query = "SELECT status FROM Loan where LoanNumber = " +
                    int.Parse(emplyeeNumberLoanTextBox.Text);
                SqlCommand cmd = new SqlCommand(query, con);

                using (SqlDataReader sqlDataReader = cmd.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        string result = sqlDataReader.GetString(0);
                        if (result == "Pending")
                        {
                            con.Close();
                            return true;
                        }
                    }
                }
            }
            con.Close();
            return false;
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
            if (employeeLoansFlowControl.Controls.Count > 0)
            {
                employeeLoansFlowControl.Controls.Clear();
                loans.Clear();
            }

            // load loans that from the same branch and is pending to make employee choose from them.

            SqlConnection con = new SqlConnection(Program.ConString);
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                // loan from the same branch and bank as the employee.
                string query = "SELECT * from Loan where BranchBankCode IN (" +
                    "select BranchBankCode from Person where ssn = '" + Program.ssnGlobal + "')" +
                    "and BranchBranchNumber IN (select BranchBranchNumber from Person where " +
                    "ssn = '" + Program.ssnGlobal + "') and status = 'Pending'";
                SqlCommand cmd = new SqlCommand(query, con);

                using (SqlDataReader sqlDataReader = cmd.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        int loanNumberResult = sqlDataReader.GetInt32(0);
                        string typeResult = sqlDataReader.GetString(1);
                        SqlMoney amountResult = sqlDataReader.GetSqlMoney(2);
                        int bankCodeResult = sqlDataReader.GetInt32(5);
                        int branchNumberResult = sqlDataReader.GetInt32(4);


                        CustomerLoanListControl loan = new CustomerLoanListControl();
                        loan.Type = typeResult;
                        loan.Number = loanNumberResult;
                        loan.State = "Pending";
                        loan.Amount = amountResult;
                        loan.BankCode = bankCodeResult;
                        loan.BranchNumber = branchNumberResult;
                        loans.Add(loan);
                    }
                }
            }
            con.Close();

            if (loans.Count <= 0)
            {
                this.Width = 359;
                employeeLoansFlowControl.Visible = false;
            }
            else
            {
                this.Width = 951;
                for (int i = 0; i < loans.Count; i++)
                {
                    employeeLoansFlowControl.Controls.Add(loans[i]);
                }
            }

        }

        private void ShowLoansEmployee_Load(object sender, EventArgs e)
        {
            populateLoans();
        }

        private void reloadLabel_Click(object sender, EventArgs e)
        {
            if (loans.Count == 0)
            {
                MessageBox.Show("No Pending Loans available !", "Note");
                return;
            }
            employeeLoansFlowControl.Controls.Clear();
            loans.Clear();
            populateLoans();
        }
    }
}
