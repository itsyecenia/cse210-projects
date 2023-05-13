using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        Prompt allPrompts = new Prompt();
        allPrompts._getPrompts();
        Entry newEntry = new Entry();
        Journal myJournal = new Journal();

        while (choice != 0;){
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");

            string anwser = Console.ReadLine();
            choice = int.Parse(anwser);

            if (choice == 1){
                Random randomGenerator = new Random();
                int magicNumber = randomGenerator.Next(1, 5);
                allPrompts._promptDisplay(magicNumber);
                newEntry._promptGiven = allPrompts._prompt[magicNumber];
                newEntry._userEntry = Console.ReadLine();
                DateTime theCurrentTime = DateTime.Now;
                newEntry._date = theCurrentTime.ToShortDateString();
                myJournal.__entries.Add(newEntry);
            }
            else if (choice == 2){
                myJournal._displayJournal();
            }
            else if (choice == 3){

            }
            else if (choice == 4){

            }
            else if (choice == 5){
                Console.WriteLine("Goodbye!");
            }
        }

    }
}