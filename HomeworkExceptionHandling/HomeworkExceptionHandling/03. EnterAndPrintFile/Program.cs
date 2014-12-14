using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.EnterAndPrintFile
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("enter full path here: ");
            string path = Console.ReadLine();

            try
            {
                ReadFile(path);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        static void ReadFile(string path)
        {
            
            Console.WriteLine(path);
        }
    }
}
