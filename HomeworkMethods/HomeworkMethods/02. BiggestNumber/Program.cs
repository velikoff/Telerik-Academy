using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.BiggestNumber
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the first number: ");
            int one = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int two = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number: ");
            int three = int.Parse(Console.ReadLine());
            int biggest = GetMax(one, two);
            biggest = GetMax(biggest, three);
            Console.WriteLine("The biggest number is {0}", biggest);    
        }
        static int GetMax(int first, int second)
        {
            int biggest = first;
            if (first < second)
            {
                biggest = second;
            }
            return biggest;


        }
    }
}
