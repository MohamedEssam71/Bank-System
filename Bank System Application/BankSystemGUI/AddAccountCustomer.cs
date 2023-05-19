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
    public partial class AddAccountCustomer : Form
    {
        private Thread th;
        public AddAccountCustomer()
        {

            InitializeComponent();

        }

        private void typeLoanComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void populateDropDownLoanList()
        {
            // need to get type of account from the DataBase


            SqlConnection con = new SqlConnection(Program.ConString);
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                /*
                 inner join Person on " +
                    "Account.PersonSSN = Person.ssn WHERE Person.BranchBranchNumber = "
                    + Program.branchNumberGlobal + " and Person.BranchBankCode = " +
                    Program.bankCodeGlobal + "
                */
                string query = "SELECT Account.Type from Account GROUP BY Account.Type";
                SqlCommand cmd = new SqlCommand(query, con);

                using (SqlDataReader sqlDataReader = cmd.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        string result = sqlDataReader.GetString(0);
                        typeAccountComboBox.Items.Add(result);
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
                //Code to Add new Account with new primary key
                SqlConnection con = new SqlConnection(Program.ConString);
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    string query = "Insert into Account(Balance, Type, PersonSSN)" +
                        "Values(" + int.Parse(balanceAccountTextBox.Text) + ", " +
                        "'" + typeAccountComboBox.Text.ToString() + "', " + 
                        "'" + Program.ssnGlobal + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                }
                con.Close();
                MessageBox.Show("Account Added Successfully", "Well Done");
                balanceAccountTextBox.Clear();
                typeAccountComboBox.Text = "";

            }

        }
        private bool checkIfLoanFill()
        {
            if (balanceAccountTextBox.TextLength == 0 || typeAccountComboBox.Text.Length == 0)
            {
                return false;
            }
            return true;
        }

        private void AddAccountCustomer_Load(object sender, EventArgs e)
        {
            populateDropDownLoanList();
        }
    }
}
