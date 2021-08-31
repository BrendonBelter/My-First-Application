
using System;

namespace FizzBuzz
{
    class Program
    {
        class FirstClass
        {
            static void Main(string[] args)
            {
                Console.WriteLine("What is your name?");
                Console.Write("Type your first name \n"); 
                string myFirstName;
                myFirstName = Console.ReadLine();

                string myLastName;
                Console.Write("Type your last name \n");
                myLastName = Console.ReadLine();

                Console.WriteLine("Hello," + myFirstName + "" + myLastName);
                Console.ReadLine();
            }
        }
    }
}


