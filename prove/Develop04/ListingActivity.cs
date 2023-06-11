public class ListingActivity : Activity{
    List <string> _listPrompt = new List<string>();
    List <string> _list = new List<string>();
    public ListingActivity(string listingName, string listingDescription) : base(listingName, listingDescription ){
        _listPrompt.Add("Who are people that you appreciate?");
        _listPrompt.Add("What are personal strengths of yours?");
        _listPrompt.Add("Who are people that you have helped this week?");
        _listPrompt.Add("When have you felt the Holy Ghost this month?");
        _listPrompt.Add("Who are some of your personal heroes?");
    }

    public void _displayRandPromptList(){
        Console.Clear();
        Console.WriteLine("Get ready...");
        _PauseSpinner(3);
        Console.WriteLine();

        Console.WriteLine("Consider the following prompt: \n");
        int prompt = random.Next(1, _listPrompt.Count);
        Console.WriteLine(" --- " + _listPrompt[prompt] + " --- \n");
        Console.WriteLine("You may begin in: ");
        _PauseCountdown(5);
    }

    

}