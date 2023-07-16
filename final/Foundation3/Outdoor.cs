public class Outdoor : Events{
    private string _weather;

    public Outdoor(string weather, string type, string title, string description, string date, string time, string street, string city, string state, string country) : base(type, title, description, date, time, street, city, state, country){
        _weather = weather;
    }
    public string GetWeather(){
        return _weather;
    }
    public string FullDescription(){
        string full = StandardDetails() + "\nWeather Forecast: " + GetWeather(); 
        return full;
    }
}