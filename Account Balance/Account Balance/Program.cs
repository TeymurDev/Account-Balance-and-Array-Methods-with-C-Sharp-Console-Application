using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            Account ac = new Account();
            double a = ac.Balance;
            double i = ac.BalanceIncrement;
            double d = ac.BalanceDecrement;
            string name = ac.Name;
            string surname = ac.Surname;
            string id = ac.IDNumber;
            string newName = ac.Name;
            string newSurname = ac.Surname;
            string newId = ac.IDNumber;
            Console.WriteLine("***ACCOUNT CREATION***");
            Console.WriteLine("Please Enter Your Name:");
            name = Console.ReadLine();
            Console.WriteLine("Please Enter Your Surname:");
            surname = Console.ReadLine();
            Console.WriteLine("Please Enter Your ID Number:");
            id = Console.ReadLine();



            while (true)
            {
                Console.WriteLine("1 - Check Balance");
                Console.WriteLine("2 - Increase Balance");
                Console.WriteLine("3 - Decrease Balance");
                Console.WriteLine("4 - Change Account Information");
                Console.WriteLine("0 - Exit");
                Console.WriteLine("-------------------------------------------\n\n");
                int x = int.Parse(Console.ReadLine());
                switch (x)

                {

                    case 1:
                        a = 0;
                        Console.WriteLine("Your Balance:" + a);
                        break;

                    case 2:
                        Console.WriteLine("Please Enter Amount to Increase Balance:");
                        i = double.Parse(Console.ReadLine());
                        a = a + i;
                        Console.WriteLine("Your Balance:" + a);
                        break;

                    case 3:
                        Console.WriteLine("Please Enter Amount to Decrease Balance:");
                        d = double.Parse(Console.ReadLine());
                        if (d > a)
                        {
                            Console.WriteLine("Your Balance is Insufficient, please enter correct amount");
                        }
                        else
                        {
                            a = a - d;
                            Console.WriteLine("Your Balance:" + a);
                        }
                        break;
                    case 4:
                        Console.WriteLine("Enter Your Name:");
                        newName = Console.ReadLine();
                        while (string.IsNullOrEmpty(newName))
                        {
                            Console.WriteLine("Name cannot be empty, please enter your Name again:");
                            newName = Console.ReadLine();
                        }
                        Console.WriteLine("Enter Your Surname:");
                        newSurname = Console.ReadLine();
                        while (string.IsNullOrEmpty(newSurname))
                        {
                            Console.WriteLine("Surname cannot be empty, please enter your Surname again:");
                            newSurname = Console.ReadLine();
                        }
                        Console.WriteLine("Enter your ID number:");
                        newId = Console.ReadLine();
                        while (string.IsNullOrEmpty(newId))
                        {
                            Console.WriteLine("ID number cannot be empty, please enter your ID number again:");
                            newId = Console.ReadLine();
                        }
                        break;

                    case 0:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Please enter the correct key");

                        break;
                }
            }
        }
    }
}
