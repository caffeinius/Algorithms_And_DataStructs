using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_And_DataStructures
{
    public class Node
    {
        public string val;
        public Node next;
        public Node prev;

        public Node(string val)
        {
            this.val = val;
            this.next = null;
            this.prev = null;
        }
    }
}
