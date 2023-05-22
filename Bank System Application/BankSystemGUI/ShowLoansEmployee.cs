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
                    MessageBox.Show("Loan Number or Personal SSN isn't Found !", "Error");
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
                        string isAccepted = employeeStateLoanComboBox.Text == "Accept" ? "Accepted" : "Rejected";
                        SqlConnection con = new SqlConnection(Program.ConString);
                        con.Open();
                        if (con.State == ConnectionState.Open)
                        {
                            string query = "UPDATE Loan_Person Set status = '" +
                                isAccepted + "', EmployeeSSn = '" + Program.ssnGlobal + "' " +
                                "WHERE LoanPersonID = " + int.Parse(emplyeeNumberLoanTextBox.Text) +
                                " and PersonSSN = '" + personSSNTextBox.Text.ToString() + "'";
                            SqlCommand cmd = new SqlCommand(query, con);
                            cmd.ExecuteNonQuery();
                        }
                        con.Close();

                        MessageBox.Show("Loan Action confirmed Successfully", "Well Done");
                        employeeStateLoanComboBox.Text = string.Empty;
                        personSSNTextBox.Text = string.Empty;
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
                string query = "SELECT Loan_Person.LoanPersonID, Loan_Person.personSSN FROM " +
                    "Loan_Person inner join Loan on Loan_Person.LoanLoanNumber = Loan.LoanNumber where " +
                    "BranchBranchNumber = " + Program.branchNumberGlobal + " " +
                    "and BranchBankCode = " + Program.bankCodeGlobal;
                SqlCommand cmd = new SqlCommand(query, con);

                using (SqlDataReader sqlDataReader = cmd.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        int result = sqlDataReader.GetInt32(0);
                        string ssn = sqlDataReader.GetString(1);
                        if (result == int.Parse(emplyeeNumberLoanTextBox.Text))
                        {
                            if (ssn == personSSNTextBox.Text)
                            {
                                con.Close();
                                return true;
                            }

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
                string query = "SELECT status FROM Loan_Person where LoanPersonID = " +
                    int.Parse(emplyeeNumberLoanTextBox.Text) + " AND personSSN = '" +
                    personSSNTextBox.Text.ToString() + "'";
                SqlCommand cmd = new SqlCommand(query, con);

                using (SqlDataReader sqlDataReader = cmd.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        string result = sqlDataReader.GetString(0);
                        if (result == "Pending" || result == "pending")
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
            if (emplyeeNumberLoanTextBox.Text.Length == 0 || employeeStateLoanComboBox.Text.Length == 0
                || personSSNTextBox.Text.Length == 0)
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
                string query = "SELECT lp.LoanPersonID,lp.PersonSSN, l.Type, lp.Amount" +
                    ", l.BranchBankCode, l.BranchBranchNumber, p.Name  from Loan_Person lp inner join Loan l " +
                    "on lp.LoanLoanNumber = l.LoanNumber " +
                    "left outer join person p on lp.PersonSSN = p.SSN " +
                    "where l.BranchBankCode IN (" +
                    "select p.BranchBankCode from Person p where ssn = '" + Program.ssnGlobal + "')" +
                    "and l.BranchBranchNumber IN (select p.BranchBranchNumber from Person p where " +
                    "ssn = '" + Program.ssnGlobal + "') and lp.status = 'Pending'";
                SqlCommand cmd = new SqlCommand(query, con);

                using (SqlDataReader sqlDataReader = cmd.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        int loanNumberResult = sqlDataReader.GetInt32(0);
                        string loanPersonSSN = sqlDataReader.GetString(1);
                        string typeResult = sqlDataReader.GetString(2);
                        SqlMoney amountResult = sqlDataReader.GetSqlMoney(3);
                        int bankCodeResult = sqlDataReader.GetInt32(4);
                        int branchNumberResult = sqlDataReader.GetInt32(5);
                        string customerName = sqlDataReader.GetString(6);

                        CustomerLoanListControl loan = new CustomerLoanListControl();
                        loan.Type = typeResult;
                        loan.LoanPersonID = loanNumberResult;
                        loan.State = "Pending";
                        loan.CustomerName = customerName;
                        loan.SSNPerson = loanPersonSSN;
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
