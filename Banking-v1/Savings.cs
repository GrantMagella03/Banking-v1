using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_v1
{
    public class Savings : Account
    {
        public decimal InterestRate { get; set; } = 0.12m;
        public Savings() : base() 
        { 
            
        }
        public decimal CalculateInterestByMonths(int months)
        {
            decimal interest = Balance * (InterestRate / 12) * months;
            Deposit(interest);
            return interest;
        }
    }
}
