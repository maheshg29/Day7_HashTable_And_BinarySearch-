using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Day7_HashTable_And_BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Day 7 HashTable and Binary Search Practice Problem");
            Console.WriteLine("Select one Option for \n 1. Find frequency of words in a sentence" +
                "\n 2. Find frequency of words in paragraph \n 3. Remove Given Word");
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

                default:
                    break;
            }
        }
    }
}
