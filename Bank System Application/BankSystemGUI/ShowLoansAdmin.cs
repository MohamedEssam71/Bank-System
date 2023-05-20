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
                        string query = "DELETE FROM Loan_Person WHERE LoanLoanNumber = " +
                            + int.Parse(adminNumberLoanTextBox.Text) + " AND PersonSSN = '"
                            + ssnTextBox.Text.ToString() + "'";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Account has been deleted", "Well Done");
                    }
                    stateLoanComboBox.Text = string.Empty;
                    adminNumberLoanTextBox.Clear();
                    ssnTextBox.Clear();
                    con.Close();
                    return;
                }
                else
                {
                    //Write Here the code to change database loan attribute to accept, reject, pending
                }

                MessageBox.Show("Loan Action confirmed Successfully", "Well Done");
                stateLoanComboBox.Text = string.Empty;
                adminNumberLoanTextBox.Clear();
                ssnTextBox.Clear();
            }

        }
        private bool checkIfFill()
        {
            if (adminNumberLoanTextBox.Text.Length == 0 || stateLoanComboBox.Text.Length == 0)
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
            //Load All the loans from the same branch with customer and employee names;
            for (int i = 0; i < 5; i++)
            {
                CustomerLoanListControl loansControl = new CustomerLoanListControl();
                loansControl.Type = "Industrial Loan";
                loansControl.Number = 3333;
                loansControl.Amount = 1234;
                loans.Add(loansControl);
                adminLoansFlowControl.Controls.Add(loansControl);

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
                MessageBox.Show("No Pending Loans available !", "Note");
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
