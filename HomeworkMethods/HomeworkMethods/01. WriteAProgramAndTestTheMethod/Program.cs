using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.WriteAProgramAndTestTheMethod
{
    public class Hello
    {
        public static string Name(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
            return name;
        }
        public static void Main()
        {
            Console.WriteLine("What is your name ?");
            Name(Console.ReadLine());
        }
    }
}

    

