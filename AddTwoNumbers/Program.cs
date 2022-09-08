using System;

namespace AddTwoNumbers
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
            int sum = 0;

            if (a >= 0 && a <= 1000000 && b >= 0 && b <= 1000000)
            {
                sum = a + b;
            }
            Console.WriteLine(sum);
        }
    }
}
