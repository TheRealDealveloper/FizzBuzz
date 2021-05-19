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
<<<<<<< HEAD
            else if (isDivisibleBy(number, 5))
            {
                return "Buzz";
            }
=======
>>>>>>> parent of 3d39860 (fixed failing buzz test)
            else
            {
                return number.ToString();
            }

        }
    }
}
