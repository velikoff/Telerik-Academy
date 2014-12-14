using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.SplitStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter string: ");
            //string myString = Console.ReadLine();

            string myString = "82 25,1   , 41 / 257";
            int sum = SumOfStrings(myString);

            Console.WriteLine(sum);
        }

        private static int SumOfStrings(string myString)
        {
            int sum;
            char[] charSeparators = new char[] { ' ', ',', '-', '/' };
            string[] splittedArray = myString.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);

            sum = CompleteSum(splittedArray);

            return sum;
        }

        private static int CompleteSum(string[] splittedArray)
        {
            int total = 0;
            foreach (string number in splittedArray)
            {
                total += int.Parse(number);
            }

            return total;
        }
    }
}
