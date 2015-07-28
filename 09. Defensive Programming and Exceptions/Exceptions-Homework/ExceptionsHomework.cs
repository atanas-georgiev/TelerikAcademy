// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ExceptionsHomework.cs" company="">
//   
// </copyright>
// <summary>
//   The exceptions homework.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
///     The exceptions homework.
/// </summary>
internal class ExceptionsHomework
{
    /// <summary>
    /// The subsequence.
    /// </summary>
    /// <param name="arr">
    /// The arr.
    /// </param>
    /// <param name="startIndex">
    /// The start index.
    /// </param>
    /// <param name="count">
    /// The count.
    /// </param>
    /// <typeparam name="T">
    /// </typeparam>
    /// <returns>
    /// The <see cref="T[]"/>.
    /// </returns>
    /// <exception cref="ArgumentException">
    /// </exception>
    public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
    {
        if (arr == null)
        {
            throw new NullReferenceException("Input array is null!");
        }

        if (arr.Length <= 0)
        {
            throw new ArgumentException("Input array cannot be empty!");
        }

        if (startIndex < 0 || startIndex >= arr.Length)
        {
            throw new ArgumentException("Start index " + startIndex + " is not correct!");
        }

        if (count < 0 || count > arr.Length)
        {
            throw new ArgumentException(count + "  is not correct!");
        }

        if (startIndex + count > arr.Length)
        {
            throw new ArgumentException("Given range " + startIndex + count + " is not correct!");
        }

        var result = new List<T>();
        for (var i = startIndex; i < startIndex + count; i++)
        {
            result.Add(arr[i]);
        }

        return result.ToArray();
    }

    /// <summary>
    /// The extract ending.
    /// </summary>
    /// <param name="str">
    /// The str.
    /// </param>
    /// <param name="count">
    /// The count.
    /// </param>
    /// <returns>
    /// The <see cref="string"/>.
    /// </returns>
    /// <exception cref="ArgumentException">
    /// </exception>
    public static string ExtractEnding(string str, int count)
    {
        if (str == null)
        {
            throw new NullReferenceException("Input string is null!");
        }

        if (str.Length <= 0)
        {
            throw new ArgumentException("Input string cannot be empty!");
        }

        if (count < 0 || count > str.Length)
        {
            throw new ArgumentException(count + "  is not correct!");
        }

        var result = new StringBuilder();
        for (var i = str.Length - count; i < str.Length; i++)
        {
            result.Append(str[i]);
        }

        return result.ToString();
    }

    /// <summary>
    /// The check prime.
    /// </summary>
    /// <param name="number">
    /// The number.
    /// </param>
    /// <returns>
    /// The <see cref="bool"/>.
    /// </returns>
    /// <exception cref="ArgumentException">
    /// </exception>
    public static bool CheckPrime(int number)
    {
        if (number < 0)
        {
            throw new ArgumentException(number + "  should be >= 0!");
        }

        for (var divisor = 2; divisor <= Math.Sqrt(number); divisor++)
        {
            if (number % divisor == 0)
            {
                return false;
            }
        }

        return true;
    }

    /// <summary>
    ///     The main.
    /// </summary>
    private static void Main()
    {
        var substr = Subsequence("Hello!".ToCharArray(), 2, 3);
        Console.WriteLine(substr);

        var subarr = Subsequence(new[] { -1, 3, 2, 1 }, 0, 2);
        Console.WriteLine(string.Join(" ", subarr));

        var allarr = Subsequence(new[] { -1, 3, 2, 1 }, 0, 4);
        Console.WriteLine(string.Join(" ", allarr));

        var emptyarr = Subsequence(new[] { -1, 3, 2, 1 }, 0, 0);
        Console.WriteLine(string.Join(" ", emptyarr));

        Console.WriteLine(ExtractEnding("I love C#", 2));
        Console.WriteLine(ExtractEnding("Nakov", 4));
        Console.WriteLine(ExtractEnding("beer", 4));

        // Console.WriteLine(ExtractEnding("Hi", 100)); // throws
        if (true == CheckPrime(23))
        {
            Console.WriteLine("23 is prime.");
        }
        else
        {
            Console.WriteLine("23 is not prime");
        }

        if (true == CheckPrime(33))
        {
            Console.WriteLine("33 is prime.");
        }
        else
        {
            Console.WriteLine("33 is not prime");
        }

        var peterExams = new List<Exam>
                             {
                                 new SimpleMathExam(2), 
                                 new CSharpExam(55), 
                                 new CSharpExam(100), 
                                 new SimpleMathExam(1), 
                                 new CSharpExam(0)
                             };
        var peter = new Student("Peter", "Petrov", peterExams);
        var peterAverageResult = peter.CalcAverageExamResultInPercents();
        Console.WriteLine("Average results = {0:p0}", peterAverageResult);
    }
}