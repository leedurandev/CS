
namespace CS.Algorithms.BinarySearchTree
{
    internal class BinarySearchTreeSrv
    {
        public IRun GeeksForGeeks { get; set; }

        public BinarySearchTreeSrv()
        {
            GeeksForGeeks = new GeeksForGeeks.Run();
        }
    }
}
