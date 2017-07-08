using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class Solution
{
    static void Main(String[] args)
    {
        string S = Console.ReadLine();
        char[] charS = S.ToCharArray();

        string evenIndexed = string.Empty;
        string oddIndexed = string.Empty;
        StringBuilder eI = new StringBuilder();
        StringBuilder oI = new StringBuilder();
        
        int x = 0;
        foreach (char j in charS)
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

        Console.WriteLine(evenIndexed);
        Console.WriteLine(oddIndexed);
    }
}
