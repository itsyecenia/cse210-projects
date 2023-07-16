using System;

class Program
{
    static void Main(string[] args)
    {
        Lectures event1 = new Lectures("Marco Polo", 50, "Lecture", "How you can find me?", "How to find someone while in the pool.", "05 May 2020", "9:00 am", "256 Polo Way", "Oceanside", "CA", "USA");
        Receptions event2 = new Receptions("jared05@gmail.com", "Reception", "The Melendez Wedding", "Join us in the marriage of Jared and Sarah as they begin their life together.", "15 Jun 2021", "5:00 pm", "1901 Wedding Ave.", "Provo", "UT", "USA");
        Outdoor event3 = new Outdoor("Sunny", "Outdoor", "Tennis Championship", "This is the final tournament for Tennis and winner will be named champion.", "08 Aug 2022", "10:00 am", "1313 Love Way", "Jordan", "UT", "USA");

        Console.WriteLine("- Standard Details -");
        Console.WriteLine(event1.StandardDetails());
        Console.WriteLine();
        Console.WriteLine("- Full Details -");
        Console.WriteLine(event1.FullDescription());
        Console.WriteLine();
        Console.WriteLine("- Short Details -");
        Console.WriteLine(event1.ShortDescription());
        Console.WriteLine();

        Console.WriteLine("- Standard Details -");
        Console.WriteLine(event2.StandardDetails());
        Console.WriteLine();
        Console.WriteLine("- Full Details -");
        Console.WriteLine(event2.FullDescription());
        Console.WriteLine();
        Console.WriteLine("- Short Details -");
        Console.WriteLine(event2.ShortDescription());
        Console.WriteLine();

        Console.WriteLine("- Standard Details -");
        Console.WriteLine(event3.StandardDetails());
        Console.WriteLine();
        Console.WriteLine("- Full Details -");
        Console.WriteLine(event3.FullDescription());
        Console.WriteLine();
        Console.WriteLine("- Short Details -");
        Console.WriteLine(event3.ShortDescription());
    }
}