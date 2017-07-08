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

        //i need to read 2 strings and perform teh same operation on both of them
        Indexing();
    }

    static void Indexing()
    {
        Console.WriteLine("Input 1: ");
        string first = Console.ReadLine();
        Console.WriteLine("Input 2: ");
        string second = Console.ReadLine();

        char[] charFirst= first.ToCharArray();
        char[] charSecond = second.ToCharArray();

        string evenIndexFirst = string.Empty;
        string oddIndexFirst = string.Empty;
        string evenIndexSecond = string.Empty;
        string oddIndexSecond = string.Empty;
        
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

        StringBuilder eS = new StringBuilder();
        StringBuilder oS = new StringBuilder();
        int y = 0;
        foreach (char j in charSecond)
        {
            if (y % 2 == 0)
            {
                eS.Append(j);
            }
            else
            {
                oS.Append(j);
            }
            y += 1;
        }
        evenIndexSecond = eS.ToString();
        oddIndexSecond = oS.ToString();

        Console.WriteLine($"{evenIndexFirst} {oddIndexFirst}" +
            $"\n{ evenIndexSecond} {oddIndexSecond}");
    }
}
