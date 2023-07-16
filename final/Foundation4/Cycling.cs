public class Cycling : Activity{
    private int _speed;
    public Cycling(int speed, string date, int time) : base(date, time){
        _speed = speed;
    }
    public override double GetDistance(){
        return Math.Round(((GetSpeed() / 60) * GetTime()),2,MidpointRounding.ToEven);
    }
    public override double GetSpeed(){
        return _speed;
    }
    public override double GetPace(){
        return Math.Round((60 / GetSpeed()),2,MidpointRounding.ToEven);
    }
    public override string GetSummary()
    {
        string summary = GetDate() + " Cycling (" + GetTime() + " min)- Distance " + GetDistance() + " miles, Speed " + GetSpeed() + "mph, Pace: " + GetPace() + " min per mile";
        return summary;
    }
}