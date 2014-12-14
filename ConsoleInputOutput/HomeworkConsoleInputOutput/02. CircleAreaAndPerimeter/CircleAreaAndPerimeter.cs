using System;
// Write a program that reads the radius r of a circle and prints its perimeter and area.

class CircleAreaAndPerimeter
{
    static void Main()
    {
        Console.Write("Please enter circle's radius: ");
        double radius = double.Parse(Console.ReadLine());

        Console.WriteLine("The Area of the circle is {0} \nThe Perimeter of the circle is {1}", 
            Math.PI * radius * radius, 2 * Math.PI * radius);
    }
}

