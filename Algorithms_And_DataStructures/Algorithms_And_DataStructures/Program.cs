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
            //Stack stack = new Stack();
            //stack.Push("first");
            //stack.Push("second");
            //stack.Push("third");
            //stack.Pop();
            //stack.Pop();

            Queue q = new Queue();
            q.Enqueue("first");
            q.Enqueue("second");
            q.Enqueue("third");
            q.Dequeue();
            q.Dequeue();
            q.Dequeue();

            Console.ReadKey();


        }

        static void printArray(int[] arr)
        {
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
