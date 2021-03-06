﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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

        public void Reverse()
        {
            Node nextNode;
            Node prevNode = null;

            printNode(head, "current head");

            Node currentNode = head;
            this.head = this.tail;
            this.tail = currentNode;

            for (int i = 0; i < length; i++)
            {
                nextNode = currentNode.next;
                currentNode.next = prevNode;
                prevNode = currentNode;
                currentNode = nextNode;
            }
        }

        public void Remove(int index)
        {
            if (index < 0 || index > length) return;
            if (index == 0) Shift();
            if (index == length - 1) Pop();
            var prev = Get(index - 1);
            var removed = prev.next;
            prev.next = removed.next;
            length--;
        }

        public bool Insert(int index, string val)
        {
            if (index < 0 || index > length) return false;
            if (index == length)
            {
                Push(val);
                return true;
            }
            if (index == 0)
            {
                this.Unshift(val);
                return true;
            }

            var prev = this.Get(index - 1); //previous
            var newNode = new Node(val);
            newNode.next = prev.next;
            prev.next = newNode;
            length++;


            return true;
        }

        public Node Get(int index)
        {
            if (index < 0 | index > this.length) return null;
            var counter = 0;
            var current = this.head;
            while (counter != index)
            {
                current = current.next;
                counter++;
            }

            return current;
        }

        public bool Set(int index, string val)
        {
            var foundNode = Get(index);
            if (foundNode != null)
            {
                foundNode.val = val;
                return true;
            }

            return false;
        }

        public void Push(string val)
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

        public void Pop()
        {
            if (length < 1 || this.head == null) return;
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

            if (length != 0) return;
            this.head = null;
            this.tail = null;
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

        private void printNode(Node n, string nodeName)
        {
            Debug.WriteLineIf(string.IsNullOrEmpty(nodeName), $"{nodeName}::");
            Debug.WriteLine($"current val{n.val}");
            Debug.WriteLine($"next val{n.next.val}");
        }
    }
}
