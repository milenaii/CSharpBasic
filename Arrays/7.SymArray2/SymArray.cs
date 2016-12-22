using System;

class SymArray
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };     // {1,2,3,2,1};
        int n = numbers.Length;

        bool symmetric = true;

        int leftIndex = 0;
        int rightIndex = n - 1;

        while (leftIndex < rightIndex)
        {
            if (numbers[leftIndex] != numbers[rightIndex])
            {
                symmetric = false;
                break;
            }
            ++leftIndex;
            --rightIndex;
        }
//print 1
        Console.WriteLine(symmetric == true ? "symmetric" : "not symmetric");
// print 2
        //Console.WriteLine("Is symmetric ? {0}", symmetric);
// print 3
        //if (symmetric == true)
        //{
        //    Console.WriteLine("Array is symmetric");
        //}
        //else
        //{
        //    Console.WriteLine("Array is not symmetric");
        //}
    }
}

