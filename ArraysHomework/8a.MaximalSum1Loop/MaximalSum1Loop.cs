using System;

//Това не съм го разглеждала....

class MaximalSum1Loop
{
    // First way

    //static void Main()
    //{
    //    int n = int.Parse(Console.ReadLine());

    //    int[] nums = new int[n];

    //    for (int i = 0; i < n; i++)
    //        nums[i] = int.Parse(Console.ReadLine());

    //    int max = nums[0];
    //    int currmax = nums[0];

    //    for (int i = 1; i < n; i++)
    //    {
    //        currmax = Math.Max(nums[i], currmax + nums[i]);
    //        if (currmax > max)
    //            max = currmax;
    //    }
    //    Console.WriteLine(max);
    //}

    // Second Way


class MainClass
    {
        public static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] arr = new int[N];
            int max = 0;
            int temp = 0;

            for (int i = 0; i < N; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                temp = Math.Max(arr[i], temp + arr[i]);
                if (temp > max)
                {
                    max = temp;
                }
            }
            Console.Write(max);
        }
    }
}




