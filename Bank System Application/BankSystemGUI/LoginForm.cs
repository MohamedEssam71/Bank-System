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
            usernameLoginTextBox.Clear();
            passwordLoginTextBox.Clear();
        }

        private void loginConfirmButton_Click(object sender, EventArgs e)
        {
            // Check DataBase
        }
    }
}
