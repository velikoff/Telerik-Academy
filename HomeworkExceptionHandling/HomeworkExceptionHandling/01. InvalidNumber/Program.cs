using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.InvalidNumber
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter Number: ");
            string s = Console.ReadLine();
            try
            {
                uint num = uint.Parse(s);
                Console.WriteLine("Its square root is " + Math.Sqrt(num));
            }
            catch (SystemException se)
            {
                Console.WriteLine("Invalid Number/ " + se.Message);
                Main();//try again
            }
           
        }
    }
}

