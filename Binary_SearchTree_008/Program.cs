﻿using System;
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


    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
