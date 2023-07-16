public class Events{
    private string _type;
    private string _title;
    private string _description;
    private string _time;
    private string _date;
    private Address _address;

    public Events(string type, string title, string description, string date, string time, string street, string city, string state, string country){
        _type = type;
        _title = title;
        _description = description;
        _time = time;
        _date = date;
        _address = new Address(street, city, state, country);
    }
    
    public string GetEventType(){
        return _type;
    }
    public string GetTitle(){
        return _title;
    }
    public string GetDesciption(){
        return _description;
    }
    public string GetTime(){
        return _time;
    }
    public string GetDate(){
        return _date;
    }
    public string StandardDetails(){
        string standard = "Title: " + GetTitle() + "\nDescription: " + GetDesciption() + "\nDate: " + GetDate() + "\nTime: " + GetTime() + "\nAddress: " + _address.GetAddress();  
        return standard;
    }

    public string ShortDescription(){
        string shortDes = "Event: " + GetEventType() + "\nTitle: " + GetTitle() + "\nDate: " + GetDate();
        return shortDes;
    }
}