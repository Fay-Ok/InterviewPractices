using System;

namespace CreatingSimpleBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree(1);
            tree.root.left = new Node(2);
            tree.root.right = new Node(3);
            tree.root.left.left = new Node(4);

            Console.ReadLine();
        }
    }

    class Node
    {
        public int data;
        public Node right, left;
        public Node(int data)
        {
            this.data = data;
            right = left = null;
        }
    }

    class BinaryTree
    {
        public Node root;
        public BinaryTree(int key)
        {
            root = new Node(key);
        }

        public BinaryTree()
        {
            root = null;
        }
    }
}
