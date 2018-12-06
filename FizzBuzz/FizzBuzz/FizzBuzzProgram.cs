using System;

namespace FizzBuzz
{
    class FizzBuzz
    {
        private static void Main(string[] args)
        {
            //Create for loop to increment number
            for (int i = 1; i <= 100; i++)
            {
                //Check if number is divisible by 3
                if (i % 3 == 0)
                {
                    //Write "Fizz"
                    Console.Write("Fizz");

                    //Check if number is not divisible by 5
                    if (i % 5 != 0)
                    {
                        //Go to new line for next entry
                        Console.WriteLine();
                    }
                }

                //Check if number is divisible by 5, else check if number is not divisible by 3
                if (i % 5 == 0)
                {
                    //Write "Buzz"
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 != 0)
                {
                    //Write number
                    Console.WriteLine(i);
                }
            }

            //Wait for user to enter key to be able to read console output
            Console.ReadKey();
        }
    }
}
