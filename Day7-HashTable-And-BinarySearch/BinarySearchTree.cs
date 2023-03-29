using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day7_HashTable_And_BinarySearch
{
    public class BinarySearchTree
    {
        public BSTNode root;

        public BinarySearchTree()
        {
            root = null;
        }

        public void Insert(int val)
        {
            BSTNode newNode = new BSTNode(val);

            if (root == null)
            {
                root = newNode;
                return;
            }

            BSTNode currNode = root;

            while (true)
            {
                if (val < currNode.value)
                {
                    if (currNode.left == null)
                    {
                        currNode.left = newNode;
                        return;
                    }
                    else
                    {
                        currNode = currNode.left;
                    }
                }
                else if (val > currNode.value)
                {
                    if (currNode.right == null)
                    {
                        currNode.right = newNode;
                        return;
                    }
                    else
                    {
                        currNode = currNode.right;
                    }
                }
                else
                {
                    return;
                }
            }
        }
    }  
}
