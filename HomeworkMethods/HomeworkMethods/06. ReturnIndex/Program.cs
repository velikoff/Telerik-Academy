using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.NeighboursMethod
{
    class NeighboursMethod
    {
        static int[] myArray = new int[20];

        static void Main(string[] args)
        {
            GenerateRandomMatrix(); //generates random matrix
            PrintMatrix();
            Console.WriteLine();
            int hasNeighbours = -1;//by default there isn't bigger neighbours

            //we dont' check the first and last element because they don't have
            //left or right neighbours
            for (int i = 1; i < myArray.Length - 1; i++)
            {
                hasNeighbours = CheckNeighbours(i);
                if (hasNeighbours == 1)
                {
                    Console.WriteLine("The first element with two bigger neighbours is: {0} at position: {1}", myArray[i], i);
                    return;
                }
            }
            Console.WriteLine(hasNeighbours);
        }

        private static int CheckNeighbours(int index)
        {
            if (CheckLefts(index) && CheckRights(index))
            {
                return 1;
            }
            else
            {
                return -1;
            }

        }

        private static bool CheckRights(int index)
        {
            if (myArray[index] > myArray[index + 1])
            {
                return true;
            }

            return false;
        }

        private static bool CheckLefts(int index)
        {
            if (myArray[index] > myArray[index - 1])
            {
                return true;
            }

            return false;
        }

        private static void PrintMatrix()
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write("{0} ", myArray[i]);
            }
        }

        private static void GenerateRandomMatrix()
        {
            Random randomNumber = new Random();

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = randomNumber.Next(101); 
            }
        }
    }

}