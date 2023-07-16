public class Lectures : Events{
    private string _speaker;
    private int _capacity;

    public Lectures(string speaker, int capacity, string type, string title, string description, string date, string time, string street, string city, string state, string country) : base(type, title, description, date, time, street, city, state, country){
        _speaker = speaker;
        _capacity = capacity;
    }
    public string GetSpeaker(){
        return _speaker;
    }
    public int GetCapacity(){
        return _capacity;
    }
    public string FullDescription(){
        string full = StandardDetails() + "\nName: " + GetSpeaker()+ "\nCapacity: " + GetCapacity(); 
        return full;
    }
}