using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid_Lab_Assignment2
{
    class Bank
    {
        private Account[] myBank = new Account[100];

        public Bank()
        {

        }
        public Account[] MyBank
        {
            get { return this.myBank; }
        }
        public void AddAccount(Account account)
        {
            bool flag = false;
            int num = -1;
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    myBank[i] = account;
                    flag = true;
                    num = i;
                    break;
                }
            }
            if (flag) Console.WriteLine("\t\t||\tAccount Opened....\n\t\t||\tYour Account Number = {0} ", myBank[num].AccountNumber);
            else Console.WriteLine("\t\t||\tCan not open your account.....");
        }
       
        public void Transaction(string transactionType, params dynamic[] x)
        {
            if (transactionType == "withdraw")
            {
                myBank[x[0]].Withdraw(x[1]);
            }
            else if (transactionType == "deposit")
            {
                myBank[x[0]].Deposit(x[1]);
            }
            else if (transactionType == "transfer")
            {
                myBank[x[0]].Transfer(myBank[x[1]], x[2]);
            }
            else
            {
                Console.WriteLine("\t\t||\tInvalid Input.........");
            }
        }
        public int SearchAccount(int accountNumber)
        {
            bool flag = false;
            int i = 0;
            for (i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null) continue;
                else if (myBank[i].AccountNumber == accountNumber)
                {
                    flag = true;
                    break;
                }
            }
            if (flag) return i;
            else return -1;
        }
        public void PrintAccountDetails(int index)
        {
            myBank[index].Show();

        }
    }
}
