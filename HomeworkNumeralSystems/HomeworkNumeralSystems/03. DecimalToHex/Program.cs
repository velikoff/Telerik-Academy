using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.DecimalToHex
{
    class Program
    {
        static char[] hexArray = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
        static void Main(string[] args)
        {
            int decimalNumber = -12345678;
        
            bool isNegative = decimalNumber < 0 ? true : false;
            string hexNumber = ToHex(decimalNumber, isNegative);
            Console.WriteLine(hexNumber);

        }

        private static string ToHex(int decimalNumber, bool isNegative)
        {
            StringBuilder result = new StringBuilder();

            if (isNegative)
            {
                decimalNumber *= -1; 

                
                int length = Convert.ToString(decimalNumber, 2).Length;
               
                int addition = 0;
                if (length % 4 != 0)
                {
                    addition = 4 - length % 4;
                }
                int lengthBits = length + addition;
                
                string bits = Convert.ToString(decimalNumber, 2);
                
                decimalNumber = Convert.ToInt32(bits, 2);

                
                int mask = 1;
                for (int i = 0; i < lengthBits; i++)
                {
                    mask = 1 << i;
                    decimalNumber = decimalNumber ^ mask;
                }
                
                decimalNumber += 1;
            }

            while (decimalNumber != 0)
            {
                
                result.Append(hexArray[decimalNumber % 16]);
                decimalNumber /= 16;

            }

            string hex = result.ToString();
            int lengthHex = hex.Length;
            result.Clear();
            
            for (int i = lengthHex - 1; i >= 0; i--)
            {
                result.Append(hex[i]);
            }

            if (isNegative)
            {
                hex = result.ToString();
                result.Clear();
                
                result.Append(hex.PadLeft(8, 'F'));
            }

            return result.ToString();
        }
    }
}
