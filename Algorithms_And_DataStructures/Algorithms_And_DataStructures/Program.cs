using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms_And_DataStructures.Trees;

namespace Algorithms_And_DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            var bst = new BinarySearchTree();
            Console.WriteLine($"root:{bst.Insert(10).root.value}");
            bst.Insert(5);
            bst.Insert(13);
            bst.Insert(11);
            bst.Insert(2);
            //Console.WriteLine($"left:{bst.root.left.value}");
            //Console.WriteLine($"right:{bst.root.right.value}");

            //Console.WriteLine($"left:{bst.Insert(10).root.left.value}");
            //Console.WriteLine($"right:{bst.Insert(10).root.right.value}");

            Console.ReadKey();


        }

        static void printArray(int[] arr)
        {
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
