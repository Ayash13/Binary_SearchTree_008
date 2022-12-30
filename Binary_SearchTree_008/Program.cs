using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_SearchTree_008
{

    class Node
    {
        public string info;
        public Node lefchild;
        public Node rightchild;

        // constructor for the node class
        public Node(string i, Node l, Node r)
        {
            info = i;
            lefchild = l;
            rightchild = r;
        }
    }

    // A node class consist as tree things, the information, the reference to the right child, and reference to the left child
    class BinaryTree
    {
        public Node ROOT;
        public BinaryTree()
        {
            ROOT = null; //Initializing ROOT to null

        }
        public void insert(string element) //insert a node in the binary search tree
        {
            Node tmp, parent = null, currentNode = null;
            
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
