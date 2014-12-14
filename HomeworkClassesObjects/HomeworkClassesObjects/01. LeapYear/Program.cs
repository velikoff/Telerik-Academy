using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.LeapYear
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter year: ");
            int year = int.Parse(Console.ReadLine());

            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine("The year {0} is Leap!", year);
            }
            else
            {
                Console.WriteLine("The year {0} is NOT Leap!", year);
            }
        }
    }
}
