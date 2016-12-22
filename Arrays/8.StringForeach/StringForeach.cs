using System;

class StringForeach
{
    static void Main()
    {
        string[] names = { "Mimi", "MIl", "Cho", "Ko" };
        foreach (string m in names)
        {
            Console.WriteLine(m);
        }

        // the other way is -  analogical to the upper:

        //for (int i = 0; i < names.Length; i++)
        //{
        //    string mi = names[i];
        //    Console.WriteLine(mi); 
        //}
    }
}

