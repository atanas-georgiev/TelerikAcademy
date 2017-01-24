namespace Task04_HashTable
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            // Implement the data structure hash table in a class HashTable<K, T>. Keep the data in array of lists of key-value pairs(LinkedList<KeyValuePair<K, T>>[]) with initial capacity of 16. When the hash table load runs over 75%, perform resizing to 2 times larger capacity.Implement the following methods and properties:
            // Add(key, value)
            // Find(key)->value
            // Remove(key)
            // Count
            // Clear()
            // this[]
            // Keys

            // create new HashTable
            var table = new HashTable<int, int>();

            // Add some values
            table.Add(0, 1);
            table.Add(1, 12);
            table.Add(120, 13);
            table.Add(1233, 14);
            table.Add(12, 15);
            table.Add(56, 61);
            table.Add(11111, 71);

            // Find element with key 0
            Console.WriteLine("Element with key 0 is " + table.Find(0));

            // Remove element with key 0
            table.Remove(0);

            // Count elements
            Console.WriteLine("Hashtable has {0} elements", table.Count);

            // Keys
            Console.WriteLine("Hastable keys: " + string.Join(", ", table.Keys));

            // Print all values
            foreach (var value in table)
            {
                Console.WriteLine("Key {0} - Value {1}", value.Key, value.Value);
            }
        }
    }
}
