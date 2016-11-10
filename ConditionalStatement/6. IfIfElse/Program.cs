using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter two integer numbers: ");

        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        if (a > b)
        {
            Console.WriteLine(a);
        }
        else if ((b > a) || (b == 5))  // тук може да е само if  
            //if       input a = 20 b = 5 , output  - 20 5
            //else if  input a = 20 b = 5 , output  - 20
        {
            Console.WriteLine(b);
        }
        else
        {
            Console.WriteLine(a = b);
        }
    }
}

