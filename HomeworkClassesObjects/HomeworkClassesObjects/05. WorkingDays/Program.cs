using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.WorkingDays
{
    class Program
    {
        static void Main(string[] args)
        {
            var holidays = new List<DateTime>();

            holidays.Add(new DateTime(2013, 01, 30));
            holidays.Add(new DateTime(2013, 01, 31));
            holidays.Add(new DateTime(2013, 02, 05));
            holidays.Add(new DateTime(2013, 02, 07));

            DateTime now = DateTime.Today;
            Console.Write("Enter final date<YYYY-MM-DD>: ");
            DateTime final = DateTime.Parse(Console.ReadLine());
            CheckWorkingDates(now, final, holidays);

        }



        private static void CheckWorkingDates(DateTime now, DateTime final, List<DateTime> holidays)
        {
            //got the length between without weekends or holidays
            int lengthDays = (final - now).Days;
            int length = lengthDays;
            DateTime currentDate = new DateTime();
            //check which dates of the period are weekends or holidays 
            //and the crease the length
            //we pass through the whole period
            for (int i = 0; i <= length; i++)
            {
                //increase date
                currentDate = now.AddDays(i);
                //we compare the currentDate with every single holiday
                for (int days = 0; days < holidays.Count; days++)
                {
                    int comparison = currentDate.CompareTo(holidays[days]); //if match return 0
                    if (comparison == 0)
                    {
                        //decrease the length ot period
                        lengthDays--;
                    }
                }
                //check is the current day in weekend
                if (currentDate.DayOfWeek == DayOfWeek.Saturday || currentDate.DayOfWeek == DayOfWeek.Sunday)
                {
                    //decrease the length ot period
                    lengthDays--;
                }
            }

            PrintResult(now, final, lengthDays);

        }

        private static void PrintResult(DateTime now, DateTime final, int lengthDays)
        {
            Console.WriteLine("Today is: {0:D}", now);
            Console.WriteLine("Final Date is: {0:D}", final);
            Console.WriteLine();
            Console.WriteLine("Working days: {0}\n", lengthDays);
        }

    }
}
