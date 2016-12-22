using System;
using System.Collections.Generic;

class NewArrayResized
    //Copy an array and save the old one

{
    static void Main()
    {
        int[] array = new int[5] { 1, 2, 3, 4, 5 };
        int[] newArray = new int[6];

        for (int i = 0; i < 5; i++)
        {
            newArray[i] = array[i];
        }
        newArray[5] = 6;
        Console.WriteLine(string.Join(" ",array));
        Console.WriteLine(string.Join(" ", newArray));

    }
}

