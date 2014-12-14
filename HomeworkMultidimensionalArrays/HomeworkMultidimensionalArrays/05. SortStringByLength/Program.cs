using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.SortStringByLength
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "mmmmm", "mm", "mmmm", "mmmmmm", "0" };

            /*
            var sorted = array.OrderBy(x => x.Length);
            foreach (var element in sorted)
            {
                Console.WriteLine(element);
            }
            */

            Array.Sort(array, (x, y) => (x.Length).CompareTo(y.Length));
            foreach (string element in array)
            {
                Console.WriteLine(element);
            }
        }
    }
}
