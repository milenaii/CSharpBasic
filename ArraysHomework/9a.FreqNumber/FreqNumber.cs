using System;
class FreqNumber
{//Write a program that finds the most frequent number
 //in an array of N elements.

    static void Main()
    {
        Console.WriteLine("Enter n:");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        Console.WriteLine("Enter n integer numbers:");

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        int counter = 1;
        int maXcounter = 1;
        int num = 0;

        Array.Sort(arr);

        for (int i = 0; i < arr.Length-1; i++)
        {
            //Console.WriteLine(arr[i]);
            if (arr[i] == arr[i+1])
            {
                counter++;
                num = arr[i];
            }
            else
            {
                counter = 1;
               
            }
            if (counter >= maXcounter)
            {
                maXcounter = counter;
            }

        }
        Console.WriteLine("{0} ({1} times)", num, maXcounter);
    }
}

