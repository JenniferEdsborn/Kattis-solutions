﻿using System;

public static class Apaxiaaaaaaaaaaaans
{
    internal static void Main()
    {
        string s = Console.ReadLine();

        for (int i = 0; i < s.Length - 1; i++)
        {
            if (s[i] != s[i + 1])
            {
                Console.Write(s[i]);
            }
        }
        Console.Write(s[s.Length - 1]);
    }
}
