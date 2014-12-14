using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.SurfaceOfTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select metod for calculate the surface of a triangle");
            Console.WriteLine("(1-side and an altitude to it/2-three sides/3-two sides and an angle between them)");
            sbyte select = sbyte.Parse(Console.ReadLine());
            if (select == 1)
            {
                Console.WriteLine("Enter side (in mm)");
                decimal side = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Enter altitude(in mm)");
                decimal altitude = decimal.Parse(Console.ReadLine());
                decimal surface = SideAltitude(side, altitude);
                Console.WriteLine("The surface is: {0:0.00} in mm", surface);
            }
            if (select == 2)
            {
                Console.WriteLine("Enter side A(in mm)");
                double sideA = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter side B(in mm)");
                double sideB = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter side C(in mm)");
                double sideC = double.Parse(Console.ReadLine()); ;
                double surface = ThreeSides(sideA, sideB, sideC);
                Console.WriteLine("The surface is: {0:0.00} in mm", surface);
            }
            if (select == 3)
            {
                Console.WriteLine("Enter side A(in mm)");
                decimal sideA = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Enter side B(in mm)");
                decimal sideB = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Enter angle(in mm)");
                decimal angle = decimal.Parse(Console.ReadLine());
                decimal surface = TwoSideAngle(sideA, sideB, angle);
                Console.WriteLine("The surface is: {0:0.00} in mm", surface);
            }
            else
            {
                Console.WriteLine("Your choice is not correct");
            }
        }

        static double ThreeSides(double sideA, double sideB, double sideC)
        {
            double perimetar = ((sideA + sideB + sideC) / 2);
            double surface = Math.Sqrt((perimetar * (perimetar - sideA) * (perimetar - sideB) * (perimetar - sideC)));
            return surface;
        }

        static decimal TwoSideAngle(decimal sideA, decimal sideB, decimal angle)
        {
            decimal surface = (sideA * sideB * (Math.Sign(angle))) / 2;
            return surface;
        }

        static decimal SideAltitude(decimal side, decimal altitude)
        {
            decimal surface = (side * altitude) / 2;
            return surface;
        }
    }
}
