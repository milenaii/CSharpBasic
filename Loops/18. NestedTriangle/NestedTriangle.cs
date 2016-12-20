using System;
//1
//12
//123
//....
//123....n

class NestedTriangle
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int row = 1; row <= n; row++)
        {
            for (int column = 1; column <= row; column++)
            {
                Console.Write(column);
            }

            Console.WriteLine(); // трябва ни за да мести
            // числата по редовете
        }
    }
}

