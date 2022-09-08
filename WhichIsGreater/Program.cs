using System;

namespace WhichIsGreater
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
            double power = Math.Pow(10, 9);
            power = (int)power;
            int sum = 0;

            if (a > 0 && a <= power && b > 0 && b <= power)
            {
                if (a > b)
                    Console.WriteLine("1");
                else
                    Console.WriteLine("0");
            }

        }
    }
}
