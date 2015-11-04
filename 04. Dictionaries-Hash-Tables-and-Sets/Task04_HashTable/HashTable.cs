namespace Task04_HashTable
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class HashTable<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>
    {
        private const int InitialSize = 16;
        private const double FillSize = 0.75;

        private int size;

        private LinkedList<KeyValuePair<TKey, TValue>>[] data;

        public HashTable()
        {
            this.size = InitialSize;
            this.data = new LinkedList<KeyValuePair<TKey, TValue>>[this.size];
        }

        public int Count
        {
            get
            {
                return this.data.Where(x => x != null).Sum(el => el.Count);
            }
        }

        public IEnumerable<TKey> Keys
        {
            get
            {
                var list = new List<TKey>();

                foreach (var el in this.data.Where(x => x != null))
                {
                    list.AddRange(el.Select(x => x.Key));
                }

                return list;
            }
        }

        public TValue this[TKey key]
        {
            get
            {
                var element = this.data[this.CalculateHashCode(key)];

                if (element == null)
                {
                    throw new KeyNotFoundException("Element not found!");
                }

                return element.First.Value.Value;
            }
        }

        public void Add(TKey key, TValue value)
        {
            var elementToAdd = new KeyValuePair<TKey, TValue>(key, value);
            var index = this.CalculateHashCode(key);

            if (this.data[index] == null)
            {
                this.data[index] = new LinkedList<KeyValuePair<TKey, TValue>>();
            }

            // Add element in the linked list
            this.data[index].AddLast(elementToAdd);

            if (this.CountIndexes() >= this.size * FillSize)
            {
                this.ResizeData();
            }
        }

        public TValue Find(TKey key)
        {
            if (this.data[this.CalculateHashCode(key)] == null)
            {
                throw new KeyNotFoundException("Element not found!");
            }

            return this.data[this.CalculateHashCode(key)].Where(x => x.Key.Equals(key)).FirstOrDefault().Value;
        }

        public void Remove(TKey key)
        {
            var element = this.data[this.CalculateHashCode(key)];

            if (element == null)
            {
                throw new KeyNotFoundException("Element not found!");
            }

            this.data[this.CalculateHashCode(key)] = null;
        }

        public void Clear()
        {
            this.size = InitialSize;
            this.data = new LinkedList<KeyValuePair<TKey, TValue>>[this.size];
        }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            return this.data.Where(x => x != null).SelectMany(element => element).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private int CountIndexes()
        {
            return this.data.Count(x => x != null);            
        }

        private int CalculateHashCode(TKey key)
        {
            return key.GetHashCode() % this.size;
        }

        private void ResizeData()
        {
            this.size *= 2;
            var newData = new LinkedList<KeyValuePair<TKey, TValue>>[this.size];

            foreach (var element in this.data.Where(x => x != null))
            {
                newData[this.CalculateHashCode(element.First.Value.Key)] = element;
            }

            this.data = newData;
        }
    }
}
