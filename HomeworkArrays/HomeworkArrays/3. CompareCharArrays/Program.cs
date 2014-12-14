using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.CompareCharArrays
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter the first char elements:");
            string firstChars = Console.ReadLine();
            char[] firstArray = firstChars.ToCharArray(); //convert string to char array
            int firstArrayLength = firstArray.Length;  //gets length of the first array

            Console.WriteLine("Please enter the second char elements:");
            string secondChars = Console.ReadLine();
            char[] secondArray = secondChars.ToCharArray();
            int secondArrayLength = secondArray.Length;

            int minLen = Math.Min(secondArrayLength, firstArrayLength); //gets min length of the two arrays

            bool equalCharArrays = true;  // a kind of flag, helps to print the correct output

            for (int i = 0; i < minLen; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    continue;
                }
                else
                {
                    equalCharArrays = false;
                    if (firstArray[i] < secondArray[i])
                    {
                        Console.WriteLine("The first char array is lexicografically before the second.");
                    }
                    else
                    {
                        Console.WriteLine("The second char array is lexicografically before the first.");
                    }
                    break;
                }
            }
            if (equalCharArrays == true && firstArrayLength < secondArrayLength)
            {
                Console.WriteLine("The first char array is lexicografically before the second.");
            }
            else if (equalCharArrays == true && firstArrayLength > secondArrayLength)
            {
                Console.WriteLine("The second char array is lexicografically before the first.");
            }
            else if (equalCharArrays == true && firstArrayLength == secondArrayLength)
            {
                Console.WriteLine("The arrays are equal.");
            }
        }
    }
}
