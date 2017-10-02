
namespace CS.Algorithms.BubbleSort
{
    internal class BubbleSortSrv
    {
        public IRun GeeksForGeeks { get; set; }

        public BubbleSortSrv()
        {
            GeeksForGeeks = new GeeksForGeeks.Run();
        }
    }
}
