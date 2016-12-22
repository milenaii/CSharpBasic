using System;
using System.Collections.Generic;

class RemoveAtContainsList
{
    static void Main()
    {
        List<int> ggg = new List<int>() { 1, 2, 3, 4, 5 };

        ggg.RemoveAt(1); // remove the element of position 1

        Console.WriteLine(string.Join(" ", ggg));  // 1 3 4 5

        Console.WriteLine("Is there 4 " + ggg.Contains(4));
        Console.WriteLine("Is there 8 " + ggg.Contains(8));

    }
}

