using System;

namespace FizzBuzz
{
    class FizzBuzz
    {
        private static void Main(string[] args)
        {
            int number = 1;

            while (number <= 100)
            {
                if (number % 3 == 0)
                {
                    Console.Write("Fizz");

                    if (number % 5 != 0)
                    {
                        Console.WriteLine();
                    }
                }

                if (number % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (number % 3 != 0)
                {
                    Console.WriteLine(number);
                }

                number++;
            }

            Console.ReadKey();
        }
    }
}
