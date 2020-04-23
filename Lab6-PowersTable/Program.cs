using System;
using System.Dynamic;

namespace Lab6_PowersTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Square and Cubed calculator");
            bool loop = true;
            while (loop == true)
            {
                int answer = ReadIntegers("Please enter a whole number: ");
                Console.WriteLine("Number   Squared  Cubed");
                Console.WriteLine("======   =======  =====");
                for (int i = 1; i <= answer; i++)
                {

                    Console.WriteLine($"{i}        {i * i}        {i * i * i}");
                }
                
            
            bool askAgain = true;
                while (askAgain)
                {
                    Console.WriteLine("Would you like to continue? y/n");
                    string userInput = Console.ReadLine().ToLower();
                    if (userInput == "y")
                    {
                        loop = true;
                        askAgain = false;
                    }
                    else if (userInput == "n")
                    {
                        loop = false;
                        askAgain = false;
                    }
                }
            }
        }
        public static int ReadIntegers(string message)
        {
                Console.WriteLine(message);
                string input = Console.ReadLine();
                int num = int.Parse(input);
                return num;
        }
    }
}
