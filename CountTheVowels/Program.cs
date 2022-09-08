using System;

namespace CountTheVowels
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine().ToLower();
            char[] list = s.ToCharArray();
            int sum = 0;

            foreach (char ch in list)
            {
                if (ch == 'a' || ch == 'o' || ch == 'e' || ch == 'i' || ch == 'u')
                    sum++;
            }
            Console.WriteLine(sum);
        }
    }
}
