using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07.ReverseDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal number = -987.654m;
            Console.WriteLine("The number is: {0}", number);
            string numberToString = number.ToString();
            string reversed = Reverse(numberToString);
            Console.WriteLine(reversed);

        }

        private static string Reverse(string number)
        {
            char[] reversedChar = number.ToCharArray();
            Array.Reverse(reversedChar);
            StringBuilder reversed = new StringBuilder();
            if (reversedChar[reversedChar.Length - 1] == '-')
            {
                reversed = reversed.Append("-");
                for (int i = 0; i < reversedChar.Length - 1; i++)
                {
                    reversed = reversed.Append(reversedChar[i]);
                }
            }
            else
            {
                for (int i = 0; i < reversedChar.Length; i++)
                {
                    reversed = reversed.Append(reversedChar[i]);
                }
            }

            return reversed.ToString();
        }
    }
}
