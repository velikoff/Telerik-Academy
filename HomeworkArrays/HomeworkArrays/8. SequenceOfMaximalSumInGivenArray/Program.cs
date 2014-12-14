using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8.SequenceOfMaximalSumInGivenArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the length of the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Enter array element {0}: ", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            int index = 0, j = 0, max = int.MinValue, sum = 0, start = 0, end = 0;
            for (index = 0; index < n; index++)
            {
                for (j = 0; j < n; j++)
                {
                    if (index + j < n) // предотвратява излизане на индекса извън размера на масива
                        sum = sum + array[index + j]; // събира последователно елементите
                    if (sum > max) // ако сумата е по голяма
                    {
                        max = sum; // запазва стойността на новата сума
                        start = index; // запазва началото на интервала от елементи  с макс. сума
                        end = index + j; // запазва края на интервала от елементи
                    }
                }
                sum = 0;
            }
            Console.WriteLine("\nMax sum of the elements are: ");
            for (j = start; j <= end; j++)
            {
                Console.Write("{0}; ", array[j]);
            }
            Console.WriteLine("\nTheir sum is: {0}\n", max);
            
        }
    }
}
