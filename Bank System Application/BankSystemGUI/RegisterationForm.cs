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
    public partial class RegisterationForm : Form
    {
        private Thread th;
        public RegisterationForm()
        {
            InitializeComponent();
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
                MessageBox.Show("Registration Complete", "Well Done");
                th = new Thread(openMainForm);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
                this.Close();
            }
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
    }
}
