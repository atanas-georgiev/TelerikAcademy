using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClassesPart2
{
    /// <summary>
    /// Problem 5. Generic class
    /// Write a generic class GenericList<T> that keeps a list of elements of some parametric type T.
    /// Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor.
    /// Implement methods for adding element, accessing element by index, removing element by index, inserting element at given position, clearing the list, finding element by its value and ToString().
    /// Check all input parameters to avoid accessing elements at invalid positions.
    /// </summary>
    class GenericList<T>
    {
        private T[] array;
        private int index;
        public T this[int i]
        {
            get
            {
                return array[i];
            }
        }

        public GenericList() { }
        public GenericList(int capacity)
        {
            array = new T[capacity];
            index = 0;
        }
        /// <summary>
        /// Problem 6. Auto-grow
        /// Implement auto-grow functionality: when the internal array is full, create a new array of double size and move all elements to it.
        /// </summary>
        public void Add(T element)
        {
            if (index > array.Length - 1)
            {
                Array.Resize<T>(ref array, array.Length * 2);
            }

            array[index] = element;
            index++;
        }

        public void RemoveAt(int position)
        {
            array = array.Where((source, i) => i != position).ToArray();
            index--;
        }

        public void InsertAt(int position, T element)
        {
            if (position == index)
            {
                Add(element);
            }
            else if (position > index)
            {
                throw new IndexOutOfRangeException("Not correct index!");
            }
            else
            {
                if (index > array.Length - 1)
                {
                    Array.Resize<T>(ref array, array.Length * 2);
                }

                for (int i = index; i >= position; i--)
                {
                    array[i] = array[i - 1];
                }

                array[position] = element;
                index++;
            }
        }

        public void Clear()
        {
            Array.Clear(array, 0, array.Length - 1);
            index = 0;
        }

        public int Find(T element)
        {
            return array.ToList().FindIndex(e => Object.Equals(e, element));;
        }

        /// <summary>
        /// Problem 7. Min and Max
        /// Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the GenericList<T>.
        /// You may need to add a generic constraints for the type T.
        /// </summary>
        public T Min()
        {
            return array.Min();
        }

        public T Max()
        {
            return array.Max();
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            Console.WriteLine("GenericList size: {0}\nItems: {1}\n Values:", array.Length, index);
            for (int i = 0; i < index; i++)
            {
                str.Append(array[i] + " ");
            }
            return str.ToString();
        }
    }
}
