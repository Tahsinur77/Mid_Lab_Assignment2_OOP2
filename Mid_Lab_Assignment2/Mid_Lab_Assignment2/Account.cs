using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid_Lab_Assignment2
{
    abstract class Account
    {
        private int accountNumber;
        private string accountName;
        protected double balance;
        private string dateOfBirth;
        private Address address;
        

        static int x = 1;
        public Account(string accountName,string dateOfBirth, double balance, Address address)
        {
            this.accountName = accountName;
            this.accountNumber = x;
            this.dateOfBirth = dateOfBirth;
            this.balance = balance;
            this.address = address;
            x++;
        }
        public int AccountNumber
        {
            set { this.accountNumber = value; }
            get { return this.accountNumber; }
        }
        public string AccountName
        {
            set { this.accountName = value; }
            get { return this.accountName; }
        }
        public string DateOfBirth
        {
            set { this.dateOfBirth = value; }
            get { return this.dateOfBirth; }
        }
        public double Balance
        {
            set { this.balance = value; }
            get { return this.balance; }
        }
        public Address Address
        {
            set { this.address = value; }
            get { return this.address; }
        }

        public abstract void Withdraw(double amount);
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Console.WriteLine("Previous Balance : {0}\nDeposit Amount: {1}", balance, amount);
                this.balance += amount;
                Console.WriteLine(" Balance: " + this.balance);
            }
            else Console.WriteLine("Can Not Deposit......");
        }
        public abstract void Transfer(Account receiver, double amount);

        public abstract void Show();
    }
}
