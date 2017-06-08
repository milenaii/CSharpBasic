using System;
// единият ред при числа от 11 нагоре е разместен

class Batman
{
    static void Main()
    {
        Console.WriteLine("Enter odd number: ");

        int s = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter a symbol: ");

        char symbol = (char)Console.Read();

        Console.WriteLine();
        Console.WriteLine();

        for (int i = 0; i <= (s / 2) - 2; i++)
        {
            Console.Write((new string(' ', i)));
            Console.Write(new string(symbol, s - i));
            Console.Write(new string(' ', s));
            Console.WriteLine(new string(symbol, s - i));
        }

        for (int i = 1; i < 2; i++)
        {

            Console.Write((new string(' ', s / 3 ))); //2
            Console.Write(new string(symbol, s - s / 3)); // 5
            Console.Write(new string(' ', s / 3));  //2
            Console.Write(new string(symbol, i));
            Console.Write(new string(' ', i));  //11
            Console.Write(new string(symbol, i));
            Console.Write(new string(' ', s / 3));  //2
            Console.WriteLine(new string(symbol, s - s / 3));
        }
        for (int i = 0; i <= (s / 2) - 2; i++)
        {
            Console.Write((new string(' ', s / 2)));
            Console.Write(new string(symbol, s*3 - s));
            Console.WriteLine(new string(' ', s / 3));  //2
        }
        for (int i = 1; i <= s/2; i++)
        {
            Console.Write((new string(' ', s + i)));
            Console.Write(new string(symbol, s - 2*i));
            Console.WriteLine(new string(' ', s + i));
        }


        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(7 % 3);

    }
}
