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
    public partial class ShowAccountCustomer : Form
    {
        private Thread th;

        private List<CustomerAccountListControl> accounts = new List<CustomerAccountListControl>();
        public ShowAccountCustomer()
        {
            InitializeComponent();
        }

        private void customerLoanListControl1_Load(object sender, EventArgs e)
        {

        }

        private void ShowAccountCustomer_Load(object sender, EventArgs e)
        {
            populateAccounts();
        }

        private void populateAccounts()
        {
            customerAccountFlowControl.Controls.Clear();
            accounts.Clear();

            SqlConnection con = new SqlConnection(Program.ConString);
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                string query = "SELECT * from Account where Account.PersonSSN = " + Program.ssnGlobal;
                SqlCommand cmd = new SqlCommand(query, con);

                using (SqlDataReader sqlDataReader = cmd.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        CustomerAccountListControl accountControl = new CustomerAccountListControl();
                        accountControl.Type = (string)sqlDataReader["Type"];
                        accountControl.AccNumber = (int)sqlDataReader["AccountNumber"];
                        accountControl.Balance = (decimal)sqlDataReader["Balance"];
                        accounts.Add(accountControl);
                        customerAccountFlowControl.Controls.Add(accountControl);

                    }
                }
            }
            con.Close();
        }

        private void backToCustomerPanel_Click(object sender, EventArgs e)
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

        private void customerLoanFlowControl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (!checkIfFill())
            {
                MessageBox.Show("Fill all the empty places !", "Error");
            }
            else
            {
                DialogResult dialogResult = new DialogResult();
                dialogResult = MessageBox.Show("Sure you want to Save Changes ? ", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection(Program.ConString);
                    con.Open();
                    if (con.State == ConnectionState.Open)
                    {
                        string InitialQuery = "";
                        SqlCommand tmpCmd = new SqlCommand(InitialQuery, con);
                        using (SqlDataReader sqlDataReader = tmpCmd.ExecuteReader())
                        {
                            while (sqlDataReader.Read())
                            {

                            }
                        }
                        string query = "";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Request Sent Successfully", "Well Done");
                        accNumTextBox.Clear();
                    }
                    con.Close();
                }
            }
        }
        private bool checkIfFill()
        {
            if (accNumTextBox.Text.Length == 0)
            {
                return false;
            }
            return true;
        }

        private void reloadLabel_Click(object sender, EventArgs e)
        {
            populateAccounts();
        }
    }
}
