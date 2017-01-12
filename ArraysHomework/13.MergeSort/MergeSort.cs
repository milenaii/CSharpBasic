using System;
using System.Collections.Generic;

//Mimi - copy without analysing

//Write a program that sorts an array of integers
//using the merge sort algorithm (find it in Wikipedia).

class MergeSortAlgorithm
{
    static void Main()
    {
        //Reading the input

        int length = Convert.ToInt32(Console.ReadLine());
        int[] input = new int[length];
        for (int i = 0; i < length; i++)
        {

            input[i] = Convert.ToInt32(Console.ReadLine());
        }


        //Start sorting the array divided by its indexes
        List<int> temp = new List<int>();
        for (int k = 1; k < length; k *= 2)
        {
            int leftIndex = 0;
            int rightIndex = k;
            int indexCounter = k;
            int counter = 0;
            for (int j = 0; j < length; j++)
            {
                if (rightIndex == indexCounter + k && leftIndex == indexCounter)//Here we check if the  
                {                                                               //left and the right parts  
                    leftIndex = rightIndex;                                     //have made their full loop.
                    rightIndex += k;                                            //1 iteration -> sort 2 numbers
                    indexCounter += k + k;                                      //2 iteration -> sort 4 numbers...
                }



                if (rightIndex > (length - 1) - counter && rightIndex != indexCounter + k)
                {
                    if (rightIndex >= length - 1 && leftIndex == indexCounter)      //Here we check if only one      
                    {                                                               //of the parts have made    
                        rightIndex = (length - 1) - counter;                        //its full loop. And if so  
                        temp.Add(input[rightIndex]);                                //we fill the other half with
                        break;                                                      //the remaining numbers.
                    }
                    else if (leftIndex < length - 1)
                    {
                        temp.Add(input[leftIndex]);
                        leftIndex++;
                        continue;
                    }
                    else
                    {
                        rightIndex = leftIndex;
                    }
                }

                if (rightIndex == indexCounter + k)         //Here is little messy!
                {                                           //I compare the numbers
                    temp.Add(input[leftIndex]);             //and sort them on their
                    leftIndex++;                            //right positions.
                }
                else if (rightIndex == leftIndex)
                {
                    temp.Add(input[rightIndex]);
                    rightIndex++;
                }
                else if (leftIndex == indexCounter && rightIndex < indexCounter + k)
                {
                    temp.Add(input[rightIndex]);
                    rightIndex++;
                }
                else if (input[leftIndex] < input[rightIndex])
                {
                    temp.Add(input[leftIndex]);
                    leftIndex++;
                }
                else
                {
                    temp.Add(input[rightIndex]);
                    rightIndex++;
                }
            }
            for (int j = 0; j < length; j++)
            {
                input[j] = temp[j];
            }
            temp = new List<int>();
        }

        //Printing the result
        foreach (int item in input)
        {
            Console.WriteLine(item);
        }
        //Console.WriteLine("{0}", string.Join(", ", input));
    }
}