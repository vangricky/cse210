using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        Console.WriteLine("");

        Assignment assignment = new Assignment("Samuel Bennet", "Multiplication");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("", "", "7.3", "8-19");
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingassignment = new WritingAssignment("", "", "The Causes of World War II by Mary Waters");
        Console.WriteLine(writingassignment.GetWritingInformation());
    }
}