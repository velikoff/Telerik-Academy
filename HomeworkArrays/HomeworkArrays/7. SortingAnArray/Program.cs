using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7.SortingAnArray
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter the length ot the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Enter array element {0}: ", i);
                array [i] = int.Parse(Console.ReadLine());
            }
            int tmp, minIndex;
            for (int i = 0; i < array.Length -1; i++)
        {
            minIndex = i;
                for (int j = i; j < array.Length - 1; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }
            
            tmp = array[i];
            array[i] = array[minIndex];
            array[minIndex] = tmp;
        }
        foreach (var item  in array)
              {
                     Console.WriteLine(item + " ");
              }
    Console.WriteLine();
        }
    }
}

        
    

