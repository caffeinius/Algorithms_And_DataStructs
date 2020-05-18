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
            dll.Push("Harry");
            dll.Push("Ron");
            dll.Push("Hermione");
            
            //Debug.WriteLine(dll.head.val);
            //dll.Shift();
            //Debug.WriteLine(dll.head.val);
            //dll.Unshift("Hagrid");
            //Debug.WriteLine(dll.head.val);


            Debug.WriteLine(dll.Remove(0).val);


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
