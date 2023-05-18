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
    public partial class UpdateCustomerDetails : Form
    {
        private Thread th;
        public UpdateCustomerDetails()
        {
            InitializeComponent();
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
                DialogResult dialogResult = new DialogResult();
                dialogResult = MessageBox.Show("Sure you want to Save Changes ? ", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    // save new data customer in database

                    MessageBox.Show("Data Saved Successfully !", "Update");
                }
                else
                {
                    //conintue 
                }

            }
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
            th = new Thread(openCustomerForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }
        private void openCustomerForm()
        {
            Application.Run(new CustomerForm());
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
            usernameTextBox.Text = "Mohamed";
            passwordTextBox.Text = "Password";
            ssnTextBox.Text = "ssn";
            phoneTextBox.Text = "Phone";
            addressTextBox.Text = "Address";
        }
    }
}
