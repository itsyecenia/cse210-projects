public class EternalGoal: Goals{
    
    public EternalGoal(string name, string description, int points, bool done): base(name, description, points, done, "EternalGoal"){}

    public override string _saveGoals(){
        string word = $"EternalGoal:{_getName()}\\{_getDescription()}\\{_getPoints()}";
        return word;
    }

    public override int _addPoints(int points){
        return points + _getPoints();
    }

    public override void _displayGoal()
    {
        Console.Write($"[ ]  {_getName()} ({_getDescription()})");
    }

    public override bool _isDone(){
        return _getDone();
    }

    public override int _recordEvent(int points)
    {
        return _addPoints(points);
    }
}