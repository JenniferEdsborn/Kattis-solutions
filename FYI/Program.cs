using System;

namespace FYI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int key = 5;

            int firstDigit = int.Parse(number.ToString().Substring(0, 1));
            int secondDigit = int.Parse(number.ToString().Substring(1, 1));
            int thirdDigit = int.Parse(number.ToString().Substring(2, 1));

            if (firstDigit == key && secondDigit == key && thirdDigit == key)
                Console.WriteLine("1");
            else
                Console.WriteLine("0");

        }
    }
}