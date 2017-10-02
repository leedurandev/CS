
namespace CS.Algorithms.BinarySearchTree.GeeksForGeeks
{
    internal class Run : IRun
    {
        void IRun.Run()
        {
            var root = new Node(50);

            Node.Insert(root, 30);
            Node.Insert(root, 20);
            Node.Insert(root, 40);
            Node.Insert(root, 75);
            Node.Insert(root, 70);
            Node.Insert(root, 60);
            Node.Insert(root, 80);

            // print inorder traversal of the binary search tree
            Traversal.InOrder(root);
        }
    }
}
