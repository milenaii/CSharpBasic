using System;

class ArrayString
{
    static void Main()
    {
        string[] mstr = new string[5];

        for (int i = 0; i < mstr.Length; i ++)
        {
        Console.WriteLine(mstr[i] + "default is null");
        }


        Console.WriteLine();
        Console.WriteLine();


        string[] week = { "Monday", "Tuesday", "Wednwsday", "Thurstday", "Friday", "Saturday", "Sunday"};

        for (int i = 0; i < week.Length; i++)
        {
            Console.WriteLine(week[i]);
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(week[4]);
        Console.WriteLine();
    }
}

