using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.PrintDay
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            Console.WriteLine("Today is {0}", today.DayOfWeek);
        }
    }
}
