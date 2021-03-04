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
            Console.WriteLine("Type to select :");
            Console.WriteLine("open => Open a Bank account\naccount => Perform transactions on an account\nquit => Exit the application");
            string type = Console.ReadLine();
            switch (type)
            {
                case "open":
                    Console.WriteLine("Command For selecting Operation:");
                    Console.WriteLine("savings => Open a savings account\nchecking => Open a checking account\nquit => Exit the application");

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
