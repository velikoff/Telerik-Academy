using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07.FromAnyNumeralSystem
{
    class Program
    {
        static int s = int.Parse(Console.ReadLine());
        static int d = int.Parse(Console.ReadLine());
        static string number = Console.ReadLine().ToUpper();

        // in this method we take number in 10 base numeral system and make it in this system that we want 
        private static string MakeInputBaseToWantBase(string number, int fromBase, int toBase)
        {
            int base10Number = MakeInputBaseToBase10System(number, fromBase);
            string numberInBaseD = string.Empty;

            while (base10Number != 0)
            {
                switch (base10Number % toBase)
                {
                    case 10: numberInBaseD = "A" + numberInBaseD; break;
                    case 11: numberInBaseD = "B" + numberInBaseD; break;
                    case 12: numberInBaseD = "C" + numberInBaseD; break;
                    case 13: numberInBaseD = "D" + numberInBaseD; break;
                    case 14: numberInBaseD = "E" + numberInBaseD; break;
                    case 15: numberInBaseD = "F" + numberInBaseD; break;
                    default: numberInBaseD = (base10Number % toBase) + numberInBaseD; break;
                }
                base10Number /= toBase;
            }
            return numberInBaseD;
        }

        // with this method we make the number in 10 base numeral system
        private static int MakeInputBaseToBase10System(string number, int fromBase)
        {
            int digit = 0;
            int result = 0;
            int count = number.Length - 1;

            for (int i = 0; i < number.Length; i++)
            {
                switch (number[i])
                {
                    case 'A': digit = 10; break;
                    case 'B': digit = 11; break;
                    case 'C': digit = 12; break;
                    case 'D': digit = 13; break;
                    case 'E': digit = 14; break;
                    case 'F': digit = 15; break;
                    default: digit = int.Parse(Convert.ToString(number[i])); break;
                }

                result += digit * Pow(count, fromBase);
                count--;
            }
            return result;
        }

        // method instead Math.Pow
        private static int Pow(int sqr, int numeralBase)
        {
            int result = 1;

            for (int i = 0; i < sqr; i++)
            {
                result = result * numeralBase;
            }

            return result;
        }

        // check if the string is entered is correct in that numeral system,
        // in that way in 15 base numeral system we can't entered F or other letter after F
        private static bool CheckInputNumberIsCorrectInInputNumeralSystem(string number, char end)
        {
            foreach (char digit in number)
            {
                if (digit >= end)
                {
                    return false;
                }
            }
            return true;
        }


        static void Main()
        {
            char sChar = 'F';
            switch (s)
            {
                case 16: sChar = 'J'; break;
                case 15: sChar = 'F'; break;
                case 14: sChar = 'E'; break;
                case 13: sChar = 'D'; break;
                case 12: sChar = 'C'; break;
                case 11: sChar = 'B'; break;
                case 10: sChar = 'A'; break;
                case 9: sChar = '9'; break;
                case 8: sChar = '8'; break;
                case 7: sChar = '7'; break;
                case 6: sChar = '6'; break;
                case 5: sChar = '5'; break;
                case 4: sChar = '4'; break;
                case 3: sChar = '3'; break;
                case 2: sChar = '2'; break;
            }

            if (CheckInputNumberIsCorrectInInputNumeralSystem(number, sChar))
            {
                Console.WriteLine(MakeInputBaseToWantBase(number, s, d));
            }
            else
            {
                Console.WriteLine("The number you entered is invalid in that numeral system.");
            }
        }
    }
}
