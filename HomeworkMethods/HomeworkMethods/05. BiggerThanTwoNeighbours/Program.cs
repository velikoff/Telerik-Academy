using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.BiggerThanTwoNeighbours
{
    class Program
    {
        static int[] myArray = new int[20];

         static void Main()
        {
            GenerateRandomMatrix(); 
            PrintMatrix();
            Console.WriteLine();
            Console.Write("Choose position of the element: ");
            int index = int.Parse(Console.ReadLine());
            CheckNeighbours(index);
        }

         public static void CheckNeighbours(int index)
        {
            if (index >= myArray.Length || index <= 0)
            {
                Console.WriteLine("Wrong Position!");
            }
            else
            {
                if (index == myArray.Length - 1)
                {
                    Console.WriteLine("One Left Neighbour!");
                    CheckLefts(index);

                }
                else if (index == 0)
                {
                    Console.WriteLine("One Right Neighbour!");
                    CheckRights(index);
                }
                else
                {
                    Console.WriteLine("Two neighbours!");
                    CheckLefts(index);
                    CheckRights(index);
                }
            }
        }

         public static void CheckRights(int index)
        {
            if (myArray[index] > myArray[index + 1])
            {
                Console.WriteLine("The right neighbour {0} is smaller than {1}", myArray[index + 1], myArray[index]);
            }
            else if (myArray[index] < myArray[index + 1])
            {
                Console.WriteLine("The right neighbour {0} is bigger than {1}", myArray[index + 1], myArray[index]);
            }
            else
            {
                Console.WriteLine("The right neighbour {0} is equal {1}", myArray[index + 1], myArray[index]);
            }
        }

         public static void CheckLefts(int index)
        {
            if (myArray[index] > myArray[index - 1])
            {
                Console.WriteLine("The left neighbour {0} is smaller than {1}", myArray[index - 1], myArray[index]);
            }
            else if (myArray[index] < myArray[index - 1])
            {
                Console.WriteLine("The left neighbour {0} is bigger than {1}", myArray[index - 1], myArray[index]);
            }
            else
            {
                Console.WriteLine("The left neighbour {0} is equal {1}", myArray[index - 1], myArray[index]);
            }
        }

         public static void PrintMatrix()
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write("{0} ", myArray[i]);
            }
        }

         public static void GenerateRandomMatrix()
        {
            Random randomNumber = new Random();

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = randomNumber.Next(11); 
            }
        }
    }
}
