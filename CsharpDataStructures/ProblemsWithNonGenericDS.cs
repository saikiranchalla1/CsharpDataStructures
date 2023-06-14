using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDataStructures
{
    internal class ProblemsWithNonGenericDS
    {
        public static void Main1(string[] args)
        {
            ArrayList arrayList= new ArrayList();

            arrayList.Add(1);
            arrayList.Add(2);
            arrayList.Add(3);
            arrayList.Add(4);

            arrayList.Add("Hello, World!");
            arrayList.Add("6");

            arrayList.Add(true);
            arrayList.Add(false);


            foreach(int number in arrayList)
            {
                Console.WriteLine(number);
            }

        }
    }
}
