using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid_Lab_Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To our Bank");
            Bank bank = new Bank();
            int check = 0;
            while (true)
            {
                Console.WriteLine("Type to select :");
                Console.WriteLine("open => Open a Bank account\naccount => Perform transactions on an account\nquit => Exit the application");
                string type = Console.ReadLine();
                switch (type)
                {
                    case "open":
                        while (true)
                        {
                            Console.WriteLine("Command For selecting Operation:");
                            Console.WriteLine("savings => Open a savings account\nchecking => Open a checking account\nquit => Exit the application");
                            string one = Console.ReadLine();
                            if (one == "savings")
                            {
                                Console.Write("\t\t||Enter Account : \n\t\t||\tName : ");
                                string accountName = Console.ReadLine();
                                Console.Write("\t\t||\tDate of Birth : ");
                                string dateOfBirth = Console.ReadLine();
                                Console.Write("\t\t||\tBalance : ");
                                double balance = Convert.ToDouble(Console.ReadLine());
                                Console.Write("\t\t||\tAddress :\n\t\t||\t\tRoad No. : ");
                                string roadNo = Console.ReadLine();
                                Console.Write("\t\t||\t\tHouse No. : ");
                                string houseNo = Console.ReadLine();
                                Console.Write("\t\t||\t\tCity : ");
                                string city = Console.ReadLine();
                                Console.Write("\t\t||\t\tCountry : ");
                                string country = Console.ReadLine();
                                Account acc;
                                acc = new SavingAccount(accountName, dateOfBirth, balance, new Address(roadNo, houseNo, city, country));
                                bank.AddAccount(acc);
                            }
                            else if (one == "checking")
                            {
                                Console.Write("\t\t||Enter Account : \n\t\t||\tName : ");
                                string accountName = Console.ReadLine();
                                Console.Write("\t\t||\tDate of Birth : ");
                                string dateOfBirth = Console.ReadLine();
                                Console.Write("\t\t||\tBalance : ");
                                double balance = Convert.ToDouble(Console.ReadLine());
                                Console.Write("\t\t||\tAddress :\n\t\t||\t\tRoad No. : ");
                                string roadNo = Console.ReadLine();
                                Console.Write("\t\t||\t\tHouse No. : ");
                                string houseNo = Console.ReadLine();
                                Console.Write("\t\t||\t\tCity : ");
                                string city = Console.ReadLine();
                                Console.Write("\t\t||\t\tCountry : ");
                                string country = Console.ReadLine();
                                Account acc;
                                acc = new CheckingAccount(accountName, dateOfBirth, balance, new Address(roadNo, houseNo, city, country));
                                bank.AddAccount(acc);

                            }
                            else if (one == "quit")
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid Input...");
                            }
                            
                        }
                        goto case "quit";
                    case "account":
                        while (true)
                        {
                            Console.WriteLine("Command For selecting Operation:");
                            Console.WriteLine("deposit => Make a deposit\nwithdraw => Make a withdrawal\ntransfer => Make a transfer");
                            Console.WriteLine("show =>Show the number transactions and balance\nquit Exit => the application");
                            string two = Console.ReadLine();
                            
                            if (two == "quit")
                            {
                                break;
                            }
                            else
                            {
                                Console.Write("\t\t||\tEnter You Account Number : ");
                                int accountNumber = Convert.ToInt32(Console.ReadLine());
                                int found = bank.SearchAccount(accountNumber);
                                if (two == "deposit")
                                {
                                    Console.Write("\t\t||Enter the amount you want to withdraw : ");
                                    double amount = Convert.ToDouble(Console.ReadLine());
                                    bank.Transaction(two, found, amount);
                                }
                            }

                        }
                        goto case "quit";
                    case "quit":
                        check = 1;
                        break;
                    default:
                        break;

                }
                if (check == 1) break;
            }
        }
    }
}
