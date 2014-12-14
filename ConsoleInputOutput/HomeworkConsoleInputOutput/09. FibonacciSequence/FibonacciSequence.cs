﻿using System;

//Write a program to print the first 100 members of the sequence of Fibonacci: 
// 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 

class FibonacciSequence
{
    static void Main()
    {
        decimal firstNumber = 0m;
        decimal secondNumber = 1m;
        decimal sum;

        for (int i = 0; i <= 99; i++)
        {
            Console.WriteLine(i + 1 + ": " +firstNumber);
            sum = firstNumber + secondNumber;
            firstNumber = secondNumber;
            secondNumber = sum;
        }
    }
}

