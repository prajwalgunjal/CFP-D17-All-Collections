using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsEG
{
    internal class ListMethods
    {
        List<string> listString = new List<string>();

        public void ArrayList()
        {
            // adding element to list
            Console.WriteLine("Adding element to list");
            listString.Add("Apple");
            listString.Add("Polo");
            listString.Add("Mohit");
            listString.Add("Xerox");
            listString.Add("Bat");  
            listString.Add("Cat");
            listString.Add("Dog");
            listString.Add("Elephant");
            listString.Add("Fish");
            Console.WriteLine("elements which are present in list are");
            Display();
            Console.WriteLine();
            listString.Remove("Apple");
            Console.WriteLine("Apple removed");
            Display();
            Console.WriteLine();
            Console.WriteLine("Checking weather Bat is present in list or not");
            Console.WriteLine("Bat"+" -> "+listString.Contains("Bat"));
            Console.WriteLine("Prajwal"+" -> "+listString.Contains(" Prajwal"));
            Console.WriteLine();
            Console.WriteLine("Counting number of elements which are present in list");
            Console.WriteLine(listString.Count);
            Console.WriteLine();
            Console.WriteLine("Sorting List ");
            listString.Sort();  
            Display();
            Console.WriteLine();
            Console.WriteLine("Clearing list ");
            listString.Clear();
        }

        public void Display()
        {
            foreach (var element in listString)
            {
                Console.Write(element +" " );
            }
            Console.WriteLine();
        }


    }
}
