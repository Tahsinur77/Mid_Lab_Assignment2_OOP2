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
            while (true)
            {
                Console.WriteLine("Type to select :");
                Console.WriteLine("open => Open a Bank account\naccount => Perform transactions on an account\nquit => Exit the application");
                string type = Console.ReadLine();
                switch (type)
                {
                    case "open":
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
                        break;
                    case "account":

                        break;
                    case "quit":

                        break;
                    default:
                        break;

                }
            }
        }
    }
}
