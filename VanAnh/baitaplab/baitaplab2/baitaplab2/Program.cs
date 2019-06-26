using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace baitaplab2
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bank = new BankAccount();
            float balance = bank.balanceInquiry();
            Console.WriteLine("current money:" + balance);
            CurrentAccount CA = new CurrentAccount(1000, 500000);
            CA.amountWithdrawn(200000);
            CA.amountDeposit(500000);
            balance = CA.balanceInquiry();
            Console.WriteLine("money: " + balance);
            SavingAccount SA = new SavingAccount(1001, 500000);
            SA.amountWithdrawn(450000);
            SA.amountDeposit(10000);
            balance = SA.balanceInquiry();
            Console.WriteLine("money: " + balance);
        }
    }
}
