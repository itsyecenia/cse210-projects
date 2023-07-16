public abstract class Activity{
    private string _date;
    private int _time;
public Activity(string date, int time){
    _date = date;
    _time = time;
}
public string GetDate(){
    return _date;
}
public int GetTime(){
    return _time;
}
public abstract double GetDistance();
public abstract double GetSpeed();
public abstract double GetPace();
public abstract string GetSummary();
}