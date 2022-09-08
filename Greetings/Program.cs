using System;

namespace Greetings
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = Console.ReadLine();
            char[] list = greeting.ToCharArray();
            int sum = 0;

            foreach (char c in list)
            {
                if (c == 'e')
                    sum++;
            }

            sum *= 2;

            Console.Write("h");

            for (int i = 1; i <= sum; i++)
            {
                Console.Write("e");
            }

            Console.Write("y");
        }
    }
}
