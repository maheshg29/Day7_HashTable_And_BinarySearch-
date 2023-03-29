using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day7_HashTable_And_BinarySearch
{
    public class BSTNode
    {
        public int value;
        public BSTNode left, right;

        public BSTNode(int val)
        {
            value = val;
            left = null;
            right = null;
        }
    }
}
