using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    public class BankAccount
    {
        public decimal Amount { get; private set; }

        public BankAccount(decimal initialAmount)
        {
            Amount = initialAmount;
        }

        public void SetNewAvount(decimal amount)
        {
            Console.WriteLine("oldValue: {0} => newValue: {1}", Amount, amount);
            Amount = amount;
        }
    }
}
