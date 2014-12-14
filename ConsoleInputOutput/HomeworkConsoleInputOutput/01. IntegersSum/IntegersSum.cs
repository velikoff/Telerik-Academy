using System;
// Write a program that reads 3 integer numbers from the console and prints their sum.

class IntegersSum
{
    static void Main()
    {
        Console.WriteLine("Please enter three integer numbers");
        Console.Write("Enter the first number: ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter the third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("The sum of the three integer numbers is {0}", (firstNumber + secondNumber + thirdNumber));
    }
}

