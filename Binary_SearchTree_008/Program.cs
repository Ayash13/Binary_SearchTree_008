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
            Search(element, ref parent, ref currentNode);
            if (currentNode == null) // check if current node to be inserted already or not
            {
                Console.WriteLine("Duplicate words not allowed");
                return;

            }
            else //if the spesified node is not present
            {
                tmp = new Node(element, null, null); //crrate a node
                if (parent == null) //if the tree is empty
                {
                    ROOT = tmp;
                }
                else if (string.Compare(element, parent.info) < 0)
                {
                    parent.lefchild = tmp;
                }
                else
                {
                    parent.rightchild = tmp;
                }
            }
        }
        public void search(string element, ref Node parent, ref Node currentNode)
        {
            //this function searches the currentNode of the specified Node as well as the current Node of its parent
            currentNode = ROOT;
            parent = null;
            while ((currentNode != null) && (currentNode.info != element))
            {
                parent = currentNode;
                if (string.Compare(element, currentNode.info) < 0)
                    currentNode = currentNode.lefchild;
                else
                    currentNode = currentNode.rightchild;
            }
        }
        
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
