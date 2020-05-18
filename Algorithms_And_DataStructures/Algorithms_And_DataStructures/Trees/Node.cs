using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_And_DataStructures.Trees
{
    public class Node
    {
        public object value;
        public Node left;
        public Node right;

        public Node(string val)
        {
            value = val;
        }

        public Node(int val)
        {
            value = val;
        }
    }
}
