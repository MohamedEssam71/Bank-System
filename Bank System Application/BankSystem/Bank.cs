using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    internal class Bank
    {
        private int Code { get; set; }
        private string Name { get; set; }
        private string Address { get; set; }
        private List<Branch> branches { get; }
        public Bank(int code, string name, string address) {
            this.Code = code;
            this.Name = name;
            this.Address = address;
            branches = new List<Branch>();
        }

        public void AddBranch(Branch branch) { branches.Add(branch); }
        public void RemoveBranch(Branch branch) { branches.Remove(branch); }
    }
}
