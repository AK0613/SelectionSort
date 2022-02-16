using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selection Sort: Sorts an array by repeatedly finding the minimum element and putting it at the beginning. ");
            int[] arr = { 50, 63, 183, 87, 90, 5, 15, 382};

            Console.Write("This is the unsorted array: ");
            print(arr);

            Console.WriteLine("\nNow sorted: ");
            int[] sortedArray = SelectionSort(arr);

            print(sortedArray);
        }

        public static int[] SelectionSort(int[] arr)
        {
            //Variable for the swap
            int temp;

            //Loops through the array
            for (int i = 0; i < arr.Length - 1 ; i++)
            {
                //Hold current minumum for each loop
                int min_index = i;
                //Compares current value with next one 
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min_index])
                        min_index = j;
                }

                //Swaps the smallest value with the first element of the unsorted array
                temp = arr[min_index];
                arr[min_index] = arr[i];
                arr[i] = temp;
            }
            return arr;
        }

        public static void print(int[] arr)
        {
            foreach (int x in arr)
                Console.Write(x + " ");
        }
    }
}
