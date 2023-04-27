using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("What number would you like to input? Type 0 to finish");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);

        while (number != 0){
            numbers.Add(number);

            Console.WriteLine("What other number would you like to input? ");
            userInput = Console.ReadLine();
            number = int.Parse(userInput);
        }

        
    }
}