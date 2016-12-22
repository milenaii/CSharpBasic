using System;
using System.Collections.Generic;
class ListArray
{
    static void Main()
    {
        // List

        List<int> listInt = new List<int>();

        for (int i = 0; i < 5; i++)
        {
            listInt.Add(i);
        }

        //is the same as:
        int[] arrayInt = new int[5] ;

        for (int i = 0; i < 5; i++)
        {
            arrayInt[i] = i;
        }
    }
}
