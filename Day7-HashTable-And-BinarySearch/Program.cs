using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_HashTable_And_BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Day 7 HashTable and Binary Search Practice Problem");
            Console.WriteLine("Select one Option for \n 1. Find frequency of words in a sentence");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    HashTableOperations findFrequencyOfWord=new HashTableOperations();
                    findFrequencyOfWord.FrequencyOfWord("To be or not to be");
                    break;
                default:
                    break;
            }
        }
    }
}
