using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid_Lab_Assignment2
{
    
    class SavingAccount : Account
    {
        
        public SavingAccount( string accountName, string dateOfBirth, double balance, Address address):base(accountName,dateOfBirth,balance,address)
        { 
        }
        
        public override void Withdraw(double amount)
        {
            if (amount > 0 && amount < base.balance)
            {
                Console.WriteLine("\t\t||\n\t\t||\tWithdraw Sucessful...");
                Console.WriteLine("\t\t||\tPrevious Balance : {0}\n\t\t||\tWithdraw Amount: {1}", balance, amount);
                base.balance -= amount;
                Console.WriteLine("\t\t||\tCurrent Balance: " + base.balance);
                base.transactions++;
            }
            else Console.WriteLine("\t\t||\tCan Not Withdraw.....");
        }
        public override void Transfer(Account receiver, double amount)
        {
            if (amount > 0 && amount < base.balance)
            {
                Console.WriteLine("\t\t||\n\t\t||\tTransfer Sucessful...");
                Console.WriteLine("\t\t||\tPrevious Balance : {0}\n\t\t||\tTransfer Amount: {1}", base.balance, amount);
                base.balance -= amount;
                receiver.Balance += amount;
                Console.WriteLine("\t\t||\tCurrent Balance: " + base.balance);
                base.transactions++;
                receiver.Transactions++;
            }
            else Console.WriteLine("\t\t||\tCan Not Transfer.....");
        }
        public override void Show()
        {
            Console.WriteLine("\t\t||\tBalance : " + base.balance);
            Console.WriteLine("\t\t||\tNumber of transactions : "+transactions);
        }
    }
}
