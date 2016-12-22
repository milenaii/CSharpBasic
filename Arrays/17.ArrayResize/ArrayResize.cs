using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var array = new int[0];

        for (int i = 0; i < 100; i++)
        {
            var newArray = new int[array.Length + 1];
            for (int j = 0; j < array.Length; j++)
            {
                newArray[j] = array[j]; // копираме елем от единия в др
            }
            newArray[array.Length] = i; // i is the new value

            array = newArray; // когато излезе от цикъла newArray няма да същ
            // array ще сочи към новите елементи
        }

    }
}

