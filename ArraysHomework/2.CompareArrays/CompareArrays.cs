using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] arr1 = new int[n];
        int[] arr2 = new int[n];

        for (int i = 0; i < n; i++)
        {
            arr1[i] = int.Parse(Console.ReadLine());
            //Console.WriteLine(arr1[i]);
        }

        for (int i = 0; i < n; i++)
        {
            arr2[i] = int.Parse(Console.ReadLine());
            //Console.WriteLine(arr2[i]);
        }

        for (int i = 0; i < n; i++)
        {
            if (arr1[i]!=arr2[i])
            {
                Console.WriteLine("Not equal");
                break;
            }
            else
            {
                break;
                Console.WriteLine("Equals");
            }
        }
        {

        }
    }
}

