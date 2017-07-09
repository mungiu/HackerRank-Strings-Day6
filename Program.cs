using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class Solution
{
    static void Main(String[] args)
    {
        Console.WriteLine("Input T: ");
        int T = Convert.ToInt32(Console.ReadLine());
        
        while (T > 0)
        {
            Indexing();
        }
    }

    static void Indexing()
    {
        Console.WriteLine("Input: ");
        string first = Console.ReadLine();
        char[] charFirst= first.ToCharArray();
        string evenIndexFirst = string.Empty;
        string oddIndexFirst = string.Empty;
        StringBuilder eF = new StringBuilder();
        StringBuilder oF = new StringBuilder();
        int x = 0;

        foreach (char j in charFirst)
        {
            if (x % 2 == 0)
            {
                eF.Append(j);
            }
            else
            {
                oF.Append(j);
            }
            x += 1;
        }
        evenIndexFirst = eF.ToString();
        oddIndexFirst = oF.ToString();
        Console.WriteLine($"{evenIndexFirst} {oddIndexFirst}");
    }
}
