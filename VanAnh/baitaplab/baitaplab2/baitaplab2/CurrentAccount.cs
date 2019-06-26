using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitaplab2
{
    class CurrentAccount : BankAccount
    {
        public CurrentAccount() { }
        public CurrentAccount(int accountID, float balance)
        {
            this.AccountID = accountID;
            this.Balance = balance;
        }
        public void amountWithdrawn(float amount)
        {

            if (Balance <= 5000)
            {
                Console.WriteLine("Not is enough the money:");
                return;
            }
            else if (this.Balance - amount > 5000)
            {
                this.Balance -= amount;
            }

            else
            {

                Console.WriteLine("minimum balance should not decrease Rs.5000");
                return;


            }
        }
        public void amountDeposit(float amount)
        {
            this.Balance += amount;
        }
    }

}

       

    
           

        
        

        
           
            
   
        
           
        

 

