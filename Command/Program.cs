using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var bankAccount = new BankAccount(100);

            var group = new CommandGroup<AddMoney>();
            group.Add(new AddMoney(bankAccount, 10));
            group.Add(new AddMoney(bankAccount, 10));
            group.Add(new AddMoney(bankAccount, 10));

            group.UnDo();

            group.Add(new AddMoney(bankAccount, 5));

            group.UnDo();
            group.UnDo();

            group.ReDo();

            Console.Read();
        }
    }
}