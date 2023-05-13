using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        Prompt allPrompts = new Prompt();
        allPrompts._savePrompts();
        Journal myJournal = new Journal();
        Console.WriteLine("What would you like to do in your Journal?");

        while (choice != 5){
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit\n");

            string anwser = Console.ReadLine();
            choice = int.Parse(anwser);

            // Add an entry to the Journal
            if (choice == 1){
                Entry entry = new Entry();
                Random randomGenerator = new Random();
                int magicNumber = randomGenerator.Next(1, 5);
                allPrompts._promptDisplay(magicNumber);
                entry._promptGiven = allPrompts._getPrompt(magicNumber);
                entry._userEntry = Console.ReadLine();
                DateTime theCurrentTime = DateTime.Now;
                entry._date = theCurrentTime.ToShortDateString();
                myJournal._entries.Add(entry);
                Console.WriteLine();
            }
            // Display what is in the current Journal
            else if (choice == 2){
                myJournal._displayJournal();
            }
            // Save to a file
            else if (choice == 3){
                if (myJournal._entries.Count != 0){
                    Console.WriteLine("In what file would you like to save your Journal?\n");
                    anwser = Console.ReadLine();
                    myJournal._filename = anwser;
                    myJournal._saveJournal();
                }
                else Console.WriteLine("You need to have at least one entry to your Journal to save.\n");
            }
            // Load from a file
            else if (choice == 4){
                Console.WriteLine("What file would you like to load in your Journal?\n");
                anwser = Console.ReadLine();
                myJournal._filename = anwser;
                myJournal._entries.Clear();
                myJournal._loadJournal();
            }
            // Quit
            else if (choice == 5){
                Console.WriteLine("Goodbye!\n");
            }
            else Console.WriteLine("Not a valid response. Try a number from 1-5.\n");

            if(choice != 5){
                Console.WriteLine("What else would you like to do in your Journal?");
            }
        }
        
    }
}