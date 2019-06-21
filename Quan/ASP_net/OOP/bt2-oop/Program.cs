using System;

namespace bt2_oop
{
    public class BankAccount
    {
        public int accountID;
        public double balance;
        public int AccountID { get { return accountID; } set {accountID = value; } }
        public double Balance { get { return balance; } set { balance = value; } }
        public double balanceInquery()
        {
            return balance;
        }
    }
    public class CurrentAccount : BankAccount
    {
        public CurrentAccount(int AccountID,double Balance)
        {
            base.AccountID = AccountID;
            base.Balance = Balance;
        }
        public void amountWithdrawn()
        {
            Console.WriteLine("Nhap so tien muon rut: ");
            float amountWithdrawn = float.Parse(Console.ReadLine());
            if(balanceInquery() <= 5000)
            {
                Console.WriteLine("The minimum balance should not decrease Rs.5000");
                return;
            }
            else if(balanceInquery() - amountWithdrawn <= 5000)
            {
                Console.WriteLine("The minimum balance should not decrease Rs.5000");
                return;
            }
            else
            {
                double b = balanceInquery() - amountWithdrawn;
                base.balance = b;
                Console.WriteLine($"Successfully withdraw the amount of {amountWithdrawn} NND!");
                Console.WriteLine($"Current amount in the account{balance} NND");
            }
        }
        public void amountDeposit()
        {
            Console.WriteLine("Nhap so tien muon gui: ");
            float amountdeposit = float.Parse(Console.ReadLine());
            if(amountdeposit <= 5000)
            {
                Console.WriteLine("Ong oi khong ai gui tiet kiem nho hơn 5000 đau.");
                return;
            }
            double a = balanceInquery() + amountdeposit;
            base.balance = a;
            Console.WriteLine($"Đa gui thanh cong {amountdeposit} NND!");
            Console.WriteLine($"So tien trong tai khoan la {a} NND!");
        }
    }
    public class SavingsAccount : BankAccount
    {
        public SavingsAccount(int AccountID,double Balance)
        {
            base.Balance = Balance;
            base.AccountID = AccountID;
        }
        public void amountWithdrawn()
        {
            Console.WriteLine("Nhap so tien muon rut: ");
            float amountWithdrawn = float.Parse(Console.ReadLine());
            if (balanceInquery() <= 10000)
            {
                Console.WriteLine("The minimum balance should not decrease Rs.10000");
                return;
            }
            else if (balanceInquery() - amountWithdrawn <= 10000)
            {
                Console.WriteLine("The minimum balance should not decrease Rs.10000");
                return;
            }
            else
            {
                double b = balanceInquery() - amountWithdrawn;
                base.balance = b;
                Console.WriteLine($"Successfully withdraw the amount of {amountWithdrawn} NND!");
                Console.WriteLine($"Saving amount in the account is{balance} NND!");
            }
        }
        public void amountDeposit()
        {
            Console.WriteLine("Nhap so tien muon gui: ");
            float amountdeposit = float.Parse(Console.ReadLine());
            if (amountdeposit <= 10000)
            {
                Console.WriteLine("Ong oi khong ai gui tiet kiem nho hơn 10000 đau.");
                return;
            }
            double a = balanceInquery() + amountdeposit;
            base.balance = a;
            Console.WriteLine($"Đa gui thanh cong {amountdeposit} NND!");
            Console.WriteLine($"So tien trong tai khoan la {a} NND!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CurrentAccount c = new CurrentAccount(1, 100000);
            c.amountWithdrawn();
            c.amountDeposit();
            Console.ReadLine();
            SavingsAccount s = new SavingsAccount(2, 100000);
            s.amountWithdrawn();
            s.amountDeposit();
            Console.ReadLine();
        }
    }
}
