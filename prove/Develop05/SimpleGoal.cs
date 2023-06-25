public class SimpleGoal: Goals{
    
    public SimpleGoal(string name, string description, int points, bool done): base(name, description, points, done, "SimpleGoal"){}

    public override string _saveGoals(){
        string word = $"SimpleGoal:{_getName()}\\{_getDescription()}\\{_getPoints()}\\{_getDone()}";
        return word;
    }

    public override int _addPoints(int points){
        return points + _getPoints();
    }


    public override void _displayGoal(){
        if (_isDone()){
            Console.Write($"[X] {_getName()} ({_getDescription()})");
        }
        else Console.Write($"[ ]  {_getName()} ({_getDescription()})");
    }

    public override bool _isDone(){
        return _getDone();
    }

    public override int _recordEvent(int points)
    {
        if (!_isDone()){
            _setDone();
            points = _addPoints(points);
        }
        else Console.Write("This goal is already done.");
        
        return points;
        
    }
}