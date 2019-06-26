using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opp2
{
    class BankAccount
    {
        private int accountID;
        private long balance;

        public BankAccount()
        {
        }

        public BankAccount(int accountID, long balance)
        {
            this.accountID = accountID;
            this.Balance = balance;
        }

        public long Balance { get => balance; set => balance = value; }

        public void balanceInquiry()
        {
            Console.WriteLine("Balance: "+balance);
        }
    }
}
