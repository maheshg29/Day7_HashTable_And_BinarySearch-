using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_HashTable_And_BinarySearch
{
    class HashTableOperations
    {
        public void FrequencyOfWord(string inputString)
        {
            Hashtable wordFrequency = new Hashtable();
            string[] words = inputString.Split(' ');

            foreach (string word in words)
            {
                if (wordFrequency.ContainsKey(word))
                {
                    int frequency = (int)wordFrequency[word];
                    wordFrequency[word] = frequency + 1;

                }
                else
                {
                    wordFrequency.Add(word, 1);
                }
            }

            foreach (DictionaryEntry entry in wordFrequency)
            {
                Console.WriteLine("{0}: {1}", entry.Key, entry.Value);
            }
        }
    }
}
