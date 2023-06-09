using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDataStructures
{
    internal class ArrayListDemo
    {
        static void Main1(string[] args)
        {
            // ArrayList(), ArrayList(collection), ArrayList(size)
            // non-generic arraylist

            ArrayList myList = new ArrayList(10);

            myList.Add(123);
            myList.Add("James Bond");
            myList.Add(true);
            myList.Add(null);
            myList.Add(123);
            myList.Add("James Bond");
            myList.Add(true);
            myList.Add(null);

            foreach (var i in myList)
            {
                Console.WriteLine(i);
            }

            int firstElement = (int) myList[0];
            string secondElement = (string) myList[1];

            myList[7] = "007";

            myList.Insert(6, "Sixth Element");


            myList.Remove("007");
            myList.RemoveAt(1);
            myList.RemoveRange(2, 2);

            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine($"myList[{i}] = {myList[i]}");
            }

            Console.WriteLine(myList.Capacity);

            Console.WriteLine(myList.Contains("007"));


            object[] myListCopy = new object[myList.Count];

            myList.CopyTo(myListCopy);

            // Array.Sort
            myList.Sort();
            myList.Reverse();


            myList.Clear();
        }
    }
}
