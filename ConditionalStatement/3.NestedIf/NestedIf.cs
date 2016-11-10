using System;
// пример за NEsted If, но не е хубаво да се прави. 
// по възможност вътрешното условие if във външното. виж следващият файл 4.Good
class NestedIf
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        if (a > 0)
        {

            if (a % 2 == 0)
            {
                Console.WriteLine("a is positive even number");
            }
            else
            {
                Console.WriteLine("a is positive odd number");
            }
        }
        else
        {
            Console.WriteLine("a is negative number");
        }

    }
}

