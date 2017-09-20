
namespace CS.Algorithms.BinarySearchTree.geeksforgeeks
{
    internal class Node
    {
        public int Key { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node() { }
        public Node(int key)
        {
            Key = key;
        }
    
        public static Node Insert(Node node, int key)
        {
            if (node == null)
                return new Node(key);

            if (key < node.Key)
                node.Left = Insert(node.Left, key);

            if (key > node.Key)
                node.Right = Insert(node.Right, key);
               
            /* return the (unchanged) node */
            return node;
        }
    }
}
