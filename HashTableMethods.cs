using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsEG
{
    internal class HashTableMethods
    {
        HashSet<string> hashset = new HashSet<string>();

        public void hashtableMethods()
        {
            Console.WriteLine("Adding element to list");
            hashset.Add("Apple");
            hashset.Add("Polo");
            hashset.Add("Mohit");
            hashset.Add("Xerox");
            hashset.Add("Bat");
            hashset.Add("Cat");
            hashset.Add("Dog");
            hashset.Add("Elephant");
            hashset.Add("Fish");
            Console.WriteLine("elements which are present in list are");
            Display();
            Console.WriteLine();
            Console.WriteLine("Checking wether xerox is present or not");
            Console.WriteLine("Xerox - > " + hashset.Contains("Xerox"));
            Console.WriteLine();
            Console.WriteLine("Removing Apple");
            hashset.Remove("Apple");
            Console.WriteLine("Apple removed");
            Display();
            Console.WriteLine();

            Console.WriteLine("Counting number of elements which are present in Hashset");
            Console.WriteLine(hashset.Count);
            Console.WriteLine();
            Console.WriteLine("Clearing hashset ");
            hashset.Clear();
        }

        public void Display()
        {
            foreach (var item in hashset)
            {
                Console.Write(item + " -> ");
            }
            Console.WriteLine();
        }
    }
}
