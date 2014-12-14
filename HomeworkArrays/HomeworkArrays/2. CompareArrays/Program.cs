using System;


namespace _2.CompareArrays
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Type the length of the first array ");
            int firstArrayLength = int.Parse(Console.ReadLine());
            Console.WriteLine("Type the length of the second array ");
            int secongArrayLength = int.Parse(Console.ReadLine());

            int[] firstArray = new int[firstArrayLength];
            int[] secondArray = new int[secongArrayLength];

            Console.WriteLine("Type the element of the first array");
            for (int i = 0; i < firstArrayLength; i++)
            {
                firstArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Type the element of second array");
            for (int j = 0; j < secongArrayLength; j++)
            {
                secondArray[j] = int.Parse(Console.ReadLine());
            }
            if (firstArrayLength != secongArrayLength)
            {
                Console.WriteLine("Arrays are not the same length!");
            }
            else
            {

                for (int i = 0; i < firstArrayLength; i++)
                {

                    if (firstArray[i] != secondArray[i])
                    {
                        Console.WriteLine("Arrays are not the same!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Arrays are  the same!");
                        break;
                    }
                }
            }
        }
    }
}
