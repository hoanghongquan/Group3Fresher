using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitaplab2
{
    class BankAccount
    {
        public int accountID;
        public float balance;
        public int AccountID { get { return accountID; } set { accountID = value; } }
        public float Balance { get { return balance; } set { balance = value; } }
        public float balanceInquiry()
        {
            return this.balance;
        }
        
           
       

    }
}
