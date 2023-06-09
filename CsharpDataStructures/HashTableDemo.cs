using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDataStructures
{
    internal class HashTableDemo
    {
        public static void Main1(string[] args)
        {
            ArrayList myList = new ArrayList();

            myList.Add(100001);
            myList.Add("James");
            myList.Add("Bond");
            myList.Add("New York");
            myList.Add(83822);
            myList.Add("IT");
            myList.Add("abc@gmail.com");

            // HashTable = Key and Value pairs


            Hashtable hashtable= new Hashtable();

            hashtable.Add("EId", 100001);
            hashtable.Add("FirstName", "James");
            hashtable.Add("LastName", "Bond");
            hashtable.Add("City", "NYC");
            hashtable.Add("Zip", 82822);
            hashtable.Add("Dept", "IT");

            foreach(object obj in hashtable.Keys)
            {
                Console.WriteLine(obj);
                Console.WriteLine(hashtable[obj]);

                Console.WriteLine("-----");
            }

            foreach(DictionaryEntry entry in hashtable)
            {
                Console.WriteLine(entry.Key + " " + entry.Value);
            }


            Console.WriteLine(hashtable.Contains("Email"));
            Console.WriteLine(hashtable.ContainsKey("EId"));
            Console.WriteLine(hashtable.ContainsValue("Bond"));

            hashtable.Remove("EId");


            hashtable["Zip"] = "89919";

            Console.WriteLine(hashtable.IsReadOnly);
            Console.WriteLine(hashtable.IsFixedSize);
            Console.WriteLine(hashtable.Values);
            Console.WriteLine(hashtable.Keys);
            Console.WriteLine(hashtable.Count);


            hashtable.Clear();










        }
    }
}
