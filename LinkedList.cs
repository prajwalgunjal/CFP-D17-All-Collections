using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsEG
{
    internal class LinkedList
    {
        LinkedList<int> linkedList = new LinkedList<int>();
        public void LinkedlistM()
        {
            // Add elements to the LinkedList
            linkedList.AddLast(1);
            linkedList.AddLast(2);
            linkedList.AddLast(3);
            linkedList.AddLast(4);
            linkedList.AddLast(5);
            linkedList.AddLast(6);
            linkedList.AddLast(7);

            Console.WriteLine("Printing linked list");
            Display();

            // Count
            Console.WriteLine("Count: " + linkedList.Count);

            // Contains
            Console.WriteLine("Contains 2: " + linkedList.Contains(2));

            // Remove
            linkedList.Remove(2);
            Console.WriteLine("printing after remove");
            // Count after removing an element
            Console.WriteLine("Count after removal: " + linkedList.Count);

            // Clear
            linkedList.Clear();

            // Count after clearing the LinkedList
            Console.WriteLine("Count after clearing: " + linkedList.Count);

            // AddFirst
            linkedList.AddFirst(10);

            // AddLast
            linkedList.AddLast(20);

            // Iterate over the LinkedList
            Display();

        }

        public void Display()
        {
            LinkedListNode<int> currentNode = linkedList.First;
            while (currentNode != null)
            {
                Console.Write(currentNode.Value + " -> ");
                currentNode = currentNode.Next;
            }
            Console.WriteLine();
        }
    }
}
