using System;
// Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.

class GreaterNumber
{
    static void Main()
    {
        Console.Write("Please enter the first number: ");
        string firstStr = Console.ReadLine();
        int first = int.Parse(firstStr);
        Console.Write("Please enter the second number: ");
        string secondStr = Console.ReadLine();
        int second = int.Parse(secondStr);

        int maxNumber = first - ((first - second) & ((first - second) >> 31));
        Console.WriteLine("Greater number is: " + maxNumber);
    }
}

