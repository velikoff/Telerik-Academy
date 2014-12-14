using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4.MaximalSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type the length of  array ");
            int ArrayLength = int.Parse(Console.ReadLine());
           
            int[] array = new int[ArrayLength];
            Console.WriteLine("Type the element of array");
            for (int i = 0; i < ArrayLength; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            //дефинираме променливите: start която ще приеме нова стойност
            //index  на първият елемент от последователно повтарящи се елемента минус length
            //length  ще се увеличава с единица с всеки следващ елемент който допълва повтарящата се послвдователност 
            //и други две променливи които ще пaзят настоящата най-дълга пследователност bestlength и
            //индекса на първият елемент от нея- bestStart 
            int start = 0, length = 1, bestStart = 0, bestLength = 1;
            //с for цикъл  достъпваме по индекс всеки следващ елемент
            for (int i = 1;  i<ArrayLength; i++)
            {
                //конструкцията if проверява дали елементите са равни 
                if (array[i] == array[i - 1])
                {
                   //ако са равни start приеме стойност която показва индекса на елемента от който започват 
                    //повторениеята в редицата изчислен от  : i - length.
                    start = i - length;
                    //а length се увеличава с единица при всяко следващо повторение за да пази стойността на настоящата 
                    //повтаряща се редица
                    length += 1;
                    // в условна конструкция проверяваме дали настоящата е по-дълга от предишната повтаряща се 
                    //последователност и ако е така я присвояваме на променливата която ще пази дължината на
                    //най-дългата такава последователност. 
                    // а bestStart ще стане равен на start
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
            //отпечатваме резултатът
            Console.WriteLine("The maximal sequence of equal elements is from element {0} to element {1}", bestStart, (bestStart + bestLength - 1));
            Console.WriteLine("The equal elements is " + array[bestStart]);
        }
    }
}
