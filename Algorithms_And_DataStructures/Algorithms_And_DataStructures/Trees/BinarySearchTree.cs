using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_And_DataStructures.Trees
{
    public class BinarySearchTree
    {
        public Node root;

        public BinarySearchTree()
        {
            root = null;
        }

        public bool Find(int val)
        {
            if (root == null) return false;
            var current = root;
            var found = false;

            while (!found && current != null)
            {
                if (val < (int)current.value)
                {
                    current = current.left;
                }
                else if (val > (int)current.value)
                {
                    current = current.right;
                }
                else
                {
                    found = true;
                }
            }

            return found;
        }

        public BinarySearchTree Insert(int val)
        {
            Node newNode = new Node(val);
            if (root == null)
            {
                root = newNode;
                return this;
            }
            else
            {
                var current = root;
                while (true)
                {
                    if (val == (int)current.value) return null;
                    if (val < (int)current.value)
                    {
                        if (current.left == null)
                        {
                            current.left = newNode;
                            return this;
                        }
                        else
                        {
                            current = current.left;
                        }
                    } else if (val > (int)current.value)
                    {
                        if (current.right == null)
                        {
                            current.right = newNode;
                            return this;
                        }
                        else
                        {
                            current = current.right;
                        }
                    }
                }
                return this;
            }

        }
    }
}
