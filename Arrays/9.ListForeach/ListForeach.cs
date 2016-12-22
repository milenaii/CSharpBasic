using System;
using System.Collections.Generic;

class ListForeach
{
    static void Main()
    {
        // declaring, initialization
        // List<int> name = new List<int>();

        List<int> li = new List<int>() { 1, 2, 3, 4, 5 };

        foreach (int l in li)
        {
            Console.WriteLine(l);  // 1 2 3 4 5 
        }

        li[2] = 100;

        foreach (int l in li)
        {
            Console.WriteLine(l);   // 1 2 100 4 5 
        }
    }
}

