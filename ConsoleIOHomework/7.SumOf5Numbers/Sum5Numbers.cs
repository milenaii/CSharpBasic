using System;
//Write a program that reads 5 integer numbers from the console and prints their sum.
//Input
//You will receive 5 numbers on five separate lines.
//Output
//Your output should consist only of a single line - the sum of the 5 numbers.
//Constraints
//All 5 numbers will always be valid integer numbers between -1000 and 1000, inclusive
class Sum5Numbers
{
    static void Main()
    {
        Console.WriteLine("Enter 5 integer numbers:");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c= int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int e = int.Parse(Console.ReadLine());

        if ((-1000 > a) ^ (a > 1000)^(-1000 > b) ^ (b > 1000) ^ (-1000 > c) ^ (c > 1000) ^ (-1000 > d) ^ (d > 1000) ^ (-1000 > e) ^ (e > 1000)) 
        {
            Console.WriteLine("Not valid numbers!\n -1000 <= numb <= 1000");
        }
        else
        {
        int sum = a + b + c + d + e;
        Console.WriteLine(sum);
        }
        // Second way: 

        //int sum = 0;
        //for (int i = 1; i <= 5; i++)
        //{
        //    int a = int.Parse(Console.ReadLine());
        //    if ((-1000 > a) ^ (a > 1000))
        //    {
        //        Console.WriteLine("Not valid number!");
        //    }
        //    else
        //        sum = sum + a;

        //}
        //Console.WriteLine("The sum is: {0} \n", sum);
    }
}





