using System;
//Изхода не е ок, но изчисленията са добре!!
class Neurons
{
    static void Main()
    {

        while (true)
        {
            int n = int.Parse(Console.ReadLine());
            //Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
            if (n == -1)
            {
                break;
            }
            else if (n == 0)
            {
                Console.WriteLine(0);
                continue;
            }

            int r = Int16.MinValue;
            int l = Int16.MinValue;

            for (int i = 0; i < 32; i++)
            {
                // get
                int get = n & (1 << i);
                //Console.WriteLine(Convert.ToString(get, 2).PadLeft(32, '0'));

                if ((get > 0) & (r == l))
                {
                    r = i;
                }
                else if ((get > 0) & (r != l))
                {
                    l = i;
                }

            }
            //Console.WriteLine("{0},{1}", r, l);

            for (int i = r; i <= l; i++)
            {
                int get = n & (1 << i);

                if (get > 0)
                {
                    //clear i
                    n = n ^ (1 << i);
                }
                else if (get == 0)
                {
                    //set i
                    n = n | (1 << i);
                }
            }
            Console.WriteLine(n);

        }
    }
}

//// get
//uint mask = (1 << 3);
//uint get = (a & mask);
//Console.WriteLine(get != 0 ? 1 : 0);

//// set
//uint set = (a | mask);
//Console.WriteLine(set != 0 ? 1 :0);

////clear    
//uint clear = (a & ~mask);
//Console.WriteLine(clear != 0 ? 1 : 0);



