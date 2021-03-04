using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid_Lab_Assignment2
{
    class Account
    {
        private int accountNumber;
        private string accountName;
        private double balance;
        private string dateOfBirth;
        private Address address;

        public Account(int accountNumber, string accountName,string dateOfBirth, double balance, Address address)
        {
            this.accountName = accountName;
            this.accountNumber = accountNumber;
            this.dateOfBirth = dateOfBirth;
            this.balance = balance;
            this.address = address;

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
        public void Transfer(Account receiver, double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                Console.WriteLine("Previous Balance : {0}\nTransfer Amount: {1}", balance, amount);
                this.balance -= amount;
                receiver.balance += amount;
                Console.WriteLine("Current Balance: " + this.balance);
            }
            else Console.WriteLine("Can Not Transfer.....");
        }
        public void ShowAccountInformation()
        {
            Console.WriteLine("Account Number : {0}\nAccount Name: {1}\nBalance : {2}", this.accountNumber, this.accountName, this.balance);
            address.GetAddress();
        }
    }
}
