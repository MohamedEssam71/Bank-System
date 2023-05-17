using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    internal class Account
    {
        public string AccountNumber { get; set; }
        public double Balance { get; set; }
        public string Type { get; set; }
        public Account(string accountNumber, double balance, string Type)
        {
            this.AccountNumber = accountNumber;
            this.Balance = balance;
            this.Type = Type;
        }
    }
}
