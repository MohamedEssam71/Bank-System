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
    public partial class ShowLoansAdmin : Form
    {
        private Thread th;

        private List<CustomerLoanListControl> loans = new List<CustomerLoanListControl>();
        public ShowLoansAdmin()
        {
            InitializeComponent();
        }

        private void backToEmployeeLabel_Click(object sender, EventArgs e)
        {
            th = new Thread(openAdminPanelForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }
        private void openAdminPanelForm()
        {
            Application.Run(new AdminForm());
        }

        private void confirmStateLoanButton_Click(object sender, EventArgs e)
        {
            if (!checkIfFill())
            {
                MessageBox.Show("Fill all the empty places !", "Error");
            }
            else
            {
                if (stateLoanComboBox.Text == "Delete")
                {
                    SqlConnection con = new SqlConnection(Program.ConString);
                    con.Open();
                    if (con.State == ConnectionState.Open)
                    {
                        // Retrieve the bank code of the admin
                        string bankCodeQuery = "SELECT BranchBankCode FROM Person WHERE SSN = '" + Program.ssnGlobal + "'";
                        SqlCommand bankCodeCmd = new SqlCommand(bankCodeQuery, con);
                        int bankCode = (int)bankCodeCmd.ExecuteScalar();

                        string LoanPersonIDQuery = "SELECT LoanLoanNumber FROM Loan_Person WHERE " +
                            "PersonSSN = '" + ssnTextBox.Text + "' AND LoanPersonID = "
                            + int.Parse(adminNumberLoanTextBox.Text);
                        SqlCommand LoanCmd = new SqlCommand(LoanPersonIDQuery, con);
                        int LoanLoanNumber = (int)LoanCmd.ExecuteScalar();

                        string query = "DELETE FROM Loan_Person " +
                                       "WHERE LoanPersonID = " + int.Parse(adminNumberLoanTextBox.Text) +
                                       " AND PersonSSN = '" + ssnTextBox.Text.ToString() + "' " +
                                       "AND EXISTS " +
                                       "(SELECT 1 FROM Loan l INNER JOIN Person p ON l.BranchBranchNumber = p.BranchBranchNumber AND l.BranchBankCode = p.BranchBankCode " +
                                       "WHERE l.LoanNumber = " + LoanLoanNumber +
                                       " AND p.BranchBankCode = " + bankCode + ")";

                        SqlCommand cmd = new SqlCommand(query, con);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Loan has been deleted", "Success");
                        }
                        else
                        {
                            MessageBox.Show("Loan not found or you don't have access to delete it", "Error");
                        }
                    }
                    stateLoanComboBox.Text = string.Empty;
                    adminNumberLoanTextBox.Clear();
                    ssnTextBox.Clear();
                    con.Close();
                    return;
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
                            string isAccepted = stateLoanComboBox.Text == "Accept" ? "Accepted" : "Rejected";
                            SqlConnection con = new SqlConnection(Program.ConString);
                            con.Open();
                            if (con.State == ConnectionState.Open)
                            {
                                string query = "UPDATE Loan_Person Set status = '" +
                                    isAccepted + "'" +
                                    ",employeeSSN = '" + Program.ssnGlobal + "' " +
                                    "WHERE LoanPersonID = " + int.Parse(adminNumberLoanTextBox.Text) +
                                    " and PersonSSN = '" + ssnTextBox.Text.ToString() + "'";

                                SqlCommand cmd = new SqlCommand(query, con);
                                cmd.ExecuteNonQuery();
                            }
                            con.Close();

                            MessageBox.Show("Loan Action confirmed Successfully", "Well Done");
                            stateLoanComboBox.Text = string.Empty;
                            ssnTextBox.Text = string.Empty;
                            adminNumberLoanTextBox.Clear();
                        }
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
                string query = "SELECT lp.LoanPersonID, lp.PersonSSN " +
                    "FROM Loan_Person lp " +
                    "INNER JOIN Loan l ON lp.LoanLoanNumber = l.LoanNumber " +
                    "WHERE lp.LoanPersonID = " + int.Parse(adminNumberLoanTextBox.Text) + " " +
                    "AND l.BranchBankCode = " + Program.bankCodeGlobal + " " +
                    "AND l.BranchBranchNumber IN (SELECT BranchNumber FROM Branch WHERE BankCode = " + Program.bankCodeGlobal + ")";
                SqlCommand cmd = new SqlCommand(query, con);

                using (SqlDataReader sqlDataReader = cmd.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        int result = sqlDataReader.GetInt32(0);
                        string ssn = sqlDataReader.GetString(1);
                        if (result == int.Parse(adminNumberLoanTextBox.Text) && ssn == ssnTextBox.Text)
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
                string query = "SELECT Status " +
                    "FROM Loan_Person " +
                    "WHERE LoanPersonID = " + int.Parse(adminNumberLoanTextBox.Text) + " " +
                    "AND PersonSSN = '" + ssnTextBox.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);

                using (SqlDataReader sqlDataReader = cmd.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        string result = sqlDataReader.GetString(0);
                        if (result.Equals("Pending", StringComparison.OrdinalIgnoreCase))
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
            if (adminNumberLoanTextBox.Text.Length == 0 || stateLoanComboBox.Text.Length == 0
                || ssnTextBox.Text.Length == 0)
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
            if (adminLoansFlowControl.Controls.Count > 0)
            {
                adminLoansFlowControl.Controls.Clear();
                loans.Clear();
            }

            SqlConnection con = new SqlConnection(Program.ConString);
            con.Open();
            if (con.State == ConnectionState.Open)
            {


                // loan from the same bank as the admin.
                string query = "SELECT lp.LoanPersonID, lp.PersonSSN, l.Type, lp.Amount, l.BranchBankCode," +
                    " l.BranchBranchNumber, lp.Status, p.Name as customerName, p2.Name as EmployeeName " +
                "FROM Loan_Person lp " +
                "INNER JOIN Loan l ON lp.LoanLoanNumber = l.LoanNumber " +
                "Left OUTER JOIN Person p2 on lp.EmployeeSSN = p2.SSN " +
                "Left OUTER JOIN Person p on lp.PersonSSN = p.SSN " +
                "WHERE l.BranchBankCode = " + Program.bankCodeGlobal;
                /*
                "INNER JOIN Person p ON p.SSN = lp.PersonSSN " +
                "WHERE p.BranchBankCode = (SELECT BranchBankCode FROM Person WHERE SSN = '" + Program.ssnGlobal + "') " +
                "AND lp.Status <> 'Delete'";
                */

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
                        string loanState = sqlDataReader.GetString(6);
                        string customerName = sqlDataReader.GetString(7);
                        string employeeName = sqlDataReader["EmployeeName"] == DBNull.Value ? string.Empty
                            : (string)sqlDataReader["EmployeeName"];

                        CustomerLoanListControl loan = new CustomerLoanListControl();
                        loan.Type = typeResult;
                        loan.LoanPersonID = loanNumberResult;
                        loan.State = loanState;

                        if (employeeName == "")
                        {
                            loan.CustomerName = customerName;
                        }
                        else
                        {
                            loan.EmployeeName = employeeName;
                            loan.CustomerNameComma = customerName;
                        }
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
                adminLoansFlowControl.Visible = false;
            }
            else
            {
                this.Width = 951;
                for (int i = 0; i < loans.Count; i++)
                {
                    adminLoansFlowControl.Controls.Add(loans[i]);
                }
            }
        }

        private void ShowLoansAdmin_Load(object sender, EventArgs e)
        {
            populateLoans();
        }

        private void reloadLabel_Click(object sender, EventArgs e)
        {
            if (loans.Count == 0)
            {
                MessageBox.Show("No Loans available !", "Note");
                return;
            }
            adminLoansFlowControl.Controls.Clear();
            loans.Clear();
            populateLoans();
        }

        private void employeeStateLoanComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
