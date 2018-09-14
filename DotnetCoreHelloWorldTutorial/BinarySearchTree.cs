using System;
using System.Collections.Generic;
using System.Text;

namespace DotnetCoreHelloWorldTutorial
{
    class BinarySearchTree
    {
        public Node Insert(Node root, int val)
        {
            if (root == null)
            {
                root = new Node(val);
            }
            else if (root.val > val)
            {
                root.left = Insert(root.left, val);
            }
            else if (root.val < val)
            {
                root.right = Insert(root.right, val);
            }
            return root;
        }

        public void TravelPre(Node root)
        {
            if (root == null)
            {
                return;
            }
            Console.WriteLine(root.val);
            TravelPre(root.left);
            TravelPre(root.right);
        }

        public void TravelIn(Node root)
        {
            if (root == null)
            {
                return;
            }
            TravelIn(root.left);
            Console.WriteLine(root.val);
            TravelIn(root.right);
        }

        public void TravelPost(Node root)
        {
            if (root == null)
            {
                return;
            }
            TravelPost(root.left);
            TravelPost(root.right);
            Console.WriteLine(root.val);
        }

        public bool isBST(Node root)
        {
            return isBSTUtil(root, int.MinValue, int.MaxValue);
        }

        bool isBSTUtil(Node root, int min, int max)
        {
            if (root == null)
            {
                return true;
            }
            if (root.val < min || root.val > max)
                return false;
            return (isBSTUtil(root.left, min, root.val - 1) && isBSTUtil(root.right, root.val + 1, max));
        }

        public void removeDuplicate(string str)
        {
            HashSet<char> hs = new HashSet<char>();
            for (int i = 0; i < str.Length; i++)
            {
                hs.Add(str[i]);
            }

            foreach (var item in hs)
            {
                Console.Write(item);
            }
        }
    }

    public class Node
    {
        public int val;
        public Node left;
        public Node right;
        public Node(int val)
        {
            this.val = val;
        }
    }
}
