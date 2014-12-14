using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.BinaryToDecimal
{
    class Program
    {
        static void BinaryToDecimal(string binary)
        {
            double decim = 0.0;
            int len = binary.Length;
            for (int i = len - 1; i >= 0; i--)
            {
                if (binary[i] == '1') decim = decim + Math.Pow(2, len - 1 - i);
            }
            Console.WriteLine(decim);
        }
        static void Main(string[] args)
        {
            string binary = Console.ReadLine();
            BinaryToDecimal(binary);
        }
    }
}
