namespace JobExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            int[] k = new int[n];
            int sum = 0;

            if (n >= 0 && n <= 20000)
            {
                string x = Console.ReadLine();
                string[] input = x.Split(" ", n);

                for (int i = 0; i < input.Length; i++)
                {
                    k[i] = Int32.Parse(input[i]);

                    if (k[i] >= -50000 && k[i] <= 500000 && k[i] != 0)
                    {
                        if (k[i] < 0)
                            sum += Math.Abs(k[i]);
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}