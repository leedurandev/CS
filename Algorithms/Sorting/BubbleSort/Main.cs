
namespace CS.Algorithms.Sorting.BubbleSort
{
    internal class Main : IRun
    {
        void IRun.Run()
        {
            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
            var sorter = new Sorter(arr);
        }
    }
}
