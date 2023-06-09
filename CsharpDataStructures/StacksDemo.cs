using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDataStructures
{
    internal class StacksDemo
    {
        public static void Main1(string[] args)
        {
            // LIFO

            // stack operations: push (insert) and pop (remove)

            Stack stack = new Stack();
            stack.Push(10);
            stack.Push("!23");
            stack.Push(true);
            stack.Push(3.14f);
            stack.Push(1.445);
            stack.Push('A');

            foreach (object item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Popped Element:" + stack.Pop());
            /*Console.WriteLine("Popped Element:" + stack.Pop());
            Console.WriteLine("Popped Element:" + stack.Pop());
            Console.WriteLine("Popped Element:" + stack.Pop());
            Console.WriteLine("Popped Element:" + stack.Pop());
            Console.WriteLine("Popped Element:" + stack.Pop());*/
            // Console.WriteLine("Popped Element:" + stack.Pop()); <-- This will throw exception


            Console.WriteLine("Peeked Element:" + stack.Peek());
            Console.WriteLine("Peeked Element:" + stack.Peek());
            Console.WriteLine("Peeked Element:" + stack.Peek());

            Console.WriteLine("Element exists in Stack? " + stack.Contains(3.14));

            Console.WriteLine("Count of stack:" + stack.Count);

        }
    }
}
