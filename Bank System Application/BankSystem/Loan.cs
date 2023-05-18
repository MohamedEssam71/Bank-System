using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    internal class Loan
    {
        public string loanNumber{ get; set; }
        public string loanType{ get; set; }
        public double loanAmount{ get; set; }

        public Loan(string loanNumber, string loanType, double loanAmount)
        {
            this.loanNumber = loanNumber;
            this.loanType = loanType;
            this.loanAmount = loanAmount;
        }
    }
}
