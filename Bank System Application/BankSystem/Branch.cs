using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    internal class Branch
    {
        public string BranchNumber { get; set; }
        private string Address { get; set; }
        private List<CustomerModel> Customers { get; set; }
        private List<Loan> Loans { get; set; }
        public Branch(string branchNumber ,string address, CustomerModel customers, Loan loan)
        {
            this.BranchNumber = branchNumber;
            this.Address = address;
            this.Customers = new List<CustomerModel>();
            this.Loans = new List<Loan>();
        }

        public void AddCustomer(CustomerModel customer) { Customers.Add(customer); }
        public void RemoveCustomer(CustomerModel customer) { Customers.Remove(customer); }
        public void AddLoan(Loan loan) { Loans.Add(loan); }    
        public void RemoveLoan(Loan loan) { Loans.Remove(loan); }

    }
}

