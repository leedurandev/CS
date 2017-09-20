using CS.Algorithms.BinarySearchTree;

namespace CS.Algorithms
{
    internal class AlgorithmsSrv
    {
        public BinarySearchTreeSrv BinarySearchTree { get; set; }

        public AlgorithmsSrv()
        {
            BinarySearchTree = new BinarySearchTreeSrv();
        }
    }
}
