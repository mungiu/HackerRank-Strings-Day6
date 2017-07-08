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
        Console.WriteLine(FirstIndexing());
        Console.WriteLine(SecondIndexing());
    }

    static string FirstIndexing()
    {
        Console.WriteLine("Input 1: ");
        string fI = Console.ReadLine();
        char[] charfI= fI.ToCharArray();

        string evenIndexed = string.Empty;
        string oddIndexed = string.Empty;
        StringBuilder eI = new StringBuilder();
        StringBuilder oI = new StringBuilder();

        int x = 0;
        foreach (char j in charfI)
        {
            if (x % 2 == 0)
            {
                eI.Append(j);
            }
            else
            {
                oI.Append(j);
            }
            x += 1;
        }
        evenIndexed = eI.ToString();
        oddIndexed = oI.ToString();

        return ($"{evenIndexed}  {oddIndexed}");
    }

    static string SecondIndexing()
    {
        Console.WriteLine("Input 2: ");
        string sI = Console.ReadLine();
        char[] charsI = sI.ToCharArray();

        string evenIndexed = string.Empty;
        string oddIndexed = string.Empty;
        StringBuilder eI = new StringBuilder();
        StringBuilder oI = new StringBuilder();

        int x = 0;
        foreach (char j in charsI)
        {
            if (x % 2 == 0)
            {
                eI.Append(j);
            }
            else
            {
                oI.Append(j);
            }
            x += 1;
        }
        evenIndexed = eI.ToString();
        oddIndexed = oI.ToString();

        return ($"{evenIndexed}  {oddIndexed}");
    }
}
