using System;

namespace FindMinValueInBST
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            Node root = null;
            root = tree.Insert(root, 4);
            tree.Insert(root, 2);
            tree.Insert(root, 0);
            tree.Insert(root, 3);
            tree.Insert(root, 6);
            tree.Insert(root, 5);

            Console.WriteLine("Minimum value of BST is " + tree.FindMinValue(root));
            Console.ReadLine();
        }
    }

    class Node
    {
        public Node left, right;
        public int key;
        public Node(int data)
        {
            this.key = data;
            right = left = null;
        }
    }

    class BinaryTree
    {
        public Node root;
        
        public Node Insert(Node node, int key)
        {

            if (node == null)
            {
                return new Node(key);
            }
            else
            {
                if (key <= node.key)
                {
                    node.left = Insert(node.left, key);
                }
                else
                {
                    node.right = Insert(node.right, key);
                }
            }
            return node;
        }

        public int FindMinValue(Node node)
        {
            if (node == null)
            {
                return 0;
            }

            Node current = node;

            while (current.left != null)
            {
                current = current.left;

            }
            return current.key;
        }
    }
}
