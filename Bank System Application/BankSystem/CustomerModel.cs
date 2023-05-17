using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    internal class CustomerModel
    {
        private string SSN { get; set; }
        private string Name { get; set; }
        private string Phone { get; set; }
        private string Address { get; set; }
        private Branch Branch { get; set; }
        private List<Loan> Loans { get; set; }
        private List<Account> Accounts { get; }
        public Customer(string SSN, string name, string phone, string address, Branch branch, Loan loan)
        {
            this.SSN = SSN;
            this.Name = name;
            this.Phone = phone;
            this.Address = address;
            this.Branch = branch;
            this.Loans = new List<Loan>();
            this.Accounts = new List<Account>();
        }
        public void AddAccount(Account account) { this.Accounts.Add(account); }
        public void RemoveAccount(Account account) { this.RemoveAccount(account); }
        public bool Deposit(Account account, double amount) {
            Account? TmpAccount = null;
            foreach (Account Acc in Accounts)
            {
                if (Acc == account)
                {
                    TmpAccount = Acc;
                    break;
                }
            }
            if (TmpAccount == null)
            {
                return false;
            } 
            else
            {
                TmpAccount.Balance += amount;
                return true;
            }
        }
        public bool Withdraw(Account account, double amount)
        {
            Account? TmpAccount = null;
            foreach (Account Acc in Accounts)
            {
                if (Acc == account)
                {
                    TmpAccount = Acc;
                    break;
                }
            }
            if (TmpAccount == null)
            {
                return false;
            }
            else
            {
                if (TmpAccount.Balance >= amount) 
                {
                    TmpAccount.Balance -= amount;
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public bool RequestLoan(Loan loan)
        {
            bool Found = false;
            for (int i = 0; i < Branch.Loans.Count; i++)
            {
                if (Branch.Loans[i] == loan)
                { 
                    Found = true;
                    break;
                }
            }
            if (!Found)
            {
                return false;
            }
            else
            {
                this.Loans.Add(loan);
                return true;
            }
        }
    }
}
