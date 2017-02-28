using System;
//Write a program to find the number D(The total number of digits
//in the page numbers is D.) by given number of pages (N).

class NumberOfPages
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine()); //pages

        int countDigit = 0;

        for (int i = 1; i <= n; i++)
        {
            int m = i;
            while (m > 0)
            {
                countDigit++;
                m /= 10;
            }
        }
        Console.WriteLine(countDigit);
    }
}


