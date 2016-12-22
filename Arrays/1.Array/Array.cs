using System;

class Array
{
    static void Main()
    {
        int[] numbers = new int[10];

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(numbers[i]);
            //000000000 - не сме задали стойнтости на елементите,
            // така че ще приемат default стойността на int -> 0
        }
    }
}

