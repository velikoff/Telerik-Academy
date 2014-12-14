using System;
//Write a program that reads two positive integer numbers and prints how many numbers p exist between them
// such that the reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2.

class BetweenTwoNumbersDividedBy5
{
    static void Main()
    {
        Console.Write("Please enter the first integer number: ");
        int first = int.Parse(Console.ReadLine());
        Console.Write("Please enter the second integer number: ");
        int second = int.Parse(Console.ReadLine());
        int p = 0;

        for (int i = first; i <= second; i++)
        {
            if (i % 5 == 0)
            {
               p++;
            }
            
        }
       Console.WriteLine("There is {0} number(s) between {1} and {2} which is divided by 5 with reminder 0",
           p, first, second);
    }
}

