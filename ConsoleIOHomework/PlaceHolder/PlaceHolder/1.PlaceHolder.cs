using System;
class PlaceHolder
{
    static void Main()
    {
        double f = 3.6543210;

// !!!!!!!!  This is very usefull:

        Console.WriteLine("{0:#.00}", f);   // 3.65 без закръгляне, колкото знака искаме 

        Console.WriteLine("{0:#.00000}", f); // 3.65432
 // !!!


        Console.WriteLine("{0}", f);   // 3.6543210       

        Console.WriteLine("{0:0}", f);  // 4  - закръгля нагоре

        Console.WriteLine("{0:0.0}", f);   // 3.7  - 1 ц след запет + закръглян нагоре

        Console.WriteLine("{0:00.0}", f); // 03.7

        Console.WriteLine("{0,15}", f); //  (15 дължина) подравнено    

        Console.WriteLine("{0: My number is 0.0}", f);  // My number is 3.7

        Console.WriteLine("{0:P}", f);   // 365.43 %

        Console.WriteLine("{0:E}", f);  // 3.654321E+000

        Console.WriteLine("{0:E2}", f);  // 3.65E+000

        Console.WriteLine("{0:E4}", f);  // 3.6543E+000

        Console.WriteLine("{0:C}",f);    // 3.65 лв

        //   Console.WriteLine("{0:X}", f);   Exception   -  шестнадесетичен формат

        // Тези пък защо са така ???? :

        Console.WriteLine("\n{0:1.##}", f);  // 13.65  -   1 отпред

        Console.WriteLine("{0:1.#}", f);  // 13.7  -  1 отпред, 1 ц след запет

        Console.WriteLine("{0:1}", f);  //   1  - само единица без цифри от числото

        Console.WriteLine("{0:2.####}", f);  // 23.6543 - 2 отпред + числото до 4 ц след запетаята     

        Console.WriteLine("{0:1.00}",f );   // 13.65     

        Console.WriteLine("{0:2##}", f);   // 24 - 2 отпред 
        Console.WriteLine("{0:0.0}", f);   //  3.7
        Console.WriteLine("{0:00.000}", f);   //  03.654

        //PlaceHolder from homework:

        //Hexidecimal (set in condition INT)
        //Console.WriteLine("{0:X}", a);

        //Binary, 10 digit length (set in condition INT)
        //Console.WriteLine(Convert.ToString(a, 2).PadLeft(10, '0'));

        //Две цифри след запетаята, 10 ц дълж, подравнено вдясно (set FLOAT)
        //Console.WriteLine("{0,10:0.00}", b);

        //Две цифри след запетаята, 10 ц дълж, подравнено вляво (set FLOAT)
        //Console.WriteLine("{0,-10:0.000}", c);


    }

}

