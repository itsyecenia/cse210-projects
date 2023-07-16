public class Swimming : Activity{
    private double _laps;
    public Swimming(double laps, string date, int time) : base(date, time){
        _laps = laps;
    }
    public double getLaps(){
        return _laps;
    }
    public override double GetDistance(){
        return Math.Round((((getLaps() * 50) / 1000) * 0.62),2,MidpointRounding.ToEven);
    }
    public override double GetSpeed(){
        return Math.Round((60 / GetPace()),2,MidpointRounding.ToEven); 
    }
    public override double GetPace(){
        return Math.Round((GetTime() / GetDistance()),2,MidpointRounding.ToEven);
    }
    public override string GetSummary()
    {
        string summary = GetDate() + " Swimming (" + GetTime() + " min)- Distance " + GetDistance() + " miles, Speed " + GetSpeed() + "mph, Pace: " + GetPace() + " min per mile";
        return summary;
    }
}