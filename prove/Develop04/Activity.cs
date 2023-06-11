public class Activity{
    protected string _ActivityName;
    protected string _Description;
    protected int _Duration = 0;
    List<string> animationStrings = new List<string>();
    public Random random = new Random();

    public Activity(string ActivityName, string Description){
        _ActivityName = ActivityName;
        _Description = Description;

        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

    }

    public int _getDuration(){
        return _Duration;
    }

     public void _DisplayStartingMessage(){
        Console.WriteLine("Welcome to the " + _ActivityName + ".\n");
        Console.WriteLine(_Description);
        Console.WriteLine("\nHow long, in seconds, would you like for your session?");
        _Duration = int.Parse(Console.ReadLine());
    }
    public void _DisplayEndingingMessage(){
        Console.WriteLine("Well Done!!");
        _PauseSpinner(3);
        Console.WriteLine("You have completed another " + _Duration + " seconds of the " + _ActivityName + ".");
        _PauseSpinner(9);
    }

    public void _PauseSpinner(int totalSecs){
        int i =  0;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(totalSecs);
        while (DateTime.Now < endTime){ 
            string s = animationStrings[i];      
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the + character

            i++;

            if (i >= animationStrings.Count){
                i = 0;
            }
        }
    }
    public void _PauseCountdown(int time){
        for(int i = time; i > 0; i--){
            if (i >= 10){
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b\b  \b\b");    
            }
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}