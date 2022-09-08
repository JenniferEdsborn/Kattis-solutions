using System;
class ColdputerScience
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        string[] temps = Console.ReadLine().Split(" ");
        int sum = 0;

        for (int i = 0; i < temps.Length; i++)
        {
            if (int.Parse(temps[i]) < 0)
            {
                sum++;
            }
        }

        Console.WriteLine(sum);
    }
}
