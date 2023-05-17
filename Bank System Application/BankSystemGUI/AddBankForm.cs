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
    public partial class AddBankForm : Form
    {
        private Thread th;
        public AddBankForm()
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
                //Code to add Bank
                MessageBox.Show("Bank Added Successfully", "Well Done");
                nameBankTextBox.Clear();
                codeBankTextBox.Clear();
                addressBankTextBox.Clear();
            }
        }
        private bool checkIfAddBankFill()
        {
            if (nameBankTextBox.TextLength == 0 || codeBankTextBox.TextLength == 0
                || addressBankTextBox.TextLength == 0)
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
