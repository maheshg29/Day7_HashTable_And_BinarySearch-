using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day7_HashTable_And_BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Day 7 HashTable and Binary Search Practice Problem");
            Console.WriteLine("Select one Option for \n 1. Find frequency of words in a sentence" +
                "\n 2. Find frequency of words in paragraph \n 3. Remove Given Word \n 4. Insert Data in BST" +
                "\n 5. Create New data Binary Tree ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    //HashTableOperations findFrequencyOfWord=new HashTableOperations();
                    //findFrequencyOfWord.FrequencyOfWord("To be or not to be");
                    HashTableUsingLinkList.FreqOfWord("To be or not to be");
                    break;

                case 2:
                    HashTableUsingLinkList.FreqOfWord("Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations");
                    break;

                case 3:
                    string inputString = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
                    LinkedList<MyMapNode<string, int>>[] hashtable = HashTableUsingLinkList.FreqOfWord(inputString);
                    HashTableUsingLinkList.RemoveWord("avoidable", hashtable);
                    break;

                case 4:
                    BinarySearchTree binarySearchTree = new BinarySearchTree();
                    binarySearchTree.Insert(56);
                    binarySearchTree.Insert(30);
                    binarySearchTree.Insert(70);
                    break;
                case 5:
                    BinarySearchTree binarySearchTree1 = new BinarySearchTree();
                    int[] dataArray = new int[] { 56, 30, 70, 22, 40, 60, 95, 11, 65, 3, 16, 63, 67 };
                    for (int i = 0; i < dataArray.Length; i++)
                    {
                        binarySearchTree1.Insert(dataArray[i]);
                    }
                    Console.WriteLine("BST in-order traversal:");
                    BinarySearchTree.InOrderTraversal(binarySearchTree1.root);
                    break;  

                default:
                    Console.WriteLine("Please Enter Valid Option fot operation");
                    break;
            }
        }        
    }
}
