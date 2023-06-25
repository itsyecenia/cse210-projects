using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        int points = 0;
        List<Goals> myGoals = new List<Goals>();
        Console.Clear();

        while (choice != 6){
            Console.WriteLine($"You have {points} points.\n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1){
                Console.Clear();
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine(" 1. Simple Goal");
                Console.WriteLine(" 2. Eternal Goal");
                Console.WriteLine(" 3. Checklist Goal");
                Console.Write("Which type of goal would you like to create? ");
                int goalChoice = int.Parse(Console.ReadLine());

                Console.Write("What is the name of your goal? ");
                string name = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                string description = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                int setPoints = int.Parse(Console.ReadLine());

                if (goalChoice == 1){
                    myGoals.Add(new SimpleGoal(name,description,setPoints,false));
                }
                else if (goalChoice == 2){
                    myGoals.Add(new EternalGoal(name,description,setPoints, false));
                }
                else if (goalChoice == 3){
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    int endGoal = int.Parse(Console.ReadLine());
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    int bonusPoints = int.Parse(Console.ReadLine());

                    myGoals.Add(new ChecklistGoal(name, description, setPoints, false, 0, endGoal, bonusPoints));
                }
                Console.Clear();
                Console.WriteLine("New Goal Added!\n");
            }

            else if (choice == 2){
                Console.Clear();
                Console.WriteLine("The Goals are:");
                int x = 0;
                foreach(Goals goal in myGoals){
                    x = x + 1;
                    Console.Write($"{x}. ");
                    goal._displayGoal();
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            else if (choice == 3){
                Console.Clear();
                Console.Write("What is the Filename for the goal file: ");
                string filename = Console.ReadLine();
                Console.WriteLine("Saving File");
                Thread.Sleep(2000);

                using (StreamWriter outoutfile = new StreamWriter(filename)){
                    outoutfile.WriteLine(points);
                    foreach (Goals goal in myGoals){
                        outoutfile.WriteLine(goal._saveGoals());                        
                    }
                }
                Console.Clear();
                Console.WriteLine("Finished Saving File!\n");
            }

            else if (choice == 4){
                Console.Clear();
                Console.Write("What is the Filename for the goal file: ");
                string filename = Console.ReadLine();
                Console.WriteLine("Loading File");
                Thread.Sleep(2000);

                string[] lines = System.IO.File.ReadAllLines(filename);
                myGoals.Clear();
                int counter = 0;
                foreach (string line in lines){
                    if (counter == 0){
                        points = int.Parse(line);
                    }
                    else {
                        string[] reference = line.Split(new char [] {':', '\\'});
                        if(reference[0] == "SimpleGoal"){
                            bool check = reference[4] == "True" ? true: false;
                            myGoals.Add(new SimpleGoal(reference[1],reference[2],int.Parse(reference[3]),check));
                        }
                        else if (reference[0] == "EternalGoal"){
                            myGoals.Add(new EternalGoal(reference[1],reference[2],int.Parse(reference[3]), false));
                        }
                        else if (reference[0] == "ChecklistGoal"){
                            myGoals.Add(new ChecklistGoal(reference[1], reference[2], int.Parse(reference[3]), false, int.Parse(reference[6]),int.Parse(reference[5]),int.Parse(reference[4])));
                        }
                    }
                    counter++;
                }

                Console.Clear();
                Console.WriteLine("Finished Loading File!\n");
            }

            else if (choice == 5){
                Console.Clear();
                Console.WriteLine("The Goals are:");
                int x = 0;
                int beforepoints = points;
                foreach(Goals goal in myGoals){
                    x = x + 1;
                    Console.Write($"{x}. ");
                    goal._displayGoal();
                    Console.WriteLine();
                }
                Console.Write("Which goal did you accomplished? ");
                int didGoal = int.Parse(Console.ReadLine()) - 1;
                points = myGoals[didGoal]._recordEvent(points);
                if (beforepoints != points){
                    Console.Clear();
                    Console.WriteLine($"\nCongratulations! You have earned {points - beforepoints} points!");
                    Console.WriteLine($"You now have {points} points.\n");
                }
            }
        }
    }
}