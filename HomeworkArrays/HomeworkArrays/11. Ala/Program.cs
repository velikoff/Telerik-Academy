using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11.FindsTheIndexOfSortedArray
{
    class Program
    {
        static void Main()
        {
            //Въвеждаме сортиран масив
            int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            //Въвеждаме числото което търсим
            int searchedNumber = int.Parse(Console.ReadLine());
            //за да определим средата определяме търсенето да започва от: startSearch = 0
            int startSearch = 0;
            //за да определим средата определяме търсенето да завършва с : индексът на последният елемет от масива
            int endSearch = array.Length - 1;
            int middle;
            //цикъл while, който работи докато индексът за начало натърсената редица не надминава края на търсената редица
            while (startSearch <= endSearch)
            {
                // в цикъла първо се определям средата на редицата
                middle = (startSearch + endSearch) / 2;
                // ако средният елемент е равен на търсеното число отпечатваме неговият индекс
                if (array[middle] == searchedNumber)
                {
                    Console.WriteLine("Index is: {0}.", middle);
                    //break-ваме защото елементът който търсим е намерен
                    break;
                }
                //ако средният елемент е по-малък от елементът който търсим
                if (array[middle] < searchedNumber)
                {
                    // тогава стойността на елементът от който ще започва новата редица за търсене на елемента присвоява стойност = middle  + 1 
                    startSearch = middle + 1;
                }
                //ако средният елемент е по-голям от елементът който търсим 
                if (array[middle] > searchedNumber)
                {
                    // тогава стойността на елементът с който завършва новата редица за търсене не на елемента присвоява стойност = middle - 1
                    endSearch = middle - 1;
                }
            }
        }
    }
}
