public class Running : Activity{
    private int _distance;

    public Running(int distance, string date, int time) : base(date, time){
    _distance = distance;
    }
    public override double GetDistance(){
        return _distance;
    }
    public override double GetSpeed(){
        return Math.Round(((GetDistance() / GetTime()) * 60),2,MidpointRounding.ToEven);
    }
    public override double GetPace(){
        return Math.Round((60 / GetSpeed()),2,MidpointRounding.ToEven);
    }
    public override string GetSummary()
    {
        string summary = GetDate() + " Running (" + GetTime() + " min)- Distance " + GetDistance() + " miles, Speed " + GetSpeed() + "mph, Pace: " + GetPace() + " min per mile";
        return summary;
    }
}