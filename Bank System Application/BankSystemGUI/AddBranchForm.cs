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
    public partial class AddBranchForm : Form
    {
        private Thread th;
        public AddBranchForm()
        {
            InitializeComponent();
        }

        private void AddBankForm_Load(object sender, EventArgs e)
        {

        }

        private void backToAdminLabel_Click(object sender, EventArgs e)
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

        private void addBankConfirmButton_Click(object sender, EventArgs e)
        {
            if (!checkIfAddBankFill())
            {
                MessageBox.Show("Fill all the empty places !", "Error");
            }
            else
            {
                if (!isValidBankCode())
                {
                    MessageBox.Show("The Bank Code is not Found, Please Insert a new one", "Error");
                }
                else
                {
                    SqlConnection con = new SqlConnection(Program.ConString);
                    con.Open();
                    if (con.State == ConnectionState.Open)
                    {
                        string query = "INSERT INTO Branch(bankCode, branchNumber, address) VALUES ('" +
                            bankCodeBranchTextBox.Text + "', '" + codeBranchTextBox.Text + "', '" +
                            addressBranchTextBox.Text.ToString() + "')";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                    MessageBox.Show("Branch Added Successfully", "Well Done");
                    bankCodeBranchTextBox.Clear();
                    codeBranchTextBox.Clear();
                    addressBranchTextBox.Clear();
                }

            }

        }
        private bool isValidBankCode()
        {
            SqlConnection con = new SqlConnection(Program.ConString);
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                string query = "SELECT Code FROM Bank";
                SqlCommand cmd = new SqlCommand(query, con);

                using (SqlDataReader sqlDataReader = cmd.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        int result = sqlDataReader.GetInt32(0);
                        if (result == int.Parse(bankCodeBranchTextBox.Text))
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
        private bool checkIfAddBankFill()
        {
            if (bankCodeBranchTextBox.TextLength == 0 || codeBranchTextBox.TextLength == 0
                || addressBranchTextBox.TextLength == 0)
            {
                return false;
            }
            return true;

        }

        private void codeBankTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
