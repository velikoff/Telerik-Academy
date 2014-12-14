using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.RandomGenerate
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNumber = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}", randomNumber.Next(100, 201));
            }
        }
    }
}
