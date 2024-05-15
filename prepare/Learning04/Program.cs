using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Samuel Bennet", "Multiplication");
        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        WritingAssigment writingAssigment = new WritingAssigment("Mary Waters", "European History", "Causes of the Second World War");
        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());
        Console.WriteLine(writingAssigment.GetSummary());
        Console.WriteLine(writingAssigment.GetWritingInformation());


    }
}