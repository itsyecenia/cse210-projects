public class BreathingActivity : Activity{
    protected string _breathingName;
    protected string _breathingDescription;

    public BreathingActivity(string breathingName, string breathingDescription) : base(breathingName, breathingDescription ){
        breathingName = "Breathing Activity";
        breathingDescription = "This activity will help you relax by walking you through beathing in and out slowly. Clear your mind and focus on your breathing";
        
    }
    public void _displayBreathe(int totalSecs){
        Console.Clear();
        Console.WriteLine("Get ready...");
        _PauseSpinner(3);
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(totalSecs);
        while (DateTime.Now < endTime){ 
            Console.WriteLine("Breathe in...");
            _PauseCountdown(4);
            Console.WriteLine("Now breathe out...");
            _PauseCountdown(4);
            Console.WriteLine();
        }
    }

}