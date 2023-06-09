using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDataStructures
{
    internal class QueuesDemo
    {
        public static void Main(string[] args)
        {
            Queue queue = new Queue();

            // Enqueue (insert) and Dequeue (remove)
            queue.Enqueue(1);
            queue.Enqueue("Testing");
            queue.Enqueue(3.14);
            queue.Enqueue("James Bond");
            queue.Enqueue(true);
            queue.Enqueue(12.123f);
            queue.Enqueue('B');



            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Removed element: " + queue.Dequeue());
            Console.WriteLine("Peeked element: " + queue.Peek());
            Console.WriteLine("Peeked element: " + queue.Peek());
            Console.WriteLine("Queue contains?" + queue.Contains("testing"));

            Console.WriteLine("Queue size: " + queue.Count);
        }
    }
}
