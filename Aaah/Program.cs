using System;

class Aaah
{
    static void Main()
    {
        string jonMarius = Console.ReadLine();
        string doctor = Console.ReadLine();

        if (jonMarius.Length >= doctor.Length)
            Console.WriteLine("go");
        else if (jonMarius.Length < doctor.Length)
            Console.WriteLine("no");
    }
}
