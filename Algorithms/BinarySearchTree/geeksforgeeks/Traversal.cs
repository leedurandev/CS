using System;

namespace CS.Algorithms.BinarySearchTree.geeksforgeeks
{
    internal static class Traversal
    {
        public static void InOrder(Node root)
        {
            if (root == null)
                return;

            InOrder(root.Left);
            Console.WriteLine(root.Key);
            InOrder(root.Right);
        }
    }
}
