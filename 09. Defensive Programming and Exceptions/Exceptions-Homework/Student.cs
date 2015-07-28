// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Student.cs" company="">
//   
// </copyright>
// <summary>
//   The student.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// The student.
/// </summary>
public class Student
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Student"/> class.
    /// </summary>
    /// <param name="firstName">
    /// The first name.
    /// </param>
    /// <param name="lastName">
    /// The last name.
    /// </param>
    /// <param name="exams">
    /// The exams.
    /// </param>
    public Student(string firstName, string lastName, IList<Exam> exams = null)
    {
        if (firstName == null)
        {
            throw new NullReferenceException("First name cannot be null!");
        }

        if (lastName == null)
        {
            throw new NullReferenceException("Last name cannot be null!");
        }

        this.FirstName = firstName;
        this.LastName = lastName;
        this.Exams = exams;
    }

    /// <summary>
    /// Gets or sets the first name.
    /// </summary>
    public string FirstName { get; set; }

    /// <summary>
    /// Gets or sets the last name.
    /// </summary>
    public string LastName { get; set; }

    /// <summary>
    /// Gets or sets the exams.
    /// </summary>
    public IList<Exam> Exams { get; set; }

    /// <summary>
    /// The check exams.
    /// </summary>
    /// <returns>
    /// The <see cref="IList"/>.
    /// </returns>
    /// <exception cref="Exception">
    /// </exception>
    public IList<ExamResult> CheckExams()
    {
        if (this.Exams == null)
        {
            throw new NullReferenceException("No exams for the student!");
        }

        if (this.Exams.Count == 0)
        {
            Console.WriteLine("The student has no exams!");
            return null;
        }

        IList<ExamResult> results = new List<ExamResult>();
        for (var i = 0; i < this.Exams.Count; i++)
        {
            results.Add(this.Exams[i].Check());
        }

        return results;
    }

    /// <summary>
    /// The calc average exam result in percents.
    /// </summary>
    /// <returns>
    /// The <see cref="double"/>.
    /// </returns>
    /// <exception cref="Exception">
    /// </exception>
    public double CalcAverageExamResultInPercents()
    {
        if (this.Exams == null || this.Exams.Count == 0)
        {
            throw new InvalidOperationException("Cannot calculate average on missing exams!");
        }

        var examScore = new double[this.Exams.Count];
        var examResults = this.CheckExams();
        for (var i = 0; i < examResults.Count; i++)
        {
            examScore[i] = ((double)examResults[i].Grade - examResults[i].MinGrade)
                           / (examResults[i].MaxGrade - examResults[i].MinGrade);
        }

        return examScore.Average();
    }
}