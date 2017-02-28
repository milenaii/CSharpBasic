using System;
class MutantSquirells
{
    static void Main()
    {
        Console.WriteLine("Enter an integer t:  1 <= t <= 100 000");
        int t = int.Parse(Console.ReadLine()); //number of trees

        Console.WriteLine("Enter an integer b:  3 <= t <= 5 000");
        int b = int.Parse(Console.ReadLine()); // branches of each tree

        Console.WriteLine("Enter an integer s:  5 <= t <= 800");
        int s = int.Parse(Console.ReadLine()); //squirrel on each branch

        Console.WriteLine("Enter an integer n:  1 <= t <= 100");
        int n = int.Parse(Console.ReadLine()); //tails for each squirrel 

        decimal tails = t * b * s * n;

        if (tails % 2 == 0)
        {
            tails *= 376439;
        }
        else
        {
            tails /= 7;
        }
        Console.WriteLine("{0:0.000}", tails);

    }
}

