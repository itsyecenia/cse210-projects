public class ReflectingActivity : Activity{
    List <string> _refPrompt = new List<string>();
    List <string> _question = new List<string>();

    public ReflectingActivity(string reflectingName, string reflectingDescription) : base(reflectingName, reflectingDescription ){
        _refPrompt.Add("Think of a time when you stood up for someone else.");
        _refPrompt.Add("Think of a time when you did something really difficult.");
        _refPrompt.Add("Think of a time when you helped someone in need.");
        _refPrompt.Add("Think of a time when you did something truly selfless.");

        _question.Add("Why was this experience meaningful to you?");
        _question.Add("Have you ever done anything like this before?");
        _question.Add("How did you get started?");
        _question.Add("What made this time different than other times when you were not as successful?");
        _question.Add("What could you learn from this experience that applies to other situations?");
        _question.Add("How can you keep this experience in mind in the future?");
    }

    public void _displayRandPrompt(){
        Console.Clear();
        Console.WriteLine("Get ready...");
        _PauseSpinner(3);
        Console.WriteLine();

        Console.WriteLine("Consider the following Prompt: \n");
        int prompt = random.Next(1, _refPrompt.Count);
        Console.WriteLine(" --- " + _refPrompt[prompt] + " --- \n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experiance.\nYou may begin in: ");
        _PauseCountdown(5);
    }

    public void _displayQuestions(int timer){
        Console.Clear();
        int question = random.Next(1, _question.Count);
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(timer);
        while (DateTime.Now < endTime){
            Console.WriteLine(" > " + _question[question] + " ");
            _PauseSpinner(10);
            question = random.Next(1, _question.Count);
        }
        Console.WriteLine();
    }

}