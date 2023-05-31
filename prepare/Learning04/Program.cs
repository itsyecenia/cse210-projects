using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
        mathAssignment math = new mathAssignment("Roberto Rodriguez", "Fraction", "Section 7.3", "Problems 8-19");
        writingAssignment writing = new writingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.Clear();
        Console.WriteLine(assignment._getSummary());
        Console.WriteLine(math._getSummary());
        Console.WriteLine(math._GetHomeworkList());
        Console.WriteLine(writing._getSummary());
        Console.WriteLine(writing._GetWritingInformation());
    }
}