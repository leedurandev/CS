using CS.Algorithms.BubbleSort;
using CS.Algorithms.BinarySearchTree;

namespace CS.Algorithms
{
    internal class AlgorithmsSrv
    {
        public BubbleSortSrv BubbleSort { get; set; }
        public BinarySearchTreeSrv BinarySearchTree { get; set; }

        public AlgorithmsSrv()
        {
            BubbleSort = new BubbleSortSrv();
            BinarySearchTree = new BinarySearchTreeSrv();
        }
    }
}
