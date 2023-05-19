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
                //Code to add Bank
                MessageBox.Show("Branch Added Successfully", "Well Done");
                bankCodeBranchTextBox.Clear();
                codeBranchTextBox.Clear();
                addressBranchTextBox.Clear();
            }
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
