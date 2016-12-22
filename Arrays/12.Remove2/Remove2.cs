using System;
using System.Collections.Generic;

// if there are some eual elements, which one REMOVE will remove

class Remove2
{
    static void Main()
    {
        List<int> ggg = new List<int>();

        for (int i = 1; i <= 7; i++)
        {
            ggg.Add(i);
        }
        ggg.Add(3);
        Console.WriteLine(string.Join(" ",ggg));

        // there are two 3, which one we can remove

        ggg.Remove(3);

        Console.WriteLine(string.Join(" ",ggg));
    }
}

