using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.ArrayIndexMultiplyByFive
{
    class Program
    {
        static void Main()
        {
            int[] array;
            array =  new int[20];
            for (int index = 0; index < array.Length; index++)
            {
            array[index] = index * 5;
            Console.WriteLine("element[{0}] = {1}", index, array[index]);
            }
        }
    }
}
