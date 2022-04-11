using BinarytreeLib;
using System;

namespace BSTreeTest
{
    class Program
    {
        static void Main (string[] args)
        {
            BST bstree = new BST();
            bstree.Clear();
            bstree.Add(5);
            bstree.Add(7);
            bstree.Add(2);
            bstree.Add(10);
            bstree.Add(21);
            bstree.Add(4);
            bstree.Add(9);
            bstree.Add(15);

            Console.WriteLine("Number of members = {0}",bstree.Count(bstree.Root));
            Console.WriteLine();
            InorderTraversal(bstree.Root)
        }
    }
}
