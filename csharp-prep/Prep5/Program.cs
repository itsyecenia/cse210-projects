using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();

        static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the Program! ");

            Console.WriteLine("Please enter your name: ");
            string userName = Console.ReadLine();

            Console.WriteLine("Please enter your favorite number: ");
            string userNumber = Console.ReadLine();
            int number = int.Parse(userNumber);
            
            int squareNumber = number * number;

            Console.WriteLine($"{userName}, the square of your number is: {squareNumber}");
        }
    }
}