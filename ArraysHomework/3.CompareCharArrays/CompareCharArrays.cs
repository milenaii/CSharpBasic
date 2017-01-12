using System;

//Write a program that compares two char arrays lexicographically
// (letter by letter).

class Program
{
    static void Main()
    {
        string st1 = Console.ReadLine();
        string st2 = Console.ReadLine();

        for (int i = 0; i < st1.Length; i++)
        {
            if (st1[i] == st2[i] && st1.Length > 1)
            //не е решено за случая st1.Length = 1 
            {
                if (st1[i + 1] < st2[i + 1])
                {
                    Console.WriteLine(" < ");
                    break;
                }
                else if (st1[i + 1] > st2[i + 1])
                {
                    Console.WriteLine(" > ");
                    break;
                }
                else if (st1[i + 1] == st2[i + 1])
                {
                    Console.WriteLine(" = ");
                    break;
                }
            }
            else if (st1[i] < st2[i])
            {
                Console.WriteLine(" < ");
                break;
            }
            else if (st1[i + 1] > st2[i + 1])
            {
                Console.WriteLine(" > ");
                break;
            }
            
        }
    }
}