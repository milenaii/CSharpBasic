using System;
// Като че ли програмата работи, но доста бавно..

class IndexLetters
{
    static void Main()
    {
        char[] alphabet = new char[26];
        for (int i = 0; i < alphabet.Length; i++)
        {
            alphabet[i] = (char)(97 + i);
            //Console.WriteLine(alphabet[15]);
        }
        Console.WriteLine("Enter a word: ");

        string word = Console.ReadLine();

        //Here we try to find the index of each of letters with binary search
        // from the past task.

        int l = 0;
        int r = alphabet.Length - 1;
        //bool found = false;

        for (int i = 0; i < word.Length; i++)
        {
            while (l <= r)
            {
            int mid = (l + r) / 2;

                if (word[i] == alphabet[mid])
                {
                    Console.WriteLine(mid);
                    break;
                }
                else if (word[i] <= alphabet[mid])
                {
                    r = mid;
                }
                else if (word[i] >= alphabet[mid])
                {
                    l = mid;
                }

            }
        }
    }
}
