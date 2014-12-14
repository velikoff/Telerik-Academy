using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.NumberAppearInArrayWithTest
{
    class Program
    {
        public static int numberToCheck;
        public static int counter;

        public static void CountAppearances(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == numberToCheck)
                {
                    counter++;
                }
            }
        }

        static void Main()
        {
            Console.Write("Enter the number which appearance you wish to count:");
            numberToCheck = int.Parse(Console.ReadLine());
            int[] array = { 4, 8, 6, 1, 4, 4, 8, 9, 0, 6, 4, 2, 1, 1 };
            CountAppearances(array);
            Console.WriteLine("The number {0} appears {1} of times in the array", numberToCheck, counter);
        }
    }
}
