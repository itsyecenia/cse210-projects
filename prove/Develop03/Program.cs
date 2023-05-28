using System;

class Program
{
    static void Main(string[] args)
    {
        Scriptures memorize = new Scriptures("scripture.txt","hidden.txt");

        memorize._makeHiddenList();

        bool done = false;
        while (!done){

            Console.Clear();
            memorize._display();
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
            string goOn = Console.ReadLine();
            if (goOn != "quit"){
                memorize._removeWords();
                memorize._removeWords();
                memorize._removeWords();
            }
            else done = true;

            if (memorize._getCountofNonHiddenWords() == 0){
                done = true;
            }
        }

    }
}