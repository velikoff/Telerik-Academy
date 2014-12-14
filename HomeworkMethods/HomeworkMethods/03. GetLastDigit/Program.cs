using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.GetLastDigit
{
    class Program
    {
        static string[] digitNames = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

        static string GetDigitName(int a)
        {
            return digitNames[a];
        }

        static int GetLastDigit(int a)
        {
            return a % 10;
        }

        static void Main()
        {
            Console.WriteLine(GetDigitName(GetLastDigit(4201)));
        }
    }
}
