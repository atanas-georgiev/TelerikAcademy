namespace Task13
{
    using System.Collections.Generic;

    class LinkedQueue<T>
    {
        private LinkedList<T> values;

        public LinkedQueue()
        {
            this.values = new LinkedList<T>();
        }

        public T Dequeue()
        {
            var result = this.values.Last.Value;
            this.values.RemoveLast();

            return result;
        }

        public void Enqueue(T item)
        {
            this.values.AddFirst(item);
        }
    }
}
