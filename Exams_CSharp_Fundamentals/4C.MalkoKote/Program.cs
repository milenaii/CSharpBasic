using System;
//All input data is read from the standard input (the console). On the first line you will receive an integer S. The size of malko kote On the second line you will receive the character C with which you will have to print the kote
//10
//#
//Sample Output 1

// # #
// ###
//  #
// ###
// ###   ##
//#####  #
//#####  #
//#####  #
//##### ##
// ######

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter an even numbers: 10 < s < 86 ");

        int s = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter a symbol: ");

        char symbol = char.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();



        Console.Write(" ");
        Console.Write(new string(symbol, 1));
        Console.Write(new string(' ', s / 6));
        Console.WriteLine(new string(symbol, 1));

        for (int i = 1; i <= s / 6; i++)
        {
            Console.Write(" ");
            Console.WriteLine(new string(symbol, s / 6 + 2));
        }

        for (int i = 1; i <= s / 6; i++)
        {
            Console.Write("  ");
            Console.WriteLine(new string(symbol, s / 6));
        }

        for (int i = 1; i <= s / 6; i++)
        {
            Console.Write(" ");
            Console.WriteLine(new string(symbol, s / 6 + 2));
        }

        Console.Write(" ");
        Console.Write(new string(symbol, s / 6 + 2));
        Console.Write("   ");
        Console.WriteLine(new string(symbol, s / 6 + 1));

        for (int i = 1; i <= s/6 + 2; i++)
        {
        Console.Write(new string(symbol, s/6 + 4));  
        Console.Write("  ");
        Console.WriteLine(new string(symbol,1));
        }
        Console.Write(new string(symbol, s / 6 + 4));
        Console.Write(" ");
        Console.WriteLine(new string (symbol, 2));

        Console.Write(" ");
        Console.WriteLine(new string(symbol,s/6 + 5));


        Console.WriteLine();
    }
}

