using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11.CalculateN
{
    class Program
    {
        static void Main()
        {
            Console.Write("Input the a positive integer: ");
            int n = int.Parse(Console.ReadLine());
            int[] result = { 1 };
            for (int i = 2; i <= n; i++)
            {
                result = Myltiply(result, GetArrayFromPositiveNumber(i));
            }
            Console.Write("And {0}! = ", n);
            PrintArrayNumber(result);
        }

        private static int[] Myltiply(int[] a, int[] b)
        {
            int[] result;
            if (a.Length > b.Length)
            {
                result = MultiplyBySecondNumberDigits(a, b);
            }
            else
            {
                result = MultiplyBySecondNumberDigits(b, a);
            }
            return result;
        }

        private static int[] MultiplyBySecondNumberDigits(int[] a, int[] b)
        {
            List<int>[] resultsToAdd = new List<int>[b.Length];
            int currentDigitPosition = 0;
            for (int i = 0; i < resultsToAdd.Length; i++)
            {
                currentDigitPosition = 0;
                resultsToAdd[i] = new List<int>(a.Length + i + 1);
                //first add zeroes in the end
                while (currentDigitPosition < i)
                {
                    resultsToAdd[i].Add(0);
                    currentDigitPosition++;
                }

                //then multiply by b[i] to get the remaining digits of the number
                int remainingToAdd = 0;
                int currentMultiplication;
                for (int positionInA = 0; positionInA < a.Length; positionInA++)
                {
                    currentMultiplication = b[i] * a[positionInA];
                    resultsToAdd[i].Add((currentMultiplication + remainingToAdd) % 10);
                    remainingToAdd = (currentMultiplication + remainingToAdd) / 10;
                }
                if (remainingToAdd > 0)
                {
                    resultsToAdd[i].Add(remainingToAdd);
                }
            }

            //calculate final result by adding the previous b.Length results
            int[] result = resultsToAdd[0].ToArray();
            for (int i = 1; i < resultsToAdd.Length; i++)
            {
                result = Add(result, resultsToAdd[i].ToArray());
            }

            return result;
        }

        private static int[] GetArrayFromPositiveNumber(int number)
        {
            int[] result = new int[(int)Math.Log10(number) + 1];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = number % 10;
                number /= 10;
            }
            return result;
        }

        private static void PrintArrayNumber(int[] result)
        {
            for (int i = result.Length - 1; i >= 0; i--)
            {
                Console.Write(result[i]);
            }
            Console.WriteLine();
        }

        private static int[] Add(int[] firstNumber, int[] secondNumber)
        {

            List<int> result = new List<int>(Math.Max(firstNumber.Length, secondNumber.Length) + 1);
            int min = Math.Min(firstNumber.Length, secondNumber.Length);
            int add = 0;
            for (int i = 0; i < min; i++)
            {
                result.Add((firstNumber[i] + secondNumber[i] + add) % 10);
                add = ((firstNumber[i] + secondNumber[i] + add) / 10) % 10;
            }
            if (firstNumber.Length > min)
            {
                for (int i = min; i < firstNumber.Length; i++)
                {
                    result.Add((firstNumber[i] + add) % 10);
                    add = ((firstNumber[i] + add) / 10) % 10;
                }
            }
            if (secondNumber.Length > min)
            {
                for (int i = min; i < secondNumber.Length; i++)
                {
                    result.Add((secondNumber[i] + add) % 10);
                    add = ((secondNumber[i] + add) / 10) % 10;
                }
            }
            if (add > 0)
            {
                result.Add(add);
            }
            return result.ToArray();
        }
    }
}

