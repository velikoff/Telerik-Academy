using System;

//Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum.

class CalculateSum
{
    static void Main()
    {
        int sum = 0;
      
        Console.Write("Please enter how many numbers you will enter: ");
        int length = int.Parse(Console.ReadLine());

        for (int i = 1; i < length + 1; i++)
        {
            Console.Write("Please enter number #{0}: ", i);
            int n = int.Parse(Console.ReadLine());
            sum += n;
        }
        Console.WriteLine("The sum of the numbers is: {0}", sum);
        
    }
}


