using System;
using System.Collections.Generic;

namespace _589_NTreePreorderTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        // iterative
        static IList<int> Preorder(Node root)
        {
            List<int> result = new List<int>();
            if (root == null) return result;

            Stack<Node> stack = new Stack<Node>();
            stack.Push(root);

            while (stack.Count > 0)
            {
                Node current = stack.Pop();
                result.Add(current.val);

                for (int i = current.children.Count - 1; i >= 0; i--)
                {
                    stack.Push(current.children[i]);
                }
            }

            return result;
        }

        // recursive
        static IList<int> PreorderRecursive(Node root)
        {
            IList<int> result = new List<int>();

            if (root == null) return result;

            result.Add(root.val);

            foreach (Node node in root.children)
            {
                PreorderRecursive(node);
            }

            return result;
        }
    }

    public class Node
    {
        public int val;
        public IList<Node> children;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, IList<Node> _children)
        {
            val = _val;
            children = _children;
        }
    }
}

