using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string percentage = Console.ReadLine();
        int number = int.Parse(percentage);

        string letter;

        if (number >= 90)
        {
            letter = "A";
        }
        else if (90 > number && number >= 80)
        {
            letter = "B";
        }
        else if (80 > number && number >= 70)
        {
            letter = "C";
        }
        else if (70 > number && number >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"You earned a {letter}");

        if (number >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course!");
        }

        else
        {
            Console.WriteLine("You didn't pass the course but you can try again.");
        }
    }
}