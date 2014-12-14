using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09.InternalBinaryFloat
{
    class Program
    {
        static void Main()
		{
			float numberToConvert = float.Parse(Console.ReadLine());
			int sign = numberToConvert < 0 ? 1 : 0;
			numberToConvert = Math.Abs(numberToConvert);
			int exponent = 0;
			float decimalPart = numberToConvert - (int)numberToConvert;
			string mantissaNormalized = (int)numberToConvert == 0 ? "" : Convert.ToString((int)numberToConvert, 2);
			// calc mantissa
			while (decimalPart != 0)
			{
				decimalPart *= 2f;
				mantissaNormalized += (int)decimalPart;
				decimalPart -= (int)decimalPart;
			}
			mantissaNormalized = mantissaNormalized.TrimStart('0');
			// calc exponent depend integer part of the float
			decimalPart = numberToConvert - (int)numberToConvert;
			if ((int)numberToConvert == 0)
				while (decimalPart < 1 && exponent > -127)
				{
					exponent--;
					decimalPart *= 2;
				}
			else
				while (numberToConvert >= 2)
				{
					exponent++;
					numberToConvert /= 2;
				}
			// output
			Console.WriteLine("sign = {0} exponent = {1} mantissa = {2}", sign, Convert.ToString(exponent + 127, 2).PadLeft(8, '0'), mantissaNormalized.PadRight(24, '0').Substring(1));
		}
	}
    }

