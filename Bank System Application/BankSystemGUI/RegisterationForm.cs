using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystemGUI
{
    public partial class RegisterationForm : Form
    {
        private Thread th;
        
        public RegisterationForm()
        {
            InitializeComponent();
            populateBankNumCode();
            if (bankNumComboBox.Text.Length != 0)
            {
                branchNumComboBox.Visible = true;
                branchNumLabel.Visible = true;
            }
        }

        private void populateBankNumCode()
        {
            SqlConnection con = new SqlConnection(Program.ConString);
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                string query = "SELECT Code from Bank ORDER BY Code";
                SqlCommand cmd = new SqlCommand(query, con);

                using (SqlDataReader sqlDataReader = cmd.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        int result = sqlDataReader.GetInt32(0);
                        bankNumComboBox.Items.Add(result);
                    }
                }
            }
            con.Close();
        }
        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameLabel_Click(object sender, EventArgs e)
        {
        }

        private void signConfirmButton_Click(object sender, EventArgs e)
        {

            if (!checkIfRegisterFill())
            {
                MessageBox.Show("Fill all the empty places !", "Error");
            }
            else
            {
                if (!isValidSSN())
                {
                    MessageBox.Show("The SSN is used Before, Please Insert a new one", "Error");
                }
                else
                {
                    SqlConnection con = new SqlConnection(Program.ConString);
                    con.Open();
                    if (con.State == ConnectionState.Open)
                    {
                        string query = "INSERT INTO Person(ssn, name, password, type, phone, address, " +
                            "BranchBranchNumber, BranchBankCode) " +
                            "VALUES ('" + ssnTextBox.Text.ToString() + "', '" + usernameTextBox.Text.ToString() +
                            "', '" + passwordTextBox.Text.ToString() + "', '" + typeDropDownList.Text.ToString() +
                            "', '" + phoneTextBox.Text.ToString() + "', '" + addressTextBox.Text.ToString() + "', '"
                            + branchNumComboBox.Text.ToString() + "', '" + bankNumComboBox.Text.ToString() + "')";

                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registration Complete", "Well Done");
                        th = new Thread(openMainForm);
                        th.SetApartmentState(ApartmentState.STA);
                        th.Start();
                        this.Close();
                    }
                }
            }
        }
        private bool isValidSSN()
        {
            SqlConnection con = new SqlConnection(Program.ConString);
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                string query = "SELECT ssn FROM Person";
                SqlCommand cmd = new SqlCommand(query, con);

                using (SqlDataReader sqlDataReader = cmd.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        string result = sqlDataReader.GetString(0);
                        if(result == ssnTextBox.Text)
                        {
                            return false;
                        }
                    }
                }
            }
            con.Close();
            return true;
        }
        private bool checkIfRegisterFill()
        {
            if (ssnTextBox.Text.Length == 0 || usernameTextBox.Text.Length == 0
                || passwordTextBox.Text.Length == 0 || phoneTextBox.Text.Length == 0
                || addressTextBox.TextLength == 0 || typeDropDownList.Text.Length == 0)
            {
                return false;
            }
            return true;
        }

        private void goBackToMainButton_Click(object sender, EventArgs e)
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

        private void bankNumComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            branchNumComboBox.Items.Clear();

            if (bankNumComboBox.Text.Length != 0)
            {
                branchNumComboBox.Visible = true;
                branchNumLabel.Visible = true;
            }

            SqlConnection con = new SqlConnection(Program.ConString);
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                string query = "SELECT BranchNumber from Branch WHERE BankCode = "
                    + bankNumComboBox.Text + " ORDER BY BranchNumber";
                SqlCommand cmd = new SqlCommand(query, con);

                using (SqlDataReader sqlDataReader = cmd.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        int result = sqlDataReader.GetInt32(0);
                        branchNumComboBox.Items.Add(result);
                    }
                }
            }
            con.Close();
        }

        private void ssnTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
