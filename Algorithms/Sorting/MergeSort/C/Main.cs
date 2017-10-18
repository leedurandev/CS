using System;

namespace CS.Algorithms.Sorting.MergeSort.C
{
    internal class Main : IRun
    {
        public void Run()
        {
            var sorter = new Sorter();

            int[] arr = { 12, 11, 13, 5, 6, 7 };

            Console.WriteLine("Given array is \n");
            sorter.printArray(arr, arr.Length);

            sorter.mergeSort(arr, 0, arr.Length - 1);

            Console.WriteLine("\nSorted array is \n");
            sorter.printArray(arr, arr.Length);
        }
    }
}
