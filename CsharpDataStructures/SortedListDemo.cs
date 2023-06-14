using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDataStructures
{
    internal class SortedListDemo
    {
        public static void Main1(string[] args)
        {
            // Key-value - HashTable vs SortedList

            SortedList sortedList = new SortedList();

            sortedList.Add(1, "One");
            sortedList.Add(5, "Five");
            sortedList.Add(4, "Four");
            sortedList.Add(2, "Two");
            sortedList.Add(3, "Three");

            // sortedList.Add(4, "Four");
            sortedList.Add(6, null);

            for (int i = 0; i < sortedList.Count; i++)
            {
                // Console.WriteLine(sortedList[i]);
                Console.WriteLine(sortedList.GetKey(i) + ":" + sortedList.GetByIndex(i));
            }

            Console.WriteLine("--------");

            foreach(DictionaryEntry entry in sortedList)
            {
                Console.WriteLine(entry.Key + ":" + entry.Value);
            }

            sortedList.Remove(1);
            sortedList.RemoveAt(3);

            Console.WriteLine("--------");

            foreach (DictionaryEntry entry in sortedList)
            {
                Console.WriteLine(entry.Key + ":" + entry.Value);
            }

            Console.WriteLine(sortedList.Contains(1));
            Console.WriteLine(sortedList.ContainsValue("Four"));
        }
    }
}
