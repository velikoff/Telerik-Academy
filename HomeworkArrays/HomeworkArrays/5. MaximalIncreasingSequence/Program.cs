using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5.MaximalIncreasingSequence
{
    class MaximalIncreasingSequence
    {
        static void Main(string[] args)
        {
            //Write a program that finds the maximal increasing sequence in an array. Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.

            Console.WriteLine("Type the length of  array ");
            int ArrayLength = int.Parse(Console.ReadLine());

            int[] array = new int[ArrayLength];
            Console.WriteLine("Type the element of array");
            for (int i = 0; i < ArrayLength; i++)
            {
                array[i] = int.Parse(Console.ReadLine());

            }
            // въвеждаме четири помощни променливи  
            int start = 0, length = 1, bestStart = 0, bestLength = 1;

            //for цикъл върти елементите на масива чрез техните индекси
            for (int i = 1; i < ArrayLength; i++)
            {
                //условието при което ще се приема редицата за евнтуално 
                //решение на задачата е, ако настоящият елемент е с единица по-малък от следващият елемент
                if (array[i] == (array[i - 1] + 1))
                {
                    //ако условието е изпълнено за начало на редицата приемаме индекса на настоящият елемент минус дължината на 
                    // растящата редица (i- length), а стойността се присвоява на променливата start
                    start = i - length;
                    //дължината на редицата се записва в променливата length като за всеки следващ елемент от редицата добавя 
                    //единица към настоящата си стойност
                    length += 1;
                    //при условие че новата дължина на редицата е по-дълга от предната тя се присвоява на помощната променлива 
                    //bestLength, а bestStart присвоява стойността на start.
                    if (length > bestLength)
                    {
                        bestLength = length;
                        bestStart = start;
                    }
                }
                else
                {
                    start = 0;
                    length = 1;
                }

            }
            Console.WriteLine("The maximal increasing sequence elements is from array [{0}] to array [{1}]", bestStart, (bestStart + bestLength - 1));
            Console.WriteLine("The elements are from {0}, to {1}", array[bestStart], array[bestStart + bestLength - 1]);
      
        }
    }
}
