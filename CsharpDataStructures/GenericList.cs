using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDataStructures
{
    internal class GenericList
    {
        public static void Main1(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("Name1");
            names.Add("Name2");

           /* names.Add(1);
            names.Add(true);
*/
           foreach (string i in names)
            {
                Console.WriteLine(i);
            }

        }
    }
}
