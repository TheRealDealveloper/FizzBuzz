using System;

namespace FizzBuzz
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static string Convert(int number)
        {
            if (number % 3 == 0)
            {
                return "Fizz";
            }
            else
            {
                return number.ToString();
            }

        }
    }
}
