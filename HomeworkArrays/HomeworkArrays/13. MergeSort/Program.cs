using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _13.MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initial unsorted array
            int[] array = { 2, -4, 5, 2, -10, 3, 1, 0, 13, 15, 9, 8, 4 };
            //Help array
            int[] tempArray = new int[array.Length];

            //a variable to hold the array lenght
            int arraySize = array.Length;
            //a variable to hold the lenght of the subarrays to be sorted at any given moment, at the beginning it is one, as we compere arrays of one element each
            int currentLength = 1;
            //current position, we start at the beginning, index 0
            int currentPosition = 0;
            //two counters which determine how many elements have been sorted from the left array or the right array
            int left = 0;
            int right = 0;

            //main sorting algorithm, it will continue until the lenght of the subarrays is smaller to or equal the size of the initial array
            while (currentLength <= arraySize)
            {
                //A loop that go over the elements of the initial array. The step, at which i increases depends on the variable currentLenght, so at the first cycle of the while loop we compare adjacent elements, then the first elements of adjacent pairs, then the first elements of adjacent quadruplets etc.
                for (int i = 0; i < arraySize; i = i + currentLength * 2)
                {
                    while (currentPosition < arraySize)
                    {
                        //compare the first element of the subarrays if:
                        //1) there are elements left in the left arrays
                        //2) there are elements left in the right arrays
                        //3) the position of the element to be compared in the right array is not outside of the initial array (in case of hanging elements, when the size of the initial array is not a power of 2
                        if (left < currentLength && right < currentLength && i + right + currentLength < arraySize)
                        {
                            //i+left is the index of the first element of the left array, depending on the i and the counter left
                            //i+right+currentLenght is the index of the first element of the right array
                            //this if condition compares the first elements of the left and right arrays. Whichever element is slower is added as the next in line to the help array and the counter of the respective subarray (left or right) is increased by 1
                            if (array[i + left] <= array[i + right + currentLength])
                            {
                                tempArray[currentPosition] = array[i + left];
                                left++;
                            }
                            else
                            {
                                tempArray[currentPosition] = array[i + right + currentLength];
                                right++;
                            }
                        }
                        //in case conditions 2) or 3) are not fulfilled, we'll have a residual element in the left array, which will be added to the temp array
                        else if (left < currentLength)
                        {
                            tempArray[currentPosition] = array[i + left];
                            left++;
                        }
                        //in case conditions 1) or 3) are not fulfilled, we'll have a residual element in the right array, which will be added to the temp array
                        else if (right < currentLength)
                        {
                            tempArray[currentPosition] = array[i + right + currentLength];
                            right++;
                        }
                        //if none of the conditions is fulfilled, there are no elements to be compered in eighter of the two subarrays and the next cycle of the outer while loop must be executed
                        else
                        {
                            break;
                        }
                        currentPosition++;
                    }
                    //reset left and right counter for the next cycle of the outer while loop
                    right = 0;
                    left = 0;
                }
                //double the current lenght to go from single, to pair, to quadruplet etc.
                currentLength = currentLength * 2;
                //reset current position
                currentPosition = 0;
                //fill the temp array with the elements sorted so far, at each cycle of the outer while loop the elements get more and more sorted
                for (int i = 0; i < arraySize; i++)
                {
                    array[i] = tempArray[i];
                }
            }

            //when the condition of the while loop becomes false, than all elements are sorted and we only need to print them to the console
            for (int i = 0; i < arraySize; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
