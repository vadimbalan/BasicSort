using System;

namespace BasicSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Algorithms sort = new Algorithms();
            // You can change the size here: size, min, max
            int[] test = genArray(1000, 1, 5000);
            
            // Different sorting algorithms 
            // Comment two of the three out to test one of the sorting algorithms
            sort.bubblesSort(test);
            sort.insertionSort(test);
            sort.selectionSort(test);

            // Line the array up using ", " 
            string testString = string.Join(", ", test);
            // Print out the algorithm 
            Console.WriteLine(testString);
            Console.WriteLine("Inversions? " + Algorithms.hasInversions(test));
        }

        // Generates a random array with the size of the array, the min number to use in array
        // and max number to use in Array
        public static int[] genArray(int size, int min, int max)
        {
            Random rand = new Random();
            int[] array = new int[size];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = min + rand.Next(max - min + 1);
            }

            return array;
        }
    }
}
