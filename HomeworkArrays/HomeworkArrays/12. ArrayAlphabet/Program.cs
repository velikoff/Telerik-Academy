using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12.ArrayAlphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            //създаваме масив
            char[] array = new char[27];
            //въвеждаме променлива която ще ни помогне да изпишем азбуката, като я инициализираме с 65 от това, че А = 65
            int startOfArray = 65;
            //запълваме масива
            for (int i = 1; i < 27; i++)
            {
                array[i] = (char)startOfArray;
                startOfArray++;
            }

            Console.WriteLine("Please enter a word with capital letters:");
            //въвеждаме думата
            string enteredWord = Console.ReadLine().ToUpper();
            //отпечатваме индекса на всяка буква от думата
            foreach (char letter in enteredWord)
            {
                for (int i = 1; i < 27; i++)
                {
                    if (array[i] == letter)
                    {
                        Console.WriteLine("The index of the letter {0} is {1}", letter, i);
                        break;
                    }
                }
            }
        }
    }
}
