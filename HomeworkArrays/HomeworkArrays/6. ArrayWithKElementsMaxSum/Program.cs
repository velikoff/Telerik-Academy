using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6.ArrayWithKElementsMaxSum
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter the length of the array");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the K");
            int k = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int[] arrayK = new int[k];
            int sum = 0;
            int currentSeq = 0, bestSum = 0, bestSeq = 0;
            //условната конструкция if проверява дали въведеното число К не е по-голямо от
            //N защотото в такъв случай ще излезе от рамките на масива.
            if (k > n)
            {
                Console.WriteLine("Can't find correct result in this way");
                return;
            }

            for (int index = 0; index < n; index++)
            {
                Console.Write("array[{0}] :", index);
                array[index] = int.Parse(Console.ReadLine());
            }
            //чрез класа Array  и метода .Sort сортираме елементите в масива, така
            //със сигурност знаем, че последните К елементи от масива образуват най-голяма сума от всички числа в първия масив
            Array.Sort(array);
            //с цикъл for отпечатваме последният елемент който е с индекс n-1, и всеки предходен докато не достигнат брой равен на К т.е. n-k
            for (int index = n - 1; index >= n - k; index--)
            {
                Console.WriteLine("arrayK[{0}] : {1}", index, array[index]);

            }
       
            
        }
    }
}
