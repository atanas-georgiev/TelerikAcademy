using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem06BinarySearchTree
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            // create new tree
            BinarySearchTree<int> tree = new BinarySearchTree<int>();
            tree.Insert(5);
            tree.Insert(-1);
            tree.Insert(533);
            tree.Insert(-125);

            Console.WriteLine("tree = ");
            Console.WriteLine(tree);

            // create new tree as clone
            Console.WriteLine("tree2 = ");
            BinarySearchTree<int> tree2 = (BinarySearchTree<int>)tree.Clone();
            Console.WriteLine(tree2);

            Console.WriteLine("tree == tree2 ? " + (tree == tree2));

            // add element in tree
            tree.Insert(0);
            Console.WriteLine("tree = ");
            Console.WriteLine(tree);
            Console.WriteLine("tree2 = ");
            Console.WriteLine(tree2);            
            Console.WriteLine("tree == tree2 ? " + (tree == tree2));

            // foreach elements
            Console.WriteLine("Foreach elements in tree");
            foreach (var item in tree)
            {
                Console.WriteLine(item);
            }
        }
    }
}
