using System;
using System.Collections.Generic;
class Remove3
{
    static void Main()
    {
        List<int> ggg = new List<int>();

        for (int i = 1; i <= 7; i++)
        {
            ggg.Add(i);
        }
        Console.WriteLine(string.Join(" ", ggg));

        //remove the element which is not in that list
        ggg.Remove(8);
        Console.WriteLine(string.Join(" ",ggg)); // it is the same
    }
}
