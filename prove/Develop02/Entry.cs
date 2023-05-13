public class Entry{
    string _promptGiven;
    string _userEntry;
    string _date;

    public void _Display(){
        Console.WriteLine($"{_date}");
        Console.WriteLine($"{_promptGiven}");
        Console.WriteLine($"{_userEntry}");
        Console.WriteLine(" ");
    }
}