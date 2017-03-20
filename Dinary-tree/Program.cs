using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinary_tree
{
    class Program
    {
        class BinaryTreeNode
        {
            public int val;
            public BinaryTreeNode left;
            public BinaryTreeNode right;

            public BinaryTreeNode()
            {
                val = 0;
                left = null;
                right = null;
            }

            public BinaryTreeNode(int _val)
            {
                val = _val;
                left = null;
                right = null;
            }
        }

        class BinaryTree
        {
            BinaryTreeNode root;

            public void Insert(BinaryTreeNode parent, BinaryTreeNode left, BinaryTreeNode right)
            {
                parent.left = left;
                parent.right = right;

            }

            void TravelsByPre(BinaryTreeNode _root)
            {
                Console.Write(_root.val + " ");
                if (_root.left != null)
                    TravelsByPre(_root.left);
                if (_root.right != null)
                    TravelsByPre(_root.right);
            }

            public void TravelsByPre()
            {
                TravelsByPre(root);
            }

            void TravelsByIn(BinaryTreeNode _root)
            {
                if (_root.left != null)
                    TravelsByIn(_root.left);

                Console.Write(_root.val + " ");

                if (_root.right != null)
                    TravelsByIn(_root.right);
            }

            public void TravelsByIn()
            {
                TravelsByIn(root);
            }

            void TravelsByPost(BinaryTreeNode _root)
            {
                if (_root.left != null)
                    TravelsByPost(_root.left);

                if (_root.right != null)
                    TravelsByPost(_root.right);

                Console.Write(_root.val + " ");

            }


            public void TravelsByPost()
            {
                TravelsByPost(root);
            }

            public void SetRoot(BinaryTreeNode rootNode)
            {
                root = rootNode;
            }

        }


        static void Main(string[] args)
        {
            // travels binary tree
            BinaryTreeNode tmpNode1 = new BinaryTreeNode(1);
            BinaryTreeNode tmpNode2 = new BinaryTreeNode(2);
            BinaryTreeNode tmpNode3 = new BinaryTreeNode(3);
            BinaryTreeNode tmpNode4 = new BinaryTreeNode(4);
            BinaryTreeNode tmpNode5 = new BinaryTreeNode(5);
            BinaryTreeNode tmpNode6 = new BinaryTreeNode(6);
            BinaryTreeNode tmpNode7 = new BinaryTreeNode(7);

            BinaryTree bTree = new BinaryTree();

            bTree.SetRoot(tmpNode1);
            bTree.Insert(tmpNode1, tmpNode2, tmpNode3);
            bTree.Insert(tmpNode2, tmpNode4, tmpNode5);
            bTree.Insert(tmpNode3, tmpNode6, tmpNode7);

            bTree.TravelsByPre();
            Console.WriteLine();

            bTree.TravelsByIn();
            Console.WriteLine();

            bTree.TravelsByPost();
            Console.WriteLine();
        }
    }
}
