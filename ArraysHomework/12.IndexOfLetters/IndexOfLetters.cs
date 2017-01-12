using System;
//Write a program that creates an array containing all letters
//from the alphabet (a-z). Read a word from the console and print 
//the index of each of its letters in the array.
class IndexOfLetters
{
    static void Main()
    {
        string[] alphabet = new string[26]{"a","b","c","d","e",
            "f","g","h","i","j","k","l","m","n","o","p",
            "q","r","s","t","u","v","w","x","y","z"};

        Console.WriteLine("Enter word: ");
        string input = Console.ReadLine();

        for (int i = 0; i < input.Length; i++)
        {
            for (int j = 0; j < alphabet.Length; j++)
            {
                if (input[i].ToString().Contains(alphabet[j]))
                {
                    Console.WriteLine(j);
                }
            }

        }
                    
    }
}

