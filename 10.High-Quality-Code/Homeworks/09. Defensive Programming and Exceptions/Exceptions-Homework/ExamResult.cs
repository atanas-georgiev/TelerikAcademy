// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ExamResult.cs" company="">
//   
// </copyright>
// <summary>
//   The exam result.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;

/// <summary>
/// The exam result.
/// </summary>
public class ExamResult
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ExamResult"/> class.
    /// </summary>
    /// <param name="grade">
    /// The grade.
    /// </param>
    /// <param name="minGrade">
    /// The min grade.
    /// </param>
    /// <param name="maxGrade">
    /// The max grade.
    /// </param>
    /// <param name="comments">
    /// The comments.
    /// </param>
    /// <exception cref="Exception">
    /// </exception>
    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        if (grade < 0)
        {
            throw new ArgumentException("Grade should be positive!");
        }

        if (minGrade < 0)
        {
            throw new ArgumentException("Min Grade should be positive!");
        }

        if (maxGrade <= minGrade)
        {
            throw new ArgumentException("Max Grade should be positive!");
        }

        if (comments == null)
        {
            throw new NullReferenceException("Input string is null!");
        }

        if (comments.Length <= 0)
        {
            throw new ArgumentException("Input string cannot be empty!");
        }

        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }

    /// <summary>
    /// Gets the grade.
    /// </summary>
    public int Grade { get; private set; }

    /// <summary>
    /// Gets the min grade.
    /// </summary>
    public int MinGrade { get; private set; }

    /// <summary>
    /// Gets the max grade.
    /// </summary>
    public int MaxGrade { get; private set; }

    /// <summary>
    /// Gets the comments.
    /// </summary>
    public string Comments { get; private set; }
}