using System;
// Write a program that reads the coefficients a, b and c of a quadratic equation ax2+bx+c=0 and solves it 
// (prints its real roots).


class QuadraticEquation
{
    static void Main()
    {
        Console.Write("Please enter the value of coefficient a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please enter the value of coefficient b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Please enter the value of coefficient c: ");
        double c = double.Parse(Console.ReadLine());

        // Calculate the discriminant
        double discriminant = b * b - 4 * a * c;
        double discriminantRoot = Math.Sqrt(discriminant);

        if (discriminant < 0)
        {
            Console.WriteLine("Discriminant < 0 and there are no real roots");
        }
        else if (discriminant == 0)
        {
            // the equation have only one root
            double x1 = (-b) / (2 * a);
            Console.WriteLine("The Equation have only one root x = {0}", x1);
        }
        else
        {
            // the equation have two real root
            double x2 = (-b + discriminantRoot) / (2 * a);
            double x3 = (-b - discriminantRoot) / (2 * a);
            Console.WriteLine("The Equation have two real roots x1 = {0} and x2 = {1}", x2, x3);
        }
    }
}

