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
            if (flag) Console.WriteLine("Account Added....\nYour Account Number = {0} ", myBank[num].AccountNumber);
            else Console.WriteLine("Can not add.....");
        }
       
        public void Transaction(int transactionType, params dynamic[] x)
        {
            if (transactionType == 1)
            {
                myBank[x[0]].Withdraw(x[1]);
            }
            else if (transactionType == 2)
            {
                myBank[x[0]].Deposit(x[1]);
            }
            else if (transactionType == 3)
            {
                myBank[x[0]].Transfer(myBank[x[1]], x[2]);
            }
            else
            {
                Console.WriteLine("You gave a wrong input....");
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
            myBank[index].ShowAccountInformation();

        }
    }
}
