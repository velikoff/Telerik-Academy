using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _9.MostFrequentNumberInAnArray
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter the length of the array: ");
             int n = int.Parse(Console.ReadLine());
             int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter the array element {0}: ", i);
                array[i] = int.Parse(Console.ReadLine());
            }
             
            int MaxBr = 1;   // брой повторения в настоящия цикъл
            int mostFrequent = array[0];   // най-големия брой повторения до сега
            int br = 1; // променлива, която пази стойността на елемента, който се повтаря най-много

            for (int i = 0; i < n - 1; i++)
            {
                br = 1;

                for (int j = i +1; j < n; j++)
                    
                    if (array[i] == array[j])
                {
                    br++;
                }
                if (br > MaxBr)
                {
                MaxBr = br;
                mostFrequent = array[i];    
                }
            }
            if (MaxBr > 1)
            {
                Console.WriteLine("Most frequent number is {0}", mostFrequent);
                Console.WriteLine("Count  {0} times", MaxBr);
            }
            else 
            {
                Console.WriteLine("All elements are different");
            }
                    
        }
    }
}
