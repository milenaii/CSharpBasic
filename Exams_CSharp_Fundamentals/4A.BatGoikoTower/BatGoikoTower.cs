using System;

//not perfect, but very well
// it needs some additional things

class BatGoikoTower
{
    static void Main()
    {
        int h = 11;
        for (int i = 1; i <= h; i++)
        {
            Console.Write(new string('.', h - i));
            Console.Write("/");
            Console.Write(new string('.', 2 * i - 2));
            Console.Write("\\");
            Console.WriteLine(new string('.', h - i));
        }

    }
}
