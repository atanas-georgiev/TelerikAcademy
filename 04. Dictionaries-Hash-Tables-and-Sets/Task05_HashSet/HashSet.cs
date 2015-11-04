namespace Task05_Set
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    using Task04_HashTable;

    public class HashSet<TValue> : IEnumerable<TValue>
    {
        private HashTable<int, TValue> data;

        public HashSet()
        {
            this.data = new HashTable<int, TValue>();
        }

        public int Count
        {
            get
            {
                return this.data.Count;
            }
        }

        public void Add(TValue value)
        {
            this.data.Add(value.GetHashCode(), value);
        }

        public bool Find(TValue value)
        {
            var isFound = true;

            try
            {
                this.data.Find(value.GetHashCode());
            }
            catch (KeyNotFoundException)
            {
                isFound = false;
            }
            
            return isFound;            
        }

        public void Remove(TValue value)
        {
            this.data.Remove(value.GetHashCode());
        }

        public void Clear()
        {
            this.data.Clear();
        }

        public HashSet<TValue> Union(HashSet<TValue> inputSet)
        {
            var result = new HashSet<TValue>();

            foreach (var element in this.data)
            {
                result.Add(element.Value);
            }

            foreach (var element in inputSet.Where(element => !result.Find(element)))
            {
                result.Add(element);
            }

            return result;
        }

        public HashSet<TValue> Intersect(HashSet<TValue> inputSet)
        {
            var result = new HashSet<TValue>();

            foreach (var element in this.data.Where(element => inputSet.Find(element.Value)))
            {
                result.Add(element.Value);
            }

            return result;
        }

        public IEnumerator<TValue> GetEnumerator()
        {
            return this.data.Select(element => element.Value).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
