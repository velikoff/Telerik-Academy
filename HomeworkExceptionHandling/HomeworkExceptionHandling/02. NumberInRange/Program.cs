using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.NumberInRange
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter start range:");
                int start = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter end range:");
                int end = int.Parse(Console.ReadLine());

                MainRangeCheck(start, end);

                int counter = 0;
                int index = 0;
                int[] numbers = new int[10];

                NumbersInput(ref start, end, ref counter, ref index, numbers);
            }

            catch (FormatException)
            {
                Console.WriteLine("You have to enter an integer number!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("The number is to big");
            }
        }

        private static void MainRangeCheck(int start, int end)
        {
            if (start < 1 || end > 100 || end < start + 10)
            {
                throw new ArithmeticException("Wrong range numbers!");
            }
        }

        private static void NumbersInput(ref int start, int end, ref int counter, ref int index, int[] numbers)
        {
            do
            {
                Console.WriteLine("Enter a number:");
                numbers[index] = int.Parse(Console.ReadLine());
                RangeCheck(start, end, index, numbers);
                start = numbers[index];
                counter++;
                index++;
            }
            while (counter < 10);

            foreach (int number in numbers)
            {
                Console.Write("{0} ", number);
            }
        }

        private static void RangeCheck(int start, int end, int index, int[] numbers)
        {
            if (numbers[index] < start || numbers[index] > end)
            {
                throw new ArithmeticException("The number is out of range!");
            }
        }
    }
}
