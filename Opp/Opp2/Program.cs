using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opp2
{
    class Program
    {
        static void Main(string[] args)
        {
            CurrentAccount account = new CurrentAccount(1,10000);
            account.amountWithDrawn(10);
            account.amountDeposit(20);
            account.balanceInquiry();

            SavingsAccount savingsAccount = new SavingsAccount(2,10000);
            savingsAccount.amountWithDrawn(10);
            savingsAccount.amountDeposit(20);
            savingsAccount.balanceInquiry();
            Console.ReadKey();
        }
    }
}
