using System;
// Too long numbers -> decimal or bigintegers
class TheSecretOfNumbers
{
    static void Main()
    {
        string number = Console.ReadLine();
        int num = int.Parse(number);

        if (num < 0)
        {
            num *= -1;
        }

        int specialSum = 0;
        int currentDigitPosition = 0;

        while (num > 0)
        {
            int currentDigit = num % 10;
            currentDigitPosition++;
            if (currentDigitPosition % 2 == 1)
            {
                specialSum += currentDigit * currentDigitPosition * currentDigitPosition;
            }
            else
            {
                specialSum += currentDigit * currentDigit * currentDigitPosition;
            }
            num /= 10;
        }
        Console.WriteLine(specialSum);

        int lastDigit = specialSum % 10;  // == secret Sequence Length
                                          //по условие
        if (lastDigit != 0)
        {
            char firstSecretLetter = (char)(specialSum % 26 + 'A');
            //Console.WriteLine(firstSecretLetter);
            for (int i = 0; i < lastDigit; i++)
            {
                char secretLetter = (char)(firstSecretLetter + i);
                if (secretLetter > 'Z')
                {
                    secretLetter = (char)(secretLetter - 'Z' + 'A' - 1);
                }
                Console.Write(secretLetter);
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("{0} has no secret alpha-sequence", number);
        }

    }
}



