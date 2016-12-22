using System;
using System.Collections.Generic;

//list of objects

class ListObject
{
    static void Main()
    {
        List<object> obj = new List<object>() { false, 42, 4.5M, "municii" };

        Console.WriteLine(string.Join(" ", obj));
        // all types in C# can be ToString, so all elements are print
    }
}

