using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_And_DataStructures
{
    public class Stack
    {
        public Node first;
        public Node last;
        public int size;

        public Stack()
        {
            size = 0;
        }

        public int Push(string val)
        {
            var newNode = new Node(val);
            if (first == null)
            {
                first = newNode;
                last = first;
            }
            else
            {
                var temp = first;
                first = newNode;
                first.next = temp;
            }

            size++;
            Debug.WriteLine($"Size: {size}");
            return size;
        }

        public string Pop()
        {
            if (first == null) return null;
            var temp = first;
            if (this.first == this.last)
                this.last = null;

            first = this.first.next;
            size--;

            Debug.WriteLine($"Value: {first.val}");
            return temp.val;
        }
    }
}
