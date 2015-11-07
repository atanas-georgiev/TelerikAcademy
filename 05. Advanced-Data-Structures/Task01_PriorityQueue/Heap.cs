namespace Task01_PriorityQueue
{
    using System;
    using System.Collections.Generic;

    public class Heap<T>
    {
        private readonly IComparer<T> comparer;

        private readonly IList<T> list;

        public Heap(IList<T> list, int count, IComparer<T> comparer)
        {
            this.comparer = comparer;
            this.list = list;
            this.Count = count;
            this.Heapify();
        }

        public int Count { get; private set; }

        public T PopRoot()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Empty heap.");
            }

            var root = this.list[0];
            this.SwapCells(0, this.Count - 1);
            this.Count--;
            this.HeapDown(0);
            return root;
        }

        public T PeekRoot()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Empty heap.");
            }

            return this.list[0];
        }

        public void Insert(T e)
        {
            if (this.Count >= this.list.Count)
            {
                this.list.Add(e);
            }
            else
            {
                this.list[this.Count] = e;
            }

            this.Count++;
            this.HeapUp(this.Count - 1);
        }

        private void Heapify()
        {
            for (var i = this.Parent(this.Count - 1); i >= 0; i--)
            {
                this.HeapDown(i);
            }
        }

        private void HeapUp(int i)
        {
            var elt = this.list[i];
            while (true)
            {
                var parent = this.Parent(i);
                if (parent < 0 || this.comparer.Compare(this.list[parent], elt) > 0)
                {
                    break;
                }

                this.SwapCells(i, parent);
                i = parent;
            }
        }

        private void HeapDown(int i)
        {
            while (true)
            {
                var lchild = this.LeftChild(i);
                if (lchild < 0)
                {
                    break;
                }

                var rchild = this.RightChild(i);

                var child = rchild < 0
                                ? lchild
                                : this.comparer.Compare(this.list[lchild], this.list[rchild]) > 0 ? lchild : rchild;

                if (this.comparer.Compare(this.list[child], this.list[i]) < 0)
                {
                    break;
                }

                this.SwapCells(i, child);
                i = child;
            }
        }

        private int Parent(int i)
        {
            return i <= 0 ? -1 : this.SafeIndex((i - 1) / 2);
        }

        private int RightChild(int i)
        {
            return this.SafeIndex(2 * (i + 2));
        }

        private int LeftChild(int i)
        {
            return this.SafeIndex(2 * (i + 1));
        }

        private int SafeIndex(int i)
        {
            return i < this.Count ? i : -1;
        }

        private void SwapCells(int i, int j)
        {
            var temp = this.list[i];
            this.list[i] = this.list[j];
            this.list[j] = temp;
        }
    }
}