using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        while(choice != 4){
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Select a choice from the menu:");
            choice = int.Parse(Console.ReadLine());


            if (choice == 1){
                Console.Clear();
                string breathingName = "Breathing Activity";
                string breathingDescription = "This activity will help you relax by walking you through beathing in and out slowly. Clear your mind and focus on your breathing.";
                BreathingActivity breathing = new BreathingActivity(breathingName, breathingDescription);
                
                breathing._DisplayStartingMessage();
                breathing._displayBreathe(breathing._getDuration());
                breathing._DisplayEndingingMessage();
            }
            else if (choice == 2){
                Console.Clear();
                string reflectingName = "Reflecting Activity";
                string reflectingDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
                ReflectingActivity reflecting = new ReflectingActivity(reflectingName, reflectingDescription);

                reflecting._DisplayStartingMessage();
                reflecting._displayRandPrompt();
                reflecting._displayQuestions(reflecting._getDuration());
                reflecting._DisplayEndingingMessage();
            }
            else if (choice == 3){
                /* Didn't finish on time */
                Console.Clear();
                string listingName = "Listing Activity";
                string listingDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
                ListingActivity listing = new ListingActivity(listingName, listingDescription);

                listing._DisplayStartingMessage();
                listing._displayRandPromptList();

                listing._DisplayEndingingMessage();
            }
            else if (choice == 4){/* Will Quit */}
        }
    }
}