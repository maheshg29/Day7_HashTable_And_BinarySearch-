using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day7_HashTable_And_BinarySearch
{
    public class MyMapNode<TKey, TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }

        public MyMapNode(TKey key, TValue value)
        {
            Key = key;
            Value = value;
        }

    }

    class HashTableUsingLinkList
    {
        public static LinkedList<MyMapNode<string, int>>[] FreqOfWord(string inputString)
        {
                LinkedList<MyMapNode<string, int>>[] hashtable = new LinkedList<MyMapNode<string, int>>[inputString.Length];
                string[] words = inputString.Split(' ');

                foreach (string word in words)
                {
                
                    int index = GetArrayIndex(word,words.Length);
                    if (hashtable[index] == null)
                    {
                        hashtable[index] = new LinkedList<MyMapNode<string, int>>();
                    }

                    MyMapNode<string, int> node = hashtable[index].FirstOrDefault(n => n.Key == word);

                     if (node == null)
                     {
                        node = new MyMapNode<string, int>(word, 1);
                        hashtable[index].AddLast(node);
                     }
                     else
                     {
                        node.Value++;
                     }
                }

                foreach (LinkedList<MyMapNode<string, int>> list in hashtable)
                {
                    if (list != null)
                    {
                        foreach (MyMapNode<string, int> node in list)
                        {
                            Console.WriteLine("{0}: {1}", node.Key, node.Value);
                        }
                    }
                }
        return hashtable;
        }

        static int GetArrayIndex(string word,int indexsize)
        {
                int hashCode = word.GetHashCode();
                int index = hashCode % indexsize;
                return Math.Abs(index);
        }

       

    }

}
