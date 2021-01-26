using System;
using System.Collections.Generic;
using System.Text;

namespace BasicSort
{
    class Algorithms
    {
        /*
        * @param array This is the bubbleSort algorithm that compares adjacent
        * elements and swaps if they are in the wrong order and takes a random generated array
        */
        public void bubblesSort(int[] array)
        {
            int size = array.Length;

            for (int i = 0; i < size - 1; i++)
            {
                for (int x = 0; x < size - i - 1; x++)
                {
                    if (array[x] > array[x + 1])
                    {
                        int temp = array[x];
                        array[x] = array[x + 1];
                        array[x + 1] = temp;
                    }
                }
            }
        }

        /**
        * @param array takes in a random generated array and sorts based on the selectionSort algorithm
        */
        public void selectionSort(int[] array)
        {
            int size = array.Length;
            for (int i = 0; i < size - 1; i++)
            {
                int min = i;

                for (int x = i + 1; x < size; x++)
                {
                    if (array[x] < array[min])
                    {
                        min = x;
                    }
                }
                int temp = array[min];
                array[min] = array[i];
                array[i] = temp;
            }
        }

        /**
        * @param array Takes a random generated array and sorts based on the insertionSort algorithm
        */
        public void insertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                for (int x = i; x >= 1; x--)
                {
                    if (array[x] < array[x - 1])
                    {
                        swap(array, x, x - 1);
                    }
                    else
                    {
                        break;
                    }
                }

            }
        }

        /**
        * @param array Takes in a random generated array
        * @return returns if the array has inversions
        */
        public static bool hasInversions(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    return true;
                }
            }
            return false;
        }

        /**
        * @param array Takes in a random generated array
        * @param first is the first number that needs to be swapped with the second number
        * @param second this is the second number
        */
        public static void swap(int[] array, int first, int second)
        {
            int temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }

    }
}
