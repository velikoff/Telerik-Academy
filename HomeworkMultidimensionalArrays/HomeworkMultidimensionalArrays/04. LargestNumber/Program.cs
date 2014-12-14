using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.LargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
             int[] array = {4, 1, 2, 7, 5, 9, 7, 8 };
	        int K = 3;
	 
	        Array.Sort(array);
	        //Array.Sort(array, (x, y) => (x).CompareTo(y));
	 
	        int searchedNumber = Array.BinarySearch(array, K);
	        foreach (int number in array)
	        {
	            Console.Write(number + " ");
	        }
	        Console.WriteLine();
	 
	        if (searchedNumber < -1)
	        {
	            Console.WriteLine("Largest number lower than or equal to {0} is {1}", K, array[~searchedNumber - 1]);
        }
	        else if (~searchedNumber == 0)
	        {
	            Console.WriteLine("No such number");
	        }
	        else
	        {
	            Console.WriteLine("Largest number lower than or equal to {0} is {1}");
            }
        }
    }
}

        


