using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogIn_Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$_DotNet-Bank_$$$$$$$$$$$$$$$$$$$$$$");
            System.Console.WriteLine("Home-Login Page");

            string userName;
            string password = null;

            System.Console.WriteLine("Hi, Enter Username");
            userName = Console.ReadLine();
            char key;

            if (userName != "")
            {
                System.Console.WriteLine("Hi, Enter password.");
                while ((key=Console.ReadKey(true).KeyChar) !='\r')
                {
                    password += key;
                    Console.Write("*");
                }
                Console.WriteLine("");
            }


            if (userName != "Sujit" && password != "Sujit")
            {
                Console.WriteLine("Please register & Visit again.");
            }

            if (userName == "Sujit" && password == "Sujit")
            {
                Console.WriteLine("Welcome Sujit! Check the menu to go ahead.");
                Console.ReadKey();
            }
            else
                Console.WriteLine("Wrong credentials.");

            Console.WriteLine("Thank You.");
            Console.ReadKey();

            //Console.Write("Enter a password: ");
            //string password = "";
            //char key;

            //while ((key = Console.ReadKey(true).KeyChar) != '\r') // Enter key
            //{
            //    password += key;
            //    Console.Write("*");
            //}

            //Console.WriteLine("\nYou entered: " + password);
            //Console.ReadKey();
        }
    }
}
