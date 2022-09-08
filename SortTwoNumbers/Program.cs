using System;

namespace SortTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            string[] input = x.Split(" ");
            int[] list = new int[2];

            for (int i = 0; i < input.Length; i++)
            {
                list[i] = Int32.Parse(input[i]);
            }

            int a = list[0];
            int b = list[1];

            if (a >= 0 && a <= 1000000 && b >= 0 && b <= 1000000)
            {
                if (a < b)
                    Console.WriteLine(a.ToString() + " " + b.ToString());
                else
                    Console.WriteLine(b.ToString() + " " + a.ToString());
            }
        }
    }
}
