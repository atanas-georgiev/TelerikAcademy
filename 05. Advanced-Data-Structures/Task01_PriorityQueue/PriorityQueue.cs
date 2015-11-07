namespace Task01_PriorityQueue
{
    using System.Collections.Generic;
    
    public class PriorityQueue<T>
    {
        private readonly Heap<T> heap;

        public PriorityQueue(IComparer<T> comparer)
        {
            this.heap = new Heap<T>(new List<T>(), 0, comparer);
        }

        public int Size
        {
            get
            {
                return this.heap.Count;
            }
        }

        public T Top()
        {
            return this.heap.PeekRoot();
        }

        public void Push(T e)
        {
            this.heap.Insert(e);
        }

        public T Pop()
        {
            return this.heap.PopRoot();
        }
    }
}