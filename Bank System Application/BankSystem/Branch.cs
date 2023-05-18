using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public class Branch
    {
        public string BranchNumber { get; set; }
        public string Address { get; set; }
        public List<CustomerModel> Customers { get; set; }
        public List<Loan> Loans { get; set; }
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

