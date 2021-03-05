using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid_Lab_Assignment2
{
    class CheckingAccount:Account
    {
        private int transactions;
        public CheckingAccount( string accountName, string dateOfBirth, double balance, Address address) : base(accountName, dateOfBirth, balance, address)
        {
        }
        public int Transactions
        {
            set { this.transactions = value; }
            get { return this.transactions; }
        }
        public override void Withdraw(double amount)
        {
            if (amount > 0 && amount <= base.balance)
            {
                Console.WriteLine("Previous Balance : {0}\nWithdraw Amount: {1}", balance, amount);
                base.balance -= amount;
                Console.WriteLine("Current Balance: " + base.balance);
                this.transactions++;
            }
            else Console.WriteLine("Can Not Withdraw.....");
        }
        public override void Transfer(Account receiver, double amount)
        {
            if (amount > 0 && amount <= base.balance)
            {
                Console.WriteLine("Previous Balance : {0}\nTransfer Amount: {1}", base.balance, amount);
                base.balance -= amount;
                receiver.Balance += amount;
                Console.WriteLine("Current Balance: " + base.balance);
                this.transactions++;
            }
            else Console.WriteLine("Can Not Transfer.....");
        }
        public override void Show()
        {
            Console.WriteLine("Number of transactions : " + transactions);
        }
    }
}
