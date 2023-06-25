public class ChecklistGoal: Goals{
    private int _goalCount;
    private int _endGoal;
    private int _bonusPoints;
    
    public ChecklistGoal(string name, string description, int points, bool done, int goalCount, int endGoal, int bonusPoints): base(name, description, points, done, "ChecklistGoal"){
        _goalCount = goalCount;
        _endGoal = endGoal;
        _bonusPoints = bonusPoints;
    }

    public int _getGoalCount(){
        return _goalCount;
    }

    public void _setGoalCount(int count){
        _goalCount = _goalCount + count;
    }

    public int _getEndGoal(){
        return _endGoal;
    }

    public int _getBonusPoints(){
        return _bonusPoints;
    }

    public override string _saveGoals(){
        string word = $"ChecklistGoal:{_getName()}\\{_getDescription()}\\{_getPoints()}\\{_getBonusPoints()}\\{_getEndGoal()}\\{_getGoalCount()}";
        return word;
    }

    public override int _addPoints(int points){
        if (_getGoalCount() == _getEndGoal()){
            _setDone();
            points = points + _getBonusPoints();
        }
        return points + _getPoints();
    }

    public override void _displayGoal()
    {
        if (_isDone()){
            Console.Write($"[X] {_getName()} ({_getDescription()}) -- Currently completed: {_getGoalCount()}/{_getEndGoal()}");
        }
        else Console.Write($"[ ]  {_getName()} ({_getDescription()}) -- Currently completed: {_getGoalCount()}/{_getEndGoal()}");
    }

    public override bool _isDone()
    {
        return _getDone();
    }

    public override int _recordEvent(int points)
    {
        if (_getGoalCount() == _getEndGoal()){
            Console.Write("This goal is already done.");
        }
        else{
            _setGoalCount(1);
            points = _addPoints(points);
        }
        return points;
    }
}