using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Opp2
{
    class CurrentAccount:BankAccount
    {
        public CurrentAccount()
        {
        }

        public CurrentAccount(int accountID, long balance) : base(accountID, balance)
        {
        }

        public void amountWithDrawn(long amount)
        {
            if(Balance - amount  >= 5000)
            {
                Balance -=amount;
                WriteLine("WithDrawn Done!");
            } else WriteLine("! Error Balance < 5000");
        }

        public void amountDeposit(long amount)
        {
            Balance += amount;
            WriteLine("Deposit Done!");
        }



     
    }
}
