
namespace CS.Services
{
    internal class Algorithm
    {
        public IRun BubbleSort { get; set; }
        public IRun BinarySearch { get; set; }

        public Algorithm()
        {
            BubbleSort = new Algorithms.Sorting.BubbleSort.Main();
            BinarySearch = new Algorithms.Graph.BinarySearch.Main();
        }
    }
}
