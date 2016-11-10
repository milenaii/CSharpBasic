using System;

class IfElse
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        if (a > b)
        {
            Console.WriteLine("A is grather than B");
        }
        else
        {
            Console.WriteLine("A is lesser or equal than B");
        }
    }
}
