using System;
// This programme must print the greather number
class IfElseIfElse
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
        else if (b > a) // тук може да е само if, тогава и двата if ще работят!!
            // В този вариант, ако е изпълнено едното усл, другото не е, 
            //ако е с два if  -  двете условия може да са изпълнени едновременно
            // пример - виж 6,IFIfElse
        {
            Console.WriteLine(b);
        }
        else
        {
            Console.WriteLine("a = b = {0}",a);
        }
    }
}

