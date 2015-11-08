namespace Task03_BiDictionary
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;

    using Wintellect.PowerCollections;

    public class BiDictionary<K1, K2, T>
    {
        private readonly Dictionary<K1, Dictionary<K2, T>> dataKey1;
        private readonly Dictionary<K2, Dictionary<K1, T>> dataKey2;

        public BiDictionary()
        {
            this.dataKey1 = new Dictionary<K1, Dictionary<K2, T>>();
            this.dataKey2 = new Dictionary<K2, Dictionary<K1, T>>();
        }

        public void Add(K1 key1, K2 key2, T value)
        {
            if (!this.dataKey1.ContainsKey(key1))
            {
                this.dataKey1.Add(key1, new Dictionary<K2, T>());
            }

            if (!this.dataKey2.ContainsKey(key2))
            {
                this.dataKey2.Add(key2, new Dictionary<K1, T>());
            }

            if (!this.dataKey1[key1].ContainsKey(key2))
            {
                this.dataKey1[key1] = new Dictionary<K2, T>();
            }

            if (!this.dataKey2[key2].ContainsKey(key1))
            {
                this.dataKey2[key2] = new Dictionary<K1, T>();
            }

            this.dataKey1[key1][key2] = value;
            this.dataKey2[key2][key1] = value;
        }

        public IEnumerable<T> Find(K1 key1 = default(K1), K2 key2 = default(K2))
        {
            if (key1.Equals(default(K1)) && key2.Equals(default(K2)))
            {
                throw new InvalidOperationException("Key not specified!");
            } 
            else if (key2.Equals(default(K2)))
            {
                // key 1 specified
                if (!this.dataKey1.ContainsKey(key1))
                {
                    throw new KeyNotFoundException("Value not found!");
                }

                return this.dataKey1[key1].Values;
            }
            else if (key1.Equals(default(K1)))
            {
                // key 2 specified
                if (!this.dataKey2.ContainsKey(key2))
                {
                    throw new KeyNotFoundException("Value not found!");
                }

                return this.dataKey2[key2].Values;
            }
            else
            {
                // both specified
                if (!this.dataKey1.ContainsKey(key1) || !this.dataKey2.ContainsKey(key2))
                {
                    throw new KeyNotFoundException("Value not found!");
                }

                return new List<T>() { this.dataKey1[key1][key2] };
            }
        }
    }
}
