using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the magic number? ");
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        Console.WriteLine(magicNumber);
    

        Console.WriteLine("What is your guess? ");
        string userGuess = Console.ReadLine();
        int number = int.Parse(userGuess);

        while (number != magicNumber)
        {
            if (magicNumber > number)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < number)
            {
                Console.WriteLine("Lower");
            }

            Console.WriteLine("What is your guess? ");
            userGuess = Console.ReadLine();
            number = int.Parse(userGuess);
        }
        Console.WriteLine("You guessed it!");
    }
}