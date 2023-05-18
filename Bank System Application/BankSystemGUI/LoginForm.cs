using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
                if (ssnLoginTextBox.Text == "admin" && passwordLoginTextBox.Text == "admin")
                {
                    th = new Thread(openAdminForm);
                }
                else if (ssnLoginTextBox.Text == "employee" && passwordLoginTextBox.Text == "employee")
                {
                    th = new Thread(openEmployeeForm);
                }
                else if (ssnLoginTextBox.Text == "customer" && passwordLoginTextBox.Text == "customer")
                {
                    th = new Thread(openCustomerForm);
                }
                else
                {
                    MessageBox.Show("Username or Password is incorrect !", "Error");
                    ssnLoginTextBox.Clear();
                    passwordLoginTextBox.Clear();
                    return;
                }
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
                this.Close();
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
