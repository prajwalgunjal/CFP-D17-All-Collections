/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsEG
{
    internal class StackMethods
    {
        Stack<int> stack = new Stack<int>();
        public void stackMethod()
        {
            // Push elements to the stack
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);

            Display();

            // Count
            Console.WriteLine("Count: " + stack.Count);

            // Contains
            Console.WriteLine("Contains 2: " + stack.Contains(2));

            // Peek
            Console.WriteLine("Peek: " + stack.Peek());

            // Pop
            Console.WriteLine("Pop: " + stack.Pop());

            // Count after popping an element
            Console.WriteLine("Count after popping: " + stack.Count);

            // Clear
            stack.Clear();

            // Count after clearing the stack
            Console.WriteLine("Count after clearing: " + stack.Count);

            // Push more elements to the stack
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
        }

        public void Display()
        {
            foreach (int item in stack)
            {
                Console.Write(item+" -> ");
            }
            Console.WriteLine();
        }
    }
}
*/