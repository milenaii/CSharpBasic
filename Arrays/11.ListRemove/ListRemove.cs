using System;
using System.Collections.Generic;

class ListRemove
{
    static void Main()
    {                                         // може и така
        List<int> lucy = new List<int>();    //var lucy = new List<int>();

        for (int i = 1; i <= 10; i ++)
        {
            lucy.Add(i);
        }
        Console.WriteLine(string.Join(" ", lucy)); // 1 2 3 4 5 6 7 8 9 10

        lucy.Remove(3);

        Console.WriteLine(string.Join(" ", lucy));// 1 2 4 5 6 7 8 9 10

    }
}

