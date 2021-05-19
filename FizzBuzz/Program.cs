using System;

namespace FizzBuzz
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        private static bool isDivisibleBy(int nom, int denom)
        {
            return nom % denom == 0;
        }

        public static string Convert(int number)
        {
            if (isDivisibleBy(number, 3))
            {
                return "Fizz";
            }
            else if (isDivisibleBy(number, 5))
            {
                return "Buzz";
            }
            else
            {
                return number.ToString();
            }

        }
    }
}
