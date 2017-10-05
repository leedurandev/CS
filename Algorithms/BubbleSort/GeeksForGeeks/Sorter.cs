using System;

namespace CS.Algorithms.BubbleSort.GeeksForGeeks
{
    /// <summary>
    /// Sorting algorithm that repeatedly swaps the adjacent elements 
    /// if they are in wrong order.
    /// 
    /// - Worst and Average Case Time Complexity: O(n*n). Worst case occurs when array is reverse sorted.
    /// - Best Case Time Complexity: O(n). Best case occurs when array is already sorted.
    /// - Auxiliary Space: O(1)
    /// - Boundary Cases: Bubble sort takes minimum time (Order of n) when elements are already sorted.
    /// - Sorting In Place: Yes
    /// - Stable: Yes
    /// </summary>
    internal class Sorter
    {
        public Sorter(int[] arr)
        {
            Arr = arr;
            Sort();
            Print();
        }

        public int[] Arr { get; set; }

        void Swap(ref int xp, ref int yp)
        {
            int temp = xp;
            xp = yp;
            yp = temp;
        }
 
        /// <summary>
        /// Implements bubble sort
        /// function always runs O(n^2) time even if the array is sorted. 
        /// It can be optimized by stopping the algorithm if inner loop didn’t cause any swap.
        /// </summary>
        public void Sort()
        {
            int i, j;
            bool swapped = false;
            for (i = 0; i < Arr.Length - 1; i++)
            {
                // last i elements are already in place   
                for (j = 0; j < Arr.Length - 1; j++)
                {
                    if (Arr[j] > Arr[j + 1])
                    {
                        Swap(ref Arr[j], ref Arr[j + 1]);
                        swapped = true;
                    }
                }

                // if no two elements were swapped by inner loop, then break
                if (swapped == false)
                    break;
            }
        }

        /* function to print an array */
        void Print()
        {
            int i;
            for (i = 0; i < Arr.Length; i++)
                Console.WriteLine(Arr[i]);
        }
    }
}
