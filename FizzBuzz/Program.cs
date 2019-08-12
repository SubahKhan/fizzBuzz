using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i%3 == 0 && i%5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                if (i%3 == 0 || i.ToString().Contains("3"))
                {
                    Console.WriteLine("Fizz");
                }
                else if (i%5 == 0 || i.ToString().Contains("5"))
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
