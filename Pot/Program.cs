using System;

namespace Pot
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int total = 0;

            if (n > 1 && n < 10)
            {
                for (int i = 0; i < n; i++)
                {
                    int p = int.Parse(Console.ReadLine());

                    if (p >= 10 && p <= 9999)
                    {
                        int x = (int)Math.Pow(p / 10, p % 10);
                        total = x + total;
                    }
                }
                Console.WriteLine(total);
            }
        }
    }
}
