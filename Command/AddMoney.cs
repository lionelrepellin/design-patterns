using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    public class AddMoney : ICommand
    {
        private decimal _newValue;
        private decimal _oldValue;
        private BankAccount _bankAccount;

        public AddMoney(BankAccount bankAccount, decimal value)
        {
            _newValue = value;
            _oldValue = bankAccount.Amount;
            _bankAccount = bankAccount;
        }

        public void Do()
        {
            var value = _bankAccount.Amount + _newValue;
            _bankAccount.SetNewAvount(value);
        }

        public void Undo()
        {
            _bankAccount.SetNewAvount(_oldValue);
        }
    }
}
