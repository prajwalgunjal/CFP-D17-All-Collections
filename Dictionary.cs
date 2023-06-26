using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsEG
{
    internal class Dictionary
    {


        public void dict()
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            // Add elements to the dictionary
            dictionary.Add("One", 1);
            dictionary.Add("Two", 2);
            dictionary.Add("Three", 3);


            Display(dictionary);

            // Count
            Console.WriteLine("Count: " + dictionary.Count);

            // ContainsKey
            Console.WriteLine("ContainsKey 'Two': " + dictionary.ContainsKey("Two"));

            // ContainsValue
            Console.WriteLine("ContainsValue 2: " + dictionary.ContainsValue(2));

            // Accessing values by key
            int value;
            if (dictionary.TryGetValue("One", out value))
            {
                Console.WriteLine("Value for 'One': " + value);
            }

            // Update value
            dictionary["One"] = 10;

            // Remove
            dictionary.Remove("Two");

            // Count after removing an element
            Console.WriteLine("Count after removal: " + dictionary.Count);
            Display(dictionary);
            Console.WriteLine();
            // Clear
            dictionary.Clear();

            // Count after clearing the dictionary
            Console.WriteLine("Count after clearing: " + dictionary.Count);

            Display(dictionary);
        }
        public void Display<TKey, TValue>(Dictionary<TKey, TValue> dictionary)
        {
            foreach (KeyValuePair<TKey, TValue> pair in dictionary)
            {
                Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
            }
            Console.WriteLine();
        }
    }
}
