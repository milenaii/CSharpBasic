using System;

class StringCollection
{
    static void Main()
    {
        string str = "Turtle";

        Console.WriteLine(str.Length);
        Console.WriteLine(str[0]);

        foreach (var ch in str)
        {
            Console.WriteLine(ch);

            // Ascii codes:
            //Console.WriteLine((int)ch);   
        }

    }
}

