using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new("Samuel Bennett", "Multiplication");
        MathAssignment mathAssignment = new("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        WritingAssignment writingAssignment = new("Mary Waters", "European History", "The Causes of World War II");

        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine();

        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());
        Console.WriteLine();

        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}