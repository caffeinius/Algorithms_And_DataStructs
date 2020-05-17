using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_And_DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
           SinglyLinkedList ssl = new SinglyLinkedList();
           ssl.Push("hello");
           ssl.Push("staying");
           ssl.Push("goodbye");
           ssl.Traverse();

           ssl.Set(1, "Still here");
           ssl.Traverse();


            Console.ReadKey();
        }

        static void printArray(int[] arr)
        {
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
