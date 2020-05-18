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
            DoublyLinkedList dll = new DoublyLinkedList();
            dll.Push("hello");
            Debug.WriteLine(dll.head.val);
            Debug.WriteLine(dll.tail.val);
            dll.Push("good bye");
            Debug.WriteLine(dll.head.val);
            Debug.WriteLine(dll.tail.val);
            dll.Pop();
            //Debug.WriteLine(dll.Pop().val);


            //SinglyLinkedList ssl = new SinglyLinkedList();
            //ssl.Push("hello");
            //ssl.Push("staying");
            //ssl.Push("goodbye");
            //ssl.Insert(3, "Still here");
            //ssl.Traverse();

            //ssl.Reverse();
            //ssl.Traverse();


            Console.ReadKey();


        }

        static void printArray(int[] arr)
        {
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
