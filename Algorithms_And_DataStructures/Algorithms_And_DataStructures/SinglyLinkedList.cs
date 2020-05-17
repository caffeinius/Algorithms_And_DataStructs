using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_And_DataStructures
{
    public class SinglyLinkedList
    {
        public int length;
        public Node head;
        public Node tail;

        //piece of data - val
        //reference to next node - next

        public SinglyLinkedList()
        {
            this.length = 0;
            this.head = null;
            this.tail = null;
        }

        public SinglyLinkedList Push(string val)
        {
            var node = new Node(val);
            if (head == null)
            {
                head = node;
                this.tail = head;
            }
            else
            {
                tail.next = node;
                tail = node;
            }

            length++;

            return this;
        }

        //mainly an example 
        public void Traverse()
        {
            var current = this.head;
            while (current != null)
            {
                Debug.WriteLine($"{current.val} of {this.length}");
                current = current.next;
            }
        }

        public SinglyLinkedList Pop()
        {
            if (length < 1 || this.head == null) return null;
            Node currentNode = this.head;
            Node newTail = currentNode;

            while (currentNode.next != null)
            {
                newTail = currentNode;
                currentNode = currentNode.next;
            }

            this.tail = newTail;
            this.tail.next = null;
            length--;

            if (length != 0) return this;
            this.head = null;
            this.tail = null;

            return this;
        }

        public void Shift()
        {
            if (head == null) return;
            var currentHead = head;
            this.head = currentHead.next;
            length--;
        }

        public void Unshift(string val)
        {
            var newNode = new Node(val);
            if (head == null)
            {
                this.head = newNode;
                this.tail = this.head;
            }
            else
            {
                newNode.next = this.head;
                this.head = newNode;
            }
            length++;
        }
    }
}
