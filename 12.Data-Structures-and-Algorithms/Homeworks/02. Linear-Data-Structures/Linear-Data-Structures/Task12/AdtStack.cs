using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    class AdtStack<T>
    {
        private int index;
        private int capacity;

        private T[] values;

        public AdtStack(int capacity)
        {
            this.index = 0;
            this.capacity = capacity;
            this.values = new T[this.capacity];
        }

        public int Size
        {
            get
            {
                return this.capacity;
            }
        }

        public void Push(T value)
        {
            if (this.index < this.capacity)
            {
                // Enough space in the stack
                this.values[this.index] = value;                
            }
            else
            {
                // stack is full, resize it
                var newArray = new T[this.capacity * 2];

                for (int i = 0; i < this.capacity; i++)
                {
                    newArray[i] = this.values[i];
                }

                this.capacity *= 2;
                this.values = newArray;                
                this.values[this.index] = value;
            }

            this.index += 1;
        }

        public T Pop()
        {
            if (this.index == 0)
            {
                throw new InvalidOperationException("Cannot pop, stack is empty!");
            }

            this.index -= 1;
            var result = this.values[this.index];

            return result;
        }

        public T Peek()
        {
            if (this.index == 0)
            {
                throw new InvalidOperationException("Cannot pop, stack is empty!");
            }

            var result = this.values[this.index - 1];

            return result;
        }
    }
}
