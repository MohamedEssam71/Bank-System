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
    public partial class AdminForm : Form
    {
        private Thread th;
        public AdminForm()
        {
            InitializeComponent();
        }

        private void mainPageLabel_Click(object sender, EventArgs e)
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

        private void addBankButton_Click(object sender, EventArgs e)
        {
            
            th = new Thread(openAddBankForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
           
        }
        
        private void openAddBankForm()
        {
            Application.Run(new AddBankForm());
        }
        

    }
}
