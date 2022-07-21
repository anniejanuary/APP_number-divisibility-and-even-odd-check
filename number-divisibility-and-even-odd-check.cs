using System;

namespace NestedIfStatementChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            string inputNumber = Console.ReadLine();
            int inputNumberFromString = int.Parse(inputNumber);

            if (inputNumberFromString % 3 == 0)
            {
                Console.WriteLine("The number you entered is divisible by 3");
            }

            else if (inputNumberFromString % 7 == 0)
            {
                Console.WriteLine("The number you entered is divisible by 7");
            }

            else
            {
                if (inputNumberFromString % 2 == 0)
                {
                    Console.WriteLine("The number you entered is even");
                }

                else
                {
                    Console.WriteLine("The number you entered is odd");
                }

            }

            Console.Read();

        }
    }
}

