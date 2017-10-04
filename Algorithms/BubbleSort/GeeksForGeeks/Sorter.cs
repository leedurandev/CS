using System;

namespace CS.Algorithms.BubbleSort.GeeksForGeeks
{
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

        // A function to implement bubble sort
        public void Sort()
        {
            int i, j;
            for (i = 0; i < Arr.Length - 1; i++)

                // Last i elements are already in place   
                for (j = 0; j < Arr.Length - 1; j++)
                    if (Arr[j] > Arr[j + 1])
                        Swap(ref Arr[j], ref Arr[j + 1]);
        }

        /* Function to print an array */
        void Print()
        {
            int i;
            for (i = 0; i < Arr.Length; i++)
                Console.WriteLine(Arr[i]);
        }
    }
}
