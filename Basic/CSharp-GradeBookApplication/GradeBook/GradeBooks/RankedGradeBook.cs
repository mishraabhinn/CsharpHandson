using System;
using System.Collections.Generic;
using System.Linq;

namespace GradeBook.GradeBooks
{
public class RankedGradeBook : BaseGradeBook
{
    public RankedGradeBook(string name, bool isWeighted): base(name, isWeighted)
    {
        Type = Enums.GradeBookType.Ranked;
    }
    public override char GetLetterGrade(double averageGrade)
    {
        if (Students.Count < 5)
            throw new InvalidOperationException("Ranked-grading requires a minimum of 5 students to work");


        var twentyPercent = (int)Math.Ceiling((Students.Count * 0.2));
        var fortyPercent = twentyPercent * 2;
        var sixtyPercent = twentyPercent * 3;
        var eightypercent = twentyPercent * 4;
        var grades = Students.OrderByDescending(e => e.AverageGrade).Select(e => e.AverageGrade).ToList();


        if (averageGrade >= grades[twentyPercent - 1])

            return 'A';

        else if (averageGrade <= grades[twentyPercent] && averageGrade >= grades[fortyPercent - 1])

            return 'B';

        else if (averageGrade <= grades[fortyPercent] && averageGrade >= grades[sixtyPercent - 1])

            return 'C';

        else if (averageGrade <= grades[sixtyPercent] && averageGrade >= grades[eightypercent - 1])

            return 'D';

        else

            return 'F';



    }
    public override void CalculateStatistics()
    {
        if (Students.Count < 5)
        {
            Console.WriteLine("Ranked grading requires at least 5 students with grades in order to properly calculate a student's overall grade.");

        }
        else
            base.CalculateStatistics();

    }
    public override void CalculateStudentStatistics(string name)
    {
        if (Students.Count < 5)
        {
            Console.WriteLine("Ranked grading requires at least 5 students with grades in order to properly calculate a student's overall grade.");
        }
        else
        {
            base.CalculateStudentStatistics(name);
        }
    }
}
}






