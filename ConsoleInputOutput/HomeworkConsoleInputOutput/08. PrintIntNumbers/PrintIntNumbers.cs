using System;

// Write a program that reads an integer number n from the console and prints 
// all the numbers in the interval [1..n], each on a single line.

class PrintIntNumbers
{
    static void Main()
    {
        Console.Write("Please enter an integer number: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("The numbers between 1 and {0}:", n);

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}

