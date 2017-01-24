// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SortingAlgorithms.cs" company="">
//   
// </copyright>
// <summary>
//   The sorting algorithms.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SortAlgorithmsComparison
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The sorting algorithms.
    /// </summary>
    internal class SortingAlgorithms
    {
        /// <summary>
        /// The selection sort.
        /// </summary>
        /// <param name="collection">
        /// The collection.
        /// </param>
        /// <param name="comparer">
        /// The comparer.
        /// </param>
        /// <typeparam name="T">
        /// </typeparam>
        internal static void SelectionSort<T>(T[] collection, Comparer<T> comparer = null) where T : IComparable
        {
            comparer = comparer ?? Comparer<T>.Default;

            for (var i = 0; i < collection.Length - 1; i++)
            {
                var minInd = i;

                for (var j = i + 1; j < collection.Length; j++)
                {
                    if (comparer.Compare(collection[i], collection[j]) > 0)
                    {
                        minInd = j;
                    }
                }

                if (minInd != i)
                {
                    var temp = collection[i];
                    collection[i] = collection[minInd];
                    collection[minInd] = temp;
                }
            }
        }

        /// <summary>
        /// The quick sort.
        /// </summary>
        /// <param name="collection">
        /// The collection.
        /// </param>
        /// <param name="left">
        /// The left.
        /// </param>
        /// <param name="right">
        /// The right.
        /// </param>
        /// <param name="comparer">
        /// The comparer.
        /// </param>
        /// <typeparam name="T">
        /// </typeparam>
        internal static void QuickSort<T>(T[] collection, int left, int right, Comparer<T> comparer = null)
            where T : IComparable
        {
            comparer = comparer ?? Comparer<T>.Default;
            var pivot = collection[(left + right) / 2];
            var i = left;
            var j = right;
            while (i <= j)
            {
                while (comparer.Compare(collection[i], pivot) < 0)
                {
                    i++;
                }

                while (comparer.Compare(collection[j], pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    var temp = collection[i];
                    collection[i] = collection[j];
                    collection[j] = temp;

                    i++;
                    j--;
                }
            }

            if (left < j)
            {
                QuickSort(collection, left, j, comparer);
            }

            if (i < right)
            {
                QuickSort(collection, i, right, comparer);
            }
        }

        /// <summary>
        /// The insertion sort.
        /// </summary>
        /// <param name="collection">
        /// The collection.
        /// </param>
        /// <param name="comparer">
        /// The comparer.
        /// </param>
        /// <typeparam name="T">
        /// </typeparam>
        internal static void InsertionSort<T>(T[] collection, Comparer<T> comparer = null) where T : IComparable
        {
            comparer = comparer ?? Comparer<T>.Default;

            for (var i = 0; i < collection.Length - 1; i++)
            {
                var index = i + 1;
                while (index > 0)
                {
                    if (comparer.Compare(collection[index - 1], collection[index]) > 0)
                    {
                        var temp = collection[index - 1];
                        collection[index - 1] = collection[index];
                        collection[index] = temp;
                    }

                    --index;
                }
            }
        }
    }
}