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
    public partial class LoginForm : Form
    {
        private Thread th;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void goBackToMainLabel_Click(object sender, EventArgs e)
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

        private void clearFieldsLabel_Click(object sender, EventArgs e)
        {
            ssnLoginTextBox.Clear();
            passwordLoginTextBox.Clear();
        }

        private void loginConfirmButton_Click(object sender, EventArgs e)
        {
            if (!checkIfFill())
            {
                MessageBox.Show("Fill all the empty places !", "Error");
            }
            else
            {
                // Check DataBase
                SqlConnection con = new SqlConnection(Program.ConString);
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    string query = "SELECT ssn, password, type, BranchBranchNumber, BranchBankCode FROM Person WHERE " +
                        "ssn = " + "'" + ssnLoginTextBox.Text.ToString() +"'" + " AND " +
                        "password = " + "'" + passwordLoginTextBox.Text.ToString() + "'";
                    SqlCommand cmd = new SqlCommand(query, con);

                    using (SqlDataReader sqlDataReader = cmd.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            string ssnResult = sqlDataReader.GetString(0);
                            string passResult = sqlDataReader.GetString(1);
                            string typeResult = sqlDataReader.GetString(2); 
                            int branchResult = sqlDataReader.GetInt32(3);
                            int bankCodeResult = sqlDataReader.GetInt32(4);
                            if(ssnLoginTextBox.Text == ssnResult)
                            {
                                if(passResult == passwordLoginTextBox.Text)
                                {
                                    Program.ssnGlobal = ssnResult;
                                    Program.passwordGlobal = passResult;
                                    Program.bankCodeGlobal = bankCodeResult;
                                    Program.branchNumberGlobal = branchResult;

                                    if (typeResult == "Admin")
                                    {
                                        th = new Thread(openAdminForm);
                                    }
                                    else if (typeResult == "Employee")
                                    {
                                        th = new Thread(openEmployeeForm);
                                    }
                                    else if (typeResult == "Customer")
                                    {
                                        th = new Thread(openCustomerForm);
                                    }
                                    con.Close();
                                    th.SetApartmentState(ApartmentState.STA);
                                    th.Start();
                                    this.Close();
                                    return;
                                }
                            }
                        }
                    }
                }
                MessageBox.Show("Username or Password is incorrect !", "Error");
                ssnLoginTextBox.Clear();
                passwordLoginTextBox.Clear();
                return;
            }

        }
        private bool checkIfFill()
        {
            if (ssnLoginTextBox.TextLength == 0 || passwordLoginTextBox.TextLength == 0)
            {
                return false;
            }
            return true;
        }
        private void openCustomerForm()
        {
            Application.Run(new CustomerForm());
        }
        private void openEmployeeForm()
        {
            Application.Run(new EmployeeForm());
        }
        private void openAdminForm()
        {
            Application.Run(new AdminForm());
        }

        private void ssnLoginTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
