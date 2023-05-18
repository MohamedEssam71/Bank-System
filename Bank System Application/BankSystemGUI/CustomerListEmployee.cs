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
    public partial class CustomerListEmployee : Form
    {
        private Thread th;
        private List<CustomerListControl> customerListControls = new List<CustomerListControl>();
        public CustomerListEmployee()
        {
            InitializeComponent();

        }

        private void CustomerList_Load(object sender, EventArgs e)
        {
            populateCustomers();
        }
        private void populateCustomers()
        {   /*
            //CustomerListControl[] customerListControls = new CustomerListControl[20];
            if (CustomerListFlowControlPanel.Controls.Count > 0)
            {
                CustomerListFlowControlPanel.Controls.Clear();
            }
            */

            // the problem will be fixed with database as each time 
            // the array will be loaded with the new data and won't be changed
            //this.Size = new Size(1113, 519);
            if (customerListControls.Count <= 0)
            {
                this.Width = 388;
            }
            else
            {
                this.Width = 1113;
            }

            for (int i = 0; i < customerListControls.Count(); i++)
            {
                /*
                CustomerListControl customer = new CustomerListControl();
                customer.Name = "Mohamed Essam";
                customer.SSN = "20210346";
                customer.Phone = "01119315089";
                customer.Address = "Giza, Haram, Tersa";
                customerListControls.Add(customer);
                */
                CustomerListFlowControlPanel.Controls.Add(customerListControls[i]);


            }
        }

        private void addCustomer_Click(object sender, EventArgs e)
        {
            if (!checkIfCustomerFill())
            {
                MessageBox.Show("Fill all the empty places !", "Error");
            }
            else
            {
                //this.Size = new Size(1113, 519);
                this.Width = 1113;
                CustomerListControl customer = new CustomerListControl();
                customer.Name = customerNameTextBox.Text;
                customer.SSN = customerSsnTextBox.Text;
                customer.Phone = customerPhoneTextBox.Text;
                customer.Address = customerAdderssTextBox.Text;
                customerListControls.Add(customer);
                CustomerListFlowControlPanel.Controls.Add(customer);

                //Code to add Bank

                customerNameTextBox.Clear();
                customerSsnTextBox.Clear();
                customerPhoneTextBox.Clear();
                customerAdderssTextBox.Clear();
            }
            /*
            for (int i = 0; i < 5; i++)
            {
                CustomerListControl customer = new CustomerListControl();
                customer.Name = "Mohamed Essam";
                customer.Description = "ID : 20210346 \nPhone: 01119315089 \nAddress:Giza,Haram,Terssa";
                customerListControls.Add(customer);
                CustomerListFlowControlPanel.Controls.Add(customer);
            }
            */

        }
        private bool checkIfCustomerFill()
        {
            if (customerNameTextBox.TextLength == 0 || customerSsnTextBox.TextLength == 0
                || customerPhoneTextBox.TextLength == 0 || customerAdderssTextBox.TextLength == 0)
            {
                return false;
            }
            return true;
        }

        private void backToAdminLabel_Click(object sender, EventArgs e)
        {
            th = new Thread(openEmployeeForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }
        private void openEmployeeForm()
        {
            Application.Run(new EmployeeForm());
        }
    }
}
