using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_And_DataStructures
{
    public class DoublyLinkedList
    {
        public int length;
        public Node head;
        public Node tail;

        public DoublyLinkedList()
        {
            head = null;
            tail = null;
            length = 0;
        }

        public Node Pop()
        {
            if (head == null) return null;
            var poppedNode = this.tail;
            if (length == 1)
            {
                head = null;
                tail = null;
            }
            else
            {
                tail = poppedNode.prev;
                tail.next = null;
                poppedNode.prev = null;
            }

            length--;
            return poppedNode;
        }

        public DoublyLinkedList Push(string val)
        {
            Node newNode = new Node(val);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.next = newNode;
                newNode.prev = this.tail;
                this.tail = newNode;
            }

            length++;
            return this;
        }

        //private void printNode(Node n, string nodeName = null)
        //{
        //    Debug.WriteLineIf(string.IsNullOrEmpty(nodeName), $"{nodeName}::");
        //    Debug.WriteLineIf(n.prev != null, $"prev val: {n.prev.val}");
        //    Debug.WriteLine($"current val: {n.val}");
        //    Debug.WriteLineIf(n.next != null, $"next val: {n.next.val}");
        //}
    }
}
