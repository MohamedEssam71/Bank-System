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
    public partial class UpdateAdminDetails : Form
    {
        private Thread th;
        public UpdateAdminDetails()
        {
            InitializeComponent();
            populateBankNumCode();
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

        private void updateConfirmButton_Click(object sender, EventArgs e)
        {
            if (!checkIfFill())
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
                    DialogResult dialogResult = new DialogResult();
                    dialogResult = MessageBox.Show("Sure you want to Save Changes ? ", "Confirmation", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        // save new data customer in database
                        SqlConnection con = new SqlConnection(Program.ConString);
                        con.Open();
                        if (con.State == ConnectionState.Open)
                        {
                            string query = "UPDATE Person SET " +
                                "ssn = '" + ssnTextBox.Text.ToString() + "', " +
                                "name = '" + usernameTextBox.Text.ToString() + "', " +
                                "password = '" + passwordTextBox.Text.ToString() + "', " +
                                "phone = '" + phoneTextBox.Text.ToString() + "', " +
                                "address = '" + addressTextBox.Text.ToString() + "', " +
                                "BranchBranchNumber = " + branchNumComboBox.Text + ", " +
                                "BranchBankCode = " + bankNumComboBox.Text + " " +
                                "WHERE ssn = '" + Program.ssnGlobal + "'";
                            SqlCommand cmd = new SqlCommand(query, con);
                            cmd.ExecuteNonQuery();
                        }
                        con.Close();
                        MessageBox.Show("Data Saved Successfully !", "Update");
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
                        if (result == ssnTextBox.Text && Program.ssnGlobal != ssnTextBox.Text)
                        {
                            return false;
                        }
                    }
                }
            }
            con.Close();
            return true;
        }

        private bool checkIfFill()
        {
            if (ssnTextBox.Text.Length == 0 || usernameTextBox.Text.Length == 0
                || passwordTextBox.Text.Length == 0 || phoneTextBox.Text.Length == 0
                || addressTextBox.TextLength == 0)
            {
                return false;
            }
            return true;
        }

        private void goBackToMainButton_Click(object sender, EventArgs e)
        {
            th = new Thread(openAdminForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }
        private void openAdminForm()
        {
            Application.Run(new AdminForm());
        }

        private void registrationPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void UpdateCustomerDetails_Load(object sender, EventArgs e)
        {
            populateProfileData();
        }
        private void populateProfileData()
        {

            SqlConnection con = new SqlConnection(Program.ConString);
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                string query = "SELECT * FROM Person WHERE SSN = '" + Program.ssnGlobal + "'";
                SqlCommand cmd = new SqlCommand(query, con);

                using (SqlDataReader sqlDataReader = cmd.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        string ssnResult = sqlDataReader.GetString(0);
                        string usernameResult = sqlDataReader.GetString(1);
                        string passwordResult = sqlDataReader.GetString(2);
                        string phoneResult = sqlDataReader.GetString(4);
                        string addressResult = sqlDataReader.GetString(5);
                        int bankCodeResult = sqlDataReader.GetInt32(7);
                        int branchNumResult = sqlDataReader.GetInt32(6);

                        usernameTextBox.Text = usernameResult;
                        passwordTextBox.Text = passwordResult;
                        ssnTextBox.Text = ssnResult;
                        phoneTextBox.Text = phoneResult;
                        addressTextBox.Text = addressResult;
                        bankNumComboBox.Text = bankCodeResult.ToString();
                        branchNumComboBox.Text = branchNumResult.ToString();

                    }
                }
            }
            con.Close();
        }

        private void bankNumComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            branchNumComboBox.Items.Clear();
            branchNumComboBox.Text = "";

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
    }
}
