using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsEG
{
    internal class Queue
    {
        Queue<int> queue = new Queue<int>();
        public void queueMethod()
        {
            // Enqueue elements to the queue
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            Display();
            // Count
            Console.WriteLine("Count: " + queue.Count);

            // Contains
            Console.WriteLine("Contains 2: " + queue.Contains(2));

            // Peek
            Console.WriteLine("Peek: " + queue.Peek());

            // Dequeue
            Console.WriteLine("Dequeue: " + queue.Dequeue());

            // Count after dequeueing an element
            Console.WriteLine("Count after dequeueing: " + queue.Count);

            // Clear
            queue.Clear();

            // Count after clearing the queue
            Console.WriteLine("Count after clearing: " + queue.Count);

            // Enqueue more elements to the queue
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            Display();
        }

        public void Display()
        {
            foreach (int item in queue)
            {
                Console.Write(item+" -> ");
            }
            Console.WriteLine();
        }
    }
}
