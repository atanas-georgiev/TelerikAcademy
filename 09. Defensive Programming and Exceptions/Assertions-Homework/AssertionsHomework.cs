// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AssertionsHomework.cs" company="">
//   
// </copyright>
// <summary>
//   The assertions homework.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Diagnostics;

/// <summary>
///     The assertions homework.
/// </summary>
internal class AssertionsHomework
{
    /// <summary>
    /// The selection sort.
    /// </summary>
    /// <param name="arr">
    /// The array.
    /// </param>
    /// <typeparam name="T">
    /// IComparable
    /// </typeparam>
    public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
    {
        Debug.Assert(arr != null, "arr cannot be null!");
        Debug.Assert(arr.Length != 0, "Array is empty!");

        for (var index = 0; index < arr.Length - 1; index++)
        {
            var minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);
            Swap(ref arr[index], ref arr[minElementIndex]);
        }
    }

    /// <summary>
    /// The binary search.
    /// </summary>
    /// <param name="arr">
    /// The arr.
    /// </param>
    /// <param name="value">
    /// The value.
    /// </param>
    /// <typeparam name="T">
    /// </typeparam>
    /// <returns>
    /// The <see cref="int"/>.
    /// </returns>
    public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
    {
        Debug.Assert(arr != null, "arr cannot be null!");
        Debug.Assert(arr.Length != 0, "Array is empty!");

        return BinarySearch(arr, value, 0, arr.Length - 1);
    }

    /// <summary>
    /// The find min element index.
    /// </summary>
    /// <param name="arr">
    /// The arr.
    /// </param>
    /// <param name="startIndex">
    /// The start index.
    /// </param>
    /// <param name="endIndex">
    /// The end index.
    /// </param>
    /// <typeparam name="T">
    /// </typeparam>
    /// <returns>
    /// The <see cref="int"/>.
    /// </returns>
    private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex) where T : IComparable<T>
    {
        Debug.Assert(arr != null, "arr cannot be null!");
        Debug.Assert(arr.Length != 0, "Array is empty!");
        Debug.Assert(startIndex > 0, "startIndex cannot be negative!");
        Debug.Assert(endIndex < arr.Length, "endIndex cannot be more than the array length!");
        Debug.Assert(endIndex > 0, "endIndex cannot be negative!");
        Debug.Assert(startIndex < endIndex, "startIndex should be less than endIndex!");

        var minElementIndex = startIndex;
        for (var i = startIndex + 1; i <= endIndex; i++)
        {
            if (arr[i].CompareTo(arr[minElementIndex]) < 0)
            {
                minElementIndex = i;
            }
        }

        Debug.Assert(arr.Length > 0, "Result should be more than 0!");
        return minElementIndex;
    }

    /// <summary>
    /// The swap.
    /// </summary>
    /// <param name="x">
    /// The x.
    /// </param>
    /// <param name="y">
    /// The y.
    /// </param>
    /// <typeparam name="T">
    /// </typeparam>
    private static void Swap<T>(ref T x, ref T y)
    {
        Debug.Assert(x != null, "x cannot be null!");
        Debug.Assert(y != null, "y cannot be null!");

        var oldX = x;
        x = y;
        y = oldX;
    }

    /// <summary>
    /// The binary search.
    /// </summary>
    /// <param name="arr">
    /// The arr.
    /// </param>
    /// <param name="value">
    /// The value.
    /// </param>
    /// <param name="startIndex">
    /// The start index.
    /// </param>
    /// <param name="endIndex">
    /// The end index.
    /// </param>
    /// <typeparam name="T">
    /// </typeparam>
    /// <returns>
    /// The <see cref="int"/>.
    /// </returns>
    private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex) where T : IComparable<T>
    {
        Debug.Assert(arr != null, "arr cannot be null!");
        Debug.Assert(arr.Length != 0, "Array is empty!");
        Debug.Assert(startIndex > 0, "startIndex cannot be negative!");
        Debug.Assert(endIndex < arr.Length, "endIndex cannot be more than the array length!");
        Debug.Assert(endIndex > 0, "endIndex cannot be negative!");
        Debug.Assert(startIndex < endIndex, "startIndex should be less than endIndex!");

        while (startIndex <= endIndex)
        {
            var midIndex = (startIndex + endIndex) / 2;
            if (arr[midIndex].Equals(value))
            {
                return midIndex;
            }

            if (arr[midIndex].CompareTo(value) < 0)
            {
                // Search on the right half
                startIndex = midIndex + 1;
            }
            else
            {
                // Search on the right half
                endIndex = midIndex - 1;
            }
        }

        // Searched value not found
        return -1;
    }

    /// <summary>
    ///     The main.
    /// </summary>
    private static void Main()
    {
        int[] arr = { 3, -1, 15, 4, 17, 2, 33, 0 };
        Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
        SelectionSort(arr);
        Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

        SelectionSort(new int[0]); // Test sorting empty array
        SelectionSort(new int[1]); // Test sorting single element array

        Console.WriteLine(BinarySearch(arr, -1000));
        Console.WriteLine(BinarySearch(arr, 0));
        Console.WriteLine(BinarySearch(arr, 17));
        Console.WriteLine(BinarySearch(arr, 10));
        Console.WriteLine(BinarySearch(arr, 1000));
    }
}