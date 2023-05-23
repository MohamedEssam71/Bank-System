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
    public partial class reportForm : Form
    {
        private Thread th;
        public reportForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void reportForm_Load(object sender, EventArgs e)
        {
            populateReport1();
            populateReport2();
            populateReport3();
            populateReport4();
            populateReport5();
        }
        private void populateReport1()
        {

            SqlConnection con = new SqlConnection(Program.ConString);
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                string query = "SELECT Type , AVG(Balance) as Avg_Balance from Account GROUP BY Type";
                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                con.Close();

                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;

            }
        }

        private void populateReport2()
        {

            SqlConnection con = new SqlConnection(Program.ConString);
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                string query = "SELECT Bank.Name,MAX(balance) AS TotalBalance FROM account INNER JOIN" +
                    "(person INNER JOIN Bank ON branchBankCode = Code)" +
                    "ON Account.PersonSSN = Person.SSN " +
                    "Group By Bank.Name ORDER BY Bank.Name;";
                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                con.Close();

                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView2.DataSource = dataTable;

            }
        }
        private void populateReport3()
        {
            SqlConnection con = new SqlConnection(Program.ConString);
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                string query = "SELECT Bank.Name,MIN(balance) AS TotalBalance FROM account INNER JOIN" +
                    "(person INNER JOIN Bank ON branchBankCode = Code)" +
                    "ON Account.PersonSSN = Person.SSN " +
                    "Group By Bank.Name ORDER BY Bank.Name;";
                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                con.Close();

                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView3.DataSource = dataTable;

            }
        }
        private void populateReport4()
        {

            SqlConnection con = new SqlConnection(Program.ConString);
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                string query = "SELECT Name, SUM(Amount) as TotalLoansAmount FROM" +
                    "(Loan_Person INNER JOIN" +
                    "(Loan INNER JOIN Bank ON BranchBankCode = Code)" +
                    "on LoanLoanNumber = LoanNumber) GROUP BY Name;";
                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                con.Close();

                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView4.DataSource = dataTable;

            }
        }
        private void populateReport5()
        {

            SqlConnection con = new SqlConnection(Program.ConString);
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                string query = "SELECT Bank.Name, COUNT(BranchNumber)BranchesNumber, COUNT(*)PersonsNumber FROM" +
                    "(Bank INNER JOIN (Branch INNER JOIN Person ON BranchNumber = BranchBranchNumber)" +
                    "ON Code = BankCode) GROUP BY  Bank.Name;";
                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                con.Close();

                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView5.DataSource = dataTable;

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
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
    }
}
