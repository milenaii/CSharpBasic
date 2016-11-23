using System;

//Тук цикъла ще върти 2 пъти по-малко, т.к няма да проверяваме за всички четни
class Prime2
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        // за да не делим на всички четни числа, а само на 2, правим така:
        
        if (n % 2 == 0 && n != 2) // тук влиза и числото 2, затова && n !=2 
        {

        }
        //divise да започва от три...
        int divise = 3;

        bool isPrime = true;

        while (divise < n)
        {
            if (isPrime && (n % divise == 0))
            {
                Console.WriteLine("Not prime, because it is divided on {0}", divise);
                // това cw може да е най- след while
                isPrime = false;
            }
           // и да се събира с две, т.е. ще се дели на 3,5,7,9,....
            divise+=2;

        }
        Console.WriteLine(isPrime ? "{0} is Prime" : "{0} is not prime", n);

    }
}

