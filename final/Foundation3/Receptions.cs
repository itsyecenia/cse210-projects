public class Receptions : Events{
    private string _rsvpEmail;

    public Receptions(string rsvpEmail, string type, string title, string description, string date, string time, string street, string city, string state, string country) : base(type, title, description, date, time, street, city, state, country){
        _rsvpEmail = rsvpEmail;
    }
    public string GetEmail(){
        return _rsvpEmail;
    }
    public string FullDescription(){
        string full = StandardDetails() + "\nRSVP Email: " + GetEmail();
        return full;
    }
}