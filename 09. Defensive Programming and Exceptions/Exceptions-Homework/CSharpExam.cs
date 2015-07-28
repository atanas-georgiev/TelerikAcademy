// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CSharpExam.cs" company="">
//   
// </copyright>
// <summary>
//   The c sharp exam.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;

/// <summary>
/// The c sharp exam.
/// </summary>
public class CSharpExam : Exam
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CSharpExam"/> class.
    /// </summary>
    /// <param name="score">
    /// The score.
    /// </param>
    /// <exception cref="NullReferenceException">
    /// </exception>
    public CSharpExam(int score)
    {
        if (score < 0)
        {
            throw new ArgumentException("Input score should be positive");
        }

        this.Score = score;
    }

    /// <summary>
    /// Gets the score.
    /// </summary>
    public int Score { get; private set; }

    /// <summary>
    /// The check.
    /// </summary>
    /// <returns>
    /// The <see cref="ExamResult"/>.
    /// </returns>
    /// <exception cref="InvalidOperationException">
    /// </exception>
    public override ExamResult Check()
    {
        if (this.Score < 0 || this.Score > 100)
        {
            throw new InvalidOperationException("Score values are out of range!");
        }

        return new ExamResult(this.Score, 0, 100, "Exam results calculated by score.");
    }
}