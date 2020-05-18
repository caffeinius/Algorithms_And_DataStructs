using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_And_DataStructures
{
    public class Queue
    {
        public Node first;
        public Node last;
        public int size;

        public Queue()
        {
            size = 0;
        }

        public int Enqueue(string val)
        {
            var newNode = new Node(val);
            if (first is null)
            {
                first = newNode;
                last = newNode;
            }
            else
            {
                last.next = newNode;
                last = newNode;
            }

            Debug.WriteLine($"Size: {size}");
            return size++;
        }

        public string Dequeue()
        {
            if (first is null) return null;
            var temp = first;
            if (first == last)
            {
                last = null;
            }

            first = first.next;
            size--;

            Debug.WriteLine($"Value: {first.val}");
            return temp.val;
        }
    }
}
