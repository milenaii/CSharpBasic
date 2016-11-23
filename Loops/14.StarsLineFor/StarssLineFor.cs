using System;

class StarssLineFor
{
    static void Main()
    {
        for (int x = 0, y = 0; x < 10; x++, y++)
        {
            Console.SetCursorPosition(x, y);
            Console.Write('*');
        }
    }
}

