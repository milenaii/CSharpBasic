using System;
using System.Collections.Generic;

class ListCountAdd
{
    static void Main()
    {
        List<int> lolo = new List<int>();
        Console.WriteLine(lolo.Count);   // 0

        lolo.Add(5);   // add elements in rigth - the elem is 5
        Console.WriteLine(lolo.Count);              // 1

        Console.WriteLine(lolo[0]);  // print the 0 th element  - it is 5

        //we can add many elements on the same time
        for (int i = 0; i < 17; i++)
        {
            lolo.Add(4);  // add  4 4 4 4 4 4 4 ..... 17 times
        }

        for (int i = 0; i < 9; i++)
        {
            lolo.Add(i);  // add  0 1 2 3 4 5 6 7 8
        }
        foreach (int lo in lolo)
        {
            Console.Write(lo);
        }

        Console.WriteLine(string.Join(", ",lolo));
    }
}

