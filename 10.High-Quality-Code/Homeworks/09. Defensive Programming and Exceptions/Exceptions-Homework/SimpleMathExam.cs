// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SimpleMathExam.cs" company="">
//   
// </copyright>
// <summary>
//   The simple math exam.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;

/// <summary>
/// The simple math exam.
/// </summary>
public class SimpleMathExam : Exam
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SimpleMathExam"/> class.
    /// </summary>
    /// <param name="problemsSolved">
    /// The problems solved.
    /// </param>
    public SimpleMathExam(int problemsSolved)
    {
        if (problemsSolved < 0 || problemsSolved > 10)
        {
            throw new ArgumentException("Invalid problems number");
        }

        this.ProblemsSolved = problemsSolved;
    }

    /// <summary>
    /// Gets the problems solved.
    /// </summary>
    public int ProblemsSolved { get; private set; }

    /// <summary>
    /// The check.
    /// </summary>
    /// <returns>
    /// The <see cref="ExamResult"/>.
    /// </returns>
    public override ExamResult Check()
    {
        if (this.ProblemsSolved == 0)
        {
            return new ExamResult(2, 2, 6, "Bad result: nothing done.");
        }

        if (this.ProblemsSolved == 1)
        {
            return new ExamResult(4, 2, 6, "Average result: nothing done.");
        }

        if (this.ProblemsSolved == 2)
        {
            return new ExamResult(6, 2, 6, "Average result: nothing done.");
        }

        throw new Exception("Invalid number of problems solved!");
    }
}