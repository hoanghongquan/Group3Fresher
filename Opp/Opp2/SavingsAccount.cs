using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Opp2
{
    class SavingsAccount:BankAccount
    {
        public SavingsAccount()
        {
        }

        public SavingsAccount(int accountID, long balance) : base(accountID, balance)
        {
        }

        public void amountWithDrawn(long amount)
        {
            if (Balance - amount >= 10000)
            {
                Balance = -amount;
                WriteLine("WithDrawn Done!");
            }
            else WriteLine("! Error Balance < 10.000");
        }

        public void amountDeposit(long amount)
        {
            Balance += amount;
            WriteLine("Deposit Done!");
        }
    }
}
