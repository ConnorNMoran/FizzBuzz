using System;

namespace FizzBuzz
{
    class FizzBuzz
    {
        private static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write("Fizz");

                    if (i % 5 != 0)
                    {
                        Console.WriteLine();
                    }
                }

                if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 != 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }
    }
}
