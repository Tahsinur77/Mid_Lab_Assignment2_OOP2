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
            bool check = false;
            while (true)
            {
                Console.WriteLine("Type to select :");
                Console.WriteLine("open => Open a Bank account\naccount => Perform transactions on an account\nquit => Exit the application");
                string type = Console.ReadLine();
                
                switch (type)
                { 
                    case "open":

                        bool version1 = false;
                        while (true)
                        {
                            Console.WriteLine("Command For selecting Operation:");
                            Console.WriteLine("savings => Open a savings account\nchecking => Open a checking account\nquit => Exit the application");
                            string one = Console.ReadLine();
                            switch(one)
                            {
                                case "savings":
                                    Console.Write("\t\t||Enter Account : \n\t\t||\tName : ");
                                    string accountName1 = Console.ReadLine();
                                    Console.Write("\t\t||\tDate of Birth : ");
                                    string dateOfBirth1 = Console.ReadLine();
                                    Console.Write("\t\t||\tBalance : ");
                                    double balance1 = Convert.ToDouble(Console.ReadLine());
                                    Console.Write("\t\t||\tAddress :\n\t\t||\t\tRoad No. : ");
                                    string roadNo1 = Console.ReadLine();
                                    Console.Write("\t\t||\t\tHouse No. : ");
                                    string houseNo1 = Console.ReadLine();
                                    Console.Write("\t\t||\t\tCity : ");
                                    string city1 = Console.ReadLine();
                                    Console.Write("\t\t||\t\tCountry : ");
                                    string country1 = Console.ReadLine();
                                    Account acc1;
                                    acc1 = new SavingAccount(accountName1, dateOfBirth1, balance1, new Address(roadNo1, houseNo1, city1, country1));
                                    bank.AddAccount(acc1);
                                    break;
                                case "checking":
                                    Console.Write("\t\t||Enter Account : \n\t\t||\tName : ");
                                    string accountName2 = Console.ReadLine();
                                    Console.Write("\t\t||\tDate of Birth : ");
                                    string dateOfBirth2 = Console.ReadLine();
                                    Console.Write("\t\t||\tBalance : ");
                                    double balance2 = Convert.ToDouble(Console.ReadLine());
                                    Console.Write("\t\t||\tAddress :\n\t\t||\t\tRoad No. : ");
                                    string roadNo2 = Console.ReadLine();
                                    Console.Write("\t\t||\t\tHouse No. : ");
                                    string houseNo2 = Console.ReadLine();
                                    Console.Write("\t\t||\t\tCity : ");
                                    string city2 = Console.ReadLine();
                                    Console.Write("\t\t||\t\tCountry : ");
                                    string country2 = Console.ReadLine();
                                    Account acc2;
                                    acc2 = new CheckingAccount(accountName2, dateOfBirth2, balance2, new Address(roadNo2, houseNo2, city2, country2));
                                    bank.AddAccount(acc2);
                                    break;
                                case "quit":
                                    version1 = true;
                                    break;
                                default:
                                    Console.WriteLine("Invalid Input...");
                                    break;
                            }
                            if (version1) break;
                            
                        }
                        break;
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
                                if (found >= 0)
                                {
                                    if (two == "deposit")
                                    {
                                        Console.Write("\t\t||Enter the amount you want to deposit : ");
                                        double amount = Convert.ToDouble(Console.ReadLine());
                                        bank.Transaction(two, found, amount);
                                    }
                                    else if (two == "withdraw")
                                    {
                                        Console.Write("\t\t||Enter the amount you want to withdraw : ");
                                        double amount = Convert.ToDouble(Console.ReadLine());
                                        bank.Transaction(two, found, amount);
                                    }
                                    else if (two == "transfer")
                                    {
                                        Console.Write("\t\t||Enter Receiver Account Number : ");
                                        int recAccountNumber = Convert.ToInt32(Console.ReadLine());
                                        int search = bank.SearchAccount(recAccountNumber);
                                        if (search == found)
                                        {
                                            Console.WriteLine("\t\t||The receiver Account Number is your.....");
                                        }
                                        else if (search >= 0)
                                        {
                                            Console.Write("\t\t||Enter the amount you want to Transfer : ");
                                            double amount = Convert.ToDouble(Console.ReadLine());
                                            bank.Transaction(two, found, search, amount);
                                        }
                                        else
                                        {
                                            Console.WriteLine("\t\t||\tInvalid Receiver Account Number......");
                                            
                                        }
                                    }
                                    else if (two == "show")
                                    {
                                        bank.PrintAccountDetails(found);
                                    }
                                    else
                                    {
                                        Console.WriteLine("\t\t||\tInvalid Input......");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("\t\t||\tInvalid Account Number.....");
                                }
                            }

                        }
                        break;
                    case "quit":
                        check  = true;
                        break;
                    default:
                        break;

                }
                if (check) break;
            }
        }
    }
}
