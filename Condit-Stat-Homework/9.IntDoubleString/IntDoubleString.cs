using System;

//Write a program that, depending on the first line of the input, reads an int, double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends* at the end.
//Print the result at the console. Use switch statement.

class IntDoubleString
{
    static void Main()
    {
        Console.WriteLine("Enter \"integer\", \"real\" or \"text\": ");
        string str = Console.ReadLine();

        switch (str)
        {
            case "integer":
                Console.WriteLine("Enter int: ");
                int i = int.Parse(Console.ReadLine());
                i = i + 1;
                Console.WriteLine(i);
                break;
            case "real":
                Console.WriteLine("Enter double: ");
                double h = double.Parse(Console.ReadLine());
                h = h + 1;
                string m = Convert.ToString(h);
                Console.WriteLine("{0:0.00}", h);
                break;
            case "text":
                Console.WriteLine("Enter string");
                string v = Console.ReadLine();
                Console.WriteLine("{0}" + "*", v);
                break;

            default:
                break;
        }

    }
}

