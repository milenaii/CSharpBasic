using System;
class ForWithString
{
    static void Main()
    {
        for (string input = Console.ReadLine(); input != "end"; input = Console.ReadLine())
        {
            Console.WriteLine("You just wrote: " + input);
        }
         
    }
}
