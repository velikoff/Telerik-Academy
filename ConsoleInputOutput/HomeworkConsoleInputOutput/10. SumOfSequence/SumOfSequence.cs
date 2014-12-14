using System;

// Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + .

class SumOfSequence
{
    static void Main()
    {
        double sum = 1d;
       
        for (int i = 2; i <= 1000; i++)
        {
            sum += (1d / i);
            i++;
            sum -= (1d / i);
        }
        Console.WriteLine(sum);
    }
}

