public abstract class Goals{
    private string _name;
    private string _description;
    private int _points;
    private bool _done;
    private string _type;

    public Goals(string name, string description, int points, bool done, string type){
        _name = name;
        _description = description;
        _points = points;
        _done = done;
        _type = type;
    }

    public string _getName(){
        return _name;
    }

    public string _getDescription(){
        return _description;
    }

    public int _getPoints(){
        return _points;
    }

    public bool _getDone(){
        return _done;
    }

    public void _setDone(){
        _done = true;
    }

    public string _getType(){
        return _type;
    }

    public abstract string _saveGoals();
    public abstract int _addPoints(int points);

    public abstract void _displayGoal();

    public abstract int _recordEvent(int points);

    public abstract bool _isDone();

}