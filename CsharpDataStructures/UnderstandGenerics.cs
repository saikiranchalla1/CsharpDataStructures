using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDataStructures
{
    internal class UnderstandGenerics
    {
        public static void Main1(string[] args)
        {
            /*Console.WriteLine(Calculator.AreEqual(10, 20));
            Console.WriteLine(Calculator.AreEqual("10", "20"));
            Console.WriteLine(Calculator.AreEqual("10", 10));
            Console.WriteLine(Calculator.AreEqual(10, "10"));*/

            Console.WriteLine(Calculator<int>.AreEqual(10, 10));

            Console.WriteLine(Calculator<string>.AreEqual("10", "10"));
        }
    }

    class Calculator<T>
    {
        /*public static bool AreEqual(int value1, int value2)
        {
            return value1 == value2;
        }

        public static bool AreEqual(string value1, string value2)
        {
            return value1 == value2;
        }

        public static bool AreEqual(string value1, int value2)
        {
            return int.Parse(value1) == value2;
        }
        public static bool AreEqual(int value1, string value2)
        {
            return int.Parse(value2) == value1;
        }*/

        public static bool AreEqual<T>(T value1, T value2) //GENERIC
        {
            return value1.Equals(value2);
        }
    }

    class MyGenericClass<T1, T2>
    {

    }

}
